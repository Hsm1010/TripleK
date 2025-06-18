using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TripleK.TKClient;
using System.Text.RegularExpressions;
namespace TripleK
{
    public partial class AdminForm : MaterialForm
    {
        private Dictionary<string, List<MenuItem>> itemsCategory;  // 각 카테고리별 메뉴 아이템 목록
        private string currentSelectedImagePath = null;  // 새 제품 추가 시 선택된 이미지 경로
        private string currentEditSelectedImagePath = null;  // 제품 수정 시 선택된 이미지 경로
        public Client _client;

        public AdminForm(Dictionary<string, List<MenuItem>> itemsCategory, Client client)
        {
            InitializeComponent();
            this.itemsCategory = itemsCategory;
            _client = client;
            // 카테고리 콤보박스 초기화
            cmbCategory.Items.AddRange(new string[] { "커피", "음료", "디저트", "케잌" });
            if (cmbCategory.Items.Count > 0)
            {
                cmbCategory.SelectedIndex = 0; // 기본적으로 첫 번째 카테고리 선택
            }

            // 주요 이벤트 핸들러 연결
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            btnAddStock.Click += btnAddStock_Click;

            // 새 제품 관련 컨트롤 이벤트
            btnSelectNewImage.Click += btnSelectNewImage_Click;
            btnAddNewProduct.Click += btnAddNewProduct_Click;

            // 제품 수정 관련 컨트롤 이벤트
            dgvMenuItems.SelectionChanged += dgvMenuItems_SelectionChanged;
            btnChangeSelectedImage.Click += btnChangeSelectedImage_Click;
            btnSaveChanges.Click += btnSaveChanges_Click;
            btnDeleteProduct.Click += btnDeleteProduct_Click;


            RefreshMenuItemsGrid();  // 메뉴 목록 그리드 새로고침
            ClearEditFields(); // 수정 관련 입력 필드 초기화
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            RefreshMenuItemsGrid(); // 폼이 로드될 때 메뉴 목록을 다시 표시
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)  // 카테고리 콤보박스의 선택이 변경되었을 때 호출되는 메소드
        {
            RefreshMenuItemsGrid();
            ClearEditFields();
        }

        private void RefreshMenuItemsGrid()  // DataGridView에 현재 선택된 카테고리의 메뉴 목록을 표시하는 메소드
        {
            if (cmbCategory.SelectedItem == null)
            {
                dgvMenuItems.DataSource = null;
                return;
            }

            string selectedCategory = cmbCategory.SelectedItem.ToString();
            if (itemsCategory.ContainsKey(selectedCategory))
            {
                var list = itemsCategory[selectedCategory];
                dgvMenuItems.DataSource = null;
                dgvMenuItems.DataSource = list.Select(x => new
                {
                    이름 = x.Name,
                    가격 = x.Price,
                    수량 = x.Quantity
                }).ToList();
            }
            else
            {
                dgvMenuItems.DataSource = null;
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e) // '재고 추가' 버튼 클릭 시 실행되는 메소드
        {
            if (dgvMenuItems.SelectedRows.Count > 0 && cmbCategory.SelectedItem != null)
            {
                string selectedCategory = cmbCategory.SelectedItem.ToString();
                string itemName = dgvMenuItems.SelectedRows[0].Cells["이름"].Value.ToString();
                // 해당 제품 찾기
                var item = itemsCategory[selectedCategory].FirstOrDefault(x => x.Name == itemName);
                if (item != null)
                {
                    int quantityToAdd = (int)nudAddStockQuantity.Value;

                    // 서버에 재고 추가 요청
                    string response = _client.AddAmount(item.ServerKey, quantityToAdd);
                    MessageBox.Show(response, "서버 응답");

                    item.Quantity += (int)nudAddStockQuantity.Value;
                    RefreshMenuItemsGrid();
                    MessageBox.Show($"{itemName}의 재고가 {nudAddStockQuantity.Value}만큼 추가되었습니다.", "재고 추가 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nudAddStockQuantity.Value = 0;
                }
            }
            else
            {
                MessageBox.Show("재고를 추가할 제품을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 새 제품 추가 관련 메소드

        private void btnSelectNewImage_Click(object sender, EventArgs e) // '새 이미지 선택' 버튼 클릭 시, 파일 탐색기를 열어 이미지를 선택하는 메소드
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        picNewProductPreview.Image = Image.FromFile(openFileDialog.FileName);
                        currentSelectedImagePath = openFileDialog.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("이미지를 불러오는 중 오류가 발생했습니다: " + ex.Message, "이미지 로드 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        picNewProductPreview.Image = null;
                        currentSelectedImagePath = null;
                    }
                }
            }
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e) // '새 제품 추가' 버튼 클릭 시, 입력된 정보로 새 메뉴 아이템을 생성하는 메소드
        {
            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("제품을 추가할 카테고리를 선택해주세요.", "카테고리 미선택", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtNewProductName.Text.Trim();
            decimal price = nudNewProductPrice.Value;
            int quantity = (int)nudNewProductQuantity.Value;
            Image image = picNewProductPreview.Image;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("제품명을 입력해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewProductName.Focus();
                return;
            }
            if (price <= 0)
            {
                MessageBox.Show("제품 가격은 0보다 커야 합니다.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudNewProductPrice.Focus();
                return;
            }
            if (image == null)
            {
                MessageBox.Show("제품 이미지를 선택해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSelectNewImage.Focus();
                return;
            }


            string selectedCategory = cmbCategory.SelectedItem.ToString(); // 동일한 이름의 제품이 이미 존재하는지 확인
            if (itemsCategory[selectedCategory].Any(item => item.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("이미 해당 이름의 제품이 존재합니다.", "중복 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewProductName.Focus();
                return;
            }

            MenuItem newItem = new MenuItem
            {
                Name = name,
                Price = price,
                Image = image,
                Quantity = quantity,
                ServerKey = ToSlug(name)
            };

            itemsCategory[selectedCategory].Add(newItem);
            RefreshMenuItemsGrid();
            //서버에 아이템 추가 신호 보냄
            string addResp = _client.AddProduct(
                newItem.ServerKey,
                newItem.Quantity,
                newItem.Price
            );
            MessageBox.Show("서버 응답");
            MessageBox.Show($"'{name}' 제품이 성공적으로 추가되었습니다.", "제품 추가 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txtNewProductName.Clear();
            nudNewProductPrice.Value = 0;
            nudNewProductQuantity.Value = 0;
            picNewProductPreview.Image = null;
            currentSelectedImagePath = null;
        }

        //메뉴 추가시 한글을 영어로 바꿔주는 함수
        //TextBox에 한글이 정확히 입력되지 않는 문제가 있음
        public static string ToSlug(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            // 1) 단어 경계로 분리 (영숫자가 아닌 문자를 기준)
            var parts = Regex
                .Split(input, @"[^A-Za-z0-9가-힣]+")
                .Where(p => p.Length > 0)
                .ToArray();

            if (parts.Length == 0)
                return string.Empty;

            // 2) 첫 단어는 모두 소문자
            var sb = new StringBuilder(parts[0].ToLowerInvariant());

            // 3) 두 번째 단어부터는 첫 글자만 대문자, 나머지는 소문자
            for (int i = 1; i < parts.Length; i++)
            {
                var w = parts[i];
                var lower = w.ToLowerInvariant();
                sb.Append(char.ToUpperInvariant(lower[0]));
                if (lower.Length > 1)
                    sb.Append(lower.Substring(1));
            }

            return sb.ToString();
        }

        //제품 수정/삭제 관련 메소드
        private void dgvMenuItems_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMenuItems.SelectedRows.Count > 0 && cmbCategory.SelectedItem != null)
            {
                string selectedCategory = cmbCategory.SelectedItem.ToString();
                string itemName = dgvMenuItems.SelectedRows[0].Cells["이름"].Value.ToString();

                var item = itemsCategory[selectedCategory].FirstOrDefault(x => x.Name == itemName);
                if (item != null)
                {
                    txtEditProductName.Text = item.Name;
                    nudEditProductPrice.Value = item.Price;
                    picEditProductPreview.Image = item.Image;
                    currentEditSelectedImagePath = null;
                    gbEditProduct.Enabled = true;
                }
                else
                {
                    ClearEditFields();
                }
            }
            else
            {
                ClearEditFields();
            }
        }

        private void ClearEditFields()  // 제품 수정 관련 입력 필드들을 초기화하고 그룹박스를 비활성화하는 메소드
        {
            txtEditProductName.Clear();
            nudEditProductPrice.Value = 0;
            picEditProductPreview.Image = null;
            currentEditSelectedImagePath = null;
            gbEditProduct.Enabled = dgvMenuItems.SelectedRows.Count > 0;
        }


        private void btnChangeSelectedImage_Click(object sender, EventArgs e) // '이미지 변경' 버튼 클릭 시, 수정할 제품의 이미지를 변경
        {
            if (dgvMenuItems.SelectedRows.Count == 0) return;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        picEditProductPreview.Image = Image.FromFile(openFileDialog.FileName);
                        currentEditSelectedImagePath = openFileDialog.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("이미지를 불러오는 중 오류가 발생했습니다: " + ex.Message, "이미지 로드 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e) // '변경사항 저장' 버튼 클릭 시, 제품 정보를 업데이트하는 메소드
        {
            if (dgvMenuItems.SelectedRows.Count > 0 && cmbCategory.SelectedItem != null)
            {
                string selectedCategory = cmbCategory.SelectedItem.ToString();
                // 수정 전 원래 제품 이름 가져오기 (이름이 변경될 경우를 대비)
                string originalItemName = dgvMenuItems.SelectedRows[0].Cells["이름"].Value.ToString();

                var itemToEdit = itemsCategory[selectedCategory].FirstOrDefault(x => x.Name == originalItemName);

                if (itemToEdit == null)
                {
                    MessageBox.Show("수정할 제품을 찾을 수 없습니다. 목록을 새로고침 해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string newName = txtEditProductName.Text.Trim();
                decimal newPrice = nudEditProductPrice.Value;
                Image newImage = picEditProductPreview.Image;

                if (string.IsNullOrWhiteSpace(newName))
                {
                    MessageBox.Show("제품명을 입력해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEditProductName.Focus();
                    return;
                }
                if (newPrice <= 0)
                {
                    MessageBox.Show("제품 가격은 0보다 커야 합니다.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nudEditProductPrice.Focus();
                    return;
                }
                if (newImage == null)
                {
                    MessageBox.Show("제품 이미지가 없습니다. 이미지를 선택해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                if (!newName.Equals(originalItemName, StringComparison.OrdinalIgnoreCase) &&
                    itemsCategory[selectedCategory].Any(item => item.Name.Equals(newName, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("이미 해당 이름의 다른 제품이 존재합니다.", "중복 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEditProductName.Focus();
                    return;
                }

                itemToEdit.Name = newName;
                itemToEdit.Price = newPrice;
                itemToEdit.Image = newImage;

                RefreshMenuItemsGrid();
                MessageBox.Show($"'{originalItemName}' 제품 정보가 성공적으로 수정되었습니다.", "수정 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearEditFields();
            }
            else
            {
                MessageBox.Show("수정할 제품을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e) // '제품 삭제' 버튼 클릭 시, 선택된 제품을 삭제하는 메소드
        {
            if (dgvMenuItems.SelectedRows.Count > 0 && cmbCategory.SelectedItem != null)
            {
                string selectedCategory = cmbCategory.SelectedItem.ToString();
                string itemName = dgvMenuItems.SelectedRows[0].Cells["이름"].Value.ToString();

                var itemToDelete = itemsCategory[selectedCategory].FirstOrDefault(x => x.Name == itemName);

                if (itemToDelete != null)   
                {
                    DialogResult confirmResult = MessageBox.Show($"'{itemName}' 제품을 정말 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        itemsCategory[selectedCategory].Remove(itemToDelete);
                        RefreshMenuItemsGrid();
                        //서버에 제거 신호 보냄
                        string delResp = _client.DeleteProduct(itemToDelete.ServerKey);
                        MessageBox.Show(delResp, "서버 응답");
                        MessageBox.Show($"'{itemName}' 제품이 삭제되었습니다.", "삭제 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearEditFields();

                    }
                }
            }
            else
            {
                MessageBox.Show("삭제할 제품을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
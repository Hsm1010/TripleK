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
using System.IO; // Required for Path operations if saving/loading images by path in future

namespace TripleK
{
    public partial class AdminForm : MaterialForm
    {
        private Dictionary<string, List<MenuItem>> itemsCategory;
        private string currentSelectedImagePath = null; // For new product image
        private string currentEditSelectedImagePath = null; // For editing product image

        public AdminForm(Dictionary<string, List<MenuItem>> itemsCategory)
        {
            InitializeComponent();
            this.itemsCategory = itemsCategory;

            // Initialize ComboBox
            cmbCategory.Items.AddRange(new string[] { "커피", "음료", "디저트", "케잌" });
            if (cmbCategory.Items.Count > 0)
            {
                cmbCategory.SelectedIndex = 0; // 기본적으로 첫 번째 카테고리 선택
            }

            // Event Handlers
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            btnAddStock.Click += btnAddStock_Click;

            // New Product Controls
            btnSelectNewImage.Click += btnSelectNewImage_Click;
            btnAddNewProduct.Click += btnAddNewProduct_Click;

            // Edit Product Controls
            dgvMenuItems.SelectionChanged += dgvMenuItems_SelectionChanged;
            btnChangeSelectedImage.Click += btnChangeSelectedImage_Click;
            btnSaveChanges.Click += btnSaveChanges_Click;
            btnDeleteProduct.Click += btnDeleteProduct_Click;

            // Initial population of DataGridView
            RefreshMenuItemsGrid();
            ClearEditFields(); // Ensure edit fields are initially empty
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // Any additional setup on load
            RefreshMenuItemsGrid(); // Ensure grid is populated on load
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMenuItemsGrid();
            ClearEditFields();
        }

        private void RefreshMenuItemsGrid()
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
                dgvMenuItems.DataSource = null; // Clear previous data source
                dgvMenuItems.DataSource = list.Select(x => new
                {
                    이름 = x.Name,
                    가격 = x.Price,
                    수량 = x.quantity
                }).ToList();
            }
            else
            {
                dgvMenuItems.DataSource = null;
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            if (dgvMenuItems.SelectedRows.Count > 0 && cmbCategory.SelectedItem != null)
            {
                string selectedCategory = cmbCategory.SelectedItem.ToString();
                string itemName = dgvMenuItems.SelectedRows[0].Cells["이름"].Value.ToString();

                var item = itemsCategory[selectedCategory].FirstOrDefault(x => x.Name == itemName);
                if (item != null)
                {
                    item.quantity += nudAddStockQuantity.Value; // Use renamed nud control
                    RefreshMenuItemsGrid();
                    MessageBox.Show($"{itemName}의 재고가 {nudAddStockQuantity.Value}만큼 추가되었습니다.", "재고 추가 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nudAddStockQuantity.Value = 0; // Reset numeric up down
                }
            }
            else
            {
                MessageBox.Show("재고를 추가할 제품을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // --- New Product Methods ---
        private void btnSelectNewImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        picNewProductPreview.Image = Image.FromFile(openFileDialog.FileName);
                        currentSelectedImagePath = openFileDialog.FileName; // Store path if needed for persistence later
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

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("제품을 추가할 카테고리를 선택해주세요.", "카테고리 미선택", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtNewProductName.Text.Trim();
            decimal price = nudNewProductPrice.Value;
            decimal quantity = nudNewProductQuantity.Value;
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


            string selectedCategory = cmbCategory.SelectedItem.ToString();
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
                Image = image, // Store the actual image object
                quantity = quantity
            };

            itemsCategory[selectedCategory].Add(newItem);
            RefreshMenuItemsGrid();
            MessageBox.Show($"'{name}' 제품이 성공적으로 추가되었습니다.", "제품 추가 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear input fields
            txtNewProductName.Clear();
            nudNewProductPrice.Value = 0;
            nudNewProductQuantity.Value = 0;
            picNewProductPreview.Image = null;
            currentSelectedImagePath = null;
        }

        // --- Edit/Delete Product Methods ---
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
                    picEditProductPreview.Image = item.Image; // Display current image
                    currentEditSelectedImagePath = null; // Reset path, new image will set it
                    gbEditProduct.Enabled = true;
                }
                else
                {
                    ClearEditFields(); // Item not found, clear fields
                }
            }
            else
            {
                ClearEditFields();
            }
        }

        private void ClearEditFields()
        {
            txtEditProductName.Clear();
            nudEditProductPrice.Value = 0;
            picEditProductPreview.Image = null;
            currentEditSelectedImagePath = null;
            gbEditProduct.Enabled = dgvMenuItems.SelectedRows.Count > 0;
        }


        private void btnChangeSelectedImage_Click(object sender, EventArgs e)
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
                        currentEditSelectedImagePath = openFileDialog.FileName; // Store path
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("이미지를 불러오는 중 오류가 발생했습니다: " + ex.Message, "이미지 로드 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (dgvMenuItems.SelectedRows.Count > 0 && cmbCategory.SelectedItem != null)
            {
                string selectedCategory = cmbCategory.SelectedItem.ToString();
                // Important: Get the original name from the grid BEFORE any changes in txtEditProductName
                string originalItemName = dgvMenuItems.SelectedRows[0].Cells["이름"].Value.ToString();

                var itemToEdit = itemsCategory[selectedCategory].FirstOrDefault(x => x.Name == originalItemName);

                if (itemToEdit == null)
                {
                    MessageBox.Show("수정할 제품을 찾을 수 없습니다. 목록을 새로고침 해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string newName = txtEditProductName.Text.Trim();
                decimal newPrice = nudEditProductPrice.Value;
                Image newImage = picEditProductPreview.Image; // This will be the new or existing image

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
                if (newImage == null) // Should not happen if an item is selected, but good check
                {
                    MessageBox.Show("제품 이미지가 없습니다. 이미지를 선택해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Check if new name conflicts with another existing item (excluding itself)
                if (!newName.Equals(originalItemName, StringComparison.OrdinalIgnoreCase) &&
                    itemsCategory[selectedCategory].Any(item => item.Name.Equals(newName, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("이미 해당 이름의 다른 제품이 존재합니다.", "중복 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEditProductName.Focus();
                    return;
                }

                itemToEdit.Name = newName;
                itemToEdit.Price = newPrice;
                itemToEdit.Image = newImage; // Update the image

                RefreshMenuItemsGrid();
                MessageBox.Show($"'{originalItemName}' 제품 정보가 성공적으로 수정되었습니다.", "수정 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearEditFields();
            }
            else
            {
                MessageBox.Show("수정할 제품을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
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

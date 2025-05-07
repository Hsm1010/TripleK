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

namespace TripleK
{
    public partial class Cart : MaterialForm
    {
        private decimal total;

        public Cart(List<MenuItem> cart)
        {
            InitializeComponent();
            // 그룹화하여 수량 및 합계 계산
            var grouped = cart
                .GroupBy(x => new { x.Name, x.Price, x.Image }) // 이름, 가격, 이미지로 그룹화, 쿼리 작성하는 것과 유사
                .Select(g => new
                {
                    g.Key.Image,
                    g.Key.Name,
                    Quantity = g.Count(),
                    UnitPrice = g.Key.Price,
                    TotalPrice = g.Key.Price * g.Count()
                }).ToList();

            total = grouped.Sum(x => x.TotalPrice);

            // DataGridView 설정
            dgvCart.AutoGenerateColumns = false;
            dgvCart.Columns.Clear();
            var imgCol = new DataGridViewImageColumn
            {
                HeaderText = " ",
                DataPropertyName = "Image",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 60
            };

            //그리드 뷰로 보기, 각 열 추가
            dgvCart.Columns.Add(imgCol);
            dgvCart.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "이름", DataPropertyName = "Name" });
            dgvCart.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "수량", DataPropertyName = "Quantity" });
            dgvCart.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "단가", DataPropertyName = "UnitPrice" });
            dgvCart.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "합계", DataPropertyName = "TotalPrice" });
            dgvCart.DataSource = grouped;

            lblCartTotal.Text = $"총액: {total}";
            btnCheckOut.Click += (s, e) =>
            {
                // 결제 폼 호출
                using (var payForm = new PayForm(total))
                {
                    payForm.ShowDialog();
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            };
        }

    }
}

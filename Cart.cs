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
using TripleK.TKClient;

namespace TripleK
{
    public partial class Cart : MaterialForm
    {
        private decimal total;
        private readonly List<MenuItem> _cart;
        private readonly Client _client;    

        public Cart(List<MenuItem> cart, Client client)
        {
            InitializeComponent();
            _cart = cart;
            _client = client;

            var view = _cart
                .Where(x => x.Quantity > 0)
                .Select(x => new
                {
                    x.Image,
                    x.Name,
                    x.Quantity,
                    Price = x.Price,
                    TotalPrice = x.Price * x.Quantity
                }).ToList();
            total = view.Sum(x => x.TotalPrice);

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
            dgvCart.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "단가", DataPropertyName = "Price" });
            dgvCart.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "합계", DataPropertyName = "TotalPrice" });
            dgvCart.DataSource = view;

            lblCartTotal.Text = $"총액: {total}";
            btnCheckOut.Click += (s, e) =>
            {
                // 결제 폼 호출
                var payForm = new PayForm(_cart, _client);
                if(payForm.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            };
        }

    }
}

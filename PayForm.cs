using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripleK.TKClient;

namespace TripleK
{
    public partial class PayForm : Form
    {
        private readonly List<MenuItem> _cart;
        private readonly Client _client;
        public PayForm(List<MenuItem> cart, Client client)
        {
            InitializeComponent();
            _cart = cart;
            _client = client;

            lblTotalPay.Text =
                $"총 결제 금액: {_cart.Sum(i => i.Price * i.Quantity):N0}원";

            // 단 한 번만 이벤트 걸기
            btnPay.Click += PayClicked;
        }

        private async void PayClicked(object sender, EventArgs e)
        {

            btnPay.Enabled = false;

            var itemsToSend = _cart
                .Where(x => x.Quantity > 0)
                .ToList();

            Debug.WriteLine($"▶ 전송할 아이템: {string.Join(", ", itemsToSend.Select(i => $"{i.ServerKey}×{i.Quantity}"))}");

            var sb = new StringBuilder();
            foreach (var it in itemsToSend)
            {
                string res = await Task.Run(() =>
                    _client.BuyItems(it.ServerKey, it.Quantity)
                );
                sb.AppendLine($"{it.Name} × {it.Quantity} → {res}");
            }

            MessageBox.Show(sb.ToString(), "결제 결과");
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

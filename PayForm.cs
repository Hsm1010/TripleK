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
    public partial class PayForm : Form
    {
        public PayForm(decimal total)
        {
            InitializeComponent();
            lblTotalPay.Text = $"총 결제 금액: {total}";
        }

        private void PayForm_Load(object sender, EventArgs e)
        {

        }
    }
}

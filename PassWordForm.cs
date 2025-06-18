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
    public partial class PassWordForm : Form
    {
        public string PassWord => passtb.Text;
        public PassWordForm()
        {
            InitializeComponent();
            passtb.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            };
        }

    }
}

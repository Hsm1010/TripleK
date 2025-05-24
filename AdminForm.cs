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
    public partial class AdminForm : MaterialForm
    {
        private Dictionary<string, List<MenuItem>> itemsCategory;

        public AdminForm(Dictionary<string, List<MenuItem>> itemsCategory)
        {
            InitializeComponent();
            this.itemsCategory = itemsCategory;

            cmbCategory.Items.AddRange(new string[] { "커피", "음료", "디저트", "케잌" });
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            btnAddStock.Click += btnAddStock_Click;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbCategory.SelectedItem.ToString();
            var list = itemsCategory[selected];
            dgvMenuItems.DataSource = null;
            dgvMenuItems.DataSource = list.Select(x => new
            {
                이름 = x.Name,
                가격 = x.Price,
                수량 = x.quantity
            }).ToList();
        }
        private void btnAddStock_Click(object sender, EventArgs e)
        {
            if (dgvMenuItems.SelectedRows.Count > 0)
            {
                string selectedCategory = cmbCategory.SelectedItem.ToString();
                string itemName = dgvMenuItems.SelectedRows[0].Cells["이름"].Value.ToString();

                var item = itemsCategory[selectedCategory].FirstOrDefault(x => x.Name == itemName);
                if (item != null)
                {
                    item.quantity += nudAddQuantity.Value;
                    cmbCategory_SelectedIndexChanged(null, null); // 목록 갱신
                }
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}

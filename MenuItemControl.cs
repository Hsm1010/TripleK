using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace TripleK
{

    public partial class MenuItemControl : UserControl
    {
        public MenuItem Item { get; set; }
        public event EventHandler<MenuItemEventArgs> AddClicked;
        public event EventHandler<MenuItemEventArgs> SubClicked;
        public MenuItemControl(MenuItem item)
        {
            Item = item;
            InitializeComponent();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Image = item.Image;
            lblName.Text = item.Name;
            lblPrice.Text = item.Price.ToString();

            //+버튼 클릭시, mainform에서 이벤트 처리됨
            btnAdd.Click += (s, e) =>
                AddClicked.Invoke(this, new MenuItemEventArgs(item));

            //-버튼 클릭시, mainform에서 이벤트 처리됨
            btnSub.Click += (s,e ) =>
                SubClicked.Invoke(this, new MenuItemEventArgs(item));

        }

    }

    //MenuItem class
    public class MenuItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Image Image { get; set; }
        public decimal quantity { get; set; }
    }
    public class MenuItemEventArgs : EventArgs
    {
        public MenuItem Item { get; }
        public MenuItemEventArgs(MenuItem item) => Item = item;
    }
}

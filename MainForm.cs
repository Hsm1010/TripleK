using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;
namespace TripleK
{
    public partial class MainForm : MaterialForm
    {
        //cart는 현재 담은 장바구니
        private List<MenuItem> cart;
        //itemsCategory는 카테고리 전환을 위함.
        private Dictionary<string, List<MenuItem>> itemsCategory;

        //관리자 모드를 위한 기능,
        //커피 카테고리를 5번 연속으로 누르면 관리자 모드로 진입하게 됨.
        private int coffeeClickCount = 0;
        public MainForm()
        {
            InitializeComponent();
            var msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.LIGHT;

            //메뉴 나오는 패널, 기본 설정
            panelContent.WrapContents = true;
            panelContent.FlowDirection = FlowDirection.LeftToRight;
            panelContent.AutoScroll = true;
            panelContent.AutoSize = false;
            panelContent.Margin = new Padding(0);
            panelContent.Padding = new Padding(10, 0, 10, 0);

            cart = new List<MenuItem>();
            initializeMenu();

            //초기엔 커피 화면
            LoadCategory("커피");

            //익명 함수 이용
            btnDrink.Click += (s, e) => LoadCategory("음료");
            btnDessert.Click += (s, e) => LoadCategory("디저트");
            btnCake.Click += (s, e) => LoadCategory("케잌");

            tmr.Tick += (s, e) =>
            {
                coffeeClickCount = 0;
            };

            LoadCategory("커피");
        }
        private void initializeMenu()
        {
            var exeFolder = Application.StartupPath;
            var imageFolder = Path.Combine(exeFolder, "image");

            //기본값 설정
            var coffeeList = new List<MenuItem>()
            {
                new MenuItem
                {
                    Name = "아메리카노", Price = 2000, Image = Image.FromFile(Path.Combine(imageFolder, "c_dkap.jpg"))
                },
                new MenuItem
                {
                    Name = "카페라떼", Price = 3000, Image = Image.FromFile(Path.Combine(imageFolder, "c_zkvpfkEp.jpg"))
                },
                new MenuItem
                {
                    Name = "바닐라라떼", Price = 3000, Image = Image.FromFile(Path.Combine(imageFolder, "c_qkslf.jpg"))
                },
                new MenuItem
                {
                    Name = "커피모카", Price = 3500, Image = Image.FromFile(Path.Combine(imageFolder, "c_zjvlahzk.jpg"))
                },
                new MenuItem
                {
                    Name = "카푸치노", Price = 3000, Image = Image.FromFile(Path.Combine(imageFolder, "c_zkvn.jpg"))
                }
            };
            var drinkList = new List<MenuItem>()
            {
                new MenuItem
                {
                    Name = "에이드", Price = 2500, Image = Image.FromFile(Path.Combine(imageFolder, "b_dpdlem.jpg"))
                },
                new MenuItem
                {
                    Name = "코코아", Price = 2500, Image = Image.FromFile(Path.Combine(imageFolder, "b_chzh.jpg"))
                },
                new MenuItem
                {
                    Name = "스무디", Price = 2500, Image = Image.FromFile(Path.Combine(imageFolder, "b_tmanel.jpg"))
                },
                new MenuItem
                {
                    Name = "프라페", Price = 2500, Image= Image.FromFile(Path.Combine(imageFolder, "b_vmfkvp.jpg"))
                }
            };
            var dessertList = new List<MenuItem>()
            {
                new MenuItem
                {
                    Name = "마카롱", Price = 2500, Image = Image.FromFile(Path.Combine(imageFolder, "d_akzkfhd.jpg"))
                },
                new MenuItem
                {
                    Name = "치아바타", Price = 2500, Image = Image.FromFile(Path.Combine(imageFolder, "d_cldk.jpg"))
                }
            };
            var cakeList = new List<MenuItem>()
            {
                new MenuItem
                {
                    Name = "치즈케잌", Price = 3000, Image = Image.FromFile(Path.Combine(imageFolder, "ca_clwm.jpg"))
                },
                new MenuItem
                {
                    Name = "딸기케잌", Price = 3000, Image = Image.FromFile(Path.Combine(imageFolder, "ca_Ekfrl.jpg"))
                },
                new MenuItem
                {
                    Name = "초코케잌", Price = 3000, Image = Image.FromFile(Path.Combine(imageFolder, "ca_chzh.jpg"))
                }
            };
            itemsCategory = new Dictionary<string, List<MenuItem>>()
            {
                ["커피"] = coffeeList,
                ["음료"] = drinkList,
                ["디저트"] = dessertList,
                ["케잌"] = cakeList
            };

        }

        //카테고리를 인자로 받아서 해당 카테고리를 panel에 띄워줌
        private void LoadCategory(string cate)
        {
            panelContent.Controls.Clear();
            foreach (var item in itemsCategory[cate])
            {
                ///menuitemcontrol은 사용자정의컨트롤
                ///사진, 가격, 추가 버튼으로 이루어진 작은 폼
                var mic = new MenuItemControl(item)
                {
                    //mic 크기 설정
                    Width = 160,
                    Height = 120,
                    Margin = new Padding(5, 0, 5, 0)
                };
                mic.AddClicked += (_, args) =>
                {
                    cart.Add(args.Item);
                    UpdateTotal();
                };
                mic.SubClicked += (_, args) =>
                {
                    //Name과 Price가 맞는 아이템을 가져옴.
                    var existingItem = cart.FirstOrDefault(x => x.Name == item.Name && x.Price == item.Price);

                    if (existingItem != null)
                    {
                        if (existingItem.quantity >= 1)
                            existingItem.quantity = existingItem.quantity - 1;
                        else
                            cart.Remove(existingItem);
                        UpdateTotal();
                    }
                };
                panelContent.Controls.Add(mic);
            }
        }

        //총 결제금액을 갱신해주는 함수
        private void UpdateTotal()
        {
            string total = cart.Sum(x => x.Price).ToString();
            lblTotal.Text = "총액: " + total;
        }

        //결제하기 버튼을 누르면 장바구니 폼이 열리고(장바구니 확인용)
        //해당 장바구니 폼에서 결제버튼을 누르면 진짜 결제하는 화면을 염.
        private void btnPay_Click(object sender, EventArgs e)
        {
            var cartForm = new Cart(cart);
            if (cartForm.ShowDialog() == DialogResult.OK)
            {
                cart.Clear();
                UpdateTotal();
            }
        }

        //관리자 모드를 위함.
        private void btnCoffee_Click(object sender, EventArgs e)
        {
            coffeeClickCount++;
            if (coffeeClickCount >= 5)
            {
                var adminForm = new AdminForm(itemsCategory);
                adminForm.ShowDialog();
                coffeeClickCount = 0;
            }
            else
            {
                LoadCategory("커피");
            }
            tmr.Stop();
            tmr.Start();
        }
    }
}
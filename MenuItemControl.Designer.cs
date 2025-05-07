using System.Drawing;
using System.Windows.Forms;

namespace TripleK
{
    partial class MenuItemControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuItemControl));
            this.lblName = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblPrice = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnSub = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AllowParentOverrides = false;
            this.lblName.AutoEllipsis = false;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblName.Location = new System.Drawing.Point(3, 83);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(86, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "bunifuLabel1";
            this.lblName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblPrice
            // 
            this.lblPrice.AllowParentOverrides = false;
            this.lblPrice.AutoEllipsis = false;
            this.lblPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPrice.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrice.Location = new System.Drawing.Point(95, 83);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrice.Size = new System.Drawing.Size(86, 20);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "bunifuLabel1";
            this.lblPrice.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPrice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(95, 6);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(64, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(70, 70);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // btnSub
            // 
            this.btnSub.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSub.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSub.Depth = 0;
            this.btnSub.HighEmphasis = true;
            this.btnSub.Icon = null;
            this.btnSub.Location = new System.Drawing.Point(95, 38);
            this.btnSub.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSub.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSub.Name = "btnSub";
            this.btnSub.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSub.Size = new System.Drawing.Size(64, 36);
            this.btnSub.TabIndex = 5;
            this.btnSub.Text = "-";
            this.btnSub.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSub.UseAccentColor = false;
            this.btnSub.UseVisualStyleBackColor = true;
            // 
            // MenuItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Name = "MenuItemControl";
            this.Size = new System.Drawing.Size(188, 110);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel lblName;
        private Bunifu.UI.WinForms.BunifuLabel lblPrice;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private PictureBox pictureBox;
        private MaterialSkin.Controls.MaterialButton btnSub;
    }
}

namespace TripleK
{
    partial class MainForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCoffee = new MaterialSkin.Controls.MaterialButton();
            this.btnDrink = new MaterialSkin.Controls.MaterialButton();
            this.btnDessert = new MaterialSkin.Controls.MaterialButton();
            this.btnCake = new MaterialSkin.Controls.MaterialButton();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.panelContent = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPay = new MaterialSkin.Controls.MaterialButton();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCoffee
            // 
            this.btnCoffee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCoffee.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCoffee.Depth = 0;
            this.btnCoffee.HighEmphasis = true;
            this.btnCoffee.Icon = null;
            this.btnCoffee.Location = new System.Drawing.Point(4, 5);
            this.btnCoffee.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCoffee.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCoffee.Size = new System.Drawing.Size(64, 36);
            this.btnCoffee.TabIndex = 0;
            this.btnCoffee.Text = "커피";
            this.btnCoffee.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCoffee.UseAccentColor = false;
            this.btnCoffee.UseVisualStyleBackColor = true;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            // 
            // btnDrink
            // 
            this.btnDrink.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDrink.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDrink.Depth = 0;
            this.btnDrink.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDrink.HighEmphasis = true;
            this.btnDrink.Icon = null;
            this.btnDrink.Location = new System.Drawing.Point(76, 5);
            this.btnDrink.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDrink.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDrink.Size = new System.Drawing.Size(64, 36);
            this.btnDrink.TabIndex = 2;
            this.btnDrink.Text = "음료";
            this.btnDrink.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDrink.UseAccentColor = false;
            this.btnDrink.UseVisualStyleBackColor = true;
            // 
            // btnDessert
            // 
            this.btnDessert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDessert.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDessert.Depth = 0;
            this.btnDessert.HighEmphasis = true;
            this.btnDessert.Icon = null;
            this.btnDessert.Location = new System.Drawing.Point(148, 5);
            this.btnDessert.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDessert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDessert.Size = new System.Drawing.Size(69, 36);
            this.btnDessert.TabIndex = 3;
            this.btnDessert.Text = "디저트";
            this.btnDessert.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDessert.UseAccentColor = false;
            this.btnDessert.UseVisualStyleBackColor = true;
            // 
            // btnCake
            // 
            this.btnCake.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCake.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCake.Depth = 0;
            this.btnCake.HighEmphasis = true;
            this.btnCake.Icon = null;
            this.btnCake.Location = new System.Drawing.Point(225, 5);
            this.btnCake.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCake.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCake.Name = "btnCake";
            this.btnCake.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCake.Size = new System.Drawing.Size(69, 36);
            this.btnCake.TabIndex = 4;
            this.btnCake.Text = "케이크";
            this.btnCake.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCake.UseAccentColor = false;
            this.btnCake.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotal.Location = new System.Drawing.Point(7, 498);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(29, 19);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "총액:";
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.Location = new System.Drawing.Point(6, 143);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(593, 342);
            this.panelContent.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCake);
            this.panel1.Controls.Add(this.btnDessert);
            this.panel1.Controls.Add(this.btnDrink);
            this.panel1.Controls.Add(this.btnCoffee);
            this.panel1.Location = new System.Drawing.Point(6, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 44);
            this.panel1.TabIndex = 8;
            // 
            // btnPay
            // 
            this.btnPay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPay.Depth = 0;
            this.btnPay.HighEmphasis = true;
            this.btnPay.Icon = null;
            this.btnPay.Location = new System.Drawing.Point(420, 489);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPay.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPay.Name = "btnPay";
            this.btnPay.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPay.Size = new System.Drawing.Size(85, 36);
            this.btnPay.TabIndex = 9;
            this.btnPay.Text = "결제하기";
            this.btnPay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPay.UseAccentColor = false;
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // tmr
            // 
            this.tmr.Interval = 5000;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 534);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.lblTotal);
            this.Name = "MainForm";
            this.Text = "TripleK";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnCoffee;
        private MaterialSkin.Controls.MaterialButton btnDrink;
        private MaterialSkin.Controls.MaterialButton btnDessert;
        private MaterialSkin.Controls.MaterialButton btnCake;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private System.Windows.Forms.FlowLayoutPanel panelContent;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnPay;
        private System.Windows.Forms.Timer tmr;
    }
}


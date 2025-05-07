namespace TripleK
{
    partial class Cart
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lblCartTotal = new MaterialSkin.Controls.MaterialLabel();
            this.btnCheckOut = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(6, 76);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 27;
            this.dgvCart.Size = new System.Drawing.Size(441, 248);
            this.dgvCart.TabIndex = 2;
            // 
            // lblCartTotal
            // 
            this.lblCartTotal.AutoSize = true;
            this.lblCartTotal.Depth = 0;
            this.lblCartTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCartTotal.Location = new System.Drawing.Point(20, 330);
            this.lblCartTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCartTotal.Name = "lblCartTotal";
            this.lblCartTotal.Size = new System.Drawing.Size(49, 19);
            this.lblCartTotal.TabIndex = 3;
            this.lblCartTotal.Text = "총액: \\0";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.AllowAnimations = true;
            this.btnCheckOut.AllowMouseEffects = true;
            this.btnCheckOut.AllowToggling = false;
            this.btnCheckOut.AnimationSpeed = 200;
            this.btnCheckOut.AutoGenerateColors = false;
            this.btnCheckOut.AutoRoundBorders = false;
            this.btnCheckOut.AutoSizeLeftIcon = true;
            this.btnCheckOut.AutoSizeRightIcon = true;
            this.btnCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnCheckOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.BackgroundImage")));
            this.btnCheckOut.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCheckOut.ButtonText = "결제하기";
            this.btnCheckOut.ButtonTextMarginLeft = 0;
            this.btnCheckOut.ColorContrastOnClick = 45;
            this.btnCheckOut.ColorContrastOnHover = 45;
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCheckOut.CustomizableEdges = borderEdges1;
            this.btnCheckOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCheckOut.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCheckOut.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCheckOut.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCheckOut.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckOut.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCheckOut.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCheckOut.IconMarginLeft = 11;
            this.btnCheckOut.IconPadding = 10;
            this.btnCheckOut.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckOut.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCheckOut.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCheckOut.IconSize = 25;
            this.btnCheckOut.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCheckOut.IdleBorderRadius = 1;
            this.btnCheckOut.IdleBorderThickness = 1;
            this.btnCheckOut.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnCheckOut.IdleIconLeftImage = null;
            this.btnCheckOut.IdleIconRightImage = null;
            this.btnCheckOut.IndicateFocus = false;
            this.btnCheckOut.Location = new System.Drawing.Point(350, 330);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCheckOut.OnDisabledState.BorderRadius = 1;
            this.btnCheckOut.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCheckOut.OnDisabledState.BorderThickness = 1;
            this.btnCheckOut.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCheckOut.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCheckOut.OnDisabledState.IconLeftImage = null;
            this.btnCheckOut.OnDisabledState.IconRightImage = null;
            this.btnCheckOut.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCheckOut.onHoverState.BorderRadius = 1;
            this.btnCheckOut.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCheckOut.onHoverState.BorderThickness = 1;
            this.btnCheckOut.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCheckOut.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.onHoverState.IconLeftImage = null;
            this.btnCheckOut.onHoverState.IconRightImage = null;
            this.btnCheckOut.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCheckOut.OnIdleState.BorderRadius = 1;
            this.btnCheckOut.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCheckOut.OnIdleState.BorderThickness = 1;
            this.btnCheckOut.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnCheckOut.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.OnIdleState.IconLeftImage = null;
            this.btnCheckOut.OnIdleState.IconRightImage = null;
            this.btnCheckOut.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCheckOut.OnPressedState.BorderRadius = 1;
            this.btnCheckOut.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCheckOut.OnPressedState.BorderThickness = 1;
            this.btnCheckOut.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCheckOut.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.OnPressedState.IconLeftImage = null;
            this.btnCheckOut.OnPressedState.IconRightImage = null;
            this.btnCheckOut.Size = new System.Drawing.Size(100, 36);
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCheckOut.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCheckOut.TextMarginLeft = 0;
            this.btnCheckOut.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCheckOut.UseDefaultRadiusAndThickness = true;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 380);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.lblCartTotal);
            this.Controls.Add(this.dgvCart);
            this.Name = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCart;
        private MaterialSkin.Controls.MaterialLabel lblCartTotal;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCheckOut;
    }
}

namespace TripleK
{
    partial class PayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayForm));
            this.lblTotalPay = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnPay = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblTotalPay
            // 
            this.lblTotalPay.AllowParentOverrides = false;
            this.lblTotalPay.AutoEllipsis = false;
            this.lblTotalPay.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalPay.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTotalPay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalPay.Location = new System.Drawing.Point(12, 12);
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalPay.Size = new System.Drawing.Size(82, 20);
            this.lblTotalPay.TabIndex = 0;
            this.lblTotalPay.Text = "총 결제금액:";
            this.lblTotalPay.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotalPay.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnPay
            // 
            this.btnPay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPay.Depth = 0;
            this.btnPay.HighEmphasis = true;
            this.btnPay.Icon = null;
            this.btnPay.Location = new System.Drawing.Point(135, 220);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPay.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPay.Name = "btnPay";
            this.btnPay.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPay.Size = new System.Drawing.Size(85, 36);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "결제하기";
            this.btnPay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPay.UseAccentColor = false;
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 271);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblTotalPay);
            this.Name = "PayForm";
            this.Text = "결제";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lblTotalPay;
        private MaterialSkin.Controls.MaterialButton btnPay;
    }
}
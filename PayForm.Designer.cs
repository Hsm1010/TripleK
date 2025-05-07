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
            this.SuspendLayout();
            // 
            // lblTotalPay
            // 
            this.lblTotalPay.AllowParentOverrides = false;
            this.lblTotalPay.AutoEllipsis = false;
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
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 271);
            this.Controls.Add(this.lblTotalPay);
            this.Name = "PayForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lblTotalPay;
    }
}
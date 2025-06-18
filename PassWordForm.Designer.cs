namespace TripleK
{
    partial class PassWordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassWordForm));
            this.passtb = new System.Windows.Forms.TextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // passtb
            // 
            this.passtb.Location = new System.Drawing.Point(125, 77);
            this.passtb.Name = "passtb";
            this.passtb.Size = new System.Drawing.Size(100, 25);
            this.passtb.TabIndex = 0;
            this.passtb.UseSystemPasswordChar = true;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel1.Location = new System.Drawing.Point(56, 82);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(63, 20);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "비밀번호: ";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // PassWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 169);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.passtb);
            this.Name = "PassWordForm";
            this.Text = "PassWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passtb;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}
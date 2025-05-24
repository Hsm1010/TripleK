namespace TripleK
{
    partial class AdminForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.cmbCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.dgvMenuItems = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.nudAddQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddStock = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCategory
            // 
            this.cmbCategory.AutoResize = false;
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCategory.Depth = 0;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCategory.DropDownHeight = 174;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.DropDownWidth = 121;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.IntegralHeight = false;
            this.cmbCategory.ItemHeight = 43;
            this.cmbCategory.Location = new System.Drawing.Point(548, 146);
            this.cmbCategory.MaxDropDownItems = 4;
            this.cmbCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 49);
            this.cmbCategory.StartIndex = 0;
            this.cmbCategory.TabIndex = 0;
            // 
            // dgvMenuItems
            // 
            this.dgvMenuItems.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvMenuItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMenuItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenuItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMenuItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMenuItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenuItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMenuItems.ColumnHeadersHeight = 40;
            this.dgvMenuItems.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvMenuItems.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvMenuItems.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMenuItems.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvMenuItems.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMenuItems.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvMenuItems.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvMenuItems.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvMenuItems.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvMenuItems.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMenuItems.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvMenuItems.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMenuItems.CurrentTheme.Name = null;
            this.dgvMenuItems.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMenuItems.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvMenuItems.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMenuItems.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvMenuItems.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMenuItems.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMenuItems.EnableHeadersVisualStyles = false;
            this.dgvMenuItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvMenuItems.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvMenuItems.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvMenuItems.HeaderForeColor = System.Drawing.Color.White;
            this.dgvMenuItems.Location = new System.Drawing.Point(60, 271);
            this.dgvMenuItems.Name = "dgvMenuItems";
            this.dgvMenuItems.RowHeadersVisible = false;
            this.dgvMenuItems.RowHeadersWidth = 62;
            this.dgvMenuItems.RowTemplate.Height = 40;
            this.dgvMenuItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenuItems.Size = new System.Drawing.Size(609, 285);
            this.dgvMenuItems.TabIndex = 1;
            this.dgvMenuItems.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // nudAddQuantity
            // 
            this.nudAddQuantity.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAddQuantity.Location = new System.Drawing.Point(59, 606);
            this.nudAddQuantity.Name = "nudAddQuantity";
            this.nudAddQuantity.Size = new System.Drawing.Size(120, 28);
            this.nudAddQuantity.TabIndex = 2;
            // 
            // btnAddStock
            // 
            this.btnAddStock.AllowAnimations = true;
            this.btnAddStock.AllowMouseEffects = true;
            this.btnAddStock.AllowToggling = false;
            this.btnAddStock.AnimationSpeed = 200;
            this.btnAddStock.AutoGenerateColors = false;
            this.btnAddStock.AutoRoundBorders = false;
            this.btnAddStock.AutoSizeLeftIcon = true;
            this.btnAddStock.AutoSizeRightIcon = true;
            this.btnAddStock.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStock.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnAddStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddStock.BackgroundImage")));
            this.btnAddStock.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddStock.ButtonText = "재고 추가";
            this.btnAddStock.ButtonTextMarginLeft = 0;
            this.btnAddStock.ColorContrastOnClick = 45;
            this.btnAddStock.ColorContrastOnHover = 45;
            this.btnAddStock.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAddStock.CustomizableEdges = borderEdges2;
            this.btnAddStock.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddStock.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddStock.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddStock.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddStock.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddStock.ForeColor = System.Drawing.Color.White;
            this.btnAddStock.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStock.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddStock.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddStock.IconMarginLeft = 11;
            this.btnAddStock.IconPadding = 10;
            this.btnAddStock.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStock.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddStock.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddStock.IconSize = 25;
            this.btnAddStock.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddStock.IdleBorderRadius = 1;
            this.btnAddStock.IdleBorderThickness = 1;
            this.btnAddStock.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddStock.IdleIconLeftImage = null;
            this.btnAddStock.IdleIconRightImage = null;
            this.btnAddStock.IndicateFocus = false;
            this.btnAddStock.Location = new System.Drawing.Point(519, 606);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddStock.OnDisabledState.BorderRadius = 1;
            this.btnAddStock.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddStock.OnDisabledState.BorderThickness = 1;
            this.btnAddStock.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddStock.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddStock.OnDisabledState.IconLeftImage = null;
            this.btnAddStock.OnDisabledState.IconRightImage = null;
            this.btnAddStock.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddStock.onHoverState.BorderRadius = 1;
            this.btnAddStock.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddStock.onHoverState.BorderThickness = 1;
            this.btnAddStock.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddStock.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddStock.onHoverState.IconLeftImage = null;
            this.btnAddStock.onHoverState.IconRightImage = null;
            this.btnAddStock.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddStock.OnIdleState.BorderRadius = 1;
            this.btnAddStock.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddStock.OnIdleState.BorderThickness = 1;
            this.btnAddStock.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddStock.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddStock.OnIdleState.IconLeftImage = null;
            this.btnAddStock.OnIdleState.IconRightImage = null;
            this.btnAddStock.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddStock.OnPressedState.BorderRadius = 1;
            this.btnAddStock.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddStock.OnPressedState.BorderThickness = 1;
            this.btnAddStock.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddStock.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddStock.OnPressedState.IconLeftImage = null;
            this.btnAddStock.OnPressedState.IconRightImage = null;
            this.btnAddStock.Size = new System.Drawing.Size(150, 39);
            this.btnAddStock.TabIndex = 3;
            this.btnAddStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddStock.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddStock.TextMarginLeft = 0;
            this.btnAddStock.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddStock.UseDefaultRadiusAndThickness = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "카테고리 선택";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 712);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.nudAddQuantity);
            this.Controls.Add(this.dgvMenuItems);
            this.Controls.Add(this.cmbCategory);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Padding = new System.Windows.Forms.Padding(4, 77, 4, 4);
            this.Text = "관리자 모드";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cmbCategory;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvMenuItems;
        private System.Windows.Forms.NumericUpDown nudAddQuantity;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddStock;
        private System.Windows.Forms.Label label1;
    }
}

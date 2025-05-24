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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.cmbCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.dgvMenuItems = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.nudAddStockQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddStock = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblCategorySelection = new System.Windows.Forms.Label();
            this.gbAddNewProduct = new System.Windows.Forms.GroupBox();
            this.btnAddNewProduct = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSelectNewImage = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.picNewProductPreview = new System.Windows.Forms.PictureBox();
            this.lblNewProductImage = new System.Windows.Forms.Label();
            this.nudNewProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblNewProductQuantity = new System.Windows.Forms.Label();
            this.nudNewProductPrice = new System.Windows.Forms.NumericUpDown();
            this.lblNewProductPrice = new System.Windows.Forms.Label();
            this.txtNewProductName = new MaterialSkin.Controls.MaterialTextBox();
            this.lblNewProductName = new System.Windows.Forms.Label();
            this.gbEditProduct = new System.Windows.Forms.GroupBox();
            this.btnDeleteProduct = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSaveChanges = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnChangeSelectedImage = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.picEditProductPreview = new System.Windows.Forms.PictureBox();
            this.lblEditProductImage = new System.Windows.Forms.Label();
            this.nudEditProductPrice = new System.Windows.Forms.NumericUpDown();
            this.lblEditProductPrice = new System.Windows.Forms.Label();
            this.txtEditProductName = new MaterialSkin.Controls.MaterialTextBox();
            this.lblEditProductName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddStockQuantity)).BeginInit();
            this.gbAddNewProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNewProductPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewProductQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewProductPrice)).BeginInit();
            this.gbEditProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEditProductPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditProductPrice)).BeginInit();
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
            this.cmbCategory.Location = new System.Drawing.Point(18, 100);
            this.cmbCategory.MaxDropDownItems = 4;
            this.cmbCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(180, 49);
            this.cmbCategory.StartIndex = 0;
            this.cmbCategory.TabIndex = 0;
            // 
            // dgvMenuItems
            // 
            this.dgvMenuItems.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvMenuItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMenuItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenuItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMenuItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMenuItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenuItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMenuItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMenuItems.EnableHeadersVisualStyles = false;
            this.dgvMenuItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvMenuItems.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvMenuItems.HeaderForeColor = System.Drawing.Color.White;
            this.dgvMenuItems.Location = new System.Drawing.Point(18, 155);
            this.dgvMenuItems.Name = "dgvMenuItems";
            this.dgvMenuItems.ReadOnly = true;
            this.dgvMenuItems.RowHeadersVisible = false;
            this.dgvMenuItems.RowHeadersWidth = 62;
            this.dgvMenuItems.RowTemplate.Height = 40;
            this.dgvMenuItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenuItems.Size = new System.Drawing.Size(430, 200);
            this.dgvMenuItems.TabIndex = 1;
            this.dgvMenuItems.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvMenuItems.SelectionChanged += new System.EventHandler(this.dgvMenuItems_SelectionChanged);
            // 
            // nudAddStockQuantity
            // 
            this.nudAddStockQuantity.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAddStockQuantity.Location = new System.Drawing.Point(18, 390);
            this.nudAddStockQuantity.Name = "nudAddStockQuantity";
            this.nudAddStockQuantity.Size = new System.Drawing.Size(120, 25);
            this.nudAddStockQuantity.TabIndex = 2;
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddStock.CustomizableEdges = borderEdges1;
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
            this.btnAddStock.IndicateFocus = false;
            this.btnAddStock.Location = new System.Drawing.Point(144, 383);
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
            this.btnAddStock.OnIdleState.IconLeftImage = null; // Icon image set here
            this.btnAddStock.OnIdleState.IconRightImage = null; // Icon image set here
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
            // lblCategorySelection
            // 
            this.lblCategorySelection.AutoSize = true;
            this.lblCategorySelection.Location = new System.Drawing.Point(15, 79);
            this.lblCategorySelection.Name = "lblCategorySelection";
            this.lblCategorySelection.Size = new System.Drawing.Size(102, 17);
            this.lblCategorySelection.TabIndex = 4;
            this.lblCategorySelection.Text = "카테고리 선택";
            // 
            // gbAddNewProduct
            // 
            this.gbAddNewProduct.Controls.Add(this.btnAddNewProduct);
            this.gbAddNewProduct.Controls.Add(this.btnSelectNewImage);
            this.gbAddNewProduct.Controls.Add(this.picNewProductPreview);
            this.gbAddNewProduct.Controls.Add(this.lblNewProductImage);
            this.gbAddNewProduct.Controls.Add(this.nudNewProductQuantity);
            this.gbAddNewProduct.Controls.Add(this.lblNewProductQuantity);
            this.gbAddNewProduct.Controls.Add(this.nudNewProductPrice);
            this.gbAddNewProduct.Controls.Add(this.lblNewProductPrice);
            this.gbAddNewProduct.Controls.Add(this.txtNewProductName);
            this.gbAddNewProduct.Controls.Add(this.lblNewProductName);
            this.gbAddNewProduct.Location = new System.Drawing.Point(470, 79);
            this.gbAddNewProduct.Name = "gbAddNewProduct";
            this.gbAddNewProduct.Size = new System.Drawing.Size(268, 343);
            this.gbAddNewProduct.TabIndex = 5;
            this.gbAddNewProduct.TabStop = false;
            this.gbAddNewProduct.Text = "새 제품 추가";
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.AllowAnimations = true;
            this.btnAddNewProduct.AllowMouseEffects = true;
            this.btnAddNewProduct.AllowToggling = false;
            this.btnAddNewProduct.AnimationSpeed = 200;
            this.btnAddNewProduct.AutoGenerateColors = false;
            this.btnAddNewProduct.AutoRoundBorders = false;
            this.btnAddNewProduct.AutoSizeLeftIcon = true;
            this.btnAddNewProduct.AutoSizeRightIcon = true;
            this.btnAddNewProduct.BackColor = System.Drawing.Color.Transparent;
            // this.btnAddNewProduct.BackColor1 = System.Drawing.Color.DodgerBlue; // Removed, handled by OnIdleState.FillColor
            this.btnAddNewProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewProduct.BackgroundImage")));
            this.btnAddNewProduct.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewProduct.ButtonText = "제품 추가";
            this.btnAddNewProduct.ButtonTextMarginLeft = 0;
            this.btnAddNewProduct.ColorContrastOnClick = 45;
            this.btnAddNewProduct.ColorContrastOnHover = 45;
            this.btnAddNewProduct.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAddNewProduct.CustomizableEdges = borderEdges2;
            this.btnAddNewProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            // this.btnAddNewProduct.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191))))); // Handled by OnDisabledState
            // this.btnAddNewProduct.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204))))); // Handled by OnDisabledState
            // this.btnAddNewProduct.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168))))); // Handled by OnDisabledState
            this.btnAddNewProduct.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddNewProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddNewProduct.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewProduct.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNewProduct.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddNewProduct.IconMarginLeft = 11;
            this.btnAddNewProduct.IconPadding = 10;
            this.btnAddNewProduct.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewProduct.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNewProduct.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddNewProduct.IconSize = 25;
            this.btnAddNewProduct.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddNewProduct.IdleBorderRadius = 1;
            this.btnAddNewProduct.IdleBorderThickness = 1;
            this.btnAddNewProduct.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddNewProduct.IndicateFocus = false;
            this.btnAddNewProduct.Location = new System.Drawing.Point(15, 295);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddNewProduct.OnDisabledState.BorderRadius = 1;
            this.btnAddNewProduct.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewProduct.OnDisabledState.BorderThickness = 1;
            this.btnAddNewProduct.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddNewProduct.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddNewProduct.OnDisabledState.IconLeftImage = null;
            this.btnAddNewProduct.OnDisabledState.IconRightImage = null;
            this.btnAddNewProduct.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAddNewProduct.onHoverState.BorderRadius = 1;
            this.btnAddNewProduct.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewProduct.onHoverState.BorderThickness = 1;
            this.btnAddNewProduct.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAddNewProduct.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddNewProduct.onHoverState.IconLeftImage = null;
            this.btnAddNewProduct.onHoverState.IconRightImage = null;
            this.btnAddNewProduct.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddNewProduct.OnIdleState.BorderRadius = 1;
            this.btnAddNewProduct.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewProduct.OnIdleState.BorderThickness = 1;
            this.btnAddNewProduct.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddNewProduct.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddNewProduct.OnIdleState.IconLeftImage = null;
            this.btnAddNewProduct.OnIdleState.IconRightImage = null;
            this.btnAddNewProduct.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddNewProduct.OnPressedState.BorderRadius = 1;
            this.btnAddNewProduct.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewProduct.OnPressedState.BorderThickness = 1;
            this.btnAddNewProduct.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddNewProduct.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddNewProduct.OnPressedState.IconLeftImage = null;
            this.btnAddNewProduct.OnPressedState.IconRightImage = null;
            this.btnAddNewProduct.Size = new System.Drawing.Size(236, 39);
            this.btnAddNewProduct.TabIndex = 9;
            this.btnAddNewProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddNewProduct.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddNewProduct.TextMarginLeft = 0;
            this.btnAddNewProduct.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddNewProduct.UseDefaultRadiusAndThickness = true;
            // 
            // btnSelectNewImage
            // 
            this.btnSelectNewImage.AllowAnimations = true;
            this.btnSelectNewImage.AllowMouseEffects = true;
            this.btnSelectNewImage.AllowToggling = false;
            this.btnSelectNewImage.AnimationSpeed = 200;
            this.btnSelectNewImage.AutoGenerateColors = false;
            this.btnSelectNewImage.AutoRoundBorders = false;
            this.btnSelectNewImage.AutoSizeLeftIcon = true;
            this.btnSelectNewImage.AutoSizeRightIcon = true;
            this.btnSelectNewImage.BackColor = System.Drawing.Color.Transparent;
            // this.btnSelectNewImage.BackColor1 = System.Drawing.Color.DimGray; // Removed
            this.btnSelectNewImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectNewImage.BackgroundImage")));
            this.btnSelectNewImage.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSelectNewImage.ButtonText = "이미지 선택";
            this.btnSelectNewImage.ButtonTextMarginLeft = 0;
            this.btnSelectNewImage.ColorContrastOnClick = 45;
            this.btnSelectNewImage.ColorContrastOnHover = 45;
            this.btnSelectNewImage.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnSelectNewImage.CustomizableEdges = borderEdges3;
            this.btnSelectNewImage.DialogResult = System.Windows.Forms.DialogResult.None;
            // this.btnSelectNewImage.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191))))); // Handled by OnDisabledState
            // this.btnSelectNewImage.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204))))); // Handled by OnDisabledState
            // this.btnSelectNewImage.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168))))); // Handled by OnDisabledState
            this.btnSelectNewImage.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSelectNewImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelectNewImage.ForeColor = System.Drawing.Color.White;
            this.btnSelectNewImage.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectNewImage.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSelectNewImage.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSelectNewImage.IconMarginLeft = 11;
            this.btnSelectNewImage.IconPadding = 10;
            this.btnSelectNewImage.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectNewImage.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSelectNewImage.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSelectNewImage.IconSize = 25;
            this.btnSelectNewImage.IdleBorderColor = System.Drawing.Color.DimGray;
            this.btnSelectNewImage.IdleBorderRadius = 1;
            this.btnSelectNewImage.IdleBorderThickness = 1;
            this.btnSelectNewImage.IdleFillColor = System.Drawing.Color.DimGray;
            this.btnSelectNewImage.IndicateFocus = false;
            this.btnSelectNewImage.Location = new System.Drawing.Point(126, 240);
            this.btnSelectNewImage.Name = "btnSelectNewImage";
            this.btnSelectNewImage.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSelectNewImage.OnDisabledState.BorderRadius = 1;
            this.btnSelectNewImage.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSelectNewImage.OnDisabledState.BorderThickness = 1;
            this.btnSelectNewImage.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSelectNewImage.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSelectNewImage.OnDisabledState.IconLeftImage = null;
            this.btnSelectNewImage.OnDisabledState.IconRightImage = null;
            this.btnSelectNewImage.onHoverState.BorderColor = System.Drawing.Color.Gray; // Corrected from 30,150,255
            this.btnSelectNewImage.onHoverState.BorderRadius = 1;
            this.btnSelectNewImage.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSelectNewImage.onHoverState.BorderThickness = 1;
            this.btnSelectNewImage.onHoverState.FillColor = System.Drawing.Color.Gray; // Corrected from 30,150,255
            this.btnSelectNewImage.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSelectNewImage.onHoverState.IconLeftImage = null;
            this.btnSelectNewImage.onHoverState.IconRightImage = null;
            this.btnSelectNewImage.OnIdleState.BorderColor = System.Drawing.Color.DimGray;
            this.btnSelectNewImage.OnIdleState.BorderRadius = 1;
            this.btnSelectNewImage.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSelectNewImage.OnIdleState.BorderThickness = 1;
            this.btnSelectNewImage.OnIdleState.FillColor = System.Drawing.Color.DimGray;
            this.btnSelectNewImage.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSelectNewImage.OnIdleState.IconLeftImage = null;
            this.btnSelectNewImage.OnIdleState.IconRightImage = null;
            this.btnSelectNewImage.OnPressedState.BorderColor = System.Drawing.Color.Black; // Corrected from 40,96,144
            this.btnSelectNewImage.OnPressedState.BorderRadius = 1;
            this.btnSelectNewImage.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSelectNewImage.OnPressedState.BorderThickness = 1;
            this.btnSelectNewImage.OnPressedState.FillColor = System.Drawing.Color.Black; // Corrected from 40,96,144
            this.btnSelectNewImage.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSelectNewImage.OnPressedState.IconLeftImage = null;
            this.btnSelectNewImage.OnPressedState.IconRightImage = null;
            this.btnSelectNewImage.Size = new System.Drawing.Size(125, 30);
            this.btnSelectNewImage.TabIndex = 8;
            this.btnSelectNewImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelectNewImage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSelectNewImage.TextMarginLeft = 0;
            this.btnSelectNewImage.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSelectNewImage.UseDefaultRadiusAndThickness = true;
            // 
            // picNewProductPreview
            // 
            this.picNewProductPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNewProductPreview.Location = new System.Drawing.Point(126, 160);
            this.picNewProductPreview.Name = "picNewProductPreview";
            this.picNewProductPreview.Size = new System.Drawing.Size(125, 75);
            this.picNewProductPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNewProductPreview.TabIndex = 7;
            this.picNewProductPreview.TabStop = false;
            // 
            // lblNewProductImage
            // 
            this.lblNewProductImage.AutoSize = true;
            this.lblNewProductImage.Location = new System.Drawing.Point(12, 160);
            this.lblNewProductImage.Name = "lblNewProductImage";
            this.lblNewProductImage.Size = new System.Drawing.Size(87, 17);
            this.lblNewProductImage.TabIndex = 6;
            this.lblNewProductImage.Text = "제품 이미지:";
            // 
            // nudNewProductQuantity
            // 
            this.nudNewProductQuantity.Location = new System.Drawing.Point(126, 120);
            this.nudNewProductQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudNewProductQuantity.Name = "nudNewProductQuantity";
            this.nudNewProductQuantity.Size = new System.Drawing.Size(125, 25);
            this.nudNewProductQuantity.TabIndex = 5;
            // 
            // lblNewProductQuantity
            // 
            this.lblNewProductQuantity.AutoSize = true;
            this.lblNewProductQuantity.Location = new System.Drawing.Point(12, 122);
            this.lblNewProductQuantity.Name = "lblNewProductQuantity";
            this.lblNewProductQuantity.Size = new System.Drawing.Size(72, 17);
            this.lblNewProductQuantity.TabIndex = 4;
            this.lblNewProductQuantity.Text = "초기 수량:";
            // 
            // nudNewProductPrice
            // 
            this.nudNewProductPrice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudNewProductPrice.Location = new System.Drawing.Point(126, 80);
            this.nudNewProductPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudNewProductPrice.Name = "nudNewProductPrice";
            this.nudNewProductPrice.Size = new System.Drawing.Size(125, 25);
            this.nudNewProductPrice.TabIndex = 3;
            // 
            // lblNewProductPrice
            // 
            this.lblNewProductPrice.AutoSize = true;
            this.lblNewProductPrice.Location = new System.Drawing.Point(12, 82);
            this.lblNewProductPrice.Name = "lblNewProductPrice";
            this.lblNewProductPrice.Size = new System.Drawing.Size(72, 17);
            this.lblNewProductPrice.TabIndex = 2;
            this.lblNewProductPrice.Text = "제품 가격:";
            // 
            // txtNewProductName
            // 
            this.txtNewProductName.AnimateReadOnly = false;
            this.txtNewProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewProductName.Depth = 0;
            this.txtNewProductName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNewProductName.LeadingIcon = null;
            this.txtNewProductName.Location = new System.Drawing.Point(15, 40);
            this.txtNewProductName.MaxLength = 50;
            this.txtNewProductName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNewProductName.Multiline = false;
            this.txtNewProductName.Name = "txtNewProductName";
            this.txtNewProductName.Size = new System.Drawing.Size(236, 36);
            this.txtNewProductName.TabIndex = 1;
            this.txtNewProductName.Text = "";
            this.txtNewProductName.TrailingIcon = null;
            this.txtNewProductName.UseTallSize = false;
            // 
            // lblNewProductName
            // 
            this.lblNewProductName.AutoSize = true;
            this.lblNewProductName.Location = new System.Drawing.Point(12, 20);
            this.lblNewProductName.Name = "lblNewProductName";
            this.lblNewProductName.Size = new System.Drawing.Size(57, 17);
            this.lblNewProductName.TabIndex = 0;
            this.lblNewProductName.Text = "제품명:";
            // 
            // gbEditProduct
            // 
            this.gbEditProduct.Controls.Add(this.btnDeleteProduct);
            this.gbEditProduct.Controls.Add(this.btnSaveChanges);
            this.gbEditProduct.Controls.Add(this.btnChangeSelectedImage);
            this.gbEditProduct.Controls.Add(this.picEditProductPreview);
            this.gbEditProduct.Controls.Add(this.lblEditProductImage);
            this.gbEditProduct.Controls.Add(this.nudEditProductPrice);
            this.gbEditProduct.Controls.Add(this.lblEditProductPrice);
            this.gbEditProduct.Controls.Add(this.txtEditProductName);
            this.gbEditProduct.Controls.Add(this.lblEditProductName);
            this.gbEditProduct.Location = new System.Drawing.Point(18, 430);
            this.gbEditProduct.Name = "gbEditProduct";
            this.gbEditProduct.Size = new System.Drawing.Size(720, 270);
            this.gbEditProduct.TabIndex = 6;
            this.gbEditProduct.TabStop = false;
            this.gbEditProduct.Text = "선택된 제품 수정/삭제";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.AllowAnimations = true;
            this.btnDeleteProduct.AllowMouseEffects = true;
            this.btnDeleteProduct.AllowToggling = false;
            this.btnDeleteProduct.AnimationSpeed = 200;
            this.btnDeleteProduct.AutoGenerateColors = false;
            this.btnDeleteProduct.AutoRoundBorders = false;
            this.btnDeleteProduct.AutoSizeLeftIcon = true;
            this.btnDeleteProduct.AutoSizeRightIcon = true;
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Transparent;
            // this.btnDeleteProduct.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79))))); // Removed
            this.btnDeleteProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteProduct.BackgroundImage")));
            this.btnDeleteProduct.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteProduct.ButtonText = "제품 삭제";
            this.btnDeleteProduct.ButtonTextMarginLeft = 0;
            this.btnDeleteProduct.ColorContrastOnClick = 45;
            this.btnDeleteProduct.ColorContrastOnHover = 45;
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnDeleteProduct.CustomizableEdges = borderEdges4;
            this.btnDeleteProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            // this.btnDeleteProduct.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191))))); // Handled by OnDisabledState
            // this.btnDeleteProduct.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204))))); // Handled by OnDisabledState
            // this.btnDeleteProduct.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168))))); // Handled by OnDisabledState
            this.btnDeleteProduct.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProduct.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteProduct.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDeleteProduct.IconMarginLeft = 11;
            this.btnDeleteProduct.IconPadding = 10;
            this.btnDeleteProduct.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteProduct.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteProduct.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDeleteProduct.IconSize = 25;
            this.btnDeleteProduct.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnDeleteProduct.IdleBorderRadius = 1;
            this.btnDeleteProduct.IdleBorderThickness = 1;
            this.btnDeleteProduct.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnDeleteProduct.IndicateFocus = false;
            this.btnDeleteProduct.Location = new System.Drawing.Point(473, 220);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDeleteProduct.OnDisabledState.BorderRadius = 1;
            this.btnDeleteProduct.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteProduct.OnDisabledState.BorderThickness = 1;
            this.btnDeleteProduct.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDeleteProduct.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDeleteProduct.OnDisabledState.IconLeftImage = null;
            this.btnDeleteProduct.OnDisabledState.IconRightImage = null;
            this.btnDeleteProduct.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(59)))), ((int)(((byte)(54)))));
            this.btnDeleteProduct.onHoverState.BorderRadius = 1;
            this.btnDeleteProduct.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteProduct.onHoverState.BorderThickness = 1;
            this.btnDeleteProduct.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(59)))), ((int)(((byte)(54)))));
            this.btnDeleteProduct.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.onHoverState.IconLeftImage = null;
            this.btnDeleteProduct.onHoverState.IconRightImage = null;
            this.btnDeleteProduct.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnDeleteProduct.OnIdleState.BorderRadius = 1;
            this.btnDeleteProduct.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteProduct.OnIdleState.BorderThickness = 1;
            this.btnDeleteProduct.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnDeleteProduct.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.OnIdleState.IconLeftImage = null;
            this.btnDeleteProduct.OnIdleState.IconRightImage = null;
            this.btnDeleteProduct.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.btnDeleteProduct.OnPressedState.BorderRadius = 1;
            this.btnDeleteProduct.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteProduct.OnPressedState.BorderThickness = 1;
            this.btnDeleteProduct.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.btnDeleteProduct.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.OnPressedState.IconLeftImage = null;
            this.btnDeleteProduct.OnPressedState.IconRightImage = null;
            this.btnDeleteProduct.Size = new System.Drawing.Size(236, 39);
            this.btnDeleteProduct.TabIndex = 10;
            this.btnDeleteProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteProduct.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteProduct.TextMarginLeft = 0;
            this.btnDeleteProduct.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDeleteProduct.UseDefaultRadiusAndThickness = true;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.AllowAnimations = true;
            this.btnSaveChanges.AllowMouseEffects = true;
            this.btnSaveChanges.AllowToggling = false;
            this.btnSaveChanges.AnimationSpeed = 200;
            this.btnSaveChanges.AutoGenerateColors = false;
            this.btnSaveChanges.AutoRoundBorders = false;
            this.btnSaveChanges.AutoSizeLeftIcon = true;
            this.btnSaveChanges.AutoSizeRightIcon = true;
            this.btnSaveChanges.BackColor = System.Drawing.Color.Transparent;
            // this.btnSaveChanges.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92))))); // Removed
            this.btnSaveChanges.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveChanges.BackgroundImage")));
            this.btnSaveChanges.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveChanges.ButtonText = "변경 내용 저장";
            this.btnSaveChanges.ButtonTextMarginLeft = 0;
            this.btnSaveChanges.ColorContrastOnClick = 45;
            this.btnSaveChanges.ColorContrastOnHover = 45;
            this.btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnSaveChanges.CustomizableEdges = borderEdges5;
            this.btnSaveChanges.DialogResult = System.Windows.Forms.DialogResult.None;
            // this.btnSaveChanges.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191))))); // Handled by OnDisabledState
            // this.btnSaveChanges.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204))))); // Handled by OnDisabledState
            // this.btnSaveChanges.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168))))); // Handled by OnDisabledState
            this.btnSaveChanges.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChanges.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveChanges.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSaveChanges.IconMarginLeft = 11;
            this.btnSaveChanges.IconPadding = 10;
            this.btnSaveChanges.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveChanges.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveChanges.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSaveChanges.IconSize = 25;
            this.btnSaveChanges.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSaveChanges.IdleBorderRadius = 1;
            this.btnSaveChanges.IdleBorderThickness = 1;
            this.btnSaveChanges.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSaveChanges.IndicateFocus = false;
            this.btnSaveChanges.Location = new System.Drawing.Point(15, 220);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSaveChanges.OnDisabledState.BorderRadius = 1;
            this.btnSaveChanges.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveChanges.OnDisabledState.BorderThickness = 1;
            this.btnSaveChanges.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSaveChanges.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSaveChanges.OnDisabledState.IconLeftImage = null;
            this.btnSaveChanges.OnDisabledState.IconRightImage = null;
            this.btnSaveChanges.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(157)))), ((int)(((byte)(68)))));
            this.btnSaveChanges.onHoverState.BorderRadius = 1;
            this.btnSaveChanges.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveChanges.onHoverState.BorderThickness = 1;
            this.btnSaveChanges.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(157)))), ((int)(((byte)(68)))));
            this.btnSaveChanges.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.onHoverState.IconLeftImage = null;
            this.btnSaveChanges.onHoverState.IconRightImage = null;
            this.btnSaveChanges.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSaveChanges.OnIdleState.BorderRadius = 1;
            this.btnSaveChanges.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveChanges.OnIdleState.BorderThickness = 1;
            this.btnSaveChanges.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSaveChanges.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.OnIdleState.IconLeftImage = null;
            this.btnSaveChanges.OnIdleState.IconRightImage = null;
            this.btnSaveChanges.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
            this.btnSaveChanges.OnPressedState.BorderRadius = 1;
            this.btnSaveChanges.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveChanges.OnPressedState.BorderThickness = 1;
            this.btnSaveChanges.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
            this.btnSaveChanges.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.OnPressedState.IconLeftImage = null;
            this.btnSaveChanges.OnPressedState.IconRightImage = null;
            this.btnSaveChanges.Size = new System.Drawing.Size(236, 39);
            this.btnSaveChanges.TabIndex = 9;
            this.btnSaveChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveChanges.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveChanges.TextMarginLeft = 0;
            this.btnSaveChanges.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSaveChanges.UseDefaultRadiusAndThickness = true;
            // 
            // btnChangeSelectedImage
            // 
            this.btnChangeSelectedImage.AllowAnimations = true;
            this.btnChangeSelectedImage.AllowMouseEffects = true;
            this.btnChangeSelectedImage.AllowToggling = false;
            this.btnChangeSelectedImage.AnimationSpeed = 200;
            this.btnChangeSelectedImage.AutoGenerateColors = false;
            this.btnChangeSelectedImage.AutoRoundBorders = false;
            this.btnChangeSelectedImage.AutoSizeLeftIcon = true;
            this.btnChangeSelectedImage.AutoSizeRightIcon = true;
            this.btnChangeSelectedImage.BackColor = System.Drawing.Color.Transparent;
            // this.btnChangeSelectedImage.BackColor1 = System.Drawing.Color.DimGray; // Removed
            this.btnChangeSelectedImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangeSelectedImage.BackgroundImage")));
            this.btnChangeSelectedImage.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChangeSelectedImage.ButtonText = "이미지 변경";
            this.btnChangeSelectedImage.ButtonTextMarginLeft = 0;
            this.btnChangeSelectedImage.ColorContrastOnClick = 45;
            this.btnChangeSelectedImage.ColorContrastOnHover = 45;
            this.btnChangeSelectedImage.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnChangeSelectedImage.CustomizableEdges = borderEdges6;
            this.btnChangeSelectedImage.DialogResult = System.Windows.Forms.DialogResult.None;
            // this.btnChangeSelectedImage.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191))))); // Handled by OnDisabledState
            // this.btnChangeSelectedImage.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204))))); // Handled by OnDisabledState
            // this.btnChangeSelectedImage.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168))))); // Handled by OnDisabledState
            this.btnChangeSelectedImage.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnChangeSelectedImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChangeSelectedImage.ForeColor = System.Drawing.Color.White;
            this.btnChangeSelectedImage.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeSelectedImage.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnChangeSelectedImage.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnChangeSelectedImage.IconMarginLeft = 11;
            this.btnChangeSelectedImage.IconPadding = 10;
            this.btnChangeSelectedImage.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeSelectedImage.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnChangeSelectedImage.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnChangeSelectedImage.IconSize = 25;
            this.btnChangeSelectedImage.IdleBorderColor = System.Drawing.Color.DimGray;
            this.btnChangeSelectedImage.IdleBorderRadius = 1;
            this.btnChangeSelectedImage.IdleBorderThickness = 1;
            this.btnChangeSelectedImage.IdleFillColor = System.Drawing.Color.DimGray;
            this.btnChangeSelectedImage.IndicateFocus = false;
            this.btnChangeSelectedImage.Location = new System.Drawing.Point(126, 170);
            this.btnChangeSelectedImage.Name = "btnChangeSelectedImage";
            this.btnChangeSelectedImage.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnChangeSelectedImage.OnDisabledState.BorderRadius = 1;
            this.btnChangeSelectedImage.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChangeSelectedImage.OnDisabledState.BorderThickness = 1;
            this.btnChangeSelectedImage.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnChangeSelectedImage.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnChangeSelectedImage.OnDisabledState.IconLeftImage = null;
            this.btnChangeSelectedImage.OnDisabledState.IconRightImage = null;
            this.btnChangeSelectedImage.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnChangeSelectedImage.onHoverState.BorderRadius = 1;
            this.btnChangeSelectedImage.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChangeSelectedImage.onHoverState.BorderThickness = 1;
            this.btnChangeSelectedImage.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.btnChangeSelectedImage.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnChangeSelectedImage.onHoverState.IconLeftImage = null;
            this.btnChangeSelectedImage.onHoverState.IconRightImage = null;
            this.btnChangeSelectedImage.OnIdleState.BorderColor = System.Drawing.Color.DimGray;
            this.btnChangeSelectedImage.OnIdleState.BorderRadius = 1;
            this.btnChangeSelectedImage.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChangeSelectedImage.OnIdleState.BorderThickness = 1;
            this.btnChangeSelectedImage.OnIdleState.FillColor = System.Drawing.Color.DimGray;
            this.btnChangeSelectedImage.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnChangeSelectedImage.OnIdleState.IconLeftImage = null;
            this.btnChangeSelectedImage.OnIdleState.IconRightImage = null;
            this.btnChangeSelectedImage.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btnChangeSelectedImage.OnPressedState.BorderRadius = 1;
            this.btnChangeSelectedImage.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChangeSelectedImage.OnPressedState.BorderThickness = 1;
            this.btnChangeSelectedImage.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.btnChangeSelectedImage.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnChangeSelectedImage.OnPressedState.IconLeftImage = null;
            this.btnChangeSelectedImage.OnPressedState.IconRightImage = null;
            this.btnChangeSelectedImage.Size = new System.Drawing.Size(125, 30);
            this.btnChangeSelectedImage.TabIndex = 8;
            this.btnChangeSelectedImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChangeSelectedImage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnChangeSelectedImage.TextMarginLeft = 0;
            this.btnChangeSelectedImage.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnChangeSelectedImage.UseDefaultRadiusAndThickness = true;
            // 
            // picEditProductPreview
            // 
            this.picEditProductPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEditProductPreview.Location = new System.Drawing.Point(126, 90);
            this.picEditProductPreview.Name = "picEditProductPreview";
            this.picEditProductPreview.Size = new System.Drawing.Size(125, 75);
            this.picEditProductPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEditProductPreview.TabIndex = 7;
            this.picEditProductPreview.TabStop = false;
            // 
            // lblEditProductImage
            // 
            this.lblEditProductImage.AutoSize = true;
            this.lblEditProductImage.Location = new System.Drawing.Point(12, 90);
            this.lblEditProductImage.Name = "lblEditProductImage";
            this.lblEditProductImage.Size = new System.Drawing.Size(87, 17);
            this.lblEditProductImage.TabIndex = 6;
            this.lblEditProductImage.Text = "제품 이미지:";
            // 
            // nudEditProductPrice
            // 
            this.nudEditProductPrice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudEditProductPrice.Location = new System.Drawing.Point(473, 40);
            this.nudEditProductPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudEditProductPrice.Name = "nudEditProductPrice";
            this.nudEditProductPrice.Size = new System.Drawing.Size(125, 25);
            this.nudEditProductPrice.TabIndex = 3;
            // 
            // lblEditProductPrice
            // 
            this.lblEditProductPrice.AutoSize = true;
            this.lblEditProductPrice.Location = new System.Drawing.Point(380, 42);
            this.lblEditProductPrice.Name = "lblEditProductPrice";
            this.lblEditProductPrice.Size = new System.Drawing.Size(72, 17);
            this.lblEditProductPrice.TabIndex = 2;
            this.lblEditProductPrice.Text = "제품 가격:";
            // 
            // txtEditProductName
            // 
            this.txtEditProductName.AnimateReadOnly = false;
            this.txtEditProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditProductName.Depth = 0;
            this.txtEditProductName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEditProductName.LeadingIcon = null;
            this.txtEditProductName.Location = new System.Drawing.Point(80, 35);
            this.txtEditProductName.MaxLength = 50;
            this.txtEditProductName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEditProductName.Multiline = false;
            this.txtEditProductName.Name = "txtEditProductName";
            this.txtEditProductName.Size = new System.Drawing.Size(236, 36);
            this.txtEditProductName.TabIndex = 1;
            this.txtEditProductName.Text = "";
            this.txtEditProductName.TrailingIcon = null;
            this.txtEditProductName.UseTallSize = false;
            // 
            // lblEditProductName
            // 
            this.lblEditProductName.AutoSize = true;
            this.lblEditProductName.Location = new System.Drawing.Point(12, 42);
            this.lblEditProductName.Name = "lblEditProductName";
            this.lblEditProductName.Size = new System.Drawing.Size(57, 17);
            this.lblEditProductName.TabIndex = 0;
            this.lblEditProductName.Text = "제품명:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "선택 제품 재고:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 712);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbEditProduct);
            this.Controls.Add(this.gbAddNewProduct);
            this.Controls.Add(this.lblCategorySelection);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.nudAddStockQuantity);
            this.Controls.Add(this.dgvMenuItems);
            this.Controls.Add(this.cmbCategory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 3);
            this.Text = "관리자 모드";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddStockQuantity)).EndInit();
            this.gbAddNewProduct.ResumeLayout(false);
            this.gbAddNewProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNewProductPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewProductQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewProductPrice)).EndInit();
            this.gbEditProduct.ResumeLayout(false);
            this.gbEditProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEditProductPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditProductPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cmbCategory;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvMenuItems;
        private System.Windows.Forms.NumericUpDown nudAddStockQuantity;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddStock;
        private System.Windows.Forms.Label lblCategorySelection;
        private System.Windows.Forms.GroupBox gbAddNewProduct;
        private System.Windows.Forms.Label lblNewProductName;
        private MaterialSkin.Controls.MaterialTextBox txtNewProductName;
        private System.Windows.Forms.Label lblNewProductPrice;
        private System.Windows.Forms.NumericUpDown nudNewProductPrice;
        private System.Windows.Forms.Label lblNewProductQuantity;
        private System.Windows.Forms.NumericUpDown nudNewProductQuantity;
        private System.Windows.Forms.Label lblNewProductImage;
        private System.Windows.Forms.PictureBox picNewProductPreview;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSelectNewImage;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddNewProduct;
        private System.Windows.Forms.GroupBox gbEditProduct;
        private System.Windows.Forms.Label lblEditProductName;
        private MaterialSkin.Controls.MaterialTextBox txtEditProductName;
        private System.Windows.Forms.Label lblEditProductPrice;
        private System.Windows.Forms.NumericUpDown nudEditProductPrice;
        private System.Windows.Forms.Label lblEditProductImage;
        private System.Windows.Forms.PictureBox picEditProductPreview;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnChangeSelectedImage;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSaveChanges;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDeleteProduct;
        private System.Windows.Forms.Label label2;
    }
}
        #endregion

        private MaterialSkin.Controls.MaterialComboBox cmbCategory;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvMenuItems;
        private System.Windows.Forms.NumericUpDown nudAddQuantity;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddStock;
        private System.Windows.Forms.Label label1;
    }
}

namespace WF_C_
{
    partial class Sales
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlCartHeader = new System.Windows.Forms.Panel();
            this.lblItemsCount = new System.Windows.Forms.Label();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnSell = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.lblSearchHint = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pnlInfoContent = new System.Windows.Forms.Panel();
            this.lblInfoTitle = new System.Windows.Forms.Label();
            this.lblInfoVital = new System.Windows.Forms.Label();
            this.lblInfoNarcotic = new System.Windows.Forms.Label();
            this.lblInfoRecipe = new System.Windows.Forms.Label();
            this.lblInfoStorage = new System.Windows.Forms.Label();
            this.lblInfoGroup = new System.Windows.Forms.Label();
            this.lblInfoManufacturer = new System.Windows.Forms.Label();
            this.lblInfoBatch = new System.Windows.Forms.Label();
            this.lblInfoStatus = new System.Windows.Forms.Label();
            this.lblInfoExpiration = new System.Windows.Forms.Label();
            this.lblInfoPrice = new System.Windows.Forms.Label();
            this.lblInfoBarcode = new System.Windows.Forms.Label();
            this.lblInfoName = new System.Windows.Forms.Label();
            this.lblInfoUid = new System.Windows.Forms.Label();
            this.lblInfoSeparator = new System.Windows.Forms.Label();
            this.Uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retail_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expiration_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Need_recipe = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Is_narcotic = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlCartHeader.SuspendLayout();
            this.pnlCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlInfoContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.splitContainer);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(5);
            this.pnlMain.Size = new System.Drawing.Size(1100, 700);
            this.pnlMain.TabIndex = 1;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(5, 5);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.pnlLeft);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pnlRight);
            this.splitContainer.Size = new System.Drawing.Size(1090, 690);
            this.splitContainer.SplitterDistance = 690;
            this.splitContainer.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pnlCartHeader);
            this.pnlLeft.Controls.Add(this.pnlCart);
            this.pnlLeft.Controls.Add(this.pnlBottom);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(690, 690);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlCartHeader
            // 
            this.pnlCartHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlCartHeader.Controls.Add(this.lblItemsCount);
            this.pnlCartHeader.Controls.Add(this.btnClearCart);
            this.pnlCartHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCartHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlCartHeader.Name = "pnlCartHeader";
            this.pnlCartHeader.Size = new System.Drawing.Size(690, 40);
            this.pnlCartHeader.TabIndex = 0;
            // 
            // lblItemsCount
            // 
            this.lblItemsCount.AutoSize = true;
            this.lblItemsCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblItemsCount.Location = new System.Drawing.Point(10, 10);
            this.lblItemsCount.Name = "lblItemsCount";
            this.lblItemsCount.Size = new System.Drawing.Size(83, 19);
            this.lblItemsCount.TabIndex = 1;
            this.lblItemsCount.Text = "Товаров: 0";
            // 
            // btnClearCart
            // 
            this.btnClearCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClearCart.FlatAppearance.BorderSize = 0;
            this.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearCart.ForeColor = System.Drawing.Color.White;
            this.btnClearCart.Location = new System.Drawing.Point(600, 5);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(80, 30);
            this.btnClearCart.TabIndex = 0;
            this.btnClearCart.Text = "Очистить";
            this.btnClearCart.UseVisualStyleBackColor = false;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // pnlCart
            // 
            this.pnlCart.Controls.Add(this.dgvCart);
            this.pnlCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCart.Location = new System.Drawing.Point(0, 0);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Padding = new System.Windows.Forms.Padding(5);
            this.pnlCart.Size = new System.Drawing.Size(690, 620);
            this.pnlCart.TabIndex = 1;
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AllowUserToResizeRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Uid,
            this.Name_Item,
            this.Barcode,
            this.Retail_Price,
            this.Expiration_Date,
            this.Need_recipe,
            this.Is_narcotic});
            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCart.Location = new System.Drawing.Point(5, 46);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(680, 569);
            this.dgvCart.TabIndex = 0;
            this.dgvCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellClick);
            this.dgvCart.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellDoubleClick);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlBottom.Controls.Add(this.btnSell);
            this.pnlBottom.Controls.Add(this.lblTotal);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 620);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(690, 70);
            this.pnlBottom.TabIndex = 2;
            // 
            // btnSell
            // 
            this.btnSell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSell.FlatAppearance.BorderSize = 0;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.Location = new System.Drawing.Point(530, 10);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(150, 50);
            this.btnSell.TabIndex = 1;
            this.btnSell.Text = "💳 Продать";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.lblTotal.Location = new System.Drawing.Point(10, 20);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(119, 30);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Итого: 0 ₽";
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlSearch);
            this.pnlRight.Controls.Add(this.pnlInfo);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(0, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(396, 690);
            this.pnlRight.TabIndex = 0;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlSearch.Controls.Add(this.btnAddToCart);
            this.pnlSearch.Controls.Add(this.txtUid);
            this.pnlSearch.Controls.Add(this.lblSearchHint);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(396, 80);
            this.pnlSearch.TabIndex = 0;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(286, 38);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(100, 30);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "В корзину";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // txtUid
            // 
            this.txtUid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUid.Location = new System.Drawing.Point(10, 38);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(270, 29);
            this.txtUid.TabIndex = 1;
            this.txtUid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUid_KeyPress);
            // 
            // lblSearchHint
            // 
            this.lblSearchHint.AutoSize = true;
            this.lblSearchHint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearchHint.ForeColor = System.Drawing.Color.Gray;
            this.lblSearchHint.Location = new System.Drawing.Point(10, 15);
            this.lblSearchHint.Name = "lblSearchHint";
            this.lblSearchHint.Size = new System.Drawing.Size(204, 15);
            this.lblSearchHint.TabIndex = 0;
            this.lblSearchHint.Text = "Введите UID товара и нажмите Enter";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInfo.Controls.Add(this.pnlInfoContent);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInfo.Location = new System.Drawing.Point(0, 80);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Padding = new System.Windows.Forms.Padding(10);
            this.pnlInfo.Size = new System.Drawing.Size(396, 610);
            this.pnlInfo.TabIndex = 1;
            // 
            // pnlInfoContent
            // 
            this.pnlInfoContent.AutoScroll = true;
            this.pnlInfoContent.Controls.Add(this.lblInfoTitle);
            this.pnlInfoContent.Controls.Add(this.lblInfoVital);
            this.pnlInfoContent.Controls.Add(this.lblInfoNarcotic);
            this.pnlInfoContent.Controls.Add(this.lblInfoRecipe);
            this.pnlInfoContent.Controls.Add(this.lblInfoStorage);
            this.pnlInfoContent.Controls.Add(this.lblInfoGroup);
            this.pnlInfoContent.Controls.Add(this.lblInfoManufacturer);
            this.pnlInfoContent.Controls.Add(this.lblInfoBatch);
            this.pnlInfoContent.Controls.Add(this.lblInfoStatus);
            this.pnlInfoContent.Controls.Add(this.lblInfoExpiration);
            this.pnlInfoContent.Controls.Add(this.lblInfoPrice);
            this.pnlInfoContent.Controls.Add(this.lblInfoBarcode);
            this.pnlInfoContent.Controls.Add(this.lblInfoName);
            this.pnlInfoContent.Controls.Add(this.lblInfoUid);
            this.pnlInfoContent.Controls.Add(this.lblInfoSeparator);
            this.pnlInfoContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInfoContent.Location = new System.Drawing.Point(10, 6);
            this.pnlInfoContent.Name = "pnlInfoContent";
            this.pnlInfoContent.Size = new System.Drawing.Size(376, 594);
            this.pnlInfoContent.TabIndex = 1;
            // 
            // lblInfoTitle
            // 
            this.lblInfoTitle.AutoSize = true;
            this.lblInfoTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInfoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.lblInfoTitle.Location = new System.Drawing.Point(3, 4);
            this.lblInfoTitle.Name = "lblInfoTitle";
            this.lblInfoTitle.Size = new System.Drawing.Size(192, 19);
            this.lblInfoTitle.TabIndex = 0;
            this.lblInfoTitle.Text = "📋 Информация о товаре";
            // 
            // lblInfoVital
            // 
            this.lblInfoVital.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoVital.Location = new System.Drawing.Point(3, 410);
            this.lblInfoVital.Name = "lblInfoVital";
            this.lblInfoVital.Size = new System.Drawing.Size(350, 20);
            this.lblInfoVital.TabIndex = 13;
            this.lblInfoVital.Text = "Жизненно важный: -";
            // 
            // lblInfoNarcotic
            // 
            this.lblInfoNarcotic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoNarcotic.Location = new System.Drawing.Point(3, 390);
            this.lblInfoNarcotic.Name = "lblInfoNarcotic";
            this.lblInfoNarcotic.Size = new System.Drawing.Size(350, 20);
            this.lblInfoNarcotic.TabIndex = 12;
            this.lblInfoNarcotic.Text = "Наркотическое: -";
            // 
            // lblInfoRecipe
            // 
            this.lblInfoRecipe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoRecipe.Location = new System.Drawing.Point(3, 370);
            this.lblInfoRecipe.Name = "lblInfoRecipe";
            this.lblInfoRecipe.Size = new System.Drawing.Size(350, 20);
            this.lblInfoRecipe.TabIndex = 11;
            this.lblInfoRecipe.Text = "Требует рецепт: -";
            // 
            // lblInfoStorage
            // 
            this.lblInfoStorage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoStorage.Location = new System.Drawing.Point(3, 350);
            this.lblInfoStorage.Name = "lblInfoStorage";
            this.lblInfoStorage.Size = new System.Drawing.Size(350, 20);
            this.lblInfoStorage.TabIndex = 10;
            this.lblInfoStorage.Text = "Место хранения: -";
            // 
            // lblInfoGroup
            // 
            this.lblInfoGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoGroup.Location = new System.Drawing.Point(3, 330);
            this.lblInfoGroup.Name = "lblInfoGroup";
            this.lblInfoGroup.Size = new System.Drawing.Size(350, 20);
            this.lblInfoGroup.TabIndex = 9;
            this.lblInfoGroup.Text = "Фарм. группа: -";
            // 
            // lblInfoManufacturer
            // 
            this.lblInfoManufacturer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoManufacturer.Location = new System.Drawing.Point(3, 310);
            this.lblInfoManufacturer.Name = "lblInfoManufacturer";
            this.lblInfoManufacturer.Size = new System.Drawing.Size(350, 20);
            this.lblInfoManufacturer.TabIndex = 8;
            this.lblInfoManufacturer.Text = "Производитель: -";
            // 
            // lblInfoBatch
            // 
            this.lblInfoBatch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoBatch.Location = new System.Drawing.Point(3, 290);
            this.lblInfoBatch.Name = "lblInfoBatch";
            this.lblInfoBatch.Size = new System.Drawing.Size(350, 20);
            this.lblInfoBatch.TabIndex = 7;
            this.lblInfoBatch.Text = "Партия: -";
            // 
            // lblInfoStatus
            // 
            this.lblInfoStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoStatus.Location = new System.Drawing.Point(4, 212);
            this.lblInfoStatus.Name = "lblInfoStatus";
            this.lblInfoStatus.Size = new System.Drawing.Size(370, 20);
            this.lblInfoStatus.TabIndex = 6;
            this.lblInfoStatus.Text = "Статус: -";
            // 
            // lblInfoExpiration
            // 
            this.lblInfoExpiration.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoExpiration.Location = new System.Drawing.Point(4, 192);
            this.lblInfoExpiration.Name = "lblInfoExpiration";
            this.lblInfoExpiration.Size = new System.Drawing.Size(350, 20);
            this.lblInfoExpiration.TabIndex = 5;
            this.lblInfoExpiration.Text = "Годен до: -";
            // 
            // lblInfoPrice
            // 
            this.lblInfoPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoPrice.Location = new System.Drawing.Point(4, 172);
            this.lblInfoPrice.Name = "lblInfoPrice";
            this.lblInfoPrice.Size = new System.Drawing.Size(350, 20);
            this.lblInfoPrice.TabIndex = 4;
            this.lblInfoPrice.Text = "Цена: -";
            // 
            // lblInfoBarcode
            // 
            this.lblInfoBarcode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoBarcode.Location = new System.Drawing.Point(4, 152);
            this.lblInfoBarcode.Name = "lblInfoBarcode";
            this.lblInfoBarcode.Size = new System.Drawing.Size(350, 20);
            this.lblInfoBarcode.TabIndex = 3;
            this.lblInfoBarcode.Text = "Штрихкод: -";
            // 
            // lblInfoName
            // 
            this.lblInfoName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInfoName.Location = new System.Drawing.Point(4, 88);
            this.lblInfoName.Name = "lblInfoName";
            this.lblInfoName.Size = new System.Drawing.Size(350, 40);
            this.lblInfoName.TabIndex = 2;
            this.lblInfoName.Text = "Название: -";
            // 
            // lblInfoUid
            // 
            this.lblInfoUid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoUid.Location = new System.Drawing.Point(4, 68);
            this.lblInfoUid.Name = "lblInfoUid";
            this.lblInfoUid.Size = new System.Drawing.Size(350, 20);
            this.lblInfoUid.TabIndex = 1;
            this.lblInfoUid.Text = "UID: -";
            // 
            // lblInfoSeparator
            // 
            this.lblInfoSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInfoSeparator.Location = new System.Drawing.Point(37, 257);
            this.lblInfoSeparator.Name = "lblInfoSeparator";
            this.lblInfoSeparator.Size = new System.Drawing.Size(300, 2);
            this.lblInfoSeparator.TabIndex = 0;
            this.lblInfoSeparator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Uid
            // 
            this.Uid.DataPropertyName = "Uid";
            this.Uid.HeaderText = "UID";
            this.Uid.Name = "Uid";
            this.Uid.ReadOnly = true;
            // 
            // Name_item
            // 
            this.Name_Item.DataPropertyName = "Name_item";
            this.Name_Item.HeaderText = "Название";
            this.Name_Item.Name = "Name_item";
            this.Name_Item.ReadOnly = true;
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.HeaderText = "Штрихкод";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // Retail_Price
            // 
            this.Retail_Price.DataPropertyName = "Retail_Price";
            dataGridViewCellStyle5.Format = "F2";
            this.Retail_Price.DefaultCellStyle = dataGridViewCellStyle5;
            this.Retail_Price.HeaderText = "Цена";
            this.Retail_Price.Name = "Retail_Price";
            this.Retail_Price.ReadOnly = true;
            // 
            // Expiration_Date
            // 
            this.Expiration_Date.DataPropertyName = "Expiration_Date";
            this.Expiration_Date.HeaderText = "Годен до";
            this.Expiration_Date.Name = "Expiration_Date";
            this.Expiration_Date.ReadOnly = true;
            // 
            // Need_recipe
            // 
            this.Need_recipe.DataPropertyName = "Need_recipe";
            this.Need_recipe.HeaderText = "Нужен рецепт";
            this.Need_recipe.Name = "Need_recipe";
            this.Need_recipe.ReadOnly = true;
            this.Need_recipe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Need_recipe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Is_narcotic
            // 
            this.Is_narcotic.DataPropertyName = "Is_narcotic";
            this.Is_narcotic.HeaderText = "Наркотическое";
            this.Is_narcotic.Name = "Is_narcotic";
            this.Is_narcotic.ReadOnly = true;
            this.Is_narcotic.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Is_narcotic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Sales";
            this.Size = new System.Drawing.Size(1100, 700);
            this.pnlMain.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlCartHeader.ResumeLayout(false);
            this.pnlCartHeader.PerformLayout();
            this.pnlCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfoContent.ResumeLayout(false);
            this.pnlInfoContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.Label lblSearchHint;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblInfoTitle;
        private System.Windows.Forms.Panel pnlInfoContent;
        private System.Windows.Forms.Label lblInfoSeparator;
        private System.Windows.Forms.Label lblInfoUid;
        private System.Windows.Forms.Label lblInfoName;
        private System.Windows.Forms.Label lblInfoBarcode;
        private System.Windows.Forms.Label lblInfoPrice;
        private System.Windows.Forms.Label lblInfoExpiration;
        private System.Windows.Forms.Label lblInfoStatus;
        private System.Windows.Forms.Label lblInfoBatch;
        private System.Windows.Forms.Label lblInfoVital;
        private System.Windows.Forms.Label lblInfoNarcotic;
        private System.Windows.Forms.Label lblInfoRecipe;
        private System.Windows.Forms.Label lblInfoStorage;
        private System.Windows.Forms.Label lblInfoGroup;
        private System.Windows.Forms.Label lblInfoManufacturer;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlCartHeader;
        private System.Windows.Forms.Label lblItemsCount;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Retail_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expiration_Date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Need_recipe;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Is_narcotic;
    }
}
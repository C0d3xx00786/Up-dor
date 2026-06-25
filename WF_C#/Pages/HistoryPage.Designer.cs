namespace WF_C_.Pages
{
    partial class HistoryPage
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

        #region Код, автоматически созданный конструктором компонентов

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.Sale_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sold_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBottomStats = new System.Windows.Forms.Panel();
            this.lblCleanRevenueMonth = new System.Windows.Forms.Label();
            this.lblTotalRevenueMonth = new System.Windows.Forms.Label();
            this.lblCleanRevenue = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfoTitle = new System.Windows.Forms.Label();
            this.pnlInfoContent = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVital = new System.Windows.Forms.Label();
            this.lblNarcotic = new System.Windows.Forms.Label();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.lbldateSell = new System.Windows.Forms.Label();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblSoldPriceInfo = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblSupplierBatch = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblUid = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.pnlBottomStats.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlInfoContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.splitContainer);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMain.Size = new System.Drawing.Size(1154, 692);
            this.pnlMain.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(10, 10);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.dgvHistory);
            this.splitContainer.Panel1.Controls.Add(this.pnlBottomStats);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pnlInfo);
            this.splitContainer.Size = new System.Drawing.Size(1134, 672);
            this.splitContainer.SplitterDistance = 775;
            this.splitContainer.TabIndex = 0;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AllowUserToResizeRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sale_Date,
            this.Uid,
            this.Name_Item,
            this.Barcode,
            this.Sold_Price});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvHistory.MultiSelect = false;
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(775, 572);
            this.dgvHistory.TabIndex = 0;
            this.dgvHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistory_CellClick);
            // 
            // Sale_Date
            // 
            this.Sale_Date.DataPropertyName = "Sale_Date";
            dataGridViewCellStyle2.Format = "g";
            this.Sale_Date.DefaultCellStyle = dataGridViewCellStyle2;
            this.Sale_Date.HeaderText = "Дата продажи";
            this.Sale_Date.Name = "Sale_Date";
            this.Sale_Date.ReadOnly = true;
            // 
            // Uid
            // 
            this.Uid.DataPropertyName = "Uid";
            this.Uid.HeaderText = "UID товара";
            this.Uid.Name = "Uid";
            this.Uid.ReadOnly = true;
            // 
            // Name_Item
            // 
            this.Name_Item.DataPropertyName = "Name_Item";
            this.Name_Item.HeaderText = "Название";
            this.Name_Item.Name = "Name_Item";
            this.Name_Item.ReadOnly = true;
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.HeaderText = "Штрихкод";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // Sold_Price
            // 
            this.Sold_Price.DataPropertyName = "Sold_Price";
            this.Sold_Price.HeaderText = "Цена продажи";
            this.Sold_Price.Name = "Sold_Price";
            this.Sold_Price.ReadOnly = true;
            // 
            // pnlBottomStats
            // 
            this.pnlBottomStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlBottomStats.Controls.Add(this.lblCleanRevenueMonth);
            this.pnlBottomStats.Controls.Add(this.lblTotalRevenueMonth);
            this.pnlBottomStats.Controls.Add(this.lblCleanRevenue);
            this.pnlBottomStats.Controls.Add(this.lblTotalRevenue);
            this.pnlBottomStats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomStats.Location = new System.Drawing.Point(0, 572);
            this.pnlBottomStats.Name = "pnlBottomStats";
            this.pnlBottomStats.Size = new System.Drawing.Size(775, 100);
            this.pnlBottomStats.TabIndex = 1;
            // 
            // lblCleanRevenueMonth
            // 
            this.lblCleanRevenueMonth.AutoSize = true;
            this.lblCleanRevenueMonth.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCleanRevenueMonth.Location = new System.Drawing.Point(325, 55);
            this.lblCleanRevenueMonth.Name = "lblCleanRevenueMonth";
            this.lblCleanRevenueMonth.Size = new System.Drawing.Size(277, 25);
            this.lblCleanRevenueMonth.TabIndex = 3;
            this.lblCleanRevenueMonth.Text = "Чистая прибыль за месяц: ";
            // 
            // lblTotalRevenueMonth
            // 
            this.lblTotalRevenueMonth.AutoSize = true;
            this.lblTotalRevenueMonth.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalRevenueMonth.Location = new System.Drawing.Point(325, 15);
            this.lblTotalRevenueMonth.Name = "lblTotalRevenueMonth";
            this.lblTotalRevenueMonth.Size = new System.Drawing.Size(274, 25);
            this.lblTotalRevenueMonth.TabIndex = 2;
            this.lblTotalRevenueMonth.Text = "Общая выручка за месяц: ";
            // 
            // lblCleanRevenue
            // 
            this.lblCleanRevenue.AutoSize = true;
            this.lblCleanRevenue.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCleanRevenue.Location = new System.Drawing.Point(15, 55);
            this.lblCleanRevenue.Name = "lblCleanRevenue";
            this.lblCleanRevenue.Size = new System.Drawing.Size(185, 25);
            this.lblCleanRevenue.TabIndex = 1;
            this.lblCleanRevenue.Text = "Чистая прибыль: ";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(15, 15);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(182, 25);
            this.lblTotalRevenue.TabIndex = 0;
            this.lblTotalRevenue.Text = "Общая выручка: ";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInfo.Controls.Add(this.lblInfoTitle);
            this.pnlInfo.Controls.Add(this.pnlInfoContent);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Padding = new System.Windows.Forms.Padding(15);
            this.pnlInfo.Size = new System.Drawing.Size(355, 672);
            this.pnlInfo.TabIndex = 0;
            // 
            // lblInfoTitle
            // 
            this.lblInfoTitle.AutoSize = true;
            this.lblInfoTitle.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.lblInfoTitle.Location = new System.Drawing.Point(5, 10);
            this.lblInfoTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblInfoTitle.Name = "lblInfoTitle";
            this.lblInfoTitle.Size = new System.Drawing.Size(259, 25);
            this.lblInfoTitle.TabIndex = 0;
            this.lblInfoTitle.Text = "📋 Информация о товаре";
            // 
            // pnlInfoContent
            // 
            this.pnlInfoContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInfoContent.Controls.Add(this.label5);
            this.pnlInfoContent.Controls.Add(this.lblVital);
            this.pnlInfoContent.Controls.Add(this.lblNarcotic);
            this.pnlInfoContent.Controls.Add(this.lblRecipe);
            this.pnlInfoContent.Controls.Add(this.lbldateSell);
            this.pnlInfoContent.Controls.Add(this.lblSeparator);
            this.pnlInfoContent.Controls.Add(this.label1);
            this.pnlInfoContent.Controls.Add(this.lblProfit);
            this.pnlInfoContent.Controls.Add(this.lblSoldPriceInfo);
            this.pnlInfoContent.Controls.Add(this.lblPurchasePrice);
            this.pnlInfoContent.Controls.Add(this.lblSupplierBatch);
            this.pnlInfoContent.Controls.Add(this.lblName);
            this.pnlInfoContent.Controls.Add(this.lblBarcode);
            this.pnlInfoContent.Controls.Add(this.lblUid);
            this.pnlInfoContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfoContent.Location = new System.Drawing.Point(15, 15);
            this.pnlInfoContent.Name = "pnlInfoContent";
            this.pnlInfoContent.Size = new System.Drawing.Size(325, 642);
            this.pnlInfoContent.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(22, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 2);
            this.label5.TabIndex = 21;
            // 
            // lblVital
            // 
            this.lblVital.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVital.ForeColor = System.Drawing.Color.Black;
            this.lblVital.Location = new System.Drawing.Point(6, 326);
            this.lblVital.Name = "lblVital";
            this.lblVital.Size = new System.Drawing.Size(280, 25);
            this.lblVital.TabIndex = 20;
            this.lblVital.Text = "Жизненно важный: -";
            // 
            // lblNarcotic
            // 
            this.lblNarcotic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNarcotic.ForeColor = System.Drawing.Color.Black;
            this.lblNarcotic.Location = new System.Drawing.Point(6, 301);
            this.lblNarcotic.Name = "lblNarcotic";
            this.lblNarcotic.Size = new System.Drawing.Size(280, 25);
            this.lblNarcotic.TabIndex = 19;
            this.lblNarcotic.Text = "Наркотический: -";
            // 
            // lblRecipe
            // 
            this.lblRecipe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRecipe.ForeColor = System.Drawing.Color.Black;
            this.lblRecipe.Location = new System.Drawing.Point(6, 276);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(280, 25);
            this.lblRecipe.TabIndex = 17;
            this.lblRecipe.Text = "Требует рецепт: -";
            // 
            // lbldateSell
            // 
            this.lbldateSell.AutoSize = true;
            this.lbldateSell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbldateSell.ForeColor = System.Drawing.Color.Black;
            this.lbldateSell.Location = new System.Drawing.Point(6, 251);
            this.lbldateSell.Name = "lbldateSell";
            this.lbldateSell.Size = new System.Drawing.Size(126, 21);
            this.lbldateSell.TabIndex = 10;
            this.lbldateSell.Text = "Дата продажи: -";
            // 
            // lblSeparator
            // 
            this.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator.Location = new System.Drawing.Point(22, 175);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(280, 2);
            this.lblSeparator.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Производитель: -";
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProfit.ForeColor = System.Drawing.Color.Black;
            this.lblProfit.Location = new System.Drawing.Point(4, 440);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(193, 25);
            this.lblProfit.TabIndex = 7;
            this.lblProfit.Text = "Прибыль с пачки: -";
            // 
            // lblSoldPriceInfo
            // 
            this.lblSoldPriceInfo.AutoSize = true;
            this.lblSoldPriceInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSoldPriceInfo.ForeColor = System.Drawing.Color.Black;
            this.lblSoldPriceInfo.Location = new System.Drawing.Point(6, 415);
            this.lblSoldPriceInfo.Name = "lblSoldPriceInfo";
            this.lblSoldPriceInfo.Size = new System.Drawing.Size(129, 21);
            this.lblSoldPriceInfo.TabIndex = 6;
            this.lblSoldPriceInfo.Text = "Цена продажи: -";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPurchasePrice.ForeColor = System.Drawing.Color.Black;
            this.lblPurchasePrice.Location = new System.Drawing.Point(6, 390);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(121, 21);
            this.lblPurchasePrice.TabIndex = 5;
            this.lblPurchasePrice.Text = "Цена закупки: -";
            // 
            // lblSupplierBatch
            // 
            this.lblSupplierBatch.AutoSize = true;
            this.lblSupplierBatch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSupplierBatch.ForeColor = System.Drawing.Color.Black;
            this.lblSupplierBatch.Location = new System.Drawing.Point(4, 226);
            this.lblSupplierBatch.Name = "lblSupplierBatch";
            this.lblSupplierBatch.Size = new System.Drawing.Size(126, 21);
            this.lblSupplierBatch.TabIndex = 3;
            this.lblSupplierBatch.Text = "Номер партии: -";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(4, 122);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(119, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Название: -";
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBarcode.ForeColor = System.Drawing.Color.Black;
            this.lblBarcode.Location = new System.Drawing.Point(6, 97);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(96, 21);
            this.lblBarcode.TabIndex = 1;
            this.lblBarcode.Text = "Штрихкод: -";
            // 
            // lblUid
            // 
            this.lblUid.AutoSize = true;
            this.lblUid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUid.ForeColor = System.Drawing.Color.Black;
            this.lblUid.Location = new System.Drawing.Point(6, 72);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(49, 21);
            this.lblUid.TabIndex = 0;
            this.lblUid.Text = "UID: -";
            // 
            // HistoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "HistoryPage";
            this.Size = new System.Drawing.Size(1154, 692);
            this.pnlMain.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.pnlBottomStats.ResumeLayout(false);
            this.pnlBottomStats.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlInfoContent.ResumeLayout(false);
            this.pnlInfoContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlInfoContent;
        private System.Windows.Forms.Label lblUid;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSupplierBatch;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblSoldPriceInfo;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Panel pnlBottomStats;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblInfoTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCleanRevenueMonth;
        private System.Windows.Forms.Label lblTotalRevenueMonth;
        private System.Windows.Forms.Label lblCleanRevenue;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.Label lbldateSell;
        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVital;
        private System.Windows.Forms.Label lblNarcotic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sold_Price;
    }
}
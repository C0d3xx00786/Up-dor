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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.Uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sold_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBottomStats = new System.Windows.Forms.Panel();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfoTitle = new System.Windows.Forms.Label();
            this.pnlInfoContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblSoldPriceInfo = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblSupplierBatch = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
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
            this.pnlMain.Padding = new System.Windows.Forms.Padding(5);
            this.pnlMain.Size = new System.Drawing.Size(950, 550);
            this.pnlMain.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(5, 5);
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
            this.splitContainer.Size = new System.Drawing.Size(940, 540);
            this.splitContainer.SplitterDistance = 643;
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
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Uid,
            this.Name_Item,
            this.Barcode,
            this.Sold_Price,
            this.Sale_Date});
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvHistory.MultiSelect = false;
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(643, 476);
            this.dgvHistory.TabIndex = 0;
            this.dgvHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistory_CellClick);
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
            // Sale_Date
            // 
            this.Sale_Date.DataPropertyName = "Sale_Date";
            dataGridViewCellStyle1.Format = "g";
            this.Sale_Date.DefaultCellStyle = dataGridViewCellStyle1;
            this.Sale_Date.HeaderText = "Дата продажи";
            this.Sale_Date.Name = "Sale_Date";
            this.Sale_Date.ReadOnly = true;
            // 
            // pnlBottomStats
            // 
            this.pnlBottomStats.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBottomStats.Controls.Add(this.lblTotalProfit);
            this.pnlBottomStats.Controls.Add(this.lblTotalRevenue);
            this.pnlBottomStats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomStats.Location = new System.Drawing.Point(0, 476);
            this.pnlBottomStats.Name = "pnlBottomStats";
            this.pnlBottomStats.Size = new System.Drawing.Size(643, 64);
            this.pnlBottomStats.TabIndex = 1;
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalProfit.ForeColor = System.Drawing.Color.Green;
            this.lblTotalProfit.Location = new System.Drawing.Point(15, 38);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(172, 19);
            this.lblTotalProfit.TabIndex = 1;
            this.lblTotalProfit.Text = "Чистая прибыль: 0.00 ₽";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(15, 12);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(170, 19);
            this.lblTotalRevenue.TabIndex = 0;
            this.lblTotalRevenue.Text = "Общая выручка: 0.00 ₽";
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
            this.pnlInfo.Size = new System.Drawing.Size(293, 540);
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
            this.pnlInfoContent.Controls.Add(this.label1);
            this.pnlInfoContent.Controls.Add(this.lblProfit);
            this.pnlInfoContent.Controls.Add(this.lblSoldPriceInfo);
            this.pnlInfoContent.Controls.Add(this.lblPurchasePrice);
            this.pnlInfoContent.Controls.Add(this.lblExpirationDate);
            this.pnlInfoContent.Controls.Add(this.lblSupplierBatch);
            this.pnlInfoContent.Controls.Add(this.lblManufacturer);
            this.pnlInfoContent.Controls.Add(this.lblBarcode);
            this.pnlInfoContent.Controls.Add(this.lblUid);
            this.pnlInfoContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfoContent.Location = new System.Drawing.Point(15, 15);
            this.pnlInfoContent.Name = "pnlInfoContent";
            this.pnlInfoContent.Size = new System.Drawing.Size(263, 510);
            this.pnlInfoContent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Производитель: -";
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProfit.ForeColor = System.Drawing.Color.Black;
            this.lblProfit.Location = new System.Drawing.Point(4, 311);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(133, 17);
            this.lblProfit.TabIndex = 7;
            this.lblProfit.Text = "Прибыль с пачки: -";
            // 
            // lblSoldPriceInfo
            // 
            this.lblSoldPriceInfo.AutoSize = true;
            this.lblSoldPriceInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSoldPriceInfo.ForeColor = System.Drawing.Color.Black;
            this.lblSoldPriceInfo.Location = new System.Drawing.Point(4, 281);
            this.lblSoldPriceInfo.Name = "lblSoldPriceInfo";
            this.lblSoldPriceInfo.Size = new System.Drawing.Size(108, 17);
            this.lblSoldPriceInfo.TabIndex = 6;
            this.lblSoldPriceInfo.Text = "Цена продажи: -";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPurchasePrice.ForeColor = System.Drawing.Color.Black;
            this.lblPurchasePrice.Location = new System.Drawing.Point(4, 251);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(100, 17);
            this.lblPurchasePrice.TabIndex = 5;
            this.lblPurchasePrice.Text = "Цена закупки: -";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExpirationDate.ForeColor = System.Drawing.Color.Black;
            this.lblExpirationDate.Location = new System.Drawing.Point(4, 221);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(107, 17);
            this.lblExpirationDate.TabIndex = 4;
            this.lblExpirationDate.Text = "Срок годности: -";
            // 
            // lblSupplierBatch
            // 
            this.lblSupplierBatch.AutoSize = true;
            this.lblSupplierBatch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSupplierBatch.ForeColor = System.Drawing.Color.Black;
            this.lblSupplierBatch.Location = new System.Drawing.Point(4, 192);
            this.lblSupplierBatch.Name = "lblSupplierBatch";
            this.lblSupplierBatch.Size = new System.Drawing.Size(132, 17);
            this.lblSupplierBatch.TabIndex = 3;
            this.lblSupplierBatch.Text = "Серия поставщика: -";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblManufacturer.ForeColor = System.Drawing.Color.Black;
            this.lblManufacturer.Location = new System.Drawing.Point(4, 132);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(113, 17);
            this.lblManufacturer.TabIndex = 2;
            this.lblManufacturer.Text = "Производитель: -";
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBarcode.ForeColor = System.Drawing.Color.Black;
            this.lblBarcode.Location = new System.Drawing.Point(4, 102);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(80, 17);
            this.lblBarcode.TabIndex = 1;
            this.lblBarcode.Text = "Штрихкод: -";
            // 
            // lblUid
            // 
            this.lblUid.AutoSize = true;
            this.lblUid.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUid.ForeColor = System.Drawing.Color.Black;
            this.lblUid.Location = new System.Drawing.Point(4, 72);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(41, 17);
            this.lblUid.TabIndex = 0;
            this.lblUid.Text = "UID: -";
            // 
            // HistoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "HistoryPage";
            this.Size = new System.Drawing.Size(950, 550);
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
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblSupplierBatch;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblSoldPriceInfo;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Panel pnlBottomStats;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sold_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale_Date;
        private System.Windows.Forms.Label lblInfoTitle;
        private System.Windows.Forms.Label label1;
    }
}
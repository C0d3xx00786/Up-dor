namespace WF_C_.Pages
{
    partial class StockPage
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dgvMedications = new System.Windows.Forms.DataGridView();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfoTitle = new System.Windows.Forms.Label();
            this.pnlInfoContent = new System.Windows.Forms.Panel();
            this.lblVital = new System.Windows.Forms.Label();
            this.lblNarcotic = new System.Windows.Forms.Label();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.lblStorageLocation = new System.Windows.Forms.Label();
            this.lblPharmacologicGroup = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblQuantityPerPack = new System.Windows.Forms.Label();
            this.lblMeasurementUnit = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblWrittenOffReason = new System.Windows.Forms.Label();
            this.lblSupplierBatch = new System.Windows.Forms.Label();
            this.lblItemStatus = new System.Windows.Forms.Label();
            this.lblReceiptDate = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblRetailPrice = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblUid = new System.Windows.Forms.Label();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.Uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retail_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expiration_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Measurement_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_Per_Pack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedications)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.pnlInfoContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10, 10, 10, 6);
            this.pnlMain.Size = new System.Drawing.Size(950, 650);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.splitContainer);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(10, 10);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(930, 634);
            this.pnlContent.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.dgvMedications);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pnlInfo);
            this.splitContainer.Size = new System.Drawing.Size(930, 634);
            this.splitContainer.SplitterDistance = 630;
            this.splitContainer.TabIndex = 1;
            // 
            // dgvMedications
            // 
            this.dgvMedications.AllowUserToAddRows = false;
            this.dgvMedications.AllowUserToDeleteRows = false;
            this.dgvMedications.AllowUserToResizeRows = false;
            this.dgvMedications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedications.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvMedications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Uid,
            this.Name_Item,
            this.Barcode,
            this.Retail_Price,
            this.Expiration_Date,
            this.Item_Status,
            this.Measurement_Unit,
            this.Quantity_Per_Pack,
            this.Supplier_Batch});
            this.dgvMedications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedications.Location = new System.Drawing.Point(0, 0);
            this.dgvMedications.MultiSelect = false;
            this.dgvMedications.Name = "dgvMedications";
            this.dgvMedications.ReadOnly = true;
            this.dgvMedications.RowHeadersVisible = false;
            this.dgvMedications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedications.Size = new System.Drawing.Size(630, 634);
            this.dgvMedications.TabIndex = 0;
            this.dgvMedications.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedications_CellClick);
            this.dgvMedications.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedications_CellDoubleClick);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.Controls.Add(this.lblInfoTitle);
            this.pnlInfo.Controls.Add(this.pnlInfoContent);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Padding = new System.Windows.Forms.Padding(15);
            this.pnlInfo.Size = new System.Drawing.Size(296, 634);
            this.pnlInfo.TabIndex = 0;
            // 
            // lblInfoTitle
            // 
            this.lblInfoTitle.AutoSize = true;
            this.lblInfoTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblInfoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.lblInfoTitle.Location = new System.Drawing.Point(10, 10);
            this.lblInfoTitle.Name = "lblInfoTitle";
            this.lblInfoTitle.Size = new System.Drawing.Size(212, 21);
            this.lblInfoTitle.TabIndex = 0;
            this.lblInfoTitle.Text = "ИНФОРМАЦИЯ О ТОВАРЕ";
            // 
            // pnlInfoContent
            // 
            this.pnlInfoContent.AutoScroll = true;
            this.pnlInfoContent.Controls.Add(this.lblVital);
            this.pnlInfoContent.Controls.Add(this.lblNarcotic);
            this.pnlInfoContent.Controls.Add(this.lblRecipe);
            this.pnlInfoContent.Controls.Add(this.lblStorageLocation);
            this.pnlInfoContent.Controls.Add(this.lblPharmacologicGroup);
            this.pnlInfoContent.Controls.Add(this.lblManufacturer);
            this.pnlInfoContent.Controls.Add(this.lblQuantityPerPack);
            this.pnlInfoContent.Controls.Add(this.lblMeasurementUnit);
            this.pnlInfoContent.Controls.Add(this.lblName);
            this.pnlInfoContent.Controls.Add(this.lblBarcode);
            this.pnlInfoContent.Controls.Add(this.lblWrittenOffReason);
            this.pnlInfoContent.Controls.Add(this.lblSupplierBatch);
            this.pnlInfoContent.Controls.Add(this.lblItemStatus);
            this.pnlInfoContent.Controls.Add(this.lblReceiptDate);
            this.pnlInfoContent.Controls.Add(this.lblExpirationDate);
            this.pnlInfoContent.Controls.Add(this.lblRetailPrice);
            this.pnlInfoContent.Controls.Add(this.lblPurchasePrice);
            this.pnlInfoContent.Controls.Add(this.lblUid);
            this.pnlInfoContent.Controls.Add(this.lblSeparator);
            this.pnlInfoContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfoContent.Location = new System.Drawing.Point(15, 15);
            this.pnlInfoContent.Name = "pnlInfoContent";
            this.pnlInfoContent.Size = new System.Drawing.Size(266, 604);
            this.pnlInfoContent.TabIndex = 1;
            // 
            // lblVital
            // 
            this.lblVital.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblVital.ForeColor = System.Drawing.Color.Black;
            this.lblVital.Location = new System.Drawing.Point(3, 450);
            this.lblVital.Name = "lblVital";
            this.lblVital.Size = new System.Drawing.Size(240, 20);
            this.lblVital.TabIndex = 18;
            this.lblVital.Text = "Жизненно важный: -";
            // 
            // lblNarcotic
            // 
            this.lblNarcotic.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblNarcotic.ForeColor = System.Drawing.Color.Black;
            this.lblNarcotic.Location = new System.Drawing.Point(3, 430);
            this.lblNarcotic.Name = "lblNarcotic";
            this.lblNarcotic.Size = new System.Drawing.Size(240, 20);
            this.lblNarcotic.TabIndex = 17;
            this.lblNarcotic.Text = "Наркотический: -";
            // 
            // lblRecipe
            // 
            this.lblRecipe.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblRecipe.ForeColor = System.Drawing.Color.Black;
            this.lblRecipe.Location = new System.Drawing.Point(3, 410);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(240, 20);
            this.lblRecipe.TabIndex = 16;
            this.lblRecipe.Text = "Требует рецепт: -";
            // 
            // lblStorageLocation
            // 
            this.lblStorageLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblStorageLocation.ForeColor = System.Drawing.Color.Black;
            this.lblStorageLocation.Location = new System.Drawing.Point(3, 390);
            this.lblStorageLocation.Name = "lblStorageLocation";
            this.lblStorageLocation.Size = new System.Drawing.Size(240, 20);
            this.lblStorageLocation.TabIndex = 15;
            this.lblStorageLocation.Text = "Место хранения: -";
            // 
            // lblPharmacologicGroup
            // 
            this.lblPharmacologicGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPharmacologicGroup.ForeColor = System.Drawing.Color.Black;
            this.lblPharmacologicGroup.Location = new System.Drawing.Point(3, 370);
            this.lblPharmacologicGroup.Name = "lblPharmacologicGroup";
            this.lblPharmacologicGroup.Size = new System.Drawing.Size(240, 20);
            this.lblPharmacologicGroup.TabIndex = 14;
            this.lblPharmacologicGroup.Text = "Фарм. группа: -";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblManufacturer.ForeColor = System.Drawing.Color.Black;
            this.lblManufacturer.Location = new System.Drawing.Point(3, 350);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(240, 20);
            this.lblManufacturer.TabIndex = 13;
            this.lblManufacturer.Text = "Производитель: -";
            // 
            // lblQuantityPerPack
            // 
            this.lblQuantityPerPack.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblQuantityPerPack.ForeColor = System.Drawing.Color.Black;
            this.lblQuantityPerPack.Location = new System.Drawing.Point(3, 330);
            this.lblQuantityPerPack.Name = "lblQuantityPerPack";
            this.lblQuantityPerPack.Size = new System.Drawing.Size(240, 20);
            this.lblQuantityPerPack.TabIndex = 12;
            this.lblQuantityPerPack.Text = "Кол-во в упаковке: -";
            // 
            // lblMeasurementUnit
            // 
            this.lblMeasurementUnit.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMeasurementUnit.ForeColor = System.Drawing.Color.Black;
            this.lblMeasurementUnit.Location = new System.Drawing.Point(3, 310);
            this.lblMeasurementUnit.Name = "lblMeasurementUnit";
            this.lblMeasurementUnit.Size = new System.Drawing.Size(240, 20);
            this.lblMeasurementUnit.TabIndex = 11;
            this.lblMeasurementUnit.Text = "Единица измерения: -";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(3, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(240, 40);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Название: -";
            // 
            // lblBarcode
            // 
            this.lblBarcode.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblBarcode.ForeColor = System.Drawing.Color.Black;
            this.lblBarcode.Location = new System.Drawing.Point(3, 50);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(240, 20);
            this.lblBarcode.TabIndex = 9;
            this.lblBarcode.Text = "Штрихкод: -";
            // 
            // lblWrittenOffReason
            // 
            this.lblWrittenOffReason.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblWrittenOffReason.ForeColor = System.Drawing.Color.Black;
            this.lblWrittenOffReason.Location = new System.Drawing.Point(3, 270);
            this.lblWrittenOffReason.Name = "lblWrittenOffReason";
            this.lblWrittenOffReason.Size = new System.Drawing.Size(240, 20);
            this.lblWrittenOffReason.TabIndex = 7;
            this.lblWrittenOffReason.Text = "Причина списания: -";
            // 
            // lblSupplierBatch
            // 
            this.lblSupplierBatch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSupplierBatch.ForeColor = System.Drawing.Color.Black;
            this.lblSupplierBatch.Location = new System.Drawing.Point(3, 290);
            this.lblSupplierBatch.Name = "lblSupplierBatch";
            this.lblSupplierBatch.Size = new System.Drawing.Size(240, 20);
            this.lblSupplierBatch.TabIndex = 8;
            this.lblSupplierBatch.Text = "Номер партии: -";
            // 
            // lblItemStatus
            // 
            this.lblItemStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblItemStatus.ForeColor = System.Drawing.Color.Black;
            this.lblItemStatus.Location = new System.Drawing.Point(3, 250);
            this.lblItemStatus.Name = "lblItemStatus";
            this.lblItemStatus.Size = new System.Drawing.Size(240, 20);
            this.lblItemStatus.TabIndex = 6;
            this.lblItemStatus.Text = "Статус: -";
            // 
            // lblReceiptDate
            // 
            this.lblReceiptDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblReceiptDate.ForeColor = System.Drawing.Color.Black;
            this.lblReceiptDate.Location = new System.Drawing.Point(3, 230);
            this.lblReceiptDate.Name = "lblReceiptDate";
            this.lblReceiptDate.Size = new System.Drawing.Size(240, 20);
            this.lblReceiptDate.TabIndex = 5;
            this.lblReceiptDate.Text = "Дата поступления: -";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblExpirationDate.ForeColor = System.Drawing.Color.Black;
            this.lblExpirationDate.Location = new System.Drawing.Point(3, 210);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(240, 20);
            this.lblExpirationDate.TabIndex = 4;
            this.lblExpirationDate.Text = "Годен до: -";
            // 
            // lblRetailPrice
            // 
            this.lblRetailPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblRetailPrice.ForeColor = System.Drawing.Color.Black;
            this.lblRetailPrice.Location = new System.Drawing.Point(3, 190);
            this.lblRetailPrice.Name = "lblRetailPrice";
            this.lblRetailPrice.Size = new System.Drawing.Size(240, 20);
            this.lblRetailPrice.TabIndex = 3;
            this.lblRetailPrice.Text = "Розничная цена: -";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPurchasePrice.ForeColor = System.Drawing.Color.Black;
            this.lblPurchasePrice.Location = new System.Drawing.Point(3, 170);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(240, 20);
            this.lblPurchasePrice.TabIndex = 2;
            this.lblPurchasePrice.Text = "Закупочная цена: -";
            // 
            // lblUid
            // 
            this.lblUid.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblUid.ForeColor = System.Drawing.Color.Black;
            this.lblUid.Location = new System.Drawing.Point(3, 30);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(240, 20);
            this.lblUid.TabIndex = 1;
            this.lblUid.Text = "UID: -";
            // 
            // lblSeparator
            // 
            this.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator.Location = new System.Drawing.Point(3, 150);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(240, 2);
            this.lblSeparator.TabIndex = 0;
            // 
            // Uid
            // 
            this.Uid.DataPropertyName = "Uid";
            this.Uid.HeaderText = "UID";
            this.Uid.Name = "Uid";
            this.Uid.ReadOnly = true;
            // 
            // Name_Item
            // 
            this.Name_Item.DataPropertyName = "Name_Item";
            this.Name_Item.HeaderText = "Название лекарства";
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
            // Retail_Price
            // 
            this.Retail_Price.DataPropertyName = "Retail_Price";
            this.Retail_Price.HeaderText = "Розничная цена";
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
            // Item_Status
            // 
            this.Item_Status.DataPropertyName = "Item_Status";
            this.Item_Status.HeaderText = "Статус";
            this.Item_Status.Name = "Item_Status";
            this.Item_Status.ReadOnly = true;
            // 
            // Measurement_Unit
            // 
            this.Measurement_Unit.DataPropertyName = "Measurement_Unit";
            this.Measurement_Unit.HeaderText = "Единица измерения";
            this.Measurement_Unit.Name = "Measurement_Unit";
            this.Measurement_Unit.ReadOnly = true;
            // 
            // Quantity_Per_Pack
            // 
            this.Quantity_Per_Pack.DataPropertyName = "Quantity_Per_Pack";
            this.Quantity_Per_Pack.HeaderText = "Кол-во в упаковке";
            this.Quantity_Per_Pack.Name = "Quantity_Per_Pack";
            this.Quantity_Per_Pack.ReadOnly = true;
            // 
            // Supplier_Batch
            // 
            this.Supplier_Batch.DataPropertyName = "Supplier_Batch";
            this.Supplier_Batch.HeaderText = "Номер партии";
            this.Supplier_Batch.Name = "Supplier_Batch";
            this.Supplier_Batch.ReadOnly = true;
            // 
            // StockPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "StockPage";
            this.Size = new System.Drawing.Size(950, 650);
            this.pnlMain.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedications)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlInfoContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblInfoTitle;
        private System.Windows.Forms.Panel pnlInfoContent;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.Label lblUid;
        private System.Windows.Forms.Label lblRetailPrice;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblReceiptDate;
        private System.Windows.Forms.Label lblItemStatus;
        private System.Windows.Forms.Label lblSupplierBatch;
        private System.Windows.Forms.Label lblWrittenOffReason;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMeasurementUnit;
        private System.Windows.Forms.Label lblQuantityPerPack;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblPharmacologicGroup;
        private System.Windows.Forms.Label lblStorageLocation;
        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.Label lblNarcotic;
        private System.Windows.Forms.Label lblVital;
        private System.Windows.Forms.DataGridView dgvMedications;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Retail_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expiration_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Measurement_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_Per_Pack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_Batch;
    }
}
namespace WF_C_
{
    partial class AddComplaintForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblUid = new System.Windows.Forms.Label();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.txtDoctor = new System.Windows.Forms.TextBox();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.txtRecipe = new System.Windows.Forms.TextBox();
            this.lblPatient = new System.Windows.Forms.Label();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUid
            // 
            this.lblUid.AutoSize = true;
            this.lblUid.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblUid.Location = new System.Drawing.Point(29, 57);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(96, 17);
            this.lblUid.TabIndex = 0;
            this.lblUid.Text = "UID лекарства:";
            // 
            // txtUid
            // 
            this.txtUid.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtUid.Location = new System.Drawing.Point(29, 79);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(450, 25);
            this.txtUid.TabIndex = 1;
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDoctor.Location = new System.Drawing.Point(29, 115);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(80, 17);
            this.lblDoctor.TabIndex = 2;
            this.lblDoctor.Text = "ФИО врача:";
            // 
            // txtDoctor
            // 
            this.txtDoctor.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDoctor.Location = new System.Drawing.Point(29, 137);
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.Size = new System.Drawing.Size(450, 25);
            this.txtDoctor.TabIndex = 3;
            // 
            // lblRecipe
            // 
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblRecipe.Location = new System.Drawing.Point(29, 175);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(124, 17);
            this.lblRecipe.TabIndex = 4;
            this.lblRecipe.Text = "Реквизиты рецепта:";
            // 
            // txtRecipe
            // 
            this.txtRecipe.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtRecipe.Location = new System.Drawing.Point(29, 197);
            this.txtRecipe.Name = "txtRecipe";
            this.txtRecipe.Size = new System.Drawing.Size(450, 25);
            this.txtRecipe.TabIndex = 5;
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPatient.Location = new System.Drawing.Point(29, 235);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(111, 17);
            this.lblPatient.TabIndex = 6;
            this.lblPatient.Text = "ФИО покупателя:";
            // 
            // txtPatient
            // 
            this.txtPatient.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPatient.Location = new System.Drawing.Point(29, 257);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(450, 25);
            this.txtPatient.TabIndex = 7;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblContact.Location = new System.Drawing.Point(29, 295);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(128, 17);
            this.lblContact.TabIndex = 8;
            this.lblContact.Text = "Контакт покупателя:";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtContact.Location = new System.Drawing.Point(29, 317);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(450, 25);
            this.txtContact.TabIndex = 9;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblComment.Location = new System.Drawing.Point(29, 355);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(93, 17);
            this.lblComment.TabIndex = 10;
            this.lblComment.Text = "Комментарий:";
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtComment.Location = new System.Drawing.Point(29, 377);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(450, 60);
            this.txtComment.TabIndex = 11;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDate.Location = new System.Drawing.Point(29, 455);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(91, 17);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Дата жалобы:";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(29, 477);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(180, 25);
            this.dtpDate.TabIndex = 13;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblStatus.Location = new System.Drawing.Point(259, 455);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Статус:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbStatus.Items.AddRange(new object[] {
            "Новая",
            "Отправлена",
            "Закрыта"});
            this.cmbStatus.Location = new System.Drawing.Point(259, 477);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(220, 25);
            this.cmbStatus.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(289, 518);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(399, 518);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 35);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(520, 45);
            this.pnlTop.TabIndex = 18;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(178, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Добавление жалобы";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(475, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddComplaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 565);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtPatient);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.txtRecipe);
            this.Controls.Add(this.lblRecipe);
            this.Controls.Add(this.txtDoctor);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.lblUid);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddComplaintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить жалобу";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblUid;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.TextBox txtDoctor;
        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.TextBox txtRecipe;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
    }
}
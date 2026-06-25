namespace WF_C_.Pages
{
    partial class ComplaintsPage
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dgvComplaints = new System.Windows.Forms.DataGridView();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblDetailsTitle = new System.Windows.Forms.Label();
            this.pnlDetailsContent = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDetailComment = new System.Windows.Forms.Label();
            this.lblDetailStatus = new System.Windows.Forms.Label();
            this.lblDetailDate = new System.Windows.Forms.Label();
            this.lblDetailContact = new System.Windows.Forms.Label();
            this.lblDetailPatient = new System.Windows.Forms.Label();
            this.lblDetailRecipe = new System.Windows.Forms.Label();
            this.lblDetailDoctor = new System.Windows.Forms.Label();
            this.lblDetailDrug = new System.Windows.Forms.Label();
            this.lblDetailUid = new System.Windows.Forms.Label();
            this.lblDetailId = new System.Windows.Forms.Label();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComplaintDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaints)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.pnlDetailsContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.splitContainer);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(9);
            this.pnlMain.Size = new System.Drawing.Size(1154, 692);
            this.pnlMain.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.Location = new System.Drawing.Point(9, 9);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.dgvComplaints);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pnlDetails);
            this.splitContainer.Size = new System.Drawing.Size(1136, 674);
            this.splitContainer.SplitterDistance = 784;
            this.splitContainer.SplitterWidth = 3;
            this.splitContainer.TabIndex = 1;
            // 
            // dgvComplaints
            // 
            this.dgvComplaints.AllowUserToAddRows = false;
            this.dgvComplaints.AllowUserToDeleteRows = false;
            this.dgvComplaints.AllowUserToResizeRows = false;
            this.dgvComplaints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComplaints.BackgroundColor = System.Drawing.Color.White;
            this.dgvComplaints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvComplaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplaints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DrugName,
            this.DoctorName,
            this.PatientName,
            this.ComplaintDate,
            this.Status});
            this.dgvComplaints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComplaints.Location = new System.Drawing.Point(0, 0);
            this.dgvComplaints.MultiSelect = false;
            this.dgvComplaints.Name = "dgvComplaints";
            this.dgvComplaints.ReadOnly = true;
            this.dgvComplaints.RowHeadersVisible = false;
            this.dgvComplaints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplaints.Size = new System.Drawing.Size(784, 674);
            this.dgvComplaints.TabIndex = 0;
            this.dgvComplaints.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComplaints_CellClick);
            this.dgvComplaints.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComplaints_CellContentClick);
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDetails.Controls.Add(this.lblDetailsTitle);
            this.pnlDetails.Controls.Add(this.pnlDetailsContent);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Padding = new System.Windows.Forms.Padding(13);
            this.pnlDetails.Size = new System.Drawing.Size(349, 674);
            this.pnlDetails.TabIndex = 0;
            // 
            // lblDetailsTitle
            // 
            this.lblDetailsTitle.AutoSize = true;
            this.lblDetailsTitle.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.lblDetailsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.lblDetailsTitle.Location = new System.Drawing.Point(9, 9);
            this.lblDetailsTitle.Name = "lblDetailsTitle";
            this.lblDetailsTitle.Size = new System.Drawing.Size(211, 28);
            this.lblDetailsTitle.TabIndex = 0;
            this.lblDetailsTitle.Text = "📋 Детали жалобы";
            // 
            // pnlDetailsContent
            // 
            this.pnlDetailsContent.AutoScroll = true;
            this.pnlDetailsContent.Controls.Add(this.btnAdd);
            this.pnlDetailsContent.Controls.Add(this.lblDetailComment);
            this.pnlDetailsContent.Controls.Add(this.lblDetailStatus);
            this.pnlDetailsContent.Controls.Add(this.lblDetailDate);
            this.pnlDetailsContent.Controls.Add(this.lblDetailContact);
            this.pnlDetailsContent.Controls.Add(this.lblDetailPatient);
            this.pnlDetailsContent.Controls.Add(this.lblDetailRecipe);
            this.pnlDetailsContent.Controls.Add(this.lblDetailDoctor);
            this.pnlDetailsContent.Controls.Add(this.lblDetailDrug);
            this.pnlDetailsContent.Controls.Add(this.lblDetailUid);
            this.pnlDetailsContent.Controls.Add(this.lblDetailId);
            this.pnlDetailsContent.Controls.Add(this.lblSeparator);
            this.pnlDetailsContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailsContent.Location = new System.Drawing.Point(13, 13);
            this.pnlDetailsContent.Name = "pnlDetailsContent";
            this.pnlDetailsContent.Size = new System.Drawing.Size(323, 648);
            this.pnlDetailsContent.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(0, 573);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(15);
            this.btnAdd.Size = new System.Drawing.Size(323, 75);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "➕ Добавить жалобу";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDetailComment
            // 
            this.lblDetailComment.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDetailComment.Location = new System.Drawing.Point(3, 329);
            this.lblDetailComment.Name = "lblDetailComment";
            this.lblDetailComment.Size = new System.Drawing.Size(240, 229);
            this.lblDetailComment.TabIndex = 10;
            this.lblDetailComment.Text = "Комментарий: -";
            // 
            // lblDetailStatus
            // 
            this.lblDetailStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDetailStatus.Location = new System.Drawing.Point(3, 295);
            this.lblDetailStatus.Name = "lblDetailStatus";
            this.lblDetailStatus.Size = new System.Drawing.Size(200, 25);
            this.lblDetailStatus.TabIndex = 9;
            this.lblDetailStatus.Text = "Статус: -";
            // 
            // lblDetailDate
            // 
            this.lblDetailDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDetailDate.Location = new System.Drawing.Point(3, 264);
            this.lblDetailDate.Name = "lblDetailDate";
            this.lblDetailDate.Size = new System.Drawing.Size(200, 25);
            this.lblDetailDate.TabIndex = 8;
            this.lblDetailDate.Text = "Дата: -";
            // 
            // lblDetailContact
            // 
            this.lblDetailContact.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDetailContact.Location = new System.Drawing.Point(3, 234);
            this.lblDetailContact.Name = "lblDetailContact";
            this.lblDetailContact.Size = new System.Drawing.Size(200, 25);
            this.lblDetailContact.TabIndex = 7;
            this.lblDetailContact.Text = "Контакт: -";
            // 
            // lblDetailPatient
            // 
            this.lblDetailPatient.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDetailPatient.Location = new System.Drawing.Point(3, 204);
            this.lblDetailPatient.Name = "lblDetailPatient";
            this.lblDetailPatient.Size = new System.Drawing.Size(200, 25);
            this.lblDetailPatient.TabIndex = 6;
            this.lblDetailPatient.Text = "Покупатель: -";
            // 
            // lblDetailRecipe
            // 
            this.lblDetailRecipe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDetailRecipe.Location = new System.Drawing.Point(3, 173);
            this.lblDetailRecipe.Name = "lblDetailRecipe";
            this.lblDetailRecipe.Size = new System.Drawing.Size(200, 25);
            this.lblDetailRecipe.TabIndex = 5;
            this.lblDetailRecipe.Text = "Реквизиты рецепта: -";
            // 
            // lblDetailDoctor
            // 
            this.lblDetailDoctor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDetailDoctor.Location = new System.Drawing.Point(3, 143);
            this.lblDetailDoctor.Name = "lblDetailDoctor";
            this.lblDetailDoctor.Size = new System.Drawing.Size(200, 25);
            this.lblDetailDoctor.TabIndex = 4;
            this.lblDetailDoctor.Text = "Врач: -";
            // 
            // lblDetailDrug
            // 
            this.lblDetailDrug.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDetailDrug.Location = new System.Drawing.Point(3, 115);
            this.lblDetailDrug.Name = "lblDetailDrug";
            this.lblDetailDrug.Size = new System.Drawing.Size(200, 25);
            this.lblDetailDrug.TabIndex = 3;
            this.lblDetailDrug.Text = "Лекарство: -";
            // 
            // lblDetailUid
            // 
            this.lblDetailUid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDetailUid.Location = new System.Drawing.Point(3, 82);
            this.lblDetailUid.Name = "lblDetailUid";
            this.lblDetailUid.Size = new System.Drawing.Size(200, 25);
            this.lblDetailUid.TabIndex = 2;
            this.lblDetailUid.Text = "UID: -";
            // 
            // lblDetailId
            // 
            this.lblDetailId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDetailId.Location = new System.Drawing.Point(3, 52);
            this.lblDetailId.Name = "lblDetailId";
            this.lblDetailId.Size = new System.Drawing.Size(200, 25);
            this.lblDetailId.TabIndex = 1;
            this.lblDetailId.Text = "ID: -";
            // 
            // lblSeparator
            // 
            this.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator.Location = new System.Drawing.Point(17, 39);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(240, 2);
            this.lblSeparator.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // DrugName
            // 
            this.DrugName.DataPropertyName = "DrugName";
            this.DrugName.HeaderText = "Лекарство";
            this.DrugName.Name = "DrugName";
            this.DrugName.ReadOnly = true;
            // 
            // DoctorName
            // 
            this.DoctorName.DataPropertyName = "DoctorName";
            this.DoctorName.HeaderText = "Врач";
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.ReadOnly = true;
            // 
            // PatientName
            // 
            this.PatientName.DataPropertyName = "PatientName";
            this.PatientName.HeaderText = "Покупатель";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            // 
            // ComplaintDate
            // 
            this.ComplaintDate.DataPropertyName = "ComplaintDate";
            this.ComplaintDate.HeaderText = "Дата";
            this.ComplaintDate.Name = "ComplaintDate";
            this.ComplaintDate.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // ComplaintsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "ComplaintsPage";
            this.Size = new System.Drawing.Size(1154, 692);
            this.pnlMain.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaints)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlDetailsContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dgvComplaints;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblDetailsTitle;
        private System.Windows.Forms.Panel pnlDetailsContent;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.Label lblDetailId;
        private System.Windows.Forms.Label lblDetailUid;
        private System.Windows.Forms.Label lblDetailDrug;
        private System.Windows.Forms.Label lblDetailDoctor;
        private System.Windows.Forms.Label lblDetailRecipe;
        private System.Windows.Forms.Label lblDetailPatient;
        private System.Windows.Forms.Label lblDetailContact;
        private System.Windows.Forms.Label lblDetailDate;
        private System.Windows.Forms.Label lblDetailStatus;
        private System.Windows.Forms.Label lblDetailComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComplaintDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
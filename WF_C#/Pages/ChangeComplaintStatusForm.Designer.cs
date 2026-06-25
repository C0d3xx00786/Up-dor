namespace WF_C_.Pages
{
    partial class ChangeComplaintStatusForm
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

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbClosed = new System.Windows.Forms.RadioButton();
            this.rbSent = new System.Windows.Forms.RadioButton();
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.lblCurrentStatusValue = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(440, 45);
            this.pnlTop.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(229, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Изменение статуса жалобы";

            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(395, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.gbStatus);
            this.pnlContent.Controls.Add(this.lblCurrentStatus);
            this.pnlContent.Controls.Add(this.lblCurrentStatusValue);
            this.pnlContent.Controls.Add(this.lblInstruction);
            this.pnlContent.Controls.Add(this.lblComment);
            this.pnlContent.Controls.Add(this.txtComment);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 45);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(30, 25, 30, 0);
            this.pnlContent.Size = new System.Drawing.Size(440, 300);
            this.pnlContent.TabIndex = 1;

            // 
            // gbStatus
            // 
            this.gbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.gbStatus.Controls.Add(this.rbClosed);
            this.gbStatus.Controls.Add(this.rbSent);
            this.gbStatus.Controls.Add(this.rbNew);
            this.gbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbStatus.Location = new System.Drawing.Point(33, 80);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(374, 115);
            this.gbStatus.TabIndex = 3;
            this.gbStatus.TabStop = false;

            // 
            // rbClosed
            // 
            this.rbClosed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbClosed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbClosed.Location = new System.Drawing.Point(15, 82);
            this.rbClosed.Name = "rbClosed";
            this.rbClosed.Size = new System.Drawing.Size(160, 24);
            this.rbClosed.TabIndex = 2;
            this.rbClosed.Text = "✅ Закрыта";
            this.rbClosed.UseVisualStyleBackColor = true;
            this.rbClosed.CheckedChanged += new System.EventHandler(this.rbStatus_CheckedChanged);

            // 
            // rbSent
            // 
            this.rbSent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbSent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbSent.Location = new System.Drawing.Point(15, 52);
            this.rbSent.Name = "rbSent";
            this.rbSent.Size = new System.Drawing.Size(160, 24);
            this.rbSent.TabIndex = 1;
            this.rbSent.Text = "📤 Отправлена";
            this.rbSent.UseVisualStyleBackColor = true;
            this.rbSent.CheckedChanged += new System.EventHandler(this.rbStatus_CheckedChanged);

            // 
            // rbNew
            // 
            this.rbNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbNew.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbNew.Location = new System.Drawing.Point(15, 22);
            this.rbNew.Name = "rbNew";
            this.rbNew.Size = new System.Drawing.Size(160, 24);
            this.rbNew.TabIndex = 0;
            this.rbNew.Text = "🆕 Новая";
            this.rbNew.UseVisualStyleBackColor = true;
            this.rbNew.CheckedChanged += new System.EventHandler(this.rbStatus_CheckedChanged);

            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCurrentStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblCurrentStatus.Location = new System.Drawing.Point(30, 25);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(97, 15);
            this.lblCurrentStatus.TabIndex = 0;
            this.lblCurrentStatus.Text = "Текущий статус:";

            // 
            // lblCurrentStatusValue
            // 
            this.lblCurrentStatusValue.AutoSize = true;
            this.lblCurrentStatusValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCurrentStatusValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblCurrentStatusValue.Location = new System.Drawing.Point(137, 21);
            this.lblCurrentStatusValue.Name = "lblCurrentStatusValue";
            this.lblCurrentStatusValue.Size = new System.Drawing.Size(24, 20);
            this.lblCurrentStatusValue.TabIndex = 1;
            this.lblCurrentStatusValue.Text = "—";

            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInstruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblInstruction.Location = new System.Drawing.Point(30, 60);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(140, 15);
            this.lblInstruction.TabIndex = 2;
            this.lblInstruction.Text = "Выберите новый статус:";

            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblComment.Location = new System.Drawing.Point(30, 210);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(104, 15);
            this.lblComment.TabIndex = 4;
            this.lblComment.Text = "Комментарий к жалобе:";

            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtComment.Location = new System.Drawing.Point(33, 228);
            this.txtComment.MaxLength = 500;
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(374, 60);
            this.txtComment.TabIndex = 5;

            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlButtons.Controls.Add(this.btn_Cancel);
            this.pnlButtons.Controls.Add(this.btn_Ok);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 345);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(440, 65);
            this.pnlButtons.TabIndex = 2;

            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.White;
            this.btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_Cancel.Location = new System.Drawing.Point(240, 15);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 32);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Отмена";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btnCancel_Click);

            // 
            // btn_Ok
            // 
            this.btn_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btn_Ok.FlatAppearance.BorderSize = 0;
            this.btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ok.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Ok.ForeColor = System.Drawing.Color.White;
            this.btn_Ok.Location = new System.Drawing.Point(321, 15);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(107, 32);
            this.btn_Ok.TabIndex = 0;
            this.btn_Ok.Text = "Сохранить";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btnOK_Click);

            // 
            // ChangeComplaintStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 410);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeComplaintStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменение статуса жалобы";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.Label lblCurrentStatusValue;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbClosed;
        private System.Windows.Forms.RadioButton rbSent;
        private System.Windows.Forms.RadioButton rbNew;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Ok;
    }
}
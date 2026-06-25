using System;
using System.Windows.Forms;

namespace WF_C_.Pages
{
    public partial class ChangeComplaintStatusForm : Form
    {
        public string SelectedStatus { get; private set; }
        public string Comment { get; private set; }

        public ChangeComplaintStatusForm(string currentStatus, string currentComment)
        {
            InitializeComponent();

            // Устанавливаем текущий статус
            string statusDisplay = GetStatusDisplayName(currentStatus);
            lblCurrentStatusValue.Text = statusDisplay;

            // Устанавливаем цвет для текущего статуса
            switch (currentStatus)
            {
                case "Новая":
                    lblCurrentStatusValue.ForeColor = AppConstants.Colors.WarningYellow;
                    rbNew.Checked = true;
                    break;
                case "Отправлена":
                    lblCurrentStatusValue.ForeColor = AppConstants.Colors.PrimaryBlue;
                    rbSent.Checked = true;
                    break;
                case "Закрыта":
                    lblCurrentStatusValue.ForeColor = AppConstants.Colors.SuccessGreen;
                    rbClosed.Checked = true;
                    break;
                default:
                    rbNew.Checked = true;
                    break;
            }

            txtComment.Text = currentComment ?? "";

            // Добавляем обработчик нажатия Enter
            this.KeyPreview = true;
            this.KeyDown += ChangeComplaintStatusForm_KeyDown;
        }

        private string GetStatusDisplayName(string status)
        {
            switch (status)
            {
                case "Новая": return "Новая";
                case "Отправлена": return "Отправлена";
                case "Закрыта": return "Закрыта";
                default: return status;
            }
        }

        private void rbStatus_CheckedChanged(object sender, EventArgs e)
        {
            // Можно добавить дополнительную логику при смене статуса
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли статус
            if (!rbNew.Checked && !rbSent.Checked && !rbClosed.Checked)
            {
                MessageBox.Show("Пожалуйста, выберите статус жалобы.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Определяем выбранный статус
            if (rbNew.Checked) SelectedStatus = "Новая";
            else if (rbSent.Checked) SelectedStatus = "Отправлена";
            else if (rbClosed.Checked) SelectedStatus = "Закрыта";

            Comment = txtComment.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ChangeComplaintStatusForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
            else if (e.KeyCode == Keys.Enter && !txtComment.Focused)
            {
                btnOK_Click(sender, e);
            }
        }
    }
}
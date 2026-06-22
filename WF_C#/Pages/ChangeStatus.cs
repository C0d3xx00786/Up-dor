using System;
using System.Windows.Forms;

namespace WF_C_.Pages
{
    public partial class ChangeStatusForm : Form
    {
        public string SelectedStatus { get; private set; }
        public string Comment { get; private set; }

        public ChangeStatusForm(string currentStatus, string currentComment)
        {
            InitializeComponent();

            // Устанавливаем текущий статус

            string statusDisplay = GetStatusDisplayName(currentStatus);
            lblCurrentStatusValue.Text = statusDisplay;

            // Устанавливаем цвет для текущего статуса
            switch (currentStatus)
            {
                case "in_stock":
                    lblCurrentStatusValue.ForeColor = System.Drawing.Color.Black;
                    rbInStock.Checked = true;
                    break;
                case "sold":
                    lblCurrentStatusValue.ForeColor = System.Drawing.Color.Green;
                    rbSold.Checked = true;
                    break;
                case "written_off":
                    lblCurrentStatusValue.ForeColor = System.Drawing.Color.Red;
                    rbWrittenOff.Checked = true;
                    break;
                case "quarantined":
                    lblCurrentStatusValue.ForeColor = System.Drawing.Color.Blue;
                    rbQuarantined.Checked = true;
                    break;
                case "reserved":
                    lblCurrentStatusValue.ForeColor = System.Drawing.Color.OrangeRed;
                    rbReserved.Checked = true;
                    break;
            }

            txtComment.Text = currentComment ?? "";

            // Настройка видимости поля комментария в зависимости от статуса
            UpdateCommentVisibility();

            // Добавляем обработчик нажатия Enter
            this.KeyPreview = true;
            this.KeyDown += ChangeStatusForm_KeyDown;
        }

        private string GetStatusDisplayName(string status)
        {
            switch (status)
            {
                case "in_stock": return "В наличии";
                case "sold": return "Продан";
                case "written_off": return "Списан";
                case "quarantined": return "На карантине";
                case "reserved": return "Зарезервирован";
                default: return status;
            }
        }

        private void UpdateCommentVisibility()
        {
            // Показываем поле комментария только для списанных товаров
            bool showComment = rbWrittenOff.Checked || rbReserved.Checked;
            lblComment.Visible = showComment;
            txtComment.Visible = showComment;

            if (!showComment) txtComment.Text = "";

            if (rbWrittenOff.Checked) lblComment.Text = "Причина списания:";
            if (rbReserved.Checked) lblComment.Text = "Укажите имя клиента:";
        }

        private void rbStatus_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCommentVisibility();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли статус
            if (!rbInStock.Checked && !rbSold.Checked &&
                !rbWrittenOff.Checked && !rbQuarantined.Checked && !rbReserved.Checked)
            {
                MessageBox.Show("Пожалуйста, выберите статус товара.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Если выбран статус "списан", проверяем наличие комментария
            if (rbWrittenOff.Checked && string.IsNullOrWhiteSpace(txtComment.Text))
            {
                MessageBox.Show("Укажите причину списания.",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Добавьте return, чтобы не продолжать
            }

            if (rbReserved.Checked && string.IsNullOrWhiteSpace(txtComment.Text))
            {
                MessageBox.Show("Укажите имя клиента, для которого зарезервирован товар.",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Добавьте return, чтобы не продолжать
            }

            // Определяем выбранный статус
            if (rbInStock.Checked) SelectedStatus = "in_stock";
            else if (rbSold.Checked) SelectedStatus = "sold";
            else if (rbWrittenOff.Checked) SelectedStatus = "written_off";
            else if (rbQuarantined.Checked) SelectedStatus = "quarantined";
            else if (rbReserved.Checked) SelectedStatus = "reserved";

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

        private void ChangeStatusForm_KeyDown(object sender, KeyEventArgs e)
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
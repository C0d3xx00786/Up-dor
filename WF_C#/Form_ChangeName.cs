using System;
using System.Drawing;
using System.Windows.Forms;

namespace Up_Dor
{
    public partial class Change_Name : Form
    {
        public string NewName { get; private set; }
        public Change_Name(string currentName = null)
        {
            InitializeComponent();

            lblCurrentNameValue.Text = string.IsNullOrWhiteSpace(currentName)
                ? "не задано"
                : currentName;

            if (!string.IsNullOrWhiteSpace(currentName))
            {
                txb_changeName.Text = currentName;
                txb_changeName.SelectAll();
            }
        }
        private void SaveName()
        {
            string name = txb_changeName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show(
                    "Введите новое имя сотрудника.",
                    "Введите имя",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txb_changeName.Focus();
                return;
            }

            // Проверка: не совпадает ли с текущим
            if (name == lblCurrentNameValue.Text)
            {
                MessageBox.Show(
                    "Новое имя совпадает с текущим.",
                    "Нет изменений",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            NewName = name;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel()
        {
            NewName = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e) => SaveName();
        private void btn_Cancel_Click(object sender, EventArgs e) => Cancel();
        private void btnClose_Click(object sender, EventArgs e) => Cancel();

        private void txb_changeName_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter) SaveName();
           if (e.KeyCode == Keys.Escape) Cancel();
        }

        private void Change_Name_Shown(object sender, EventArgs e)
        {
            txb_changeName.Focus();
            if (!string.IsNullOrWhiteSpace(txb_changeName.Text))
                txb_changeName.SelectAll();
        }
    }
}
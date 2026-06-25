using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WF_C_
{
    public partial class AddComplaintForm : Form
    {
        public ComplaintItem NewComplaint { get; private set; }

        public AddComplaintForm()
        {
            InitializeComponent();
            cmbStatus.SelectedIndex = 0;
            dtpDate.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Проверка обязательных полей
            if (string.IsNullOrWhiteSpace(txtUid.Text))
            {
                MessageBox.Show("Укажите UID лекарства.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Можно проверить существование UID в БД (через DataHelper.FindDrugByUid)
            var drug = DataHelper.FindDrugByUid(txtUid.Text.Trim());
            if (drug == null)
            {
                MessageBox.Show("Лекарство с таким UID не найдено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NewComplaint = new ComplaintItem
            {
                Uid = txtUid.Text.Trim(),
                DrugName = drug.Name_Item, // автоматически подставим название
                DoctorName = txtDoctor.Text.Trim(),
                RecipeDetails = txtRecipe.Text.Trim(),
                PatientName = txtPatient.Text.Trim(),
                PatientContact = txtContact.Text.Trim(),
                Comment = txtComment.Text.Trim(),
                ComplaintDate = dtpDate.Value,
                Status = cmbStatus.SelectedItem.ToString()
            };

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
    }
}
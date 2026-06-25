using System;
using System.Drawing;
using System.Windows.Forms;

namespace WF_C_.Pages
{
    public partial class ComplaintsPage : UserControl
    {
        public ComplaintsPage()
        {
            InitializeComponent();

            dgvComplaints.AutoGenerateColumns = false;

            dgvComplaints.DataSource = Data.complaintsList;
        }

        public void UpdateDataSource()
        {
            // Просто обновляем привязку
            dgvComplaints.DataSource = null;
            dgvComplaints.DataSource = Data.complaintsList;
        }

        // Клик по строке – отображение деталей
        private void dgvComplaints_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < Data.complaintsList.Count)
            {
                var item = Data.complaintsList[e.RowIndex];
                DisplayDetails(item);
            }
        }

        private void DisplayDetails(ComplaintItem item)
        {
            if (item == null)
            {
                return;
            }

            lblDetailId.Text = $"ID: {item.Id}";
            lblDetailUid.Text = $"UID: {item.Uid ?? "-"}";
            lblDetailDrug.Text = $"Лекарство: {item.DrugName ?? "-"}";
            lblDetailDoctor.Text = $"Врач: {item.DoctorName ?? "-"}";
            lblDetailRecipe.Text = $"Реквизиты рецепта: {item.RecipeDetails ?? "-"}";
            lblDetailPatient.Text = $"Покупатель: {item.PatientName ?? "-"}";
            lblDetailContact.Text = $"Контакт: {item.PatientContact ?? "-"}";
            lblDetailDate.Text = $"Дата: {item.ComplaintDate:dd.MM.yyyy HH:mm}";
            lblDetailStatus.Text = $"Статус: {item.Status ?? "-"}";
            lblDetailComment.Text = $"Комментарий: {item.Comment ?? "-"}";

            // Цвет статуса
            switch (item.Status)
            {
                case "Новая":
                    lblDetailStatus.ForeColor = AppConstants.Colors.WarningYellow;
                    break;
                case "Отправлена":
                    lblDetailStatus.ForeColor = AppConstants.Colors.PrimaryBlue;
                    break;
                case "Закрыта":
                    lblDetailStatus.ForeColor = AppConstants.Colors.SuccessGreen;
                    break;
                default:
                    lblDetailStatus.ForeColor = Color.Black;
                    break;
            }
        }

        // Кнопка "Добавить"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new AddComplaintForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (DataHelper.AddComplaint(form.NewComplaint))
                    {
                        MessageBox.Show("Жалоба успешно добавлена.", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при сохранении жалобы.", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvComplaints_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < Data.complaintsList.Count)
            {
                var item = Data.complaintsList[e.RowIndex];

                using (var form = new ChangeComplaintStatusForm(item.Status, item.Comment))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (DataHelper.UpdateComplaintStatus(item.Id, form.SelectedStatus, form.Comment))
                        {
                            // Обновляем отображение деталей
                            DisplayDetails(item);
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при обновлении статуса жалобы.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
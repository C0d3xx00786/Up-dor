using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Up_Dor;

namespace WF_C_.Pages
{
    public partial class StockPage : UserControl
    {
        public StockPage()
        {
            InitializeComponent();
            //ConfigureGridColumns();
            UpdateDataSource(Main_Menu.data);
        }

        //Обновление Таблицы в Складе
        public void UpdateDataSource(List<DrugItem> newData)
        {
            dgvMedications.DataSource = null;
            dgvMedications.DataSource = newData;
        }

        // Колонкии для таблицы
        private void ConfigureGridColumns()
        {
            dgvMedications.AutoGenerateColumns = false;
            dgvMedications.Columns.Clear();

            // Подписываемся на событие для отрисовки вложенных свойств (DrugInfo.Name)
            dgvMedications.CellFormatting += DgvMedications_CellFormatting;

            dgvMedications.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Uid", HeaderText = "UID (Коробка)" });
            dgvMedications.Columns.Add(new DataGridViewTextBoxColumn { Name = "DrugName", HeaderText = "Название препарата" });
            dgvMedications.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ExpirationDate", HeaderText = "Годен до" });
            dgvMedications.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ItemStatus", HeaderText = "Статус" });
            dgvMedications.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ExpirationDate", HeaderText = "Годен до" });

            dgvMedications.Columns.Add(new DataGridViewTextBoxColumn { Name = "DrugName", HeaderText = "Название препарата" });
            dgvMedications.Columns.Add(new DataGridViewTextBoxColumn { Name = "DrugName", HeaderText = "Название препарата" });
            dgvMedications.Columns.Add(new DataGridViewTextBoxColumn { Name = "DrugName", HeaderText = "Название препарата" });
            dgvMedications.Columns.Add(new DataGridViewTextBoxColumn { Name = "DrugName", HeaderText = "Название препарата" });

        }

        //
        private void DgvMedications_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMedications.Rows[e.RowIndex].DataBoundItem is DrugItem item)
            {
                if (dgvMedications.Columns[e.ColumnIndex].Name == "DrugName")
                {
                    e.Value = item.DrugInfo.Name;
                }
            }
        }

        private void dgvMedications_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedItem = (DrugItem)dgvMedications.Rows[e.RowIndex].DataBoundItem;

                lblName.Text = $"Название: {selectedItem.DrugInfo.Name}";
                lblGroup.Text = $"Группа: {selectedItem.DrugInfo.Pharmacologic_Group}";
                lblPrice.Text = $"Цена (розница): {selectedItem.Retail_Price}";
                lblStatus.Text = $"Статус: {selectedItem.Item_Status}";

                if (selectedItem.Expiration_Date != default)
                {
                    lblExpiration.Text = $"Годен до: {selectedItem.Expiration_Date.ToShortDateString()}";
                    lblExpiration.ForeColor = selectedItem.Expiration_Date < DateTime.Now ? Color.Red : Color.Black;
                }

                lblManufacturer.Text = $"Производитель: {selectedItem.DrugInfo.Manufacturer}";
                lblStorage.Text = $"Место хранения: {selectedItem.DrugInfo.Storage_Location}";
            }
        }

        private void dgvMedications_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMedications.Rows[e.RowIndex];
                string uid = row.Cells["UID"].Value.ToString();
                string name = row.Cells["Название"].Value.ToString();
                string currentStatus = row.Cells["Статус"].Value.ToString();

                var result = MessageBox.Show(
                    $"Вы хотите списать данный товар?\n\nПрепарат: {name}\nUID: {uid}\nТекущий статус: {currentStatus}",
                    "Изменение состояния",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    //UpdateItemStatus(uid, "written_off");
                }
            }
        }
    }
}
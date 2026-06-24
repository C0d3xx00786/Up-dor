using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using Up_Dor;

namespace WF_C_.Pages
{
    public partial class StockPage : UserControl
    {
        private BindingSource stockBindingSource = new BindingSource();
        public StockPage()
        {
            InitializeComponent();

            dgvMedications.AutoGenerateColumns = false;

            stockBindingSource.DataSource = Data.data;
            dgvMedications.DataSource = stockBindingSource;
        }

        //Обновление Таблицы в Складе
        public void UpdateDataSource()
        {
            try
            {
                stockBindingSource.DataSource = Data.data.Where(item => item.Item_Status != "sold").ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgvMedications_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedItem = (DrugItem)dgvMedications.Rows[e.RowIndex].DataBoundItem;

                // Информация о DrugItem
                lblUid.Text = $"UID: {selectedItem.Uid}";
                lblPurchasePrice.Text = $"Закупочная цена: {selectedItem.Purchase_Price:F2}";
                lblRetailPrice.Text = $"Розничная цена: {selectedItem.Retail_Price:F2}";
                lblExpirationDate.Text = $"Годен до: {selectedItem.Expiration_Date.ToShortDateString()}";
                lblExpirationDate.ForeColor = selectedItem.Expiration_Date < DateTime.Now ? Color.Red : Color.Black;
                lblReceiptDate.Text = $"Дата поступления: {selectedItem.Receipt_Date.ToShortDateString()}";
                lblSupplierBatch.Text = $"Номер партии: {selectedItem.Supplier_Batch ?? "-"}";
                lblWrittenOffReason.Text = $"Причина списания: {selectedItem.Written_Off_Reason ?? "-"}";
                lblItemStatus.Text = $"Статус: {selectedItem.Item_Status}";
                switch (selectedItem.Item_Status)
                {
                    case "in_stock":
                        lblItemStatus.ForeColor = Color.Black;
                        lblWrittenOffReason.ForeColor = Color.Black;
                        break;
                    case "sold":
                        lblItemStatus.ForeColor = Color.Green;
                        lblWrittenOffReason.ForeColor = Color.Black;
                        break;
                    case "written_off":
                        lblItemStatus.ForeColor = Color.Red;
                        lblWrittenOffReason.ForeColor = Color.Red;
                        break;
                    case "quarantined":
                        lblItemStatus.ForeColor = Color.Blue;
                        lblWrittenOffReason.ForeColor = Color.Black;
                        break;
                    case "reserved":
                        lblItemStatus.ForeColor = Color.OrangeRed;
                        lblWrittenOffReason.ForeColor = Color.OrangeRed;
                        break;
                }

                // Информация о Drug (если есть)
                if (selectedItem.DrugInfo != null)
                {
                    var drug = selectedItem.DrugInfo;
                    lblBarcode.Text = $"Штрихкод: {drug.Barcode ?? "-"}";
                    lblName.Text = $"Название: {drug.Name ?? "-"}";
                    lblMeasurementUnit.Text = $"Единица измерения: {drug.Measurement_Unit ?? "-"}";
                    lblQuantityPerPack.Text = $"Кол-во в упаковке: {drug.Quantity_Per_Pack}";
                    lblManufacturer.Text = $"Производитель: {drug.Manufacturer ?? "-"}";
                    lblPharmacologicGroup.Text = $"Фарм. группа: {drug.Pharmacologic_Group ?? "-"}";
                    lblStorageLocation.Text = $"Место хранения: {drug.Storage_Location ?? "-"}";
                    lblRecipe.Text = $"Требует рецепт: {(drug.Need_Recipe ? "Да" : "Нет")}";
                    lblRecipe.ForeColor = drug.Need_Recipe ? Color.Green : Color.Black;

                    lblNarcotic.Text = $"Наркотический: {(drug.Is_Narcotic ? "Да" : "Нет")}";
                    lblNarcotic.ForeColor = drug.Is_Narcotic ? Color.Red : Color.Black;

                    lblVital.Text = $"Жизненно важный: {(drug.Is_Vital ? "Да" : "Нет")}";
                    lblVital.ForeColor = drug.Is_Vital ? Color.Red : Color.Black;
                }
            }
        }

        private void dgvMedications_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedItem = (DrugItem)dgvMedications.Rows[e.RowIndex].DataBoundItem;

                // Открываем форму изменения статуса
                using (var changeForm = new ChangeStatusForm(selectedItem.Item_Status, selectedItem.Written_Off_Reason))
                {
                    if (changeForm.ShowDialog() != DialogResult.OK) return;

                    if (DataHelper.UpdateDrugStatus(selectedItem.Uid, changeForm.SelectedStatus, changeForm.Comment))
                    {
                        selectedItem.Item_Status = changeForm.SelectedStatus;
                        selectedItem.Written_Off_Reason = changeForm.Comment;
                        UpdateDataSource();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при обновлении статуса", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
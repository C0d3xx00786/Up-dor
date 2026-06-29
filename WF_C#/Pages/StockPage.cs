using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WF_C_.Pages
{
    public partial class StockPage : UserControl
    {
        private BindingSource stockBindingSource = new BindingSource();
        public StockPage()
        {
            InitializeComponent();
            dgvMedications.AutoGenerateColumns = false;
            UpdateDataSource();
        }

        public void UpdateDataSource()
        {
            try
            {
                var filterstock = Data.data.Where(item => item.Item_Status != "sold").ToList();
                stockBindingSource.DataSource = filterstock;
                dgvMedications.DataSource = stockBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                lblItemStatus.ForeColor = AppConstants.GetColor(selectedItem.Item_Status);
                lblWrittenOffReason.ForeColor = AppConstants.GetColor(selectedItem.Item_Status);

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
                    lblRecipe.ForeColor = AppConstants.GetColorNeedRecipe(drug.Need_Recipe);

                    lblNarcotic.Text = $"Наркотический: {(drug.Is_Narcotic ? "Да" : "Нет")}";
                    lblNarcotic.ForeColor = AppConstants.GetColorIsNarcotic(drug.Is_Narcotic);

                    lblVital.Text = $"Жизненно важный: {(drug.Is_Vital ? "Да" : "Нет")}";
                    lblVital.ForeColor = AppConstants.GetColorIsVital(drug.Is_Vital);
                }
            }
        }

        private void dgvMedications_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string uid = dgvMedications.Rows[e.RowIndex].Cells["Uid"].Value?.ToString();

                if (string.IsNullOrEmpty(uid))
                    return;

                // Берем актуальные данные из Data.data
                var selectedItem = Data.data.FirstOrDefault(item => item.Uid == uid);

                if (selectedItem == null)
                    return;

                // Открываем форму изменения статуса
                using (var changeForm = new ChangeStatusForm(selectedItem.Item_Status, selectedItem.Written_Off_Reason))
                {
                    if (changeForm.ShowDialog() != DialogResult.OK) return;

                    if (DataHelper.UpdateDrugStatus(selectedItem.Uid, changeForm.SelectedStatus, changeForm.Comment))
                    {
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
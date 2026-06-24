using Dapper;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Up_Dor;

namespace WF_C_.Pages
{
    public partial class HistoryPage : UserControl
    {
        public HistoryPage()
        {
            InitializeComponent();

            // Отключаем автогенерацию, так как настроим колонки вручную в дизайнере
            dgvHistory.AutoGenerateColumns = false;

            dgvHistory.DataSource = Data.saledata;
        }

        // Метод загрузки истории продаж из БД
        public void UpdateDataSource()
        {
            try
            {
                // Пересчитываем выручку и прибыль на экране
                UpdateTotalStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Подсчет общей статистики по продажам внизу экрана
        private void UpdateTotalStats()
        {
            var list = Data.saledata;
            if (list != null)
            {
                decimal totalRevenue = list.Sum(item => item.Sold_Price);
                decimal totalProfit = list.Sum(item => item.Profit);

                lblTotalRevenue.Text = $"Общая выручка: {totalRevenue:F2} ₽";
                lblTotalProfit.Text = $"Чистая прибыль: {totalProfit:F2} ₽";
            }
        }

        // Выбор записи в таблице кликом мыши
        private void dgvHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedItem = (SaleHistoryItem)dgvHistory.Rows[e.RowIndex].DataBoundItem;

                if (selectedItem == null) return;

                lblUid.Text = $"UID: {selectedItem.Uid}";
                lblBarcode.Text = $"Штрихкод: {selectedItem.Barcode}";
                lblManufacturer.Text = $"Производитель: {selectedItem.Manufacturer}";
                lblSupplierBatch.Text = $"Серия поставщика: {selectedItem.Supplier_Batch}";
                lblExpirationDate.Text = $"Срок годности: {selectedItem.Expiration_Date:dd.MM.yyyy}";
                lblPurchasePrice.Text = $"Цена закупки: {selectedItem.Purchase_Price:F2} ₽";
                lblSoldPriceInfo.Text = $"Цена продажи: {selectedItem.Sold_Price:F2} ₽";

                // Вычисляем прибыль конкретной упаковки
                lblProfit.Text = $"Прибыль с пачки: {selectedItem.Profit:F2} ₽";
                lblProfit.ForeColor = selectedItem.Profit >= 0 ? Color.Green : Color.Red;

            }
        }
    }
}
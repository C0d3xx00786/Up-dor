using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

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

            UpdateTotalStats();
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

                var monthlyList = list.Where(x => x.Sale_Date >= DateTime.Now.AddMonths(-1)).ToList();

                decimal monthRevenue = monthlyList.Sum(item => item.Sold_Price);
                decimal monthProfit = monthlyList.Sum(item => item.Profit);

                // Заполняем функциональные строчки в pnlBottomStats согласно дизайнеру
                lblTotalRevenue.Text = $"Общая выручка: {totalRevenue:F2} ₽";

                lblCleanRevenue.Text = $"Чистая прибыль: {totalProfit:F2} ₽";
                lblCleanRevenue.ForeColor = totalProfit >= 0 ? AppConstants.Colors.SuccessGreen : AppConstants.Colors.DangerRed;

                lblTotalRevenueMonth.Text = $"Общая выручка за месяц: {monthRevenue:F2} ₽";

                lblCleanRevenueMonth.Text = $"Чистая прибыль за месяц: {monthProfit:F2} ₽";
                lblCleanRevenueMonth.ForeColor = monthProfit >= 0 ? AppConstants.Colors.SuccessGreen : AppConstants.Colors.DangerRed;
            }
        }

        // Выбор записи в таблице кликом мыши
        private void dgvHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvHistory.Rows[e.RowIndex].DataBoundItem is SaleHistoryItem selectedItem)
            {
                lblUid.Text = $"UID: {selectedItem.Uid}";
                lblBarcode.Text = $"Штрихкод: {selectedItem.Barcode}";
                lblSupplierBatch.Text = $"Номер партии: {selectedItem.Supplier_Batch ?? "-"}";
                lblPurchasePrice.Text = $"Цена закупки: {selectedItem.Purchase_Price:F2} ₽";
                lblSoldPriceInfo.Text = $"Цена продажи: {selectedItem.Sold_Price:F2} ₽";
                lbldateSell.Text = $"Дата продажи: {selectedItem.Sale_Date:dd.MM.yyyy HH:mm}";

                lblProfit.Text = $"Прибыль с пачки: {selectedItem.Profit:F2} ₽";
                lblProfit.ForeColor = selectedItem.Profit >= 0 ? AppConstants.Colors.SuccessGreen : AppConstants.Colors.DangerRed;

                // Информация о препарате (используем элвис-оператор ?. для защиты от null)
                var drug = selectedItem.DrugInfo;

                lblName.Text = $"Название: {(drug?.Name ?? "-")}";
                label1.Text = $"Производитель: {(drug?.Manufacturer ?? "-")}";

                // Настройка маркеров свойств (Рецепт, Наркотический, ЖНВЛП)
                bool needRecipe = drug?.Need_Recipe ?? false;
                lblRecipe.Text = $"Требует рецепт: {(needRecipe ? "Да" : "Нет")}";
                lblRecipe.ForeColor = AppConstants.GetColorNeedRecipe(needRecipe);

                bool isNarcotic = drug?.Is_Narcotic ?? false;
                lblNarcotic.Text = $"Наркотический: {(isNarcotic ? "Да" : "Нет")}";
                lblNarcotic.ForeColor = AppConstants.GetColorIsNarcotic(isNarcotic);

                bool isVital = drug?.Is_Vital ?? false;
                lblVital.Text = $"Жизненно важный: {(isVital ? "Да" : "Нет")}";
                lblVital.ForeColor = AppConstants.GetColorIsVital(isVital);

            }
        }
    }
}
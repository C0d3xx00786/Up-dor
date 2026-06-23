using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_C_;
using WF_C_.Pages;

namespace Up_Dor
{
    public partial class Main_Menu : Form
    {
        public static BindingList<DrugItem> data = new BindingList<DrugItem>();

        // Строка для подключенния к базе данных
        public static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\idimo\source\repos\WF_C#\WF_C#\DataBase\Drugs.mdf;Integrated Security=True";

        private Button selectedButton = null; // Выбранная страничка

        private Point dragCursorPoint; // координаты Курсора
        private Point dragFormPoint; // координаты формы для перемещенния

        public Main_Menu()
        {
            InitializeComponent();

            // Иконка приложения
            this.Icon = Properties.Resources.Ico;

            LoadDataAsync();
            UpdateStatusBar();
        }

        // Фоновая Загрузки базы данных
        private async void LoadDataAsync()
        {
            var loadingLabel = new Label
            {
                Text = "Загрузка данных...",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = AppConstants.Colors.Grey
            };
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(loadingLabel);

            btnRefresh.Enabled = false;

            try
            {
                await RefreshAllData();

                // Инициализируем страницы и привязываем их к тегам кнопок
                btnAutoOrders.Tag = new AutomaticOrdersPage();
                btnDeliveredGoods.Tag = new DeliveredGoodsPage();
                btnStockManagement.Tag = new StockPage();
                btnHistory.Tag = new HistoryPage();
                btnComplaints.Tag = new ComplaintsPage();
                btnOpenSales.Tag = new Sales();

                // Убираем надпись загрузки
                pnlContent.Controls.Remove(loadingLabel);

                // Открываем страницу склада по умолчанию
                SelectButton(btnStockManagement);
            }
            catch (Exception ex)
            {
                pnlContent.Controls.Remove(loadingLabel);

                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}\n\nПроверьте строку подключения к базе данных.",
                                "Критическая ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                btnRefresh.Enabled = true;
            }
        }

        // Обновление статус бара
        public void UpdateStatusBar()
        {
            if (data == null || data.Count == 0)
            {
                lblOverdue.Text = "🔴 Просрочено: 0 товаров";
                lblExpiring.Text = "🟡 Истекает срок: 0 товаров";
                return;
            }

            // Подсчет просроченных товаров (все, у кого срок годности меньше сегодня)
            int overdueCount = data.Count(item =>
                item.Item_Status != "sold" &&
                item.Expiration_Date.Date < DateTime.Now.Date);

            // Подсчет товаров, у которых срок истекает в ближайшие 30 дней
            int expiringCount = data.Count(item =>
                item.Item_Status != "sold" &&
                item.Expiration_Date.Date >= DateTime.Now.Date &&
                item.Expiration_Date.Date <= DateTime.Now.AddDays(30).Date);

            // Обновляем label'ы
            lblOverdue.Text = $"🔴 Просрочено: {overdueCount} товар{(overdueCount % 10 == 1 && overdueCount % 100 != 11 ? "" : "ов")}";
            lblExpiring.Text = $"🟡 Истекает срок: {expiringCount} товар{(expiringCount % 10 == 1 && expiringCount % 100 != 11 ? "" : "ов")}";

            // Меняем цвет, если есть просрочка
            lblOverdue.ForeColor = overdueCount > 0 ?
                AppConstants.Colors.DangerRed :
                AppConstants.Colors.Grey;
        }

        public static async Task RefreshAllData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT di.*, d.* FROM drug_items di 
                    INNER JOIN drugs d ON di.barcode = d.barcode";

                var result = await conn.QueryAsync<DrugItem, Drug, DrugItem>(
                    query,
                    (item, drug) => { item.DrugInfo = drug; return item; },
                    splitOn: "barcode"
                );

                var freshlist = result.ToList();

                data.Clear();
                foreach (var item in freshlist)
                {
                    data.Add(item);
                }
            }
        }

        // Изменение имени
        private void lblEmployee_DoubleClick(object sender, EventArgs e)
        {
            using (var change_form = new Change_Name(lblEmployee.Tag?.ToString()))
            {
                if (change_form.ShowDialog() == DialogResult.OK)
                {
                    lblEmployee.Text = $"👤 Фармацевт: {change_form.NewName}";
                    lblEmployee.Tag = change_form.NewName;
                    
                }
            }
        }

        // Закрытие приложения
        private void btnClose_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Вы хотите выйти из приложения?", "Завершить сеанс?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
            return;
        }

        // Скрыть
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Перемещение экрана
        //----------------------------------------------------
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }
        //----------------------------------------------------

        // Типо анимация
        //----------------------------------------------------
        private void ButtonMenuMouseEnter(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (b != selectedButton)
                b.BackColor = AppConstants.Colors.Hover;
        }
        private void ButtonMenuMouseLeave(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (b != selectedButton)
                b.BackColor = AppConstants.Colors.Default;
        }
        private void ButtonMenuClick(object sender, EventArgs e)
        {
            Button b = sender as Button;

            SelectButton(b);
        }
        private void SelectButton(Button b) {
            lblMenuTitle.Text = b.Text.Substring(2); // Изменения названия странички

            // Переход на страничку
            if(b.Tag is UserControl page)
            {
                pnlContent.Controls.Clear();

                page.Dock = DockStyle.Fill;

                pnlContent.Controls.Add(page);
            }

            if (b == btnOpenSales) {
                if (selectedButton != null)
                {
                    selectedButton.BackColor = AppConstants.Colors.Default;// Возращение к обычному стилю
                    selectedButton.ForeColor = AppConstants.Colors.DefaultFore;
                    selectedButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                    return;
                }
            }

            // Изменение цвета кнопки
            if (selectedButton != null)
            {
                selectedButton.BackColor = AppConstants.Colors.Default;// Возращение к обычному стилю
                selectedButton.ForeColor = AppConstants.Colors.DefaultFore;
                selectedButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            }

            selectedButton = b;

            // Стиль выбранной кнопки
            selectedButton.BackColor = AppConstants.Colors.Selected; // Стиль выбранной кнопки
            selectedButton.ForeColor = AppConstants.Colors.SelectedFore;
            selectedButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }
        //----------------------------------------------------

        // Кнопка покупки
        //----------------------------------------------------
        private void btnOpenSales_MouseEnter(object sender, EventArgs e)
        {
            btnOpenSales.BackColor = AppConstants.Colors.SuccessGreen;
            btnOpenSales.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        }

        private void btnOpenSales_MouseLeave(object sender, EventArgs e)
        {
            btnOpenSales.BackColor = AppConstants.Colors.PrimaryBlue;
            btnOpenSales.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        }
        //----------------------------------------------------

        // Обноление базы данных
        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshAllData();
                UpdateStatusBar();

                // Обновляем текущую страницу
                if (pnlContent.Controls.Count > 0 && pnlContent.Controls[0] is StockPage stockPage)
                {
                    stockPage.UpdateDataSource();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    // Модель для таблицы [drugs]
    public class Drug
    {
        public string Barcode { get; set; }
        public string Name { get; set; }
        public string Measurement_Unit { get; set; }
        public int Quantity_Per_Pack { get; set; }
        public string Manufacturer { get; set; }
        public bool Need_Recipe { get; set; }
        public string Pharmacologic_Group { get; set; }
        public bool Is_Narcotic { get; set; }
        public bool Is_Vital { get; set; }
        public string Storage_Location { get; set; }
    }

    // Модель для таблицы [drug_items]
    public class DrugItem
    {
        public string Uid { get; set; }
        //public string Barcode { get; set; }
        public decimal Purchase_Price { get; set; }
        public decimal Retail_Price { get; set; }
        public DateTime Expiration_Date { get; set; }
        public DateTime Receipt_Date { get; set; }
        public string Item_Status { get; set; }
        public string Written_Off_Reason { get; set; }
        public string Supplier_Batch { get; set; }

        // Важнейшее свойство: Ссылка на сам препарат, в который Dapper запишет данные
        public Drug DrugInfo { get; set; }

        public string Name_Item => DrugInfo?.Name ?? "-";
        public string Barcode => DrugInfo?.Barcode ?? "-";
        public string Measurement_Unit => DrugInfo?.Measurement_Unit ?? "-";
        public int Quantity_Per_Pack => DrugInfo?.Quantity_Per_Pack ?? 0;
        public string Manufacturer => DrugInfo?.Manufacturer ?? "-";
        public string Pharmacologic_Group => DrugInfo?.Pharmacologic_Group ?? "-";
        public string Storage_Location => DrugInfo?.Storage_Location ?? "-";
        public bool Need_Recipe => DrugInfo?.Need_Recipe ?? false;
        public bool Is_Narcotic => DrugInfo?.Is_Narcotic ?? false;
        public bool Is_Vital => DrugInfo?.Is_Vital ?? false;
    }
}

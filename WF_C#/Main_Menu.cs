using System;
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
        //[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        //public static extern bool SetWindowText(IntPtr hWnd, string lpString);
        //[DllImport("kernel32.dll")]
        //public static extern IntPtr GetConsoleWindow(); Изменение названия окна

        private Button selectedButton = null; // Выбранная страничка

        private Point dragCursorPoint; // координаты Курсора
        private Point dragFormPoint; // координаты формы для перемещенния

        public Main_Menu()
        {
            //SetWindowText(GetConsoleWindow(), "Up-Dor"); Изменение названия окна

            InitializeComponent();

            // Иконка приложения
            this.Icon = Properties.Resources.Ico;

            LoadDataAsync();
        }

        // Фоновая Загрузки базы данных
        public async Task LoadDataAsync()
        {
            if (pnlContent.Controls.Count == 0)
            {
                var loadingLabel = new Label()
                {
                    Text = "Загрузка данных...",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                    ForeColor = AppConstants.Colors.Grey
                };
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(loadingLabel);
            }

            btnRefresh.Enabled = false;

            try
            {
                await Data.EnsureDatabaseCreatedAsync();

                await Data.RefreshAllDataAsync();
                UpdateStatusBar();

                if (btnStockManagement.Tag == null)
                {
                    btnAutoOrders.Tag = new AutomaticOrdersPage();
                    btnDeliveredGoods.Tag = new DeliveredGoodsPage();
                    btnStockManagement.Tag = new StockPage();
                    btnHistory.Tag = new HistoryPage();
                    btnComplaints.Tag = new ComplaintsPage();
                    btnOpenSales.Tag = new Sales();
                }

                // Убираем надпись загрузки
                if (pnlContent.Controls[0] is Label label)
                {
                    pnlContent.Controls.Remove(label);
                    SelectButton(btnStockManagement);
                }
            }
            catch (Exception ex)
            {
                if (pnlContent.Controls[0] is Label label)
                    pnlContent.Controls.Remove(label);

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
            if (Data.data == null || Data.data.Count == 0)
            {
                lblOverdue.Text = "🔴 Просрочено: 0 товаров";
                lblExpiring.Text = "🟡 Истекает срок: 0 товаров";
                return;
            }

            if (Data.saledata == null || Data.saledata.Count == 0)
            {
                lblLastSale.Text = "🕐 Последняя продажа: --:--";
            }
            else {
                lblLastSale.Text = $"🕐 Последняя продажа: {Data.saledata.First().Sale_Date:HH:mm} ({Data.saledata.First().Name_Item})";
            }

            // Подсчет просроченных товаров (все, у кого срок годности меньше сегодня)
            int overdueCount = Data.data.Count(item =>
                item.Item_Status != "sold" &&
                item.Expiration_Date.Date < DateTime.Now.Date);

            // Подсчет товаров, у которых срок истекает в ближайшие 30 дней
            int expiringCount = Data.data.Count(item =>
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
        // Обноление базы данных
        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            try
            {
                await LoadDataAsync();

                // Обновляем текущую страницу
                if (pnlContent.Controls.Count > 0 && pnlContent.Controls[0] is StockPage stockPage) stockPage.UpdateDataSource();
                if (pnlContent.Controls.Count > 0 && pnlContent.Controls[0] is HistoryPage historyPage) historyPage.UpdateDataSource();
                if (pnlContent.Controls.Count > 0 && pnlContent.Controls[0] is ComplaintsPage complaintsPage) complaintsPage.UpdateDataSource();

                UpdateStatusBar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnRefresh.Enabled = true;
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
    }
}

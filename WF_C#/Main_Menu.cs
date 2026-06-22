using System;
using Dapper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WF_C_;
using WF_C_.Pages;

namespace Up_Dor
{
    public partial class Main_Menu : Form
    {
        public static List<DrugItem> data;
        // Строка для подключенния к базе данных
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\idimo\source\repos\WF_C#\WF_C#\DataBase\Drugs.mdf;Integrated Security=True";

        private Button selectedButton = null; // Выбранная страничка

        private Point dragCursorPoint; // координаты Курсора
        private Point dragFormPoint; // координаты формы для перемещенния

        private readonly Color defaultColor = Color.White;
        private readonly Color hoverColor = Color.FromArgb(240, 240, 240);
        private readonly Color selectedColor = Color.FromArgb(227, 242, 253);
        private readonly Color defaultForeColor = Color.FromArgb(50, 50, 50);
        private readonly Color selectedForeColor = Color.FromArgb(25, 118, 210);

        public Main_Menu()
        {
            LoadDataFromDatabase();
            InitializeComponent();
            // Иконка приложения
            this.Icon = Properties.Resources.Ico;
            // Связываем кнопку и страницу
            btnAutoOrders.Tag = new AutomaticOrdersPage();
            btnDeliveredGoods.Tag = new DeliveredGoodsPage();
            btnStockManagement.Tag = new StockPage();
            btnHistory.Tag = new HistoryPage();
            btnComplaints.Tag = new ComplaintsPage();

            SelectButton(btnStockManagement);
        }

        public void LoadDataFromDatabase() {
            string query = @"
                SELECT di.*, d.* FROM drug_items di
                INNER JOIN drugs d ON di.barcode = d.barcode";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    data = conn.Query<DrugItem, Drug, DrugItem>(
                        query,
                        (item, drug) =>
                        {
                            item.DrugInfo = drug; // Вкладываем объект Drug внутрь DrugItem
                            return item;
                        },
                        splitOn: "barcode"
                        ).ToList();
                }
            }
            catch (Exception ex)
            {
                var result = MessageBox.Show("Ошибка загрузки данных из БД:\n" + ex.Message + "\n\nПопробуйте позже или повторите попытку", "Ошибка", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry) {
                    LoadDataFromDatabase();
                }
        }}

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
            //var answer = MessageBox.Show("Если вы выйдите все данные будут потерянны." +
            //    "\nВы хотите выйти?", "Завершить сеанс?",
            //    MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Question);

            //if (answer == DialogResult.Yes)
            //{
                this.Close();
            //}
            //return;
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
                b.BackColor = hoverColor;
        }
        private void ButtonMenuMouseLeave(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (b != selectedButton)
                b.BackColor = defaultColor;
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

            // Изменение цвета кнопки
            if (selectedButton != null)
            {
                selectedButton.BackColor = defaultColor;// Возращение к обычному стилю
                selectedButton.ForeColor = defaultForeColor;
                selectedButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            }

            selectedButton = b;

            // Стиль выбранной кнопки
            selectedButton.BackColor = selectedColor; // Стиль выбранной кнопки
            selectedButton.ForeColor = selectedForeColor;
            selectedButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }
        //----------------------------------------------------

        // Кнопка покупки
        //----------------------------------------------------
        private void btnOpenSales_MouseEnter(object sender, EventArgs e)
        {
            btnOpenSales.BackColor = Color.FromArgb(46, 204, 113);
            btnOpenSales.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        }

        private void btnOpenSales_MouseLeave(object sender, EventArgs e)
        {
            btnOpenSales.BackColor = Color.FromArgb(25, 118, 210);
            btnOpenSales.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        }

        private void btnOpenSales_Click(object sender, EventArgs e)
        {
            using (var sales = new Sales()) {
                sales.ShowDialog();
            }
        }
        //----------------------------------------------------
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
        public string Barcode { get; set; }
        public decimal Purchase_Price { get; set; }
        public decimal Retail_Price { get; set; }
        public DateTime Expiration_Date { get; set; }
        public DateTime Receipt_Date { get; set; }
        public string Item_Status { get; set; }
        public string Written_Off_Reason { get; set; }
        public string Supplier_Batch { get; set; }

        // Важнейшее свойство: Ссылка на сам препарат, в который Dapper запишет данные
        public Drug DrugInfo { get; set; }
    }
}

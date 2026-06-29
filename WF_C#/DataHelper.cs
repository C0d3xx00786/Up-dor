using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_C_
{
    public static class DataHelper
    {
        // Переиспользуемый метод поиска по UID
        public static DrugItem FindDrugByUid(string uid)
        {
            if (string.IsNullOrWhiteSpace(uid) || Data.data == null)
                return null;

            return Data.data.FirstOrDefault(item =>
                item.Uid.Equals(uid, StringComparison.OrdinalIgnoreCase));
        }

        // Переиспользуемый метод обновления статуса
        public static bool UpdateDrugStatus(string uid, string status, string reason = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Data.connectionString))
                {
                    string query = @"UPDATE drug_items 
                                SET Item_Status = @Status, 
                                    Written_Off_Reason = @Reason 
                                WHERE Uid = @Uid";

                    var result = conn.Execute(query, new
                    {
                        Status = status,
                        Reason = reason ?? (object)DBNull.Value,
                        Uid = uid
                    });

                    if (result > 0)
                    {
                        // Обновляем объект в Data.data
                        var item = Data.data.FirstOrDefault(d => d.Uid == uid);
                        if (item != null)
                        {
                            item.Item_Status = status;
                            item.Written_Off_Reason = reason;
                        }
                        return true;
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool SellItems(IEnumerable<string> uids)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Data.connectionString))
                {
                    string query = "UPDATE drug_items SET Item_Status = 'sold' WHERE Uid IN @Uids";
                    var result = conn.Execute(query, new { Uids = uids });

                    if (result > 0)
                    {
                        //Обновление Data.data и Data.saledata
                        var uidList = uids.ToList();
                        var soldItems = Data.data.Where(item => uidList.Contains(item.Uid)).ToList();

                        foreach (var item in soldItems)
                        {
                            // Обновляем статус в Data.data
                            item.Item_Status = "sold";

                            // Добавляем запись в Data.saledata (в начало списка)
                            var saleRecord = new SaleHistoryItem
                            {
                                Uid = item.Uid,
                                Sale_Date = DateTime.Now,
                                Sold_Price = item.Retail_Price,
                                Purchase_Price = item.Purchase_Price,
                                Expiration_Date = item.Expiration_Date,
                                Supplier_Batch = item.Supplier_Batch,
                                DrugInfo = item.DrugInfo
                            };

                            Data.saledata.Insert(0, saleRecord);
                        }

                        return true;
                    }

                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool AddComplaint(ComplaintItem complaint)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Data.connectionString))
                {
                    string query = @"
                INSERT INTO [dbo].[complaints] 
                    (Uid, DrugName, DoctorName, RecipeDetails, PatientName, PatientContact, Comment, ComplaintDate, Status)
                VALUES 
                    (@Uid, @DrugName, @DoctorName, @RecipeDetails, @PatientName, @PatientContact, @Comment, @ComplaintDate, @Status);
                SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    int newId = conn.QuerySingle<int>(query, complaint);
                    complaint.Id = newId;

                    // Добавляем в список
                    Data.complaintsList.Insert(0, complaint);

                    // ❗ ПРЕДЛОЖИТЬ ПОСТАВИТЬ НА КАРАНТИН
                    var result = MessageBox.Show(
                        $"Жалоба на лекарство '{complaint.DrugName}' добавлена.\n\n" +
                        "Поставить товар на карантин? (Рекомендуется при серьёзных жалобах)",
                        "Внимание! Жалоба на лекарство",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        var drugItem = Data.data.FirstOrDefault(d => d.Uid == complaint.Uid);
                        if (drugItem != null && drugItem.Item_Status != "sold")
                        {
                            UpdateDrugStatus(complaint.Uid, "quarantined", "Карантин по жалобе №" + complaint.Id);
                            MessageBox.Show("Товар помещён на карантин.", "Готово",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Товар не найден или уже продан.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Ошибка при добавлении жалобы: {ex.Message}");
                return false;
            }
        }
        public static bool UpdateComplaintStatus(int id, string status, string comment = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Data.connectionString))
                {
                    string query = @"
                UPDATE [dbo].[complaints] 
                SET Status = @Status, Comment = @Comment 
                WHERE Id = @Id";

                    var result = conn.Execute(query, new
                    {
                        Status = status,
                        Comment = comment ?? (object)DBNull.Value,
                        Id = id
                    });

                    if (result > 0)
                    {
                        // Обновляем объект в Data.complaintsList
                        var item = Data.complaintsList.FirstOrDefault(c => c.Id == id);
                        if (item != null)
                        {
                            item.Status = status;
                            item.Comment = comment;
                        }
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Ошибка при обновлении статуса жалобы: {ex.Message}");
                return false;
            }
        }
    }
    // Наши данные
    public class Data {
        public static BindingList<DrugItem> data = new BindingList<DrugItem>();
        public static BindingList<SaleHistoryItem> saledata = new BindingList<SaleHistoryItem>();
        public static BindingList<ComplaintItem> complaintsList = new BindingList<ComplaintItem>();

        // Строка для подключенния к базе данных
        public static readonly string connectionString =
            $@"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename={AppDomain.CurrentDomain.BaseDirectory}DataBase\Drugs.mdf;
            Integrated Security=True;";

        public static async Task RefreshAllDataAsync()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT di.*, d.* FROM drug_items di 
                    INNER JOIN drugs d ON di.barcode = d.barcode;
                ";
                // EXEC DeleteOldItems; Можно добавить чтобы удалять записи давностью 6 месяцев

                var drugsResult = (await conn.QueryAsync<DrugItem, Drug, DrugItem>(
                    query,
                    (item, drug) => { item.DrugInfo = drug; return item; },
                    splitOn: "barcode"
                )).ToList();
                // Второй запрос
                query = @"
                SELECT 
                    sh.sale_id AS Sale_Id,
                    sh.uid AS Uid,
                    sh.sale_date AS Sale_Date,
                    sh.sold_price AS Sold_Price,
                    di.purchase_price AS Purchase_Price,
                    di.supplier_batch AS Supplier_Batch,
                    d.*
                FROM [dbo].[sales_history] sh
                INNER JOIN [dbo].[drug_items] di ON sh.uid = di.uid
                INNER JOIN [dbo].[drugs] d ON di.barcode = d.barcode
                ORDER BY sh.sale_date DESC";

                var salesResult = (await conn.QueryAsync<SaleHistoryItem, Drug, SaleHistoryItem>(
                    query,
                    (sale, drug) =>
                    {
                        sale.DrugInfo = drug;
                        return sale;
                    },
                    splitOn: "barcode"
                )).ToList();

                query = "SELECT * FROM [dbo].[complaints] ORDER BY ComplaintDate DESC";
                var complaintsResult = conn.Query<ComplaintItem>(query).ToList();

                data.Clear();
                foreach (var item in drugsResult) data.Add(item);

                saledata.Clear();
                foreach (var item in salesResult) saledata.Add(item);

                complaintsList.Clear();
                foreach (var item in complaintsResult) complaintsList.Add(item);
            }
        }
        public static async Task EnsureDatabaseCreatedAsync()
        {
            string databasePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "DataBase",
                "Drugs.mdf");

            if (!File.Exists(databasePath))
            {
                try
                {
                    await Task.Run(() => CreateDatabase());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Ошибка при создании базы данных:\n{ex.Message}",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private static void CreateDatabase()
        {
            string databasePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "DataBase",
                "Drugs.mdf");

            string logPath = Path.ChangeExtension(databasePath, "_log.ldf");

            Directory.CreateDirectory(Path.GetDirectoryName(databasePath));

            // Подключаемся к master
            string masterConnection =
                @"Data Source=(LocalDB)\MSSQLLocalDB;
              Initial Catalog=master;
              Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(masterConnection))
            {
                connection.Open();

                string createDatabaseSql = $@"
                    CREATE DATABASE Drugs
                    ON PRIMARY
                    (
                        NAME = Drugs,
                        FILENAME = '{databasePath}'
                    )
                    LOG ON
                    (
                        NAME = Drugs_log,
                        FILENAME = '{logPath}'
                    );";

                using (SqlCommand command = new SqlCommand(createDatabaseSql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            // Выполняем CreateDatabase.sql
            string scriptPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "DataBase",
                "CreateDatabase.sql");

            string script = File.ReadAllText(scriptPath);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (string commandText in script.Split(
                             new[] { "GO", "Go", "go" },
                             StringSplitOptions.RemoveEmptyEntries))
                {
                    if (string.IsNullOrWhiteSpace(commandText))
                        continue;

                    using (SqlCommand command = new SqlCommand(commandText, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
    public static class AppConstants
    {
        public static class Colors
        {
            public static readonly Color Default = Color.White;
            public static readonly Color Hover = Color.FromArgb(240, 240, 240);
            public static readonly Color Selected = Color.FromArgb(227, 242, 253);
            public static readonly Color DefaultFore = Color.FromArgb(50, 50, 50);
            public static readonly Color SelectedFore = Color.FromArgb(25, 118, 210);
            public static readonly Color PrimaryBlue = Color.FromArgb(25, 118, 210);
            public static readonly Color SuccessGreen = Color.FromArgb(46, 204, 113);
            public static readonly Color DangerRed = Color.FromArgb(220, 50, 50);
            public static readonly Color WarningYellow = Color.FromArgb(200, 150, 0);
            public static readonly Color Grey = Color.FromArgb(120, 120, 120);
        }
        public static Color GetColor(string status)
        {
            switch (status)
            {
                case "in_stock":
                    return Color.Black;
                case "sold":
                    return Color.Green;
                case "written_off":
                    return Color.Red;
                case "quarantined":
                    return Color.Blue;
                case "reserved":
                    return Color.OrangeRed;
                default:
                    return Color.Black;
            }
        }
        public static Color GetColorNeedRecipe(bool status)
        {
            return status ? AppConstants.Colors.DangerRed : AppConstants.Colors.SuccessGreen;
        }
        public static Color GetColorIsNarcotic(bool status)
        {
            return status ? AppConstants.Colors.DangerRed : Color.Black;
        }
        public static Color GetColorIsVital(bool status)
        {
            return status ? AppConstants.Colors.WarningYellow : Color.Black;
        }
    }
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
        public decimal Retail_Price{ get; set; }
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
    // Модель для таблицы [sales_history]
    public class SaleHistoryItem
    {
        // Первичные данные самой продажи
        public int Sale_Id { get; set; }
        public string Uid { get; set; }
        public DateTime Sale_Date { get; set; }
        public decimal Sold_Price { get; set; }
        public decimal Purchase_Price { get; set; }
        public DateTime Expiration_Date { get; set; }
        public string Supplier_Batch { get; set; }
        public Drug DrugInfo { get; set; }

        // Вычисляемые свойства для удобного отображения (например, в DataGridView)
        public string Name_Item => DrugInfo?.Name ?? "-";
        public string Barcode => DrugInfo?.Barcode ?? "-";
        public string Manufacturer => DrugInfo?.Manufacturer ?? "-";

        // Свойство вычисления чистой прибыли
        public decimal Profit => Sold_Price - Purchase_Price;
    }
    // Класс для элементов корзины
    public class CartItem
    {
        public string Uid { get; set; }
        public string Name_Item { get; set; }
        public string Barcode { get; set; }
        public decimal Retail_Price { get; set; }
        public DateTime Expiration_Date { get; set; }
        public bool Need_recipe { get; set; }
        public bool Is_narcotic { get; set; }
        public DrugItem DrugItem { get; set; }
    }
    // Класс для таблицы жалоб
    public class ComplaintItem
    {
        public int Id { get; set; }
        public string Uid { get; set; }              // UID лекарства (связь с drug_items)
        public string DrugName { get; set; }         // Название
        public string DoctorName { get; set; }
        public string RecipeDetails { get; set; }    // Реквизиты рецепта
        public string PatientName { get; set; }
        public string PatientContact { get; set; }   // Телефон / адрес
        public string Comment { get; set; }
        public DateTime ComplaintDate { get; set; }
        public string Status { get; set; }           // "Новая", "Отправлена", "Закрыта"
    }
}

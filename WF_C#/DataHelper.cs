using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Up_Dor;

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

        // Переиспользуемый метод проверки статуса
        public static bool IsDrugAvailable(string uid)
        {
            var item = FindDrugByUid(uid);
            return item != null && item.Item_Status ==  AppConstants.Statuses.InStock;
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

                    return result > 0;
                }
            }
            catch
            {
                return false;
            }
        }
    }
    // Наши данные
    public class Data {
        public static BindingList<DrugItem> data = new BindingList<DrugItem>();
        public static BindingList<SaleHistoryItem> saledata = new BindingList<SaleHistoryItem>();

        // Строка для подключенния к базе данных
        public static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\idimo\source\repos\WF_C#\WF_C#\DataBase\Drugs.mdf;Integrated Security=True";

        public static async Task RefreshAllData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT di.*, d.* FROM drug_items di 
                    INNER JOIN drugs d ON di.barcode = d.barcode;
                ";

                // EXEC DeleteOldItems; Можно добавить чтобы удалять записи давностью 6 месяцев

                var result = conn.Query<DrugItem, Drug, DrugItem>(
                    query,
                    (item, drug) => { item.DrugInfo = drug; return item; },
                    splitOn: "barcode"
                ).ToList();

                data.Clear();
                foreach (var item in result)
                {
                    data.Add(item);
                }

                // Обновление истории

                query = @"
                SELECT 
                    sh.sale_id AS Sale_Id,
                    sh.uid AS Uid,
                    sh.sale_date AS Sale_Date,
                    sh.sold_price AS Sold_Price,
                    di.purchase_price AS Purchase_Price,
                    di.expiration_date AS Expiration_Date,
                    di.supplier_batch AS Supplier_Batch,
                    d.*
                FROM [dbo].[sales_history] sh
                INNER JOIN [dbo].[drug_items] di ON sh.uid = di.uid
                INNER JOIN [dbo].[drugs] d ON di.barcode = d.barcode
                ORDER BY sh.sale_date DESC";

                // Используем мульти-маппинг, чтобы заполнить DrugInfo
                var list = conn.Query<SaleHistoryItem, Drug, SaleHistoryItem>(
                    query,
                    (sale, drug) =>
                    {
                        sale.DrugInfo = drug;
                        return sale;
                    },
                    splitOn: "barcode"
                ).ToList();

                // Очищаем старые данные из кэша и заливаем новые
                saledata.Clear();
                foreach (var item in list)
                {
                    saledata.Add(item);
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

        public static class Statuses
        {
            public const string InStock = "in_stock";
            public const string Sold = "sold";
            public const string WrittenOff = "written_off";
            public const string Quarantined = "quarantined";
            public const string Reserved = "reserved";

            public static Color GetColor(string status)
            {
                switch (status)
                {
                    case InStock:
                        return Color.Black;
                    case Sold:
                        return Color.Green;
                    case WrittenOff:
                        return Color.Red;
                    case Quarantined:
                        return Color.Blue;
                    case Reserved:
                        return Color.OrangeRed;
                    default:
                        return Color.Black;
                }
            }
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
}

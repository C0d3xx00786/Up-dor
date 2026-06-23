using Dapper;
using System;
using System.Collections.Generic;
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
            if (string.IsNullOrWhiteSpace(uid) || Main_Menu.data == null)
                return null;

            return Main_Menu.data.FirstOrDefault(item =>
                item.Uid.Equals(uid, StringComparison.OrdinalIgnoreCase));
        }

        // Переиспользуемый метод проверки статуса
        public static bool IsDrugAvailable(string uid)
        {
            var item = FindDrugByUid(uid);
            return item != null && item.Item_Status == "in_stock" && item.Item_Status == "written_off";
        }

        // Переиспользуемый метод обновления статуса
        public static bool UpdateDrugStatus(string uid, string status, string reason = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Main_Menu.connectionString))
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
}

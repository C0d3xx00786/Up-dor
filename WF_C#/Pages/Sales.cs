using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Up_Dor;

namespace WF_C_
{
    public partial class Sales : UserControl
    {
        // Корзина покупок
        private BindingList<CartItem> cartItems = new BindingList<CartItem>();

        public Sales()
        {
            InitializeComponent();

            dgvCart.AutoGenerateColumns = false;

            dgvCart.DataSource = cartItems;

            UpdateTotal();
            txtUid.Focus();
        }

        //Просмотр информации
        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < cartItems.Count)
            {
                string uid = cartItems[e.RowIndex].Uid;
                var item = DataHelper.FindDrugByUid(uid);
                DisplayItemInfo(item);
            }
        }

        //Удаление из корзины
        private void dgvCart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < cartItems.Count)
            {
                var answer = MessageBox.Show("Вы уверены что хотите удалить товар?",
                        "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (answer == DialogResult.Yes)
                {
                    cartItems.RemoveAt(e.RowIndex);
                    UpdateTotal();
                    ClearItemInfo();
                }
            }
        }

        // Обработка ввода UID
        private void txtUid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                AddToCart();
            }
        }

        // Кнопка добавления в корзину
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            AddToCart();
        }

        // Кнопка продажи
        private void btnSell_Click(object sender, EventArgs e)
        {
            if (cartItems.Count == 0)
            {
                MessageBox.Show("Корзина пуста! Добавьте товары для продажи.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Проверка на рецептурные и наркотические товары
            var recipeItems = cartItems.Where(item => item.DrugItem?.DrugInfo?.Need_Recipe == true).ToList();
            var narcoticItems = cartItems.Where(item => item.DrugItem?.DrugInfo?.Is_Narcotic == true).ToList();

            string warnings = "";

            if (narcoticItems.Count > 0)
            {
                warnings += $"⚠️ ВНИМАНИЕ! В корзине {narcoticItems.Count} НАРКОТИЧЕСКИХ препаратов:\n";
                warnings += string.Join("\n", narcoticItems.Select(i => $"  - {i.Name_item} (UID: {i.Uid})"));
                warnings += "\n\nТребуется специальный учет!\n\n";
            }

            if (recipeItems.Count > 0)
            {
                warnings += $"📋 В корзине {recipeItems.Count} РЕЦЕПТУРНЫХ препаратов:\n";
                warnings += string.Join("\n", recipeItems.Select(i => $"  - {i.Name_item} (UID: {i.Uid})"));
                warnings += "\n\nТребуется рецепт!\n\n";
            }

            // Проверка на просрочку
            var expiredItems = cartItems.Where(item => item.Expiration_Date < DateTime.Now).ToList();
            if (expiredItems.Count > 0)
            {
                warnings += $"❌ ВНИМАНИЕ! {expiredItems.Count} просроченных товаров:\n";
                warnings += string.Join("\n", expiredItems.Select(i => $"  - {i.Name_item} (UID: {i.Uid})"));
                warnings += "\n\nПродажа просроченных товаров запрещена!\n\n";
            }

            if (!string.IsNullOrEmpty(warnings))
            {
                warnings += "Продолжить продажу?";
                var result = MessageBox.Show(warnings, "Внимание! Проверка товаров", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                    return;
            }

            // Выполнение продажи
            try
            {
                using (SqlConnection conn = new SqlConnection(Main_Menu.connectionString))
                {
                    conn.Open();

                    var uidsToSell = cartItems.Select(item => item.Uid).ToArray();

                    string query = "UPDATE drug_items SET Item_Status = 'sold' WHERE Uid IN @Uids";
                    conn.Execute(query, new { Uids = uidsToSell });
                }

                decimal total = cartItems.Sum(item => item.Retail_Price);

                // Обновление данных в памяти
                foreach (var item in cartItems)
                {
                    var drugItem = Main_Menu.data.FirstOrDefault(d => d.Uid == item.Uid);
                    if (drugItem != null)
                    {
                        drugItem.Item_Status = "sold";
                    }
                }

                // Очистка корзины
                cartItems.Clear();
                //UpdateCartGrid();
                ClearItemInfo();

                // Обновление статус-бара через главное меню
                if (this.ParentForm is Main_Menu mainMenu)
                {
                    mainMenu.UpdateStatusBar();
                }

                MessageBox.Show($"Продажа успешно завершена!\nСумма: {total:F2} ₽",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtUid.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при продаже:\n{ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Кнопка очистки корзины
        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (cartItems.Count == 0)
                return;

            var result = MessageBox.Show("Очистить корзину? Все товары будут удалены.",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                cartItems.Clear();
                ClearItemInfo();
            }
        }

        // Очистка полей информации
        private void ClearItemInfo()
        {
            lblInfoUid.Text = "UID: -";
            lblInfoName.Text = "Название: -";
            lblInfoBarcode.Text = "Штрихкод: -";
            lblInfoPrice.Text = "Цена: -";
            lblInfoExpiration.Text = "Годен до: -";
            lblInfoStatus.Text = "Статус: -";
            lblInfoRecipe.Text = "Требует рецепт: -";
            lblInfoNarcotic.Text = "Наркотическое: -";
            lblInfoVital.Text = "Жизненно важный: -";
            lblInfoManufacturer.Text = "Производитель: -";
            lblInfoGroup.Text = "Фарм. группа: -";
            lblInfoStorage.Text = "Место хранения: -";
            lblInfoBatch.Text = "Партия: -";
        }

        // Отображение информации о товаре
        private void DisplayItemInfo(DrugItem item)
        {
            if (item == null)
            {
                ClearItemInfo();
                return;
            }

            lblInfoUid.Text = $"UID: {item.Uid}";
            lblInfoName.Text = $"Название: {item.Name}";
            lblInfoBarcode.Text = $"Штрихкод: {item.Barcode}";
            lblInfoPrice.Text = $"Цена: {item.Retail_Price:F2} ₽";
            lblInfoExpiration.Text = $"Годен до: {item.Expiration_Date.ToShortDateString()}";
            lblInfoExpiration.ForeColor = item.Expiration_Date < DateTime.Now ? Color.Red : Color.Black;
            lblInfoStatus.Text = $"Статус: {item.Item_Status}";

            if (item.DrugInfo != null)
            {
                var drug = item.DrugInfo;
                lblInfoRecipe.Text = $"Требует рецепт: {(drug.Need_Recipe ? "ДА" : "Нет")}";
                lblInfoRecipe.ForeColor = drug.Need_Recipe ? Color.Green : Color.Black;

                lblInfoNarcotic.Text = $"Наркотическое: {(drug.Is_Narcotic ? "ДА" : "Нет")}";
                lblInfoNarcotic.ForeColor = drug.Is_Narcotic ? Color.Red : Color.Black;

                lblInfoVital.Text = $"Жизненно важный: {(drug.Is_Vital ? "ДА" : "Нет")}";
                lblInfoVital.ForeColor = drug.Is_Vital ? Color.Red : Color.Black;

                lblInfoManufacturer.Text = $"Производитель: {drug.Manufacturer ?? "-"}";
                lblInfoGroup.Text = $"Фарм. группа: {drug.Pharmacologic_Group ?? "-"}";
                lblInfoStorage.Text = $"Место хранения: {drug.Storage_Location ?? "-"}";
                lblInfoBatch.Text = $"Партия: {item.Supplier_Batch ?? "-"}";
            }
        }

        // Добавление товара в корзину
        private void AddToCart()
        {
            string uid = txtUid.Text.Trim();

            if (string.IsNullOrEmpty(uid))
                return;

            var item = DataHelper.FindDrugByUid(uid);

            if (item == null)
            {
                MessageBox.Show("Товар не найден!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка на просрочку
            if (item.Expiration_Date < DateTime.Now)
            {
                MessageBox.Show($"Товар {item.Name} просрочен!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка статуса
            if (item.Item_Status != "in_stock")
            {
                MessageBox.Show($"Товар {item.Name} не доступен для продажи (статус: {item.Item_Status})",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка на дубликат
            if (cartItems.Any(c => c.Uid == item.Uid))
            {
                MessageBox.Show($"Товар {item.Name} уже добавлен в корзину!",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            cartItems.Add(new CartItem
            {
                Uid = item.Uid,
                Name_item = item.Name,
                Barcode = item.Barcode,
                Retail_Price = item.Retail_Price,
                Expiration_Date = item.Expiration_Date,
                Need_recipe = item.DrugInfo?.Need_Recipe ?? false,
                Is_narcotic = item.DrugInfo?.Is_Narcotic ?? false,
                DrugItem = item
            });

            DisplayItemInfo(item);
            UpdateTotal();

            txtUid.Clear();
            txtUid.Focus();
        }

        // Обновление итоговой суммы
        private void UpdateTotal()
        {
            decimal total = cartItems.Sum(item => item.Retail_Price);
            lblTotal.Text = $"Итого: {total:F2} ₽";
            lblItemsCount.Text = $"Товаров: {cartItems.Count}";
        }

        // Класс для элементов корзины
        public class CartItem
        {
            public string Uid { get; set; }
            public string Name_item { get; set; }
            public string Barcode { get; set; }
            public decimal Retail_Price { get; set; }
            public DateTime Expiration_Date { get; set; }
            public bool Need_recipe { get; set; }
            public bool Is_narcotic { get; set; }
            public DrugItem DrugItem { get; set; }
        }
    }
}
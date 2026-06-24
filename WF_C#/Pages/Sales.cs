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
                warnings += string.Join("\n", narcoticItems.Select(i => $"  - {i.Name} (UID: {i.Uid})"));
                warnings += "\n\nТребуется специальный учет!\n\n";
            }

            if (recipeItems.Count > 0)
            {
                warnings += $"📋 В корзине {recipeItems.Count} РЕЦЕПТУРНЫХ препаратов:\n";
                warnings += string.Join("\n", recipeItems.Select(i => $"  - {i.Name} (UID: {i.Uid})"));
                warnings += "\n\nТребуется рецепт!\n\n";
            }

            // Проверка на просрочку
            var expiredItems = cartItems.Where(item => item.Expiration_Date < DateTime.Now).ToList();
            if (expiredItems.Count > 0)
            {
                warnings += $"❌ ВНИМАНИЕ! {expiredItems.Count} просроченных товаров:\n";
                warnings += string.Join("\n", expiredItems.Select(i => $"  - {i.Name} (UID: {i.Uid})"));
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
                var uidsToSell = cartItems.Select(item => item.Uid).ToArray();

                // Вызываем метод из DataHelper
                if (!DataHelper.SellItems(uidsToSell))
                {
                    MessageBox.Show("Ошибка при сохранении продажи в базу данных.", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal total = cartItems.Sum(item => item.Retail_Price);

                // Обновление данных в памяти
                foreach (var item in cartItems)
                {
                    var drugItem = Data.data.FirstOrDefault(d => d.Uid == item.Uid);
                    if (drugItem != null)
                    {
                        drugItem.Item_Status = "sold";
                    }

                    Data.saledata.Insert(0, new SaleHistoryItem
                    {
                        Uid = item.Uid,
                        Sale_Date = DateTime.Now,
                        Sold_Price = item.Retail_Price,
                        Purchase_Price = item.DrugItem.Purchase_Price,
                        Expiration_Date = item.Expiration_Date,
                        Supplier_Batch = item.DrugItem.Supplier_Batch,
                        DrugInfo = item.DrugItem.DrugInfo
                    });
                }

                // Очистка корзины
                cartItems.Clear();
                ClearItemInfo();

                // Обновление статус-бара через главное меню
                if (this.ParentForm is Main_Menu mainMenu)
                {
                    mainMenu.LoadDataAsync();
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
                UpdateTotal();
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
            lblInfoExpiration.ForeColor = Color.Black;
            lblInfoStatus.Text = "Статус: -";
            lblInfoRecipe.Text = "Требует рецепт: -";
            lblInfoRecipe.ForeColor = Color.Black;
            lblInfoNarcotic.Text = "Наркотическое: -";
            lblInfoNarcotic.ForeColor = Color.Black;
            lblInfoVital.Text = "Жизненно важный: -";
            lblInfoVital.ForeColor = Color.Black;
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
            lblInfoName.Text = $"Название: {item.Name_Item}";
            lblInfoBarcode.Text = $"Штрихкод: {item.Barcode}";
            lblInfoPrice.Text = $"Цена: {item.Retail_Price:F2} ₽";
            lblInfoExpiration.Text = $"Годен до: {item.Expiration_Date.ToShortDateString()}";
            lblInfoExpiration.ForeColor = item.Expiration_Date < DateTime.Now ? AppConstants.Colors.DangerRed : Color.Black;
            lblInfoStatus.Text = $"Статус: {item.Item_Status}";

            if (item.DrugInfo != null)
            {
                var drug = item.DrugInfo;
                lblInfoRecipe.Text = $"Требует рецепт: {(drug.Need_Recipe ? "ДА" : "Нет")}";
                lblInfoRecipe.ForeColor = drug.Need_Recipe ? AppConstants.Colors.DangerRed : AppConstants.Colors.SuccessGreen;

                lblInfoNarcotic.Text = $"Наркотическое: {(drug.Is_Narcotic ? "ДА" : "Нет")}";
                lblInfoNarcotic.ForeColor = drug.Is_Narcotic ? AppConstants.Colors.DangerRed : Color.Black;

                lblInfoVital.Text = $"Жизненно важный: {(drug.Is_Vital ? "ДА" : "Нет")}";
                lblInfoVital.ForeColor = drug.Is_Vital ? AppConstants.Colors.WarningYellow : Color.Black;

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
                MessageBox.Show($"Товар {item.Name_Item} просрочен!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка статуса
            if (item.Item_Status != "in_stock" && item.Item_Status != "reserved")
            {
                MessageBox.Show($"Товар {item.Name_Item} не доступен для продажи (статус: {item.Item_Status})",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка на дубликат
            if (cartItems.Any(c => c.Uid == item.Uid))
            {
                MessageBox.Show($"Товар {item.Name_Item} уже добавлен в корзину!",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            cartItems.Add(new CartItem
            {
                Uid = item.Uid,
                Name = item.Name_Item,
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
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_C_;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Up_Dor
{
    public partial class Main_Menu : Form
    {
        Change_Name change_form;
        Sales sales;
        private Button selectedButton = null;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private Color defaultColor = Color.White;
        private Color hoverColor = Color.FromArgb(240, 240, 240);
        private Color selectedColor = Color.FromArgb(227, 242, 253);
        private Color defaultForeColor = Color.FromArgb(50, 50, 50);
        private Color selectedForeColor = Color.FromArgb(25, 118, 210);

        public Main_Menu()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.Ico;

            SelectButton(flowMenu.Controls[2] as Button);
        }

        private void AddMenuButton(string text, string pageKey)
        {
            //MenuButton btn = new MenuButton(text, pageKey, navigationManager);
            //flowMenu.Controls.Add(btn);
        }

        // Изменение имени
        private void lblEmployee_DoubleClick(object sender, EventArgs e)
        {
            using (change_form = new Change_Name(lblEmployee.Tag?.ToString()))
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
            var answer = MessageBox.Show("Если вы выйдите все данные будут потерянны." +
                "\nВы хотите выйти?", "Завершить сеанс?",
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
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }
        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        //----------------------------------------------------

        // Типо анимация
        //----------------------------------------------------
        private void MouseEnter(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b.BackColor != selectedColor)
                b.BackColor = hoverColor;
        }
        private void MouseLeave(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b.BackColor != selectedColor)
                b.BackColor = defaultColor;
        }
        private void Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            //if (!string.IsNullOrEmpty(PageKey) && NavigationManager != null)
            //{
            //    NavigationManager.NavigateTo(PageKey);
            SelectButton(b);
            //}
        }
        private void SelectButton(Button b) {
            if (selectedButton != null)
            {
                selectedButton.BackColor = defaultColor;
                selectedButton.ForeColor = defaultForeColor;
                selectedButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            }

            selectedButton = b;
            if (selectedButton != null)
            {
                selectedButton.BackColor = selectedColor;
                selectedButton.ForeColor = selectedForeColor;
                selectedButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
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
            sales = new Sales();
            sales.ShowDialog();
        }
        //----------------------------------------------------
    }
}

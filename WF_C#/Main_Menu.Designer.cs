using System.Drawing;
using System.Windows.Forms;
using WF_C_.Pages;

namespace Up_Dor
{
    partial class Main_Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblAppIcon = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.flowMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.btnAutoOrders = new System.Windows.Forms.Button();
            this.btnDeliveredGoods = new System.Windows.Forms.Button();
            this.btnStockManagement = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnComplaints = new System.Windows.Forms.Button();
            this.pnlMenuHeader = new System.Windows.Forms.Panel();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.btnOpenSales = new System.Windows.Forms.Button();
            this.panelWork = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblExpiring = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblOverdue = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLastSale = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.flowMenu.SuspendLayout();
            this.pnlMenuHeader.SuspendLayout();
            this.panelWork.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.panelTop.Controls.Add(this.lblAppIcon);
            this.panelTop.Controls.Add(this.lblAppTitle);
            this.panelTop.Controls.Add(this.lblEmployee);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1384, 50);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // lblAppIcon
            // 
            this.lblAppIcon.AutoSize = true;
            this.lblAppIcon.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAppIcon.ForeColor = System.Drawing.Color.White;
            this.lblAppIcon.Location = new System.Drawing.Point(15, 10);
            this.lblAppIcon.Name = "lblAppIcon";
            this.lblAppIcon.Size = new System.Drawing.Size(43, 30);
            this.lblAppIcon.TabIndex = 0;
            this.lblAppIcon.Text = "💊";
            this.lblAppIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.lblAppIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(64, 15);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(244, 21);
            this.lblAppTitle.TabIndex = 1;
            this.lblAppTitle.Text = "Аптека «Ап-Дор» — ИС v.1.0.0";
            this.lblAppTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.lblAppTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // lblEmployee
            // 
            this.lblEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployee.AutoEllipsis = true;
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.lblEmployee.Location = new System.Drawing.Point(1020, 15);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(199, 19);
            this.lblEmployee.TabIndex = 2;
            this.lblEmployee.Tag = "Петрова М. И.";
            this.lblEmployee.Text = "👤 Фармацевт: Петрова М. И.";
            this.lblEmployee.DoubleClick += new System.EventHandler(this.lblEmployee_DoubleClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1234, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(50, 50);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "🔄";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1284, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 50);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.Text = "─";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1334, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Controls.Add(this.flowMenu);
            this.panelLeft.Controls.Add(this.pnlMenuHeader);
            this.panelLeft.Controls.Add(this.btnOpenSales);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 50);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(220, 702);
            this.panelLeft.TabIndex = 1;
            // 
            // flowMenu
            // 
            this.flowMenu.BackColor = System.Drawing.Color.White;
            this.flowMenu.Controls.Add(this.lblSeparator);
            this.flowMenu.Controls.Add(this.btnAutoOrders);
            this.flowMenu.Controls.Add(this.btnDeliveredGoods);
            this.flowMenu.Controls.Add(this.btnStockManagement);
            this.flowMenu.Controls.Add(this.btnHistory);
            this.flowMenu.Controls.Add(this.btnComplaints);
            this.flowMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowMenu.Location = new System.Drawing.Point(0, 60);
            this.flowMenu.Name = "flowMenu";
            this.flowMenu.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.flowMenu.Size = new System.Drawing.Size(220, 582);
            this.flowMenu.TabIndex = 1;
            this.flowMenu.WrapContents = false;
            // 
            // lblSeparator
            // 
            this.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator.Location = new System.Drawing.Point(20, 5);
            this.lblSeparator.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(182, 1);
            this.lblSeparator.TabIndex = 4;
            // 
            // btnAutoOrders
            // 
            this.btnAutoOrders.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAutoOrders.FlatAppearance.BorderSize = 0;
            this.btnAutoOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoOrders.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAutoOrders.Location = new System.Drawing.Point(3, 9);
            this.btnAutoOrders.Name = "btnAutoOrders";
            this.btnAutoOrders.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAutoOrders.Size = new System.Drawing.Size(210, 45);
            this.btnAutoOrders.TabIndex = 0;
            this.btnAutoOrders.Text = "🔄 Автозаказы";
            this.btnAutoOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutoOrders.Click += new System.EventHandler(this.ButtonMenuClick);
            this.btnAutoOrders.MouseEnter += new System.EventHandler(this.ButtonMenuMouseEnter);
            this.btnAutoOrders.MouseLeave += new System.EventHandler(this.ButtonMenuMouseLeave);
            // 
            // btnDeliveredGoods
            // 
            this.btnDeliveredGoods.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDeliveredGoods.FlatAppearance.BorderSize = 0;
            this.btnDeliveredGoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeliveredGoods.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeliveredGoods.Location = new System.Drawing.Point(3, 60);
            this.btnDeliveredGoods.Name = "btnDeliveredGoods";
            this.btnDeliveredGoods.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDeliveredGoods.Size = this.btnAutoOrders.Size;
            this.btnDeliveredGoods.TabIndex = 1;
            this.btnDeliveredGoods.Text = "📦 Доставленные грузы";
            this.btnDeliveredGoods.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeliveredGoods.Click += new System.EventHandler(this.ButtonMenuClick);
            this.btnDeliveredGoods.MouseEnter += new System.EventHandler(this.ButtonMenuMouseEnter);
            this.btnDeliveredGoods.MouseLeave += new System.EventHandler(this.ButtonMenuMouseLeave);
            // 
            // btnStockManagement
            // 
            this.btnStockManagement.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnStockManagement.FlatAppearance.BorderSize = 0;
            this.btnStockManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockManagement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStockManagement.Location = new System.Drawing.Point(3, 111);
            this.btnStockManagement.Name = "btnStockManagement";
            this.btnStockManagement.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnStockManagement.Size = this.btnAutoOrders.Size;
            this.btnStockManagement.TabIndex = 2;
            this.btnStockManagement.Text = "🏪 Товары на хранении";
            this.btnStockManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockManagement.Click += new System.EventHandler(this.ButtonMenuClick);
            this.btnStockManagement.MouseEnter += new System.EventHandler(this.ButtonMenuMouseEnter);
            this.btnStockManagement.MouseLeave += new System.EventHandler(this.ButtonMenuMouseLeave);
            // 
            // btnHistory
            // 
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHistory.Location = new System.Drawing.Point(3, 162);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHistory.Size = this.btnAutoOrders.Size;
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "📜 История";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Click += new System.EventHandler(this.ButtonMenuClick);
            this.btnHistory.MouseEnter += new System.EventHandler(this.ButtonMenuMouseEnter);
            this.btnHistory.MouseLeave += new System.EventHandler(this.ButtonMenuMouseLeave);
            // 
            // btnComplaints
            // 
            this.btnComplaints.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnComplaints.FlatAppearance.BorderSize = 0;
            this.btnComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplaints.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnComplaints.Location = new System.Drawing.Point(3, 213);
            this.btnComplaints.Name = "btnComplaints";
            this.btnComplaints.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnComplaints.Size = this.btnAutoOrders.Size;
            this.btnComplaints.TabIndex = 4;
            this.btnComplaints.Text = "⚠️ Жалобы и реакции";
            this.btnComplaints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComplaints.Click += new System.EventHandler(this.ButtonMenuClick);
            this.btnComplaints.MouseEnter += new System.EventHandler(this.ButtonMenuMouseEnter);
            this.btnComplaints.MouseLeave += new System.EventHandler(this.ButtonMenuMouseLeave);
            // 
            // pnlMenuHeader
            // 
            this.pnlMenuHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlMenuHeader.Controls.Add(this.lblMenuTitle);
            this.pnlMenuHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuHeader.Name = "pnlMenuHeader";
            this.pnlMenuHeader.Size = new System.Drawing.Size(220, 60);
            this.pnlMenuHeader.TabIndex = 0;
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMenuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblMenuTitle.Location = new System.Drawing.Point(3, 25);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(204, 25);
            this.lblMenuTitle.TabIndex = 0;
            this.lblMenuTitle.Text = "Товары на хранении";
            this.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenSales
            // 
            this.btnOpenSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnOpenSales.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnOpenSales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOpenSales.FlatAppearance.BorderSize = 0;
            this.btnOpenSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnOpenSales.ForeColor = System.Drawing.Color.White;
            this.btnOpenSales.Location = new System.Drawing.Point(0, 642);
            this.btnOpenSales.Name = "btnOpenSales";
            this.btnOpenSales.Size = new System.Drawing.Size(220, 60);
            this.btnOpenSales.TabIndex = 2;
            this.btnOpenSales.Text = "💊 Продажа";
            this.btnOpenSales.UseVisualStyleBackColor = false;
            this.btnOpenSales.Click += new System.EventHandler(this.ButtonMenuClick);
            this.btnOpenSales.MouseEnter += new System.EventHandler(this.btnOpenSales_MouseEnter);
            this.btnOpenSales.MouseLeave += new System.EventHandler(this.btnOpenSales_MouseLeave);
            // 
            // panelWork
            // 
            this.panelWork.BackColor = System.Drawing.Color.Silver;
            this.panelWork.Controls.Add(this.pnlContent);
            this.panelWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWork.Location = new System.Drawing.Point(220, 50);
            this.panelWork.Name = "panelWork";
            this.panelWork.Padding = new System.Windows.Forms.Padding(5);
            this.panelWork.Size = new System.Drawing.Size(1164, 702);
            this.panelWork.TabIndex = 2;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(5, 5);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1154, 692);
            this.pnlContent.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblExpiring,
            this.lblOverdue,
            this.lblLastSale});
            this.statusStrip.Location = new System.Drawing.Point(0, 752);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1384, 22);
            this.statusStrip.TabIndex = 3;
            // 
            // lblExpiring
            // 
            this.lblExpiring.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExpiring.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.lblExpiring.Margin = new System.Windows.Forms.Padding(15, 3, 20, 2);
            this.lblExpiring.Name = "lblExpiring";
            this.lblExpiring.Size = new System.Drawing.Size(152, 17);
            this.lblExpiring.Tag = 3;
            this.lblExpiring.Text = "🟡 Истекает срок: 3 товара";
            // 
            // lblOverdue
            // 
            this.lblOverdue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOverdue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblOverdue.Margin = new System.Windows.Forms.Padding(0, 3, 20, 2);
            this.lblOverdue.Name = "lblOverdue";
            this.lblOverdue.Size = new System.Drawing.Size(142, 17);
            this.lblOverdue.Tag = 1;
            this.lblOverdue.Text = "🔴 Просрочено: 1 товар";
            // 
            // lblLastSale
            // 
            this.lblLastSale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblLastSale.Margin = new System.Windows.Forms.Padding(0, 3, 15, 2);
            this.lblLastSale.Name = "lblLastSale";
            this.lblLastSale.Size = new System.Drawing.Size(166, 17);
            this.lblLastSale.Tag = "14:32";
            this.lblLastSale.Text = "🕐 Последняя продажа: 14:32";
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1384, 774);
            this.Controls.Add(this.panelWork);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.statusStrip);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аптека «Ап-Дор» — ИС v.1.0.0";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.flowMenu.ResumeLayout(false);
            this.pnlMenuHeader.ResumeLayout(false);
            this.pnlMenuHeader.PerformLayout();
            this.panelWork.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // ===== ВЕРХНЯЯ ПАНЕЛЬ =====
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblAppIcon;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;

        // ===== ЛЕВАЯ ПАНЕЛЬ МЕНЮ =====
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel pnlMenuHeader;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.FlowLayoutPanel flowMenu;

        // ===== РАБОЧАЯ ОБЛАСТЬ =====
        private System.Windows.Forms.Panel panelWork;
        private System.Windows.Forms.Panel pnlContent;

        // ===== СТАТУС-БАР =====
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblExpiring;
        private System.Windows.Forms.ToolStripStatusLabel lblOverdue;
        private System.Windows.Forms.ToolStripStatusLabel lblLastSale;
        private System.Windows.Forms.Button btnAutoOrders;
        private Button btnDeliveredGoods;
        private Button btnStockManagement;
        private Button btnHistory;
        private Button btnComplaints;
        private Button btnOpenSales;
        private Label lblSeparator;
    }
}


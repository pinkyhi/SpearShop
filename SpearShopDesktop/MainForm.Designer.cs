namespace SpearShopDesktop
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GoodsTabPage = new System.Windows.Forms.TabPage();
            this.GoodsAddGoodButton = new System.Windows.Forms.Button();
            this.GoodsLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.GoodsSearchPanel = new System.Windows.Forms.Panel();
            this.GoodsSearchLabel = new System.Windows.Forms.Label();
            this.GoodsSearchByNameRadio = new System.Windows.Forms.RadioButton();
            this.GoodsSearchByIdRadio = new System.Windows.Forms.RadioButton();
            this.GoodsSearchTextBox = new System.Windows.Forms.TextBox();
            this.GoodsSortPanel = new System.Windows.Forms.Panel();
            this.GoodsPriceSortPanel = new System.Windows.Forms.Panel();
            this.GoodsPriceBLRadio = new System.Windows.Forms.RadioButton();
            this.GoodsPriceLBRadio = new System.Windows.Forms.RadioButton();
            this.SortPriceClearButton = new System.Windows.Forms.Button();
            this.SortGoodsLabel = new System.Windows.Forms.Label();
            this.GoodsAvailableSortPanel = new System.Windows.Forms.Panel();
            this.GoodsNotAvailableRadio = new System.Windows.Forms.RadioButton();
            this.SortAvailableClearButton = new System.Windows.Forms.Button();
            this.GoodsAvailableRadio = new System.Windows.Forms.RadioButton();
            this.GoodsSortButton = new System.Windows.Forms.Button();
            this.GoodsImgSortPanel = new System.Windows.Forms.Panel();
            this.GoodsImgFalseRadio = new System.Windows.Forms.RadioButton();
            this.SortVideoClearButton = new System.Windows.Forms.Button();
            this.GoodsImgTrueRadio = new System.Windows.Forms.RadioButton();
            this.GoodsAllFieldsSortPanel = new System.Windows.Forms.Panel();
            this.GoodsAllFieldsFalseRadio = new System.Windows.Forms.RadioButton();
            this.SortAllFieldsClearButton = new System.Windows.Forms.Button();
            this.GoodsAllFieldsTrueRadio = new System.Windows.Forms.RadioButton();
            this.GoodsVideoSortPanel = new System.Windows.Forms.Panel();
            this.GoodsVideoFalseRadio = new System.Windows.Forms.RadioButton();
            this.SortImgClearButton = new System.Windows.Forms.Button();
            this.GoodsVideoTrueRadio = new System.Windows.Forms.RadioButton();
            this.OrdersTabPage = new System.Windows.Forms.TabPage();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.OrdersLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.OrdersStatusPanel = new System.Windows.Forms.Panel();
            this.AllStatusRadio = new System.Windows.Forms.RadioButton();
            this.OrdersStatusLabel = new System.Windows.Forms.Label();
            this.ProcessedStatusRadio = new System.Windows.Forms.RadioButton();
            this.ReadyStatusRadio = new System.Windows.Forms.RadioButton();
            this.NewStatusRadio = new System.Windows.Forms.RadioButton();
            this.OrdersSearchPanel = new System.Windows.Forms.Panel();
            this.OrdersSearchLabel = new System.Windows.Forms.Label();
            this.OrdersSearchByCustomerNameRadio = new System.Windows.Forms.RadioButton();
            this.OrdersSearchByOrderIdRadio = new System.Windows.Forms.RadioButton();
            this.OrdersSearchTextBox = new System.Windows.Forms.TextBox();
            this.CustomersTabPage = new System.Windows.Forms.TabPage();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.CustomersLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.CategoriesTabPage = new System.Windows.Forms.TabPage();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.CategoriesLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.ManufacturersTabPage = new System.Windows.Forms.TabPage();
            this.AddManufacturerButton = new System.Windows.Forms.Button();
            this.ManufacturersLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.Delivery_TypesTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Delivery_TypesDeleteCounter = new System.Windows.Forms.NumericUpDown();
            this.Delivery_TypesDeleteByIdButton = new System.Windows.Forms.Button();
            this.Delivery_TypesSubmitButton = new System.Windows.Forms.Button();
            this.Delivery_TypesAddButton = new System.Windows.Forms.Button();
            this.Delivery_TypesLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.GoodsTabPage.SuspendLayout();
            this.GoodsSearchPanel.SuspendLayout();
            this.GoodsSortPanel.SuspendLayout();
            this.GoodsPriceSortPanel.SuspendLayout();
            this.GoodsAvailableSortPanel.SuspendLayout();
            this.GoodsImgSortPanel.SuspendLayout();
            this.GoodsAllFieldsSortPanel.SuspendLayout();
            this.GoodsVideoSortPanel.SuspendLayout();
            this.OrdersTabPage.SuspendLayout();
            this.OrdersStatusPanel.SuspendLayout();
            this.OrdersSearchPanel.SuspendLayout();
            this.CustomersTabPage.SuspendLayout();
            this.CategoriesTabPage.SuspendLayout();
            this.ManufacturersTabPage.SuspendLayout();
            this.Delivery_TypesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Delivery_TypesDeleteCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.GoodsTabPage);
            this.tabControl1.Controls.Add(this.OrdersTabPage);
            this.tabControl1.Controls.Add(this.CustomersTabPage);
            this.tabControl1.Controls.Add(this.CategoriesTabPage);
            this.tabControl1.Controls.Add(this.ManufacturersTabPage);
            this.tabControl1.Controls.Add(this.Delivery_TypesTabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1340, 678);
            this.tabControl1.TabIndex = 0;
            // 
            // GoodsTabPage
            // 
            this.GoodsTabPage.Controls.Add(this.GoodsAddGoodButton);
            this.GoodsTabPage.Controls.Add(this.GoodsLayoutTable);
            this.GoodsTabPage.Controls.Add(this.GoodsSearchPanel);
            this.GoodsTabPage.Controls.Add(this.GoodsSortPanel);
            this.GoodsTabPage.Location = new System.Drawing.Point(4, 22);
            this.GoodsTabPage.Name = "GoodsTabPage";
            this.GoodsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.GoodsTabPage.Size = new System.Drawing.Size(1332, 652);
            this.GoodsTabPage.TabIndex = 0;
            this.GoodsTabPage.Text = "Goods";
            this.GoodsTabPage.UseVisualStyleBackColor = true;
            // 
            // GoodsAddGoodButton
            // 
            this.GoodsAddGoodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.GoodsAddGoodButton.Location = new System.Drawing.Point(1072, 483);
            this.GoodsAddGoodButton.Name = "GoodsAddGoodButton";
            this.GoodsAddGoodButton.Size = new System.Drawing.Size(246, 41);
            this.GoodsAddGoodButton.TabIndex = 9;
            this.GoodsAddGoodButton.Text = "Add good";
            this.GoodsAddGoodButton.UseVisualStyleBackColor = true;
            this.GoodsAddGoodButton.Click += new System.EventHandler(this.GoodsAddGoodButton_Click);
            // 
            // GoodsLayoutTable
            // 
            this.GoodsLayoutTable.AutoScroll = true;
            this.GoodsLayoutTable.BackColor = System.Drawing.Color.White;
            this.GoodsLayoutTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.GoodsLayoutTable.ColumnCount = 8;
            this.GoodsLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.GoodsLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.GoodsLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.GoodsLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.GoodsLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.GoodsLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.GoodsLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.GoodsLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.GoodsLayoutTable.Location = new System.Drawing.Point(6, 45);
            this.GoodsLayoutTable.Name = "GoodsLayoutTable";
            this.GoodsLayoutTable.RowCount = 19;
            this.GoodsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GoodsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GoodsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GoodsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GoodsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GoodsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GoodsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GoodsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GoodsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GoodsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GoodsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GoodsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GoodsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GoodsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GoodsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GoodsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GoodsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GoodsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GoodsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GoodsLayoutTable.Size = new System.Drawing.Size(1052, 601);
            this.GoodsLayoutTable.TabIndex = 8;
            // 
            // GoodsSearchPanel
            // 
            this.GoodsSearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GoodsSearchPanel.Controls.Add(this.GoodsSearchLabel);
            this.GoodsSearchPanel.Controls.Add(this.GoodsSearchByNameRadio);
            this.GoodsSearchPanel.Controls.Add(this.GoodsSearchByIdRadio);
            this.GoodsSearchPanel.Controls.Add(this.GoodsSearchTextBox);
            this.GoodsSearchPanel.Location = new System.Drawing.Point(1070, 105);
            this.GoodsSearchPanel.Name = "GoodsSearchPanel";
            this.GoodsSearchPanel.Size = new System.Drawing.Size(250, 100);
            this.GoodsSearchPanel.TabIndex = 7;
            // 
            // GoodsSearchLabel
            // 
            this.GoodsSearchLabel.AutoSize = true;
            this.GoodsSearchLabel.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.GoodsSearchLabel.Location = new System.Drawing.Point(48, 3);
            this.GoodsSearchLabel.Name = "GoodsSearchLabel";
            this.GoodsSearchLabel.Size = new System.Drawing.Size(97, 39);
            this.GoodsSearchLabel.TabIndex = 6;
            this.GoodsSearchLabel.Text = "Search";
            // 
            // GoodsSearchByNameRadio
            // 
            this.GoodsSearchByNameRadio.AutoSize = true;
            this.GoodsSearchByNameRadio.Location = new System.Drawing.Point(124, 80);
            this.GoodsSearchByNameRadio.Name = "GoodsSearchByNameRadio";
            this.GoodsSearchByNameRadio.Size = new System.Drawing.Size(104, 17);
            this.GoodsSearchByNameRadio.TabIndex = 8;
            this.GoodsSearchByNameRadio.TabStop = true;
            this.GoodsSearchByNameRadio.Text = "Search by Name";
            this.GoodsSearchByNameRadio.UseVisualStyleBackColor = true;
            this.GoodsSearchByNameRadio.CheckedChanged += new System.EventHandler(this.GoodsSearchByNameRadio_CheckedChanged);
            // 
            // GoodsSearchByIdRadio
            // 
            this.GoodsSearchByIdRadio.AutoSize = true;
            this.GoodsSearchByIdRadio.Location = new System.Drawing.Point(4, 81);
            this.GoodsSearchByIdRadio.Name = "GoodsSearchByIdRadio";
            this.GoodsSearchByIdRadio.Size = new System.Drawing.Size(87, 17);
            this.GoodsSearchByIdRadio.TabIndex = 7;
            this.GoodsSearchByIdRadio.TabStop = true;
            this.GoodsSearchByIdRadio.Text = "Search by ID";
            this.GoodsSearchByIdRadio.UseVisualStyleBackColor = true;
            this.GoodsSearchByIdRadio.CheckedChanged += new System.EventHandler(this.GoodsSearchByIdRadio_CheckedChanged);
            // 
            // GoodsSearchTextBox
            // 
            this.GoodsSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.GoodsSearchTextBox.Location = new System.Drawing.Point(3, 45);
            this.GoodsSearchTextBox.MaxLength = 36;
            this.GoodsSearchTextBox.Name = "GoodsSearchTextBox";
            this.GoodsSearchTextBox.Size = new System.Drawing.Size(243, 29);
            this.GoodsSearchTextBox.TabIndex = 6;
            this.GoodsSearchTextBox.TextChanged += new System.EventHandler(this.GoodsSearchTextBox_TextChanged);
            // 
            // GoodsSortPanel
            // 
            this.GoodsSortPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GoodsSortPanel.Controls.Add(this.GoodsPriceSortPanel);
            this.GoodsSortPanel.Controls.Add(this.SortGoodsLabel);
            this.GoodsSortPanel.Controls.Add(this.GoodsAvailableSortPanel);
            this.GoodsSortPanel.Controls.Add(this.GoodsSortButton);
            this.GoodsSortPanel.Controls.Add(this.GoodsImgSortPanel);
            this.GoodsSortPanel.Controls.Add(this.GoodsAllFieldsSortPanel);
            this.GoodsSortPanel.Controls.Add(this.GoodsVideoSortPanel);
            this.GoodsSortPanel.Location = new System.Drawing.Point(1072, 211);
            this.GoodsSortPanel.Name = "GoodsSortPanel";
            this.GoodsSortPanel.Size = new System.Drawing.Size(246, 265);
            this.GoodsSortPanel.TabIndex = 5;
            // 
            // GoodsPriceSortPanel
            // 
            this.GoodsPriceSortPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GoodsPriceSortPanel.Controls.Add(this.GoodsPriceBLRadio);
            this.GoodsPriceSortPanel.Controls.Add(this.GoodsPriceLBRadio);
            this.GoodsPriceSortPanel.Controls.Add(this.SortPriceClearButton);
            this.GoodsPriceSortPanel.Location = new System.Drawing.Point(3, 53);
            this.GoodsPriceSortPanel.Name = "GoodsPriceSortPanel";
            this.GoodsPriceSortPanel.Size = new System.Drawing.Size(240, 36);
            this.GoodsPriceSortPanel.TabIndex = 1;
            // 
            // GoodsPriceBLRadio
            // 
            this.GoodsPriceBLRadio.AutoSize = true;
            this.GoodsPriceBLRadio.Location = new System.Drawing.Point(95, 11);
            this.GoodsPriceBLRadio.Name = "GoodsPriceBLRadio";
            this.GoodsPriceBLRadio.Size = new System.Drawing.Size(55, 17);
            this.GoodsPriceBLRadio.TabIndex = 2;
            this.GoodsPriceBLRadio.TabStop = true;
            this.GoodsPriceBLRadio.Text = "Price↓";
            this.GoodsPriceBLRadio.UseVisualStyleBackColor = true;
            // 
            // GoodsPriceLBRadio
            // 
            this.GoodsPriceLBRadio.AutoSize = true;
            this.GoodsPriceLBRadio.Location = new System.Drawing.Point(4, 11);
            this.GoodsPriceLBRadio.Name = "GoodsPriceLBRadio";
            this.GoodsPriceLBRadio.Size = new System.Drawing.Size(55, 17);
            this.GoodsPriceLBRadio.TabIndex = 1;
            this.GoodsPriceLBRadio.TabStop = true;
            this.GoodsPriceLBRadio.Text = "Price↑";
            this.GoodsPriceLBRadio.UseVisualStyleBackColor = true;
            // 
            // SortPriceClearButton
            // 
            this.SortPriceClearButton.Location = new System.Drawing.Point(198, 0);
            this.SortPriceClearButton.Name = "SortPriceClearButton";
            this.SortPriceClearButton.Size = new System.Drawing.Size(40, 36);
            this.SortPriceClearButton.TabIndex = 0;
            this.SortPriceClearButton.Text = "C";
            this.SortPriceClearButton.UseVisualStyleBackColor = true;
            this.SortPriceClearButton.Click += new System.EventHandler(this.SortPriceClearButton_Click);
            // 
            // SortGoodsLabel
            // 
            this.SortGoodsLabel.AutoSize = true;
            this.SortGoodsLabel.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SortGoodsLabel.Location = new System.Drawing.Point(52, 3);
            this.SortGoodsLabel.Name = "SortGoodsLabel";
            this.SortGoodsLabel.Size = new System.Drawing.Size(146, 39);
            this.SortGoodsLabel.TabIndex = 5;
            this.SortGoodsLabel.Text = "Sort Panel";
            // 
            // GoodsAvailableSortPanel
            // 
            this.GoodsAvailableSortPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GoodsAvailableSortPanel.Controls.Add(this.GoodsNotAvailableRadio);
            this.GoodsAvailableSortPanel.Controls.Add(this.SortAvailableClearButton);
            this.GoodsAvailableSortPanel.Controls.Add(this.GoodsAvailableRadio);
            this.GoodsAvailableSortPanel.Location = new System.Drawing.Point(3, 88);
            this.GoodsAvailableSortPanel.Name = "GoodsAvailableSortPanel";
            this.GoodsAvailableSortPanel.Size = new System.Drawing.Size(240, 36);
            this.GoodsAvailableSortPanel.TabIndex = 0;
            // 
            // GoodsNotAvailableRadio
            // 
            this.GoodsNotAvailableRadio.AutoSize = true;
            this.GoodsNotAvailableRadio.Location = new System.Drawing.Point(95, 7);
            this.GoodsNotAvailableRadio.Name = "GoodsNotAvailableRadio";
            this.GoodsNotAvailableRadio.Size = new System.Drawing.Size(85, 17);
            this.GoodsNotAvailableRadio.TabIndex = 4;
            this.GoodsNotAvailableRadio.TabStop = true;
            this.GoodsNotAvailableRadio.Text = "NotAvailable";
            this.GoodsNotAvailableRadio.UseVisualStyleBackColor = true;
            // 
            // SortAvailableClearButton
            // 
            this.SortAvailableClearButton.Location = new System.Drawing.Point(198, 0);
            this.SortAvailableClearButton.Name = "SortAvailableClearButton";
            this.SortAvailableClearButton.Size = new System.Drawing.Size(40, 36);
            this.SortAvailableClearButton.TabIndex = 0;
            this.SortAvailableClearButton.Text = "C";
            this.SortAvailableClearButton.UseVisualStyleBackColor = true;
            this.SortAvailableClearButton.Click += new System.EventHandler(this.SortAvailableClearButton_Click);
            // 
            // GoodsAvailableRadio
            // 
            this.GoodsAvailableRadio.AutoSize = true;
            this.GoodsAvailableRadio.Location = new System.Drawing.Point(4, 7);
            this.GoodsAvailableRadio.Name = "GoodsAvailableRadio";
            this.GoodsAvailableRadio.Size = new System.Drawing.Size(68, 17);
            this.GoodsAvailableRadio.TabIndex = 3;
            this.GoodsAvailableRadio.TabStop = true;
            this.GoodsAvailableRadio.Text = "Available";
            this.GoodsAvailableRadio.UseVisualStyleBackColor = true;
            // 
            // GoodsSortButton
            // 
            this.GoodsSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.GoodsSortButton.Location = new System.Drawing.Point(3, 226);
            this.GoodsSortButton.Margin = new System.Windows.Forms.Padding(0);
            this.GoodsSortButton.Name = "GoodsSortButton";
            this.GoodsSortButton.Size = new System.Drawing.Size(240, 36);
            this.GoodsSortButton.TabIndex = 4;
            this.GoodsSortButton.Text = "Sort";
            this.GoodsSortButton.UseVisualStyleBackColor = true;
            this.GoodsSortButton.Click += new System.EventHandler(this.GoodsSortButton_Click);
            // 
            // GoodsImgSortPanel
            // 
            this.GoodsImgSortPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GoodsImgSortPanel.Controls.Add(this.GoodsImgFalseRadio);
            this.GoodsImgSortPanel.Controls.Add(this.SortVideoClearButton);
            this.GoodsImgSortPanel.Controls.Add(this.GoodsImgTrueRadio);
            this.GoodsImgSortPanel.Location = new System.Drawing.Point(3, 122);
            this.GoodsImgSortPanel.Name = "GoodsImgSortPanel";
            this.GoodsImgSortPanel.Size = new System.Drawing.Size(240, 36);
            this.GoodsImgSortPanel.TabIndex = 1;
            // 
            // GoodsImgFalseRadio
            // 
            this.GoodsImgFalseRadio.AutoSize = true;
            this.GoodsImgFalseRadio.Location = new System.Drawing.Point(95, 9);
            this.GoodsImgFalseRadio.Name = "GoodsImgFalseRadio";
            this.GoodsImgFalseRadio.Size = new System.Drawing.Size(94, 17);
            this.GoodsImgFalseRadio.TabIndex = 6;
            this.GoodsImgFalseRadio.TabStop = true;
            this.GoodsImgFalseRadio.Text = "Without Image";
            this.GoodsImgFalseRadio.UseVisualStyleBackColor = true;
            // 
            // SortVideoClearButton
            // 
            this.SortVideoClearButton.Location = new System.Drawing.Point(198, -1);
            this.SortVideoClearButton.Name = "SortVideoClearButton";
            this.SortVideoClearButton.Size = new System.Drawing.Size(40, 36);
            this.SortVideoClearButton.TabIndex = 1;
            this.SortVideoClearButton.Text = "C";
            this.SortVideoClearButton.UseVisualStyleBackColor = true;
            this.SortVideoClearButton.Click += new System.EventHandler(this.SortVideoClearButton_Click);
            // 
            // GoodsImgTrueRadio
            // 
            this.GoodsImgTrueRadio.AutoSize = true;
            this.GoodsImgTrueRadio.Location = new System.Drawing.Point(4, 9);
            this.GoodsImgTrueRadio.Name = "GoodsImgTrueRadio";
            this.GoodsImgTrueRadio.Size = new System.Drawing.Size(79, 17);
            this.GoodsImgTrueRadio.TabIndex = 5;
            this.GoodsImgTrueRadio.TabStop = true;
            this.GoodsImgTrueRadio.Text = "With Image";
            this.GoodsImgTrueRadio.UseVisualStyleBackColor = true;
            // 
            // GoodsAllFieldsSortPanel
            // 
            this.GoodsAllFieldsSortPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GoodsAllFieldsSortPanel.Controls.Add(this.GoodsAllFieldsFalseRadio);
            this.GoodsAllFieldsSortPanel.Controls.Add(this.SortAllFieldsClearButton);
            this.GoodsAllFieldsSortPanel.Controls.Add(this.GoodsAllFieldsTrueRadio);
            this.GoodsAllFieldsSortPanel.Location = new System.Drawing.Point(3, 190);
            this.GoodsAllFieldsSortPanel.Name = "GoodsAllFieldsSortPanel";
            this.GoodsAllFieldsSortPanel.Size = new System.Drawing.Size(240, 36);
            this.GoodsAllFieldsSortPanel.TabIndex = 3;
            // 
            // GoodsAllFieldsFalseRadio
            // 
            this.GoodsAllFieldsFalseRadio.AutoSize = true;
            this.GoodsAllFieldsFalseRadio.Location = new System.Drawing.Point(95, 7);
            this.GoodsAllFieldsFalseRadio.Name = "GoodsAllFieldsFalseRadio";
            this.GoodsAllFieldsFalseRadio.Size = new System.Drawing.Size(92, 17);
            this.GoodsAllFieldsFalseRadio.TabIndex = 10;
            this.GoodsAllFieldsFalseRadio.TabStop = true;
            this.GoodsAllFieldsFalseRadio.Text = "Aren\'t all fields";
            this.GoodsAllFieldsFalseRadio.UseVisualStyleBackColor = true;
            // 
            // SortAllFieldsClearButton
            // 
            this.SortAllFieldsClearButton.Location = new System.Drawing.Point(198, -1);
            this.SortAllFieldsClearButton.Name = "SortAllFieldsClearButton";
            this.SortAllFieldsClearButton.Size = new System.Drawing.Size(40, 36);
            this.SortAllFieldsClearButton.TabIndex = 3;
            this.SortAllFieldsClearButton.Text = "C";
            this.SortAllFieldsClearButton.UseVisualStyleBackColor = true;
            this.SortAllFieldsClearButton.Click += new System.EventHandler(this.SortAllFieldsClearButton_Click);
            // 
            // GoodsAllFieldsTrueRadio
            // 
            this.GoodsAllFieldsTrueRadio.AutoSize = true;
            this.GoodsAllFieldsTrueRadio.Location = new System.Drawing.Point(4, 7);
            this.GoodsAllFieldsTrueRadio.Name = "GoodsAllFieldsTrueRadio";
            this.GoodsAllFieldsTrueRadio.Size = new System.Drawing.Size(81, 17);
            this.GoodsAllFieldsTrueRadio.TabIndex = 9;
            this.GoodsAllFieldsTrueRadio.TabStop = true;
            this.GoodsAllFieldsTrueRadio.Text = "Are all fields";
            this.GoodsAllFieldsTrueRadio.UseVisualStyleBackColor = true;
            // 
            // GoodsVideoSortPanel
            // 
            this.GoodsVideoSortPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GoodsVideoSortPanel.Controls.Add(this.GoodsVideoFalseRadio);
            this.GoodsVideoSortPanel.Controls.Add(this.SortImgClearButton);
            this.GoodsVideoSortPanel.Controls.Add(this.GoodsVideoTrueRadio);
            this.GoodsVideoSortPanel.Location = new System.Drawing.Point(3, 156);
            this.GoodsVideoSortPanel.Name = "GoodsVideoSortPanel";
            this.GoodsVideoSortPanel.Size = new System.Drawing.Size(240, 36);
            this.GoodsVideoSortPanel.TabIndex = 2;
            // 
            // GoodsVideoFalseRadio
            // 
            this.GoodsVideoFalseRadio.AutoSize = true;
            this.GoodsVideoFalseRadio.Location = new System.Drawing.Point(95, 9);
            this.GoodsVideoFalseRadio.Name = "GoodsVideoFalseRadio";
            this.GoodsVideoFalseRadio.Size = new System.Drawing.Size(92, 17);
            this.GoodsVideoFalseRadio.TabIndex = 8;
            this.GoodsVideoFalseRadio.TabStop = true;
            this.GoodsVideoFalseRadio.Text = "Without Video";
            this.GoodsVideoFalseRadio.UseVisualStyleBackColor = true;
            // 
            // SortImgClearButton
            // 
            this.SortImgClearButton.Location = new System.Drawing.Point(198, -1);
            this.SortImgClearButton.Name = "SortImgClearButton";
            this.SortImgClearButton.Size = new System.Drawing.Size(40, 36);
            this.SortImgClearButton.TabIndex = 2;
            this.SortImgClearButton.Text = "C";
            this.SortImgClearButton.UseVisualStyleBackColor = true;
            this.SortImgClearButton.Click += new System.EventHandler(this.SortImgClearButton_Click);
            // 
            // GoodsVideoTrueRadio
            // 
            this.GoodsVideoTrueRadio.AutoSize = true;
            this.GoodsVideoTrueRadio.Location = new System.Drawing.Point(4, 9);
            this.GoodsVideoTrueRadio.Name = "GoodsVideoTrueRadio";
            this.GoodsVideoTrueRadio.Size = new System.Drawing.Size(77, 17);
            this.GoodsVideoTrueRadio.TabIndex = 7;
            this.GoodsVideoTrueRadio.TabStop = true;
            this.GoodsVideoTrueRadio.Text = "With Video";
            this.GoodsVideoTrueRadio.UseVisualStyleBackColor = true;
            // 
            // OrdersTabPage
            // 
            this.OrdersTabPage.Controls.Add(this.AddOrderButton);
            this.OrdersTabPage.Controls.Add(this.OrdersLayoutTable);
            this.OrdersTabPage.Controls.Add(this.OrdersStatusPanel);
            this.OrdersTabPage.Controls.Add(this.OrdersSearchPanel);
            this.OrdersTabPage.Location = new System.Drawing.Point(4, 22);
            this.OrdersTabPage.Name = "OrdersTabPage";
            this.OrdersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersTabPage.Size = new System.Drawing.Size(1332, 652);
            this.OrdersTabPage.TabIndex = 1;
            this.OrdersTabPage.Text = "Orders";
            this.OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.AddOrderButton.Location = new System.Drawing.Point(1097, 315);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(198, 38);
            this.AddOrderButton.TabIndex = 10;
            this.AddOrderButton.Text = "Add order";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // OrdersLayoutTable
            // 
            this.OrdersLayoutTable.AutoScroll = true;
            this.OrdersLayoutTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.OrdersLayoutTable.ColumnCount = 5;
            this.OrdersLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.OrdersLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.OrdersLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.OrdersLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.OrdersLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 241F));
            this.OrdersLayoutTable.Location = new System.Drawing.Point(3, 40);
            this.OrdersLayoutTable.Name = "OrdersLayoutTable";
            this.OrdersLayoutTable.RowCount = 19;
            this.OrdersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.OrdersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.OrdersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.OrdersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.OrdersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.OrdersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.OrdersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.OrdersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.OrdersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.OrdersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.OrdersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.OrdersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.OrdersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.OrdersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.OrdersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.OrdersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.OrdersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.OrdersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.OrdersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.OrdersLayoutTable.Size = new System.Drawing.Size(1051, 600);
            this.OrdersLayoutTable.TabIndex = 10;
            // 
            // OrdersStatusPanel
            // 
            this.OrdersStatusPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrdersStatusPanel.Controls.Add(this.AllStatusRadio);
            this.OrdersStatusPanel.Controls.Add(this.OrdersStatusLabel);
            this.OrdersStatusPanel.Controls.Add(this.ProcessedStatusRadio);
            this.OrdersStatusPanel.Controls.Add(this.ReadyStatusRadio);
            this.OrdersStatusPanel.Controls.Add(this.NewStatusRadio);
            this.OrdersStatusPanel.Location = new System.Drawing.Point(1060, 229);
            this.OrdersStatusPanel.Name = "OrdersStatusPanel";
            this.OrdersStatusPanel.Size = new System.Drawing.Size(270, 80);
            this.OrdersStatusPanel.TabIndex = 9;
            // 
            // AllStatusRadio
            // 
            this.AllStatusRadio.AutoSize = true;
            this.AllStatusRadio.Checked = true;
            this.AllStatusRadio.Location = new System.Drawing.Point(5, 31);
            this.AllStatusRadio.Name = "AllStatusRadio";
            this.AllStatusRadio.Size = new System.Drawing.Size(36, 17);
            this.AllStatusRadio.TabIndex = 10;
            this.AllStatusRadio.TabStop = true;
            this.AllStatusRadio.Text = "All";
            this.AllStatusRadio.UseVisualStyleBackColor = true;
            this.AllStatusRadio.CheckedChanged += new System.EventHandler(this.AllStatusRadio_CheckedChanged);
            // 
            // OrdersStatusLabel
            // 
            this.OrdersStatusLabel.AutoSize = true;
            this.OrdersStatusLabel.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.OrdersStatusLabel.Location = new System.Drawing.Point(3, 2);
            this.OrdersStatusLabel.Name = "OrdersStatusLabel";
            this.OrdersStatusLabel.Size = new System.Drawing.Size(68, 26);
            this.OrdersStatusLabel.TabIndex = 9;
            this.OrdersStatusLabel.Text = "Status";
            // 
            // ProcessedStatusRadio
            // 
            this.ProcessedStatusRadio.AutoSize = true;
            this.ProcessedStatusRadio.Location = new System.Drawing.Point(88, 52);
            this.ProcessedStatusRadio.Name = "ProcessedStatusRadio";
            this.ProcessedStatusRadio.Size = new System.Drawing.Size(75, 17);
            this.ProcessedStatusRadio.TabIndex = 2;
            this.ProcessedStatusRadio.Text = "Processed";
            this.ProcessedStatusRadio.UseVisualStyleBackColor = true;
            this.ProcessedStatusRadio.CheckedChanged += new System.EventHandler(this.ProcessedStatusRadio_CheckedChanged);
            // 
            // ReadyStatusRadio
            // 
            this.ReadyStatusRadio.AutoSize = true;
            this.ReadyStatusRadio.Location = new System.Drawing.Point(5, 52);
            this.ReadyStatusRadio.Name = "ReadyStatusRadio";
            this.ReadyStatusRadio.Size = new System.Drawing.Size(56, 17);
            this.ReadyStatusRadio.TabIndex = 1;
            this.ReadyStatusRadio.Text = "Ready";
            this.ReadyStatusRadio.UseVisualStyleBackColor = true;
            this.ReadyStatusRadio.CheckedChanged += new System.EventHandler(this.ReadyStatusRadio_CheckedChanged);
            // 
            // NewStatusRadio
            // 
            this.NewStatusRadio.AutoSize = true;
            this.NewStatusRadio.Location = new System.Drawing.Point(88, 29);
            this.NewStatusRadio.Name = "NewStatusRadio";
            this.NewStatusRadio.Size = new System.Drawing.Size(74, 17);
            this.NewStatusRadio.TabIndex = 0;
            this.NewStatusRadio.Text = "New order";
            this.NewStatusRadio.UseVisualStyleBackColor = true;
            this.NewStatusRadio.CheckedChanged += new System.EventHandler(this.NewStatusRadio_CheckedChanged);
            // 
            // OrdersSearchPanel
            // 
            this.OrdersSearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrdersSearchPanel.Controls.Add(this.OrdersSearchLabel);
            this.OrdersSearchPanel.Controls.Add(this.OrdersSearchByCustomerNameRadio);
            this.OrdersSearchPanel.Controls.Add(this.OrdersSearchByOrderIdRadio);
            this.OrdersSearchPanel.Controls.Add(this.OrdersSearchTextBox);
            this.OrdersSearchPanel.Location = new System.Drawing.Point(1060, 118);
            this.OrdersSearchPanel.Name = "OrdersSearchPanel";
            this.OrdersSearchPanel.Size = new System.Drawing.Size(270, 111);
            this.OrdersSearchPanel.TabIndex = 8;
            // 
            // OrdersSearchLabel
            // 
            this.OrdersSearchLabel.AutoSize = true;
            this.OrdersSearchLabel.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.OrdersSearchLabel.Location = new System.Drawing.Point(65, 3);
            this.OrdersSearchLabel.Name = "OrdersSearchLabel";
            this.OrdersSearchLabel.Size = new System.Drawing.Size(97, 39);
            this.OrdersSearchLabel.TabIndex = 6;
            this.OrdersSearchLabel.Text = "Search";
            // 
            // OrdersSearchByCustomerNameRadio
            // 
            this.OrdersSearchByCustomerNameRadio.AutoSize = true;
            this.OrdersSearchByCustomerNameRadio.Location = new System.Drawing.Point(120, 81);
            this.OrdersSearchByCustomerNameRadio.Name = "OrdersSearchByCustomerNameRadio";
            this.OrdersSearchByCustomerNameRadio.Size = new System.Drawing.Size(150, 17);
            this.OrdersSearchByCustomerNameRadio.TabIndex = 8;
            this.OrdersSearchByCustomerNameRadio.TabStop = true;
            this.OrdersSearchByCustomerNameRadio.Text = "Search by customer Name";
            this.OrdersSearchByCustomerNameRadio.UseVisualStyleBackColor = true;
            this.OrdersSearchByCustomerNameRadio.CheckedChanged += new System.EventHandler(this.OrdersSearchByCustomerNameRadio_CheckedChanged);
            // 
            // OrdersSearchByOrderIdRadio
            // 
            this.OrdersSearchByOrderIdRadio.AutoSize = true;
            this.OrdersSearchByOrderIdRadio.Location = new System.Drawing.Point(4, 81);
            this.OrdersSearchByOrderIdRadio.Name = "OrdersSearchByOrderIdRadio";
            this.OrdersSearchByOrderIdRadio.Size = new System.Drawing.Size(114, 17);
            this.OrdersSearchByOrderIdRadio.TabIndex = 7;
            this.OrdersSearchByOrderIdRadio.TabStop = true;
            this.OrdersSearchByOrderIdRadio.Text = "Search by order ID";
            this.OrdersSearchByOrderIdRadio.UseVisualStyleBackColor = true;
            this.OrdersSearchByOrderIdRadio.CheckedChanged += new System.EventHandler(this.OrdersSearchByOrderIdRadio_CheckedChanged);
            // 
            // OrdersSearchTextBox
            // 
            this.OrdersSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.OrdersSearchTextBox.Location = new System.Drawing.Point(20, 45);
            this.OrdersSearchTextBox.MaxLength = 36;
            this.OrdersSearchTextBox.Name = "OrdersSearchTextBox";
            this.OrdersSearchTextBox.Size = new System.Drawing.Size(243, 29);
            this.OrdersSearchTextBox.TabIndex = 6;
            this.OrdersSearchTextBox.TextChanged += new System.EventHandler(this.OrdersSearchTextBox_TextChanged);
            // 
            // CustomersTabPage
            // 
            this.CustomersTabPage.Controls.Add(this.AddCustomerButton);
            this.CustomersTabPage.Controls.Add(this.CustomersLayoutTable);
            this.CustomersTabPage.Location = new System.Drawing.Point(4, 22);
            this.CustomersTabPage.Name = "CustomersTabPage";
            this.CustomersTabPage.Size = new System.Drawing.Size(1332, 652);
            this.CustomersTabPage.TabIndex = 2;
            this.CustomersTabPage.Text = "Customers";
            this.CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.AddCustomerButton.Location = new System.Drawing.Point(557, 4);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(198, 38);
            this.AddCustomerButton.TabIndex = 13;
            this.AddCustomerButton.Text = "Add customer";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // CustomersLayoutTable
            // 
            this.CustomersLayoutTable.AutoScroll = true;
            this.CustomersLayoutTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.CustomersLayoutTable.ColumnCount = 6;
            this.CustomersLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.CustomersLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.CustomersLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.CustomersLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.CustomersLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.CustomersLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.CustomersLayoutTable.Location = new System.Drawing.Point(34, 48);
            this.CustomersLayoutTable.Name = "CustomersLayoutTable";
            this.CustomersLayoutTable.RowCount = 19;
            this.CustomersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CustomersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CustomersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CustomersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CustomersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CustomersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CustomersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CustomersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CustomersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CustomersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CustomersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CustomersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CustomersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CustomersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CustomersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CustomersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CustomersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CustomersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CustomersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CustomersLayoutTable.Size = new System.Drawing.Size(1260, 600);
            this.CustomersLayoutTable.TabIndex = 11;
            // 
            // CategoriesTabPage
            // 
            this.CategoriesTabPage.Controls.Add(this.AddCategoryButton);
            this.CategoriesTabPage.Controls.Add(this.CategoriesLayoutTable);
            this.CategoriesTabPage.Location = new System.Drawing.Point(4, 22);
            this.CategoriesTabPage.Name = "CategoriesTabPage";
            this.CategoriesTabPage.Size = new System.Drawing.Size(1332, 652);
            this.CategoriesTabPage.TabIndex = 3;
            this.CategoriesTabPage.Text = "Categories";
            this.CategoriesTabPage.UseVisualStyleBackColor = true;
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.AddCategoryButton.Location = new System.Drawing.Point(541, 3);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(198, 38);
            this.AddCategoryButton.TabIndex = 13;
            this.AddCategoryButton.Text = "Add category";
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // CategoriesLayoutTable
            // 
            this.CategoriesLayoutTable.AutoScroll = true;
            this.CategoriesLayoutTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.CategoriesLayoutTable.ColumnCount = 5;
            this.CategoriesLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.CategoriesLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.CategoriesLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.CategoriesLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.CategoriesLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.CategoriesLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CategoriesLayoutTable.Location = new System.Drawing.Point(126, 47);
            this.CategoriesLayoutTable.Name = "CategoriesLayoutTable";
            this.CategoriesLayoutTable.RowCount = 19;
            this.CategoriesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CategoriesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CategoriesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CategoriesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CategoriesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CategoriesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CategoriesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CategoriesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CategoriesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CategoriesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CategoriesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CategoriesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CategoriesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CategoriesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CategoriesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CategoriesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CategoriesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CategoriesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CategoriesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CategoriesLayoutTable.Size = new System.Drawing.Size(1074, 600);
            this.CategoriesLayoutTable.TabIndex = 12;
            // 
            // ManufacturersTabPage
            // 
            this.ManufacturersTabPage.Controls.Add(this.AddManufacturerButton);
            this.ManufacturersTabPage.Controls.Add(this.ManufacturersLayoutTable);
            this.ManufacturersTabPage.Location = new System.Drawing.Point(4, 22);
            this.ManufacturersTabPage.Name = "ManufacturersTabPage";
            this.ManufacturersTabPage.Size = new System.Drawing.Size(1332, 652);
            this.ManufacturersTabPage.TabIndex = 4;
            this.ManufacturersTabPage.Text = "Manufacturers";
            this.ManufacturersTabPage.UseVisualStyleBackColor = true;
            // 
            // AddManufacturerButton
            // 
            this.AddManufacturerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.AddManufacturerButton.Location = new System.Drawing.Point(536, 3);
            this.AddManufacturerButton.Name = "AddManufacturerButton";
            this.AddManufacturerButton.Size = new System.Drawing.Size(198, 38);
            this.AddManufacturerButton.TabIndex = 14;
            this.AddManufacturerButton.Text = "Add manufacturer";
            this.AddManufacturerButton.UseVisualStyleBackColor = true;
            this.AddManufacturerButton.Click += new System.EventHandler(this.AddManufacturerButton_Click);
            // 
            // ManufacturersLayoutTable
            // 
            this.ManufacturersLayoutTable.AutoScroll = true;
            this.ManufacturersLayoutTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.ManufacturersLayoutTable.ColumnCount = 3;
            this.ManufacturersLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.ManufacturersLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.ManufacturersLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.ManufacturersLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ManufacturersLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ManufacturersLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ManufacturersLayoutTable.Location = new System.Drawing.Point(327, 42);
            this.ManufacturersLayoutTable.Name = "ManufacturersLayoutTable";
            this.ManufacturersLayoutTable.RowCount = 19;
            this.ManufacturersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ManufacturersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ManufacturersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ManufacturersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ManufacturersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ManufacturersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ManufacturersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ManufacturersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ManufacturersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ManufacturersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ManufacturersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ManufacturersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ManufacturersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ManufacturersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ManufacturersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ManufacturersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ManufacturersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ManufacturersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ManufacturersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ManufacturersLayoutTable.Size = new System.Drawing.Size(666, 600);
            this.ManufacturersLayoutTable.TabIndex = 13;
            // 
            // Delivery_TypesTabPage
            // 
            this.Delivery_TypesTabPage.Controls.Add(this.label1);
            this.Delivery_TypesTabPage.Controls.Add(this.Delivery_TypesDeleteCounter);
            this.Delivery_TypesTabPage.Controls.Add(this.Delivery_TypesDeleteByIdButton);
            this.Delivery_TypesTabPage.Controls.Add(this.Delivery_TypesSubmitButton);
            this.Delivery_TypesTabPage.Controls.Add(this.Delivery_TypesAddButton);
            this.Delivery_TypesTabPage.Controls.Add(this.Delivery_TypesLayoutTable);
            this.Delivery_TypesTabPage.Location = new System.Drawing.Point(4, 22);
            this.Delivery_TypesTabPage.Name = "Delivery_TypesTabPage";
            this.Delivery_TypesTabPage.Size = new System.Drawing.Size(1332, 652);
            this.Delivery_TypesTabPage.TabIndex = 5;
            this.Delivery_TypesTabPage.Text = "Delivery types";
            this.Delivery_TypesTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(146, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // Delivery_TypesDeleteCounter
            // 
            this.Delivery_TypesDeleteCounter.Location = new System.Drawing.Point(177, 154);
            this.Delivery_TypesDeleteCounter.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.Delivery_TypesDeleteCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Delivery_TypesDeleteCounter.Name = "Delivery_TypesDeleteCounter";
            this.Delivery_TypesDeleteCounter.Size = new System.Drawing.Size(80, 20);
            this.Delivery_TypesDeleteCounter.TabIndex = 20;
            this.Delivery_TypesDeleteCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Delivery_TypesDeleteByIdButton
            // 
            this.Delivery_TypesDeleteByIdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Delivery_TypesDeleteByIdButton.Location = new System.Drawing.Point(120, 85);
            this.Delivery_TypesDeleteByIdButton.Name = "Delivery_TypesDeleteByIdButton";
            this.Delivery_TypesDeleteByIdButton.Size = new System.Drawing.Size(161, 63);
            this.Delivery_TypesDeleteByIdButton.TabIndex = 17;
            this.Delivery_TypesDeleteByIdButton.Text = "Delete by ID↓↓↓";
            this.Delivery_TypesDeleteByIdButton.UseVisualStyleBackColor = true;
            this.Delivery_TypesDeleteByIdButton.Click += new System.EventHandler(this.Delivery_TypesDeleteByIdButton_Click);
            // 
            // Delivery_TypesSubmitButton
            // 
            this.Delivery_TypesSubmitButton.BackColor = System.Drawing.Color.GreenYellow;
            this.Delivery_TypesSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.Delivery_TypesSubmitButton.Location = new System.Drawing.Point(992, 561);
            this.Delivery_TypesSubmitButton.Name = "Delivery_TypesSubmitButton";
            this.Delivery_TypesSubmitButton.Size = new System.Drawing.Size(327, 75);
            this.Delivery_TypesSubmitButton.TabIndex = 16;
            this.Delivery_TypesSubmitButton.Text = "Submit";
            this.Delivery_TypesSubmitButton.UseVisualStyleBackColor = false;
            this.Delivery_TypesSubmitButton.Click += new System.EventHandler(this.Delivery_TypesSubmitButton_Click);
            // 
            // Delivery_TypesAddButton
            // 
            this.Delivery_TypesAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Delivery_TypesAddButton.Location = new System.Drawing.Point(120, 16);
            this.Delivery_TypesAddButton.Name = "Delivery_TypesAddButton";
            this.Delivery_TypesAddButton.Size = new System.Drawing.Size(161, 63);
            this.Delivery_TypesAddButton.TabIndex = 15;
            this.Delivery_TypesAddButton.Text = "Add new type";
            this.Delivery_TypesAddButton.UseVisualStyleBackColor = true;
            this.Delivery_TypesAddButton.Click += new System.EventHandler(this.Delivery_TypesAddButton_Click);
            // 
            // Delivery_TypesLayoutTable
            // 
            this.Delivery_TypesLayoutTable.AutoScroll = true;
            this.Delivery_TypesLayoutTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Delivery_TypesLayoutTable.ColumnCount = 2;
            this.Delivery_TypesLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.Delivery_TypesLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 274F));
            this.Delivery_TypesLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Delivery_TypesLayoutTable.Location = new System.Drawing.Point(287, 16);
            this.Delivery_TypesLayoutTable.Name = "Delivery_TypesLayoutTable";
            this.Delivery_TypesLayoutTable.RowCount = 19;
            this.Delivery_TypesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Delivery_TypesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Delivery_TypesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Delivery_TypesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Delivery_TypesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Delivery_TypesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Delivery_TypesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Delivery_TypesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Delivery_TypesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Delivery_TypesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Delivery_TypesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Delivery_TypesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Delivery_TypesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Delivery_TypesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Delivery_TypesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Delivery_TypesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Delivery_TypesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Delivery_TypesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Delivery_TypesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Delivery_TypesLayoutTable.Size = new System.Drawing.Size(481, 593);
            this.Delivery_TypesLayoutTable.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 681);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SpearShopDesktop";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.GoodsTabPage.ResumeLayout(false);
            this.GoodsSearchPanel.ResumeLayout(false);
            this.GoodsSearchPanel.PerformLayout();
            this.GoodsSortPanel.ResumeLayout(false);
            this.GoodsSortPanel.PerformLayout();
            this.GoodsPriceSortPanel.ResumeLayout(false);
            this.GoodsPriceSortPanel.PerformLayout();
            this.GoodsAvailableSortPanel.ResumeLayout(false);
            this.GoodsAvailableSortPanel.PerformLayout();
            this.GoodsImgSortPanel.ResumeLayout(false);
            this.GoodsImgSortPanel.PerformLayout();
            this.GoodsAllFieldsSortPanel.ResumeLayout(false);
            this.GoodsAllFieldsSortPanel.PerformLayout();
            this.GoodsVideoSortPanel.ResumeLayout(false);
            this.GoodsVideoSortPanel.PerformLayout();
            this.OrdersTabPage.ResumeLayout(false);
            this.OrdersStatusPanel.ResumeLayout(false);
            this.OrdersStatusPanel.PerformLayout();
            this.OrdersSearchPanel.ResumeLayout(false);
            this.OrdersSearchPanel.PerformLayout();
            this.CustomersTabPage.ResumeLayout(false);
            this.CategoriesTabPage.ResumeLayout(false);
            this.ManufacturersTabPage.ResumeLayout(false);
            this.Delivery_TypesTabPage.ResumeLayout(false);
            this.Delivery_TypesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Delivery_TypesDeleteCounter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GoodsTabPage;
        private System.Windows.Forms.TabPage OrdersTabPage;
        private System.Windows.Forms.Panel GoodsSortPanel;
        private System.Windows.Forms.Panel GoodsPriceSortPanel;
        private System.Windows.Forms.Button SortPriceClearButton;
        private System.Windows.Forms.Label SortGoodsLabel;
        private System.Windows.Forms.Panel GoodsAvailableSortPanel;
        private System.Windows.Forms.Button SortAvailableClearButton;
        private System.Windows.Forms.Button GoodsSortButton;
        private System.Windows.Forms.Panel GoodsImgSortPanel;
        private System.Windows.Forms.Button SortVideoClearButton;
        private System.Windows.Forms.Panel GoodsAllFieldsSortPanel;
        private System.Windows.Forms.Button SortAllFieldsClearButton;
        private System.Windows.Forms.Panel GoodsVideoSortPanel;
        private System.Windows.Forms.Button SortImgClearButton;
        private System.Windows.Forms.RadioButton GoodsPriceBLRadio;
        private System.Windows.Forms.RadioButton GoodsPriceLBRadio;
        private System.Windows.Forms.RadioButton GoodsNotAvailableRadio;
        private System.Windows.Forms.RadioButton GoodsAvailableRadio;
        private System.Windows.Forms.RadioButton GoodsImgFalseRadio;
        private System.Windows.Forms.RadioButton GoodsImgTrueRadio;
        private System.Windows.Forms.RadioButton GoodsAllFieldsFalseRadio;
        private System.Windows.Forms.RadioButton GoodsAllFieldsTrueRadio;
        private System.Windows.Forms.RadioButton GoodsVideoFalseRadio;
        private System.Windows.Forms.RadioButton GoodsVideoTrueRadio;
        private System.Windows.Forms.TabPage CustomersTabPage;
        private System.Windows.Forms.TabPage CategoriesTabPage;
        private System.Windows.Forms.TabPage ManufacturersTabPage;
        private System.Windows.Forms.Panel GoodsSearchPanel;
        private System.Windows.Forms.TextBox GoodsSearchTextBox;
        private System.Windows.Forms.Label GoodsSearchLabel;
        private System.Windows.Forms.RadioButton GoodsSearchByNameRadio;
        private System.Windows.Forms.RadioButton GoodsSearchByIdRadio;
        private System.Windows.Forms.Panel OrdersSearchPanel;
        private System.Windows.Forms.Label OrdersSearchLabel;
        private System.Windows.Forms.RadioButton OrdersSearchByCustomerNameRadio;
        private System.Windows.Forms.RadioButton OrdersSearchByOrderIdRadio;
        private System.Windows.Forms.TextBox OrdersSearchTextBox;
        private System.Windows.Forms.Panel OrdersStatusPanel;
        private System.Windows.Forms.Label OrdersStatusLabel;
        private System.Windows.Forms.RadioButton ProcessedStatusRadio;
        private System.Windows.Forms.RadioButton ReadyStatusRadio;
        private System.Windows.Forms.RadioButton NewStatusRadio;
        public System.Windows.Forms.TableLayoutPanel GoodsLayoutTable;
        private System.Windows.Forms.Button GoodsAddGoodButton;
        private System.Windows.Forms.TableLayoutPanel OrdersLayoutTable;
        private System.Windows.Forms.RadioButton AllStatusRadio;
        private System.Windows.Forms.TableLayoutPanel CustomersLayoutTable;
        private System.Windows.Forms.TableLayoutPanel CategoriesLayoutTable;
        private System.Windows.Forms.TableLayoutPanel ManufacturersLayoutTable;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Button AddCategoryButton;
        private System.Windows.Forms.Button AddManufacturerButton;
        private System.Windows.Forms.TabPage Delivery_TypesTabPage;
        private System.Windows.Forms.Button Delivery_TypesAddButton;
        private System.Windows.Forms.TableLayoutPanel Delivery_TypesLayoutTable;
        private System.Windows.Forms.Button Delivery_TypesSubmitButton;
        private System.Windows.Forms.Button Delivery_TypesDeleteByIdButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Delivery_TypesDeleteCounter;
    }
}


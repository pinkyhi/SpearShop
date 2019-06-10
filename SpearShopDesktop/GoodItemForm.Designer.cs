namespace SpearShopDesktop
{
    partial class GoodItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GoodItemPictureBox = new System.Windows.Forms.PictureBox();
            this.GoodItemIdLabel = new System.Windows.Forms.Label();
            this.GoodItemImgsList = new System.Windows.Forms.ListBox();
            this.GoodItemVideosList = new System.Windows.Forms.ListBox();
            this.GoodItemImgAddButton = new System.Windows.Forms.Button();
            this.GoodItemImgDeleteButton = new System.Windows.Forms.Button();
            this.GoodItemVideoDeleteButton = new System.Windows.Forms.Button();
            this.GoodItemVideoAddButton = new System.Windows.Forms.Button();
            this.GoodItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.GoodItemNameTextBox = new System.Windows.Forms.TextBox();
            this.GoodItemPriceLabel = new System.Windows.Forms.Label();
            this.GoodItemSubmitButton = new System.Windows.Forms.Button();
            this.GoodItemCategoriesStripMenu = new System.Windows.Forms.MenuStrip();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GoodItemManufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GoodItemPriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.GoodItemOpenImgDialog = new System.Windows.Forms.OpenFileDialog();
            this.GoodItemOpenVideoDialog = new System.Windows.Forms.OpenFileDialog();
            this.GoodItemImgOpen = new System.Windows.Forms.Button();
            this.GoodItemVideoOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GoodItemAvailableCounter = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.GoodItemDeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GoodItemPictureBox)).BeginInit();
            this.GoodItemCategoriesStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoodItemPriceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodItemAvailableCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // GoodItemPictureBox
            // 
            this.GoodItemPictureBox.BackColor = System.Drawing.Color.White;
            this.GoodItemPictureBox.Location = new System.Drawing.Point(15, 62);
            this.GoodItemPictureBox.Name = "GoodItemPictureBox";
            this.GoodItemPictureBox.Size = new System.Drawing.Size(300, 300);
            this.GoodItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GoodItemPictureBox.TabIndex = 0;
            this.GoodItemPictureBox.TabStop = false;
            // 
            // GoodItemIdLabel
            // 
            this.GoodItemIdLabel.AutoSize = true;
            this.GoodItemIdLabel.Location = new System.Drawing.Point(12, 9);
            this.GoodItemIdLabel.Name = "GoodItemIdLabel";
            this.GoodItemIdLabel.Size = new System.Drawing.Size(24, 13);
            this.GoodItemIdLabel.TabIndex = 1;
            this.GoodItemIdLabel.Text = "ID: ";
            // 
            // GoodItemImgsList
            // 
            this.GoodItemImgsList.CausesValidation = false;
            this.GoodItemImgsList.FormattingEnabled = true;
            this.GoodItemImgsList.HorizontalScrollbar = true;
            this.GoodItemImgsList.Location = new System.Drawing.Point(815, 62);
            this.GoodItemImgsList.Name = "GoodItemImgsList";
            this.GoodItemImgsList.Size = new System.Drawing.Size(348, 134);
            this.GoodItemImgsList.TabIndex = 3;
            // 
            // GoodItemVideosList
            // 
            this.GoodItemVideosList.FormattingEnabled = true;
            this.GoodItemVideosList.HorizontalScrollbar = true;
            this.GoodItemVideosList.Location = new System.Drawing.Point(815, 291);
            this.GoodItemVideosList.Name = "GoodItemVideosList";
            this.GoodItemVideosList.Size = new System.Drawing.Size(348, 134);
            this.GoodItemVideosList.TabIndex = 4;
            // 
            // GoodItemImgAddButton
            // 
            this.GoodItemImgAddButton.Location = new System.Drawing.Point(815, 203);
            this.GoodItemImgAddButton.Name = "GoodItemImgAddButton";
            this.GoodItemImgAddButton.Size = new System.Drawing.Size(105, 38);
            this.GoodItemImgAddButton.TabIndex = 5;
            this.GoodItemImgAddButton.Text = "Add";
            this.GoodItemImgAddButton.UseVisualStyleBackColor = true;
            this.GoodItemImgAddButton.Click += new System.EventHandler(this.GoodItemImgAddButton_Click);
            // 
            // GoodItemImgDeleteButton
            // 
            this.GoodItemImgDeleteButton.Location = new System.Drawing.Point(926, 203);
            this.GoodItemImgDeleteButton.Name = "GoodItemImgDeleteButton";
            this.GoodItemImgDeleteButton.Size = new System.Drawing.Size(105, 38);
            this.GoodItemImgDeleteButton.TabIndex = 6;
            this.GoodItemImgDeleteButton.Text = "Delete";
            this.GoodItemImgDeleteButton.UseVisualStyleBackColor = true;
            this.GoodItemImgDeleteButton.Click += new System.EventHandler(this.GoodItemImgDeleteButton_Click);
            // 
            // GoodItemVideoDeleteButton
            // 
            this.GoodItemVideoDeleteButton.Location = new System.Drawing.Point(926, 431);
            this.GoodItemVideoDeleteButton.Name = "GoodItemVideoDeleteButton";
            this.GoodItemVideoDeleteButton.Size = new System.Drawing.Size(105, 38);
            this.GoodItemVideoDeleteButton.TabIndex = 8;
            this.GoodItemVideoDeleteButton.Text = "Delete";
            this.GoodItemVideoDeleteButton.UseVisualStyleBackColor = true;
            this.GoodItemVideoDeleteButton.Click += new System.EventHandler(this.GoodItemVideoDeleteButton_Click);
            // 
            // GoodItemVideoAddButton
            // 
            this.GoodItemVideoAddButton.Location = new System.Drawing.Point(815, 432);
            this.GoodItemVideoAddButton.Name = "GoodItemVideoAddButton";
            this.GoodItemVideoAddButton.Size = new System.Drawing.Size(105, 38);
            this.GoodItemVideoAddButton.TabIndex = 7;
            this.GoodItemVideoAddButton.Text = "Add";
            this.GoodItemVideoAddButton.UseVisualStyleBackColor = true;
            this.GoodItemVideoAddButton.Click += new System.EventHandler(this.GoodItemVideoAddButton_Click);
            // 
            // GoodItemDescriptionTextBox
            // 
            this.GoodItemDescriptionTextBox.Location = new System.Drawing.Point(331, 62);
            this.GoodItemDescriptionTextBox.Multiline = true;
            this.GoodItemDescriptionTextBox.Name = "GoodItemDescriptionTextBox";
            this.GoodItemDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GoodItemDescriptionTextBox.Size = new System.Drawing.Size(417, 300);
            this.GoodItemDescriptionTextBox.TabIndex = 9;
            // 
            // GoodItemNameTextBox
            // 
            this.GoodItemNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.GoodItemNameTextBox.Location = new System.Drawing.Point(29, 25);
            this.GoodItemNameTextBox.Name = "GoodItemNameTextBox";
            this.GoodItemNameTextBox.Size = new System.Drawing.Size(286, 29);
            this.GoodItemNameTextBox.TabIndex = 10;
            // 
            // GoodItemPriceLabel
            // 
            this.GoodItemPriceLabel.AutoSize = true;
            this.GoodItemPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.GoodItemPriceLabel.Location = new System.Drawing.Point(598, 374);
            this.GoodItemPriceLabel.Name = "GoodItemPriceLabel";
            this.GoodItemPriceLabel.Size = new System.Drawing.Size(58, 24);
            this.GoodItemPriceLabel.TabIndex = 13;
            this.GoodItemPriceLabel.Text = "Price:";
            // 
            // GoodItemSubmitButton
            // 
            this.GoodItemSubmitButton.BackColor = System.Drawing.Color.GreenYellow;
            this.GoodItemSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.GoodItemSubmitButton.Location = new System.Drawing.Point(815, 521);
            this.GoodItemSubmitButton.Name = "GoodItemSubmitButton";
            this.GoodItemSubmitButton.Size = new System.Drawing.Size(327, 75);
            this.GoodItemSubmitButton.TabIndex = 15;
            this.GoodItemSubmitButton.Text = "Submit";
            this.GoodItemSubmitButton.UseVisualStyleBackColor = false;
            this.GoodItemSubmitButton.Click += new System.EventHandler(this.GoodItemSubmitButton_Click);
            // 
            // GoodItemCategoriesStripMenu
            // 
            this.GoodItemCategoriesStripMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GoodItemCategoriesStripMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.GoodItemCategoriesStripMenu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoodItemCategoriesStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.GoodItemCategoriesStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriesToolStripMenuItem});
            this.GoodItemCategoriesStripMenu.Location = new System.Drawing.Point(15, 372);
            this.GoodItemCategoriesStripMenu.Name = "GoodItemCategoriesStripMenu";
            this.GoodItemCategoriesStripMenu.Size = new System.Drawing.Size(126, 33);
            this.GoodItemCategoriesStripMenu.TabIndex = 16;
            this.GoodItemCategoriesStripMenu.Text = "menuStrip1";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.categoriesToolStripMenuItem.Text = "Categories";
            // 
            // GoodItemManufacturerComboBox
            // 
            this.GoodItemManufacturerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GoodItemManufacturerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.GoodItemManufacturerComboBox.FormattingEnabled = true;
            this.GoodItemManufacturerComboBox.Location = new System.Drawing.Point(414, 372);
            this.GoodItemManufacturerComboBox.Name = "GoodItemManufacturerComboBox";
            this.GoodItemManufacturerComboBox.Size = new System.Drawing.Size(178, 32);
            this.GoodItemManufacturerComboBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(283, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Manufacturer:";
            // 
            // GoodItemPriceNumeric
            // 
            this.GoodItemPriceNumeric.DecimalPlaces = 2;
            this.GoodItemPriceNumeric.Location = new System.Drawing.Point(662, 377);
            this.GoodItemPriceNumeric.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.GoodItemPriceNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GoodItemPriceNumeric.Name = "GoodItemPriceNumeric";
            this.GoodItemPriceNumeric.Size = new System.Drawing.Size(120, 20);
            this.GoodItemPriceNumeric.TabIndex = 19;
            this.GoodItemPriceNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GoodItemOpenImgDialog
            // 
            this.GoodItemOpenImgDialog.FileName = "image.jpg";
            this.GoodItemOpenImgDialog.Filter = "*.jpg|*.jpg|*.png|*.png";
            this.GoodItemOpenImgDialog.InitialDirectory = "C:\\";
            // 
            // GoodItemOpenVideoDialog
            // 
            this.GoodItemOpenVideoDialog.DefaultExt = "*.mp4 | *.mp4 | *.avi | *.avi";
            this.GoodItemOpenVideoDialog.FileName = "video.mp4";
            this.GoodItemOpenVideoDialog.InitialDirectory = "C:\\";
            // 
            // GoodItemImgOpen
            // 
            this.GoodItemImgOpen.Location = new System.Drawing.Point(1037, 203);
            this.GoodItemImgOpen.Name = "GoodItemImgOpen";
            this.GoodItemImgOpen.Size = new System.Drawing.Size(105, 38);
            this.GoodItemImgOpen.TabIndex = 20;
            this.GoodItemImgOpen.Text = "Open";
            this.GoodItemImgOpen.UseVisualStyleBackColor = true;
            this.GoodItemImgOpen.Click += new System.EventHandler(this.GoodItemImgOpen_Click);
            // 
            // GoodItemVideoOpen
            // 
            this.GoodItemVideoOpen.Location = new System.Drawing.Point(1037, 431);
            this.GoodItemVideoOpen.Name = "GoodItemVideoOpen";
            this.GoodItemVideoOpen.Size = new System.Drawing.Size(105, 38);
            this.GoodItemVideoOpen.TabIndex = 21;
            this.GoodItemVideoOpen.Text = "Open";
            this.GoodItemVideoOpen.UseVisualStyleBackColor = true;
            this.GoodItemVideoOpen.Click += new System.EventHandler(this.GoodItemVideoOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(810, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "Videos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.Location = new System.Drawing.Point(810, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "Images";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label4.Location = new System.Drawing.Point(331, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Description";
            // 
            // GoodItemAvailableCounter
            // 
            this.GoodItemAvailableCounter.Location = new System.Drawing.Point(911, 489);
            this.GoodItemAvailableCounter.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.GoodItemAvailableCounter.Name = "GoodItemAvailableCounter";
            this.GoodItemAvailableCounter.Size = new System.Drawing.Size(120, 20);
            this.GoodItemAvailableCounter.TabIndex = 26;
            this.GoodItemAvailableCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(820, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Available:";
            // 
            // GoodItemDeleteButton
            // 
            this.GoodItemDeleteButton.BackColor = System.Drawing.Color.IndianRed;
            this.GoodItemDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.GoodItemDeleteButton.Location = new System.Drawing.Point(815, 602);
            this.GoodItemDeleteButton.Name = "GoodItemDeleteButton";
            this.GoodItemDeleteButton.Size = new System.Drawing.Size(327, 75);
            this.GoodItemDeleteButton.TabIndex = 27;
            this.GoodItemDeleteButton.Text = "Delete";
            this.GoodItemDeleteButton.UseVisualStyleBackColor = false;
            this.GoodItemDeleteButton.Click += new System.EventHandler(this.GoodItemDeleteButton_Click);
            // 
            // GoodItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 691);
            this.Controls.Add(this.GoodItemDeleteButton);
            this.Controls.Add(this.GoodItemAvailableCounter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GoodItemVideoOpen);
            this.Controls.Add(this.GoodItemImgOpen);
            this.Controls.Add(this.GoodItemPriceNumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoodItemManufacturerComboBox);
            this.Controls.Add(this.GoodItemSubmitButton);
            this.Controls.Add(this.GoodItemPriceLabel);
            this.Controls.Add(this.GoodItemNameTextBox);
            this.Controls.Add(this.GoodItemDescriptionTextBox);
            this.Controls.Add(this.GoodItemVideoDeleteButton);
            this.Controls.Add(this.GoodItemVideoAddButton);
            this.Controls.Add(this.GoodItemImgDeleteButton);
            this.Controls.Add(this.GoodItemImgAddButton);
            this.Controls.Add(this.GoodItemVideosList);
            this.Controls.Add(this.GoodItemImgsList);
            this.Controls.Add(this.GoodItemIdLabel);
            this.Controls.Add(this.GoodItemPictureBox);
            this.Controls.Add(this.GoodItemCategoriesStripMenu);
            this.Name = "GoodItemForm";
            this.Text = "GoodItemForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GoodItemForm_FormClosed);
            this.Load += new System.EventHandler(this.GoodItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GoodItemPictureBox)).EndInit();
            this.GoodItemCategoriesStripMenu.ResumeLayout(false);
            this.GoodItemCategoriesStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoodItemPriceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodItemAvailableCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GoodItemPictureBox;
        private System.Windows.Forms.Label GoodItemIdLabel;
        private System.Windows.Forms.ListBox GoodItemImgsList;
        private System.Windows.Forms.ListBox GoodItemVideosList;
        private System.Windows.Forms.Button GoodItemImgAddButton;
        private System.Windows.Forms.Button GoodItemImgDeleteButton;
        private System.Windows.Forms.Button GoodItemVideoDeleteButton;
        private System.Windows.Forms.Button GoodItemVideoAddButton;
        private System.Windows.Forms.TextBox GoodItemDescriptionTextBox;
        private System.Windows.Forms.TextBox GoodItemNameTextBox;
        private System.Windows.Forms.Label GoodItemPriceLabel;
        private System.Windows.Forms.Button GoodItemSubmitButton;
        private System.Windows.Forms.MenuStrip GoodItemCategoriesStripMenu;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ComboBox GoodItemManufacturerComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown GoodItemPriceNumeric;
        private System.Windows.Forms.OpenFileDialog GoodItemOpenImgDialog;
        private System.Windows.Forms.OpenFileDialog GoodItemOpenVideoDialog;
        private System.Windows.Forms.Button GoodItemImgOpen;
        private System.Windows.Forms.Button GoodItemVideoOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown GoodItemAvailableCounter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GoodItemDeleteButton;
    }
}
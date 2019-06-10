namespace SpearShopDesktop
{
    partial class OrderItemForm
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
            this.OrderItemIdLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderItemPriceLabel = new System.Windows.Forms.Label();
            this.OrderItemStatusComboBox = new System.Windows.Forms.ComboBox();
            this.OrderItemSubmitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderItemGoodOpen = new System.Windows.Forms.Button();
            this.OrderItemGoodAddButton = new System.Windows.Forms.Button();
            this.OrderItemGoodsList = new System.Windows.Forms.ListBox();
            this.OrderItemShowCustomerButton = new System.Windows.Forms.Button();
            this.OrderItemGoodIdToAddTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderItemAddGoodCounter = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.OrderItemDeleteButton = new System.Windows.Forms.Button();
            this.OrderItemDescriptionLabel = new System.Windows.Forms.TextBox();
            this.DeliveryTypeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemAddGoodCounter)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderItemIdLabel
            // 
            this.OrderItemIdLabel.AutoSize = true;
            this.OrderItemIdLabel.Location = new System.Drawing.Point(13, 13);
            this.OrderItemIdLabel.Name = "OrderItemIdLabel";
            this.OrderItemIdLabel.Size = new System.Drawing.Size(21, 13);
            this.OrderItemIdLabel.TabIndex = 0;
            this.OrderItemIdLabel.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description";
            // 
            // OrderItemPriceLabel
            // 
            this.OrderItemPriceLabel.AutoSize = true;
            this.OrderItemPriceLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderItemPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.OrderItemPriceLabel.Location = new System.Drawing.Point(892, 511);
            this.OrderItemPriceLabel.Name = "OrderItemPriceLabel";
            this.OrderItemPriceLabel.Size = new System.Drawing.Size(91, 31);
            this.OrderItemPriceLabel.TabIndex = 3;
            this.OrderItemPriceLabel.Text = "Price: ";
            // 
            // OrderItemStatusComboBox
            // 
            this.OrderItemStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrderItemStatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.OrderItemStatusComboBox.FormattingEnabled = true;
            this.OrderItemStatusComboBox.Location = new System.Drawing.Point(24, 393);
            this.OrderItemStatusComboBox.Name = "OrderItemStatusComboBox";
            this.OrderItemStatusComboBox.Size = new System.Drawing.Size(201, 32);
            this.OrderItemStatusComboBox.TabIndex = 18;
            // 
            // OrderItemSubmitButton
            // 
            this.OrderItemSubmitButton.BackColor = System.Drawing.Color.GreenYellow;
            this.OrderItemSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.OrderItemSubmitButton.Location = new System.Drawing.Point(842, 564);
            this.OrderItemSubmitButton.Name = "OrderItemSubmitButton";
            this.OrderItemSubmitButton.Size = new System.Drawing.Size(327, 75);
            this.OrderItemSubmitButton.TabIndex = 19;
            this.OrderItemSubmitButton.Text = "Submit";
            this.OrderItemSubmitButton.UseVisualStyleBackColor = false;
            this.OrderItemSubmitButton.Click += new System.EventHandler(this.OrderItemSubmitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.Location = new System.Drawing.Point(541, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "Goods";
            // 
            // OrderItemGoodOpen
            // 
            this.OrderItemGoodOpen.Location = new System.Drawing.Point(656, 507);
            this.OrderItemGoodOpen.Name = "OrderItemGoodOpen";
            this.OrderItemGoodOpen.Size = new System.Drawing.Size(105, 38);
            this.OrderItemGoodOpen.TabIndex = 27;
            this.OrderItemGoodOpen.Text = "Open";
            this.OrderItemGoodOpen.UseVisualStyleBackColor = true;
            this.OrderItemGoodOpen.Click += new System.EventHandler(this.OrderItemGoodOpen_Click);
            // 
            // OrderItemGoodAddButton
            // 
            this.OrderItemGoodAddButton.Location = new System.Drawing.Point(545, 507);
            this.OrderItemGoodAddButton.Name = "OrderItemGoodAddButton";
            this.OrderItemGoodAddButton.Size = new System.Drawing.Size(105, 38);
            this.OrderItemGoodAddButton.TabIndex = 25;
            this.OrderItemGoodAddButton.Text = "Add";
            this.OrderItemGoodAddButton.UseVisualStyleBackColor = true;
            this.OrderItemGoodAddButton.Click += new System.EventHandler(this.OrderItemGoodAddButton_Click);
            // 
            // OrderItemGoodsList
            // 
            this.OrderItemGoodsList.CausesValidation = false;
            this.OrderItemGoodsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.OrderItemGoodsList.FormattingEnabled = true;
            this.OrderItemGoodsList.HorizontalScrollbar = true;
            this.OrderItemGoodsList.ItemHeight = 20;
            this.OrderItemGoodsList.Location = new System.Drawing.Point(546, 55);
            this.OrderItemGoodsList.Name = "OrderItemGoodsList";
            this.OrderItemGoodsList.Size = new System.Drawing.Size(585, 444);
            this.OrderItemGoodsList.TabIndex = 24;
            // 
            // OrderItemShowCustomerButton
            // 
            this.OrderItemShowCustomerButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrderItemShowCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.OrderItemShowCustomerButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OrderItemShowCustomerButton.Location = new System.Drawing.Point(310, 390);
            this.OrderItemShowCustomerButton.Name = "OrderItemShowCustomerButton";
            this.OrderItemShowCustomerButton.Size = new System.Drawing.Size(202, 40);
            this.OrderItemShowCustomerButton.TabIndex = 29;
            this.OrderItemShowCustomerButton.Text = "Show customer";
            this.OrderItemShowCustomerButton.UseVisualStyleBackColor = false;
            this.OrderItemShowCustomerButton.Click += new System.EventHandler(this.OrderItemShowCustomerButton_Click);
            // 
            // OrderItemGoodIdToAddTextBox
            // 
            this.OrderItemGoodIdToAddTextBox.Location = new System.Drawing.Point(575, 548);
            this.OrderItemGoodIdToAddTextBox.Name = "OrderItemGoodIdToAddTextBox";
            this.OrderItemGoodIdToAddTextBox.Size = new System.Drawing.Size(74, 20);
            this.OrderItemGoodIdToAddTextBox.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(542, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "ID:";
            // 
            // OrderItemAddGoodCounter
            // 
            this.OrderItemAddGoodCounter.Location = new System.Drawing.Point(597, 574);
            this.OrderItemAddGoodCounter.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.OrderItemAddGoodCounter.Name = "OrderItemAddGoodCounter";
            this.OrderItemAddGoodCounter.Size = new System.Drawing.Size(52, 20);
            this.OrderItemAddGoodCounter.TabIndex = 32;
            this.OrderItemAddGoodCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(540, 573);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Count";
            // 
            // OrderItemDeleteButton
            // 
            this.OrderItemDeleteButton.BackColor = System.Drawing.Color.IndianRed;
            this.OrderItemDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.OrderItemDeleteButton.Location = new System.Drawing.Point(16, 564);
            this.OrderItemDeleteButton.Name = "OrderItemDeleteButton";
            this.OrderItemDeleteButton.Size = new System.Drawing.Size(327, 75);
            this.OrderItemDeleteButton.TabIndex = 34;
            this.OrderItemDeleteButton.Text = "Delete";
            this.OrderItemDeleteButton.UseVisualStyleBackColor = false;
            this.OrderItemDeleteButton.Click += new System.EventHandler(this.OrderItemDeleteButton_Click);
            // 
            // OrderItemDescriptionLabel
            // 
            this.OrderItemDescriptionLabel.Location = new System.Drawing.Point(24, 55);
            this.OrderItemDescriptionLabel.Multiline = true;
            this.OrderItemDescriptionLabel.Name = "OrderItemDescriptionLabel";
            this.OrderItemDescriptionLabel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OrderItemDescriptionLabel.Size = new System.Drawing.Size(488, 319);
            this.OrderItemDescriptionLabel.TabIndex = 35;
            // 
            // DeliveryTypeLabel
            // 
            this.DeliveryTypeLabel.AutoSize = true;
            this.DeliveryTypeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeliveryTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeliveryTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.DeliveryTypeLabel.Location = new System.Drawing.Point(3, 0);
            this.DeliveryTypeLabel.Name = "DeliveryTypeLabel";
            this.DeliveryTypeLabel.Size = new System.Drawing.Size(109, 26);
            this.DeliveryTypeLabel.TabIndex = 36;
            this.DeliveryTypeLabel.Text = "Delivery by ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeliveryTypeLabel);
            this.panel1.Location = new System.Drawing.Point(312, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 100);
            this.panel1.TabIndex = 37;
            // 
            // OrderItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 691);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OrderItemDescriptionLabel);
            this.Controls.Add(this.OrderItemDeleteButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OrderItemAddGoodCounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrderItemGoodIdToAddTextBox);
            this.Controls.Add(this.OrderItemShowCustomerButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrderItemGoodOpen);
            this.Controls.Add(this.OrderItemGoodAddButton);
            this.Controls.Add(this.OrderItemGoodsList);
            this.Controls.Add(this.OrderItemSubmitButton);
            this.Controls.Add(this.OrderItemStatusComboBox);
            this.Controls.Add(this.OrderItemPriceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderItemIdLabel);
            this.Name = "OrderItemForm";
            this.Text = "OrderItemForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderItemForm_FormClosed);
            this.Load += new System.EventHandler(this.OrderItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemAddGoodCounter)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderItemIdLabel;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label OrderItemPriceLabel;
        private System.Windows.Forms.ComboBox OrderItemStatusComboBox;
        private System.Windows.Forms.Button OrderItemSubmitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OrderItemGoodOpen;
        private System.Windows.Forms.Button OrderItemGoodAddButton;
        private System.Windows.Forms.ListBox OrderItemGoodsList;
        private System.Windows.Forms.Button OrderItemShowCustomerButton;
        private System.Windows.Forms.TextBox OrderItemGoodIdToAddTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown OrderItemAddGoodCounter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OrderItemDeleteButton;
        private System.Windows.Forms.TextBox OrderItemDescriptionLabel;
        private System.Windows.Forms.Label DeliveryTypeLabel;
        private System.Windows.Forms.Panel panel1;
    }
}
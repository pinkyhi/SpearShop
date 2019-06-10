namespace SpearShopDesktop
{
    partial class CategoryItemForm
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
            this.CategoryItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoryItemCategoriesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryItemIdLabel = new System.Windows.Forms.Label();
            this.CategoryItemOpenButton = new System.Windows.Forms.Button();
            this.CategoryItemChooseParentButton = new System.Windows.Forms.Button();
            this.CategoryItemDeleteParentButton = new System.Windows.Forms.Button();
            this.CategoryItemDeleteButton = new System.Windows.Forms.Button();
            this.CategoryItemSubmitButton = new System.Windows.Forms.Button();
            this.CategoryItemParentIdLabel = new System.Windows.Forms.Label();
            this.CategoryItemLevelLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryItemNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CategoryItemDescriptionTextBox
            // 
            this.CategoryItemDescriptionTextBox.Location = new System.Drawing.Point(30, 92);
            this.CategoryItemDescriptionTextBox.Multiline = true;
            this.CategoryItemDescriptionTextBox.Name = "CategoryItemDescriptionTextBox";
            this.CategoryItemDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CategoryItemDescriptionTextBox.Size = new System.Drawing.Size(488, 319);
            this.CategoryItemDescriptionTextBox.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.Location = new System.Drawing.Point(547, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(444, 26);
            this.label3.TabIndex = 39;
            this.label3.Text = "Here you can choose parent for this category";
            // 
            // CategoryItemCategoriesList
            // 
            this.CategoryItemCategoriesList.CausesValidation = false;
            this.CategoryItemCategoriesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CategoryItemCategoriesList.FormattingEnabled = true;
            this.CategoryItemCategoriesList.HorizontalScrollbar = true;
            this.CategoryItemCategoriesList.ItemHeight = 20;
            this.CategoryItemCategoriesList.Location = new System.Drawing.Point(552, 63);
            this.CategoryItemCategoriesList.Name = "CategoryItemCategoriesList";
            this.CategoryItemCategoriesList.Size = new System.Drawing.Size(585, 444);
            this.CategoryItemCategoriesList.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(17, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 37;
            this.label1.Text = "Description";
            // 
            // CategoryItemIdLabel
            // 
            this.CategoryItemIdLabel.AutoSize = true;
            this.CategoryItemIdLabel.Location = new System.Drawing.Point(19, 9);
            this.CategoryItemIdLabel.Name = "CategoryItemIdLabel";
            this.CategoryItemIdLabel.Size = new System.Drawing.Size(21, 13);
            this.CategoryItemIdLabel.TabIndex = 36;
            this.CategoryItemIdLabel.Text = "ID:";
            // 
            // CategoryItemOpenButton
            // 
            this.CategoryItemOpenButton.Location = new System.Drawing.Point(564, 513);
            this.CategoryItemOpenButton.Name = "CategoryItemOpenButton";
            this.CategoryItemOpenButton.Size = new System.Drawing.Size(107, 40);
            this.CategoryItemOpenButton.TabIndex = 41;
            this.CategoryItemOpenButton.Text = "Open";
            this.CategoryItemOpenButton.UseVisualStyleBackColor = true;
            this.CategoryItemOpenButton.Click += new System.EventHandler(this.CategoryItemOpenButton_Click);
            // 
            // CategoryItemChooseParentButton
            // 
            this.CategoryItemChooseParentButton.Location = new System.Drawing.Point(677, 513);
            this.CategoryItemChooseParentButton.Name = "CategoryItemChooseParentButton";
            this.CategoryItemChooseParentButton.Size = new System.Drawing.Size(107, 40);
            this.CategoryItemChooseParentButton.TabIndex = 42;
            this.CategoryItemChooseParentButton.Text = "Choose parent";
            this.CategoryItemChooseParentButton.UseVisualStyleBackColor = true;
            this.CategoryItemChooseParentButton.Click += new System.EventHandler(this.CategoryItemChooseParentButton_Click);
            // 
            // CategoryItemDeleteParentButton
            // 
            this.CategoryItemDeleteParentButton.Location = new System.Drawing.Point(790, 513);
            this.CategoryItemDeleteParentButton.Name = "CategoryItemDeleteParentButton";
            this.CategoryItemDeleteParentButton.Size = new System.Drawing.Size(107, 40);
            this.CategoryItemDeleteParentButton.TabIndex = 43;
            this.CategoryItemDeleteParentButton.Text = "Delete parent";
            this.CategoryItemDeleteParentButton.UseVisualStyleBackColor = true;
            this.CategoryItemDeleteParentButton.Click += new System.EventHandler(this.CategoryItemDeleteParentButton_Click);
            // 
            // CategoryItemDeleteButton
            // 
            this.CategoryItemDeleteButton.BackColor = System.Drawing.Color.IndianRed;
            this.CategoryItemDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.CategoryItemDeleteButton.Location = new System.Drawing.Point(12, 604);
            this.CategoryItemDeleteButton.Name = "CategoryItemDeleteButton";
            this.CategoryItemDeleteButton.Size = new System.Drawing.Size(327, 75);
            this.CategoryItemDeleteButton.TabIndex = 44;
            this.CategoryItemDeleteButton.Text = "Delete";
            this.CategoryItemDeleteButton.UseVisualStyleBackColor = false;
            this.CategoryItemDeleteButton.Click += new System.EventHandler(this.CategoryItemDeleteButton_Click);
            // 
            // CategoryItemSubmitButton
            // 
            this.CategoryItemSubmitButton.BackColor = System.Drawing.Color.GreenYellow;
            this.CategoryItemSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.CategoryItemSubmitButton.Location = new System.Drawing.Point(836, 604);
            this.CategoryItemSubmitButton.Name = "CategoryItemSubmitButton";
            this.CategoryItemSubmitButton.Size = new System.Drawing.Size(327, 75);
            this.CategoryItemSubmitButton.TabIndex = 45;
            this.CategoryItemSubmitButton.Text = "Submit";
            this.CategoryItemSubmitButton.UseVisualStyleBackColor = false;
            this.CategoryItemSubmitButton.Click += new System.EventHandler(this.CategoryItemSubmitButton_Click);
            // 
            // CategoryItemParentIdLabel
            // 
            this.CategoryItemParentIdLabel.AutoSize = true;
            this.CategoryItemParentIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CategoryItemParentIdLabel.Location = new System.Drawing.Point(34, 418);
            this.CategoryItemParentIdLabel.Name = "CategoryItemParentIdLabel";
            this.CategoryItemParentIdLabel.Size = new System.Drawing.Size(91, 24);
            this.CategoryItemParentIdLabel.TabIndex = 46;
            this.CategoryItemParentIdLabel.Text = "Parent ID:";
            // 
            // CategoryItemLevelLabel
            // 
            this.CategoryItemLevelLabel.AutoSize = true;
            this.CategoryItemLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CategoryItemLevelLabel.Location = new System.Drawing.Point(34, 460);
            this.CategoryItemLevelLabel.Name = "CategoryItemLevelLabel";
            this.CategoryItemLevelLabel.Size = new System.Drawing.Size(65, 24);
            this.CategoryItemLevelLabel.TabIndex = 47;
            this.CategoryItemLevelLabel.Text = "Level: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 48;
            this.label2.Text = "Name:";
            // 
            // CategoryItemNameTextBox
            // 
            this.CategoryItemNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CategoryItemNameTextBox.Location = new System.Drawing.Point(100, 25);
            this.CategoryItemNameTextBox.Name = "CategoryItemNameTextBox";
            this.CategoryItemNameTextBox.Size = new System.Drawing.Size(249, 29);
            this.CategoryItemNameTextBox.TabIndex = 49;
            // 
            // CategoryItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 691);
            this.Controls.Add(this.CategoryItemNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CategoryItemLevelLabel);
            this.Controls.Add(this.CategoryItemParentIdLabel);
            this.Controls.Add(this.CategoryItemSubmitButton);
            this.Controls.Add(this.CategoryItemDeleteButton);
            this.Controls.Add(this.CategoryItemDeleteParentButton);
            this.Controls.Add(this.CategoryItemChooseParentButton);
            this.Controls.Add(this.CategoryItemOpenButton);
            this.Controls.Add(this.CategoryItemDescriptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CategoryItemCategoriesList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoryItemIdLabel);
            this.Name = "CategoryItemForm";
            this.Text = "CategoryItemForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CategoryItemForm_FormClosed);
            this.Load += new System.EventHandler(this.CategoryItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CategoryItemDescriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox CategoryItemCategoriesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CategoryItemIdLabel;
        private System.Windows.Forms.Button CategoryItemOpenButton;
        private System.Windows.Forms.Button CategoryItemChooseParentButton;
        private System.Windows.Forms.Button CategoryItemDeleteParentButton;
        private System.Windows.Forms.Button CategoryItemDeleteButton;
        private System.Windows.Forms.Button CategoryItemSubmitButton;
        private System.Windows.Forms.Label CategoryItemParentIdLabel;
        private System.Windows.Forms.Label CategoryItemLevelLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CategoryItemNameTextBox;
    }
}
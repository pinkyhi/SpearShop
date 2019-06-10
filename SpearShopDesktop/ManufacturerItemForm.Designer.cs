namespace SpearShopDesktop
{
    partial class ManufacturerItemForm
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
            this.ManufacturerItemNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ManufacturerItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ManufacturerItemIdLabel = new System.Windows.Forms.Label();
            this.ManufacturerItemDeleteButton = new System.Windows.Forms.Button();
            this.ManufacturerItemSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManufacturerItemNameTextBox
            // 
            this.ManufacturerItemNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ManufacturerItemNameTextBox.Location = new System.Drawing.Point(362, 49);
            this.ManufacturerItemNameTextBox.Name = "ManufacturerItemNameTextBox";
            this.ManufacturerItemNameTextBox.Size = new System.Drawing.Size(298, 29);
            this.ManufacturerItemNameTextBox.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(279, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 53;
            this.label2.Text = "Name:";
            // 
            // ManufacturerItemDescriptionTextBox
            // 
            this.ManufacturerItemDescriptionTextBox.Location = new System.Drawing.Point(292, 116);
            this.ManufacturerItemDescriptionTextBox.Multiline = true;
            this.ManufacturerItemDescriptionTextBox.Name = "ManufacturerItemDescriptionTextBox";
            this.ManufacturerItemDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ManufacturerItemDescriptionTextBox.Size = new System.Drawing.Size(537, 323);
            this.ManufacturerItemDescriptionTextBox.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(279, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 51;
            this.label1.Text = "Description";
            // 
            // ManufacturerItemIdLabel
            // 
            this.ManufacturerItemIdLabel.AutoSize = true;
            this.ManufacturerItemIdLabel.Location = new System.Drawing.Point(281, 33);
            this.ManufacturerItemIdLabel.Name = "ManufacturerItemIdLabel";
            this.ManufacturerItemIdLabel.Size = new System.Drawing.Size(21, 13);
            this.ManufacturerItemIdLabel.TabIndex = 50;
            this.ManufacturerItemIdLabel.Text = "ID:";
            // 
            // ManufacturerItemDeleteButton
            // 
            this.ManufacturerItemDeleteButton.BackColor = System.Drawing.Color.IndianRed;
            this.ManufacturerItemDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.ManufacturerItemDeleteButton.Location = new System.Drawing.Point(12, 604);
            this.ManufacturerItemDeleteButton.Name = "ManufacturerItemDeleteButton";
            this.ManufacturerItemDeleteButton.Size = new System.Drawing.Size(327, 75);
            this.ManufacturerItemDeleteButton.TabIndex = 55;
            this.ManufacturerItemDeleteButton.Text = "Delete";
            this.ManufacturerItemDeleteButton.UseVisualStyleBackColor = false;
            this.ManufacturerItemDeleteButton.Click += new System.EventHandler(this.ManufacturerItemDeleteButton_Click);
            // 
            // ManufacturerItemSubmitButton
            // 
            this.ManufacturerItemSubmitButton.BackColor = System.Drawing.Color.GreenYellow;
            this.ManufacturerItemSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.ManufacturerItemSubmitButton.Location = new System.Drawing.Point(836, 604);
            this.ManufacturerItemSubmitButton.Name = "ManufacturerItemSubmitButton";
            this.ManufacturerItemSubmitButton.Size = new System.Drawing.Size(327, 75);
            this.ManufacturerItemSubmitButton.TabIndex = 56;
            this.ManufacturerItemSubmitButton.Text = "Submit";
            this.ManufacturerItemSubmitButton.UseVisualStyleBackColor = false;
            this.ManufacturerItemSubmitButton.Click += new System.EventHandler(this.ManufacturerItemSubmitButton_Click);
            // 
            // ManufacturerItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 691);
            this.Controls.Add(this.ManufacturerItemSubmitButton);
            this.Controls.Add(this.ManufacturerItemDeleteButton);
            this.Controls.Add(this.ManufacturerItemNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ManufacturerItemDescriptionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManufacturerItemIdLabel);
            this.Name = "ManufacturerItemForm";
            this.Text = "ManufacturerItemForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManufacturerItemForm_FormClosed);
            this.Load += new System.EventHandler(this.ManufacturerItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ManufacturerItemNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ManufacturerItemDescriptionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ManufacturerItemIdLabel;
        private System.Windows.Forms.Button ManufacturerItemDeleteButton;
        private System.Windows.Forms.Button ManufacturerItemSubmitButton;
    }
}
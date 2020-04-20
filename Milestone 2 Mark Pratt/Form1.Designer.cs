namespace Milestone_2
{
    partial class Form1
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
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.equipButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.dropButton = new System.Windows.Forms.Button();
            this.inventoryBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.equippedLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionBox
            // 
            this.descriptionBox.Enabled = false;
            this.descriptionBox.Location = new System.Drawing.Point(12, 309);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(427, 98);
            this.descriptionBox.TabIndex = 0;
            this.descriptionBox.Text = "";
            // 
            // equipButton
            // 
            this.equipButton.Location = new System.Drawing.Point(12, 250);
            this.equipButton.Name = "equipButton";
            this.equipButton.Size = new System.Drawing.Size(128, 53);
            this.equipButton.TabIndex = 1;
            this.equipButton.Text = "Equip";
            this.equipButton.UseVisualStyleBackColor = true;
            this.equipButton.Click += new System.EventHandler(this.equipButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(164, 250);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(128, 53);
            this.sellButton.TabIndex = 2;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // dropButton
            // 
            this.dropButton.Location = new System.Drawing.Point(311, 250);
            this.dropButton.Name = "dropButton";
            this.dropButton.Size = new System.Drawing.Size(128, 53);
            this.dropButton.TabIndex = 3;
            this.dropButton.Text = "Drop";
            this.dropButton.UseVisualStyleBackColor = true;
            this.dropButton.Click += new System.EventHandler(this.dropButton_Click);
            // 
            // inventoryBox
            // 
            this.inventoryBox.FormattingEnabled = true;
            this.inventoryBox.ItemHeight = 20;
            this.inventoryBox.Location = new System.Drawing.Point(12, 12);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(217, 204);
            this.inventoryBox.Sorted = true;
            this.inventoryBox.TabIndex = 4;
            this.inventoryBox.SelectedIndexChanged += new System.EventHandler(this.inventoryBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.moneyLabel);
            this.groupBox1.Location = new System.Drawing.Point(248, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Money";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(59, 22);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(18, 20);
            this.moneyLabel.TabIndex = 0;
            this.moneyLabel.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.equippedLabel);
            this.groupBox2.Location = new System.Drawing.Point(248, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 71);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipped";
            // 
            // equippedLabel
            // 
            this.equippedLabel.AutoSize = true;
            this.equippedLabel.Location = new System.Drawing.Point(20, 35);
            this.equippedLabel.Name = "equippedLabel";
            this.equippedLabel.Size = new System.Drawing.Size(47, 20);
            this.equippedLabel.TabIndex = 0;
            this.equippedLabel.Text = "None";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 419);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inventoryBox);
            this.Controls.Add(this.dropButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.equipButton);
            this.Controls.Add(this.descriptionBox);
            this.Name = "Form1";
            this.Text = "Inventory";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.Button equipButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button dropButton;
        private System.Windows.Forms.ListBox inventoryBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label equippedLabel;
    }
}


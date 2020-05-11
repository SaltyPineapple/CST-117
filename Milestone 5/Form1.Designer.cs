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
            this.restockButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.storeButton = new System.Windows.Forms.Button();
            this.storeBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.moneyLabel.Size = new System.Drawing.Size(36, 20);
            this.moneyLabel.TabIndex = 0;
            this.moneyLabel.Text = "200";
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
            // restockButton
            // 
            this.restockButton.Location = new System.Drawing.Point(311, 191);
            this.restockButton.Name = "restockButton";
            this.restockButton.Size = new System.Drawing.Size(128, 53);
            this.restockButton.TabIndex = 7;
            this.restockButton.Text = "Restock";
            this.restockButton.UseVisualStyleBackColor = true;
            this.restockButton.Click += new System.EventHandler(this.restockButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(66, 25);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 26);
            this.nameBox.TabIndex = 9;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(66, 69);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(100, 26);
            this.priceBox.TabIndex = 10;
            this.priceBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Price:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(38, 115);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(128, 53);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.searchButton);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.priceBox);
            this.groupBox3.Controls.Add(this.nameBox);
            this.groupBox3.Location = new System.Drawing.Point(465, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 181);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Inventory";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.storeButton);
            this.groupBox4.Controls.Add(this.storeBox);
            this.groupBox4.Location = new System.Drawing.Point(465, 199);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(254, 208);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Store";
            // 
            // storeButton
            // 
            this.storeButton.Location = new System.Drawing.Point(10, 170);
            this.storeButton.Name = "storeButton";
            this.storeButton.Size = new System.Drawing.Size(238, 32);
            this.storeButton.TabIndex = 1;
            this.storeButton.Text = "Purchase";
            this.storeButton.UseVisualStyleBackColor = true;
            this.storeButton.Click += new System.EventHandler(this.storeButton_Click);
            // 
            // storeBox
            // 
            this.storeBox.FormattingEnabled = true;
            this.storeBox.ItemHeight = 20;
            this.storeBox.Location = new System.Drawing.Point(10, 20);
            this.storeBox.Name = "storeBox";
            this.storeBox.Size = new System.Drawing.Size(238, 144);
            this.storeBox.TabIndex = 0;
            this.storeBox.SelectedIndexChanged += new System.EventHandler(this.storeBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 419);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.restockButton);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.Button equipButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button dropButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label equippedLabel;
        private System.Windows.Forms.Button restockButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button storeButton;
        private System.Windows.Forms.ListBox storeBox;
        public System.Windows.Forms.ListBox inventoryBox;
    }
}


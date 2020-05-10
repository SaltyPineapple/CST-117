namespace Project_5 {
    partial class mainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.resultsButton = new System.Windows.Forms.Button();
            this.fruitChoiceBox = new System.Windows.Forms.ComboBox();
            this.lastLetChoiceBox = new System.Windows.Forms.ComboBox();
            this.firstLetChoiceBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.favNumBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultsButton
            // 
            this.resultsButton.Location = new System.Drawing.Point(12, 273);
            this.resultsButton.Name = "resultsButton";
            this.resultsButton.Size = new System.Drawing.Size(350, 66);
            this.resultsButton.TabIndex = 0;
            this.resultsButton.Text = "Get Results";
            this.resultsButton.UseVisualStyleBackColor = true;
            this.resultsButton.Click += new System.EventHandler(this.resultsButton_Click);
            // 
            // fruitChoiceBox
            // 
            this.fruitChoiceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fruitChoiceBox.FormattingEnabled = true;
            this.fruitChoiceBox.Items.AddRange(new object[] {
            "Apple",
            "Banana",
            "Mango",
            "Kiwi",
            "Orange"});
            this.fruitChoiceBox.Location = new System.Drawing.Point(241, 80);
            this.fruitChoiceBox.Name = "fruitChoiceBox";
            this.fruitChoiceBox.Size = new System.Drawing.Size(121, 28);
            this.fruitChoiceBox.TabIndex = 1;
            // 
            // lastLetChoiceBox
            // 
            this.lastLetChoiceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lastLetChoiceBox.FormattingEnabled = true;
            this.lastLetChoiceBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.lastLetChoiceBox.Location = new System.Drawing.Point(241, 177);
            this.lastLetChoiceBox.Name = "lastLetChoiceBox";
            this.lastLetChoiceBox.Size = new System.Drawing.Size(121, 28);
            this.lastLetChoiceBox.TabIndex = 3;
            // 
            // firstLetChoiceBox
            // 
            this.firstLetChoiceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firstLetChoiceBox.FormattingEnabled = true;
            this.firstLetChoiceBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.firstLetChoiceBox.Location = new System.Drawing.Point(241, 127);
            this.firstLetChoiceBox.Name = "firstLetChoiceBox";
            this.firstLetChoiceBox.Size = new System.Drawing.Size(121, 28);
            this.firstLetChoiceBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Favorite Fruit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Letter of First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Letter of Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Favorite Number:";
            // 
            // favNumBox
            // 
            this.favNumBox.Location = new System.Drawing.Point(241, 227);
            this.favNumBox.Name = "favNumBox";
            this.favNumBox.Size = new System.Drawing.Size(121, 26);
            this.favNumBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Location = new System.Drawing.Point(-1, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Answer these questions to get your Lucky Number";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 346);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.favNumBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstLetChoiceBox);
            this.Controls.Add(this.lastLetChoiceBox);
            this.Controls.Add(this.fruitChoiceBox);
            this.Controls.Add(this.resultsButton);
            this.Name = "mainForm";
            this.Text = "Questionaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resultsButton;
        private System.Windows.Forms.ComboBox fruitChoiceBox;
        private System.Windows.Forms.ComboBox lastLetChoiceBox;
        private System.Windows.Forms.ComboBox firstLetChoiceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox favNumBox;
        private System.Windows.Forms.Label label5;
    }
}


namespace Project_3
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
            this.fileButton = new System.Windows.Forms.Button();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.longestWordLabel = new System.Windows.Forms.Label();
            this.firstWord = new System.Windows.Forms.Label();
            this.firstWordLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastWordLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mostVowelsLabel = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(35, 24);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(109, 45);
            this.fileButton.TabIndex = 0;
            this.fileButton.Text = "Read File";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 20;
            this.itemsListBox.Location = new System.Drawing.Point(215, 24);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(199, 364);
            this.itemsListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Longest Word";
            // 
            // longestWordLabel
            // 
            this.longestWordLabel.AutoSize = true;
            this.longestWordLabel.Location = new System.Drawing.Point(31, 124);
            this.longestWordLabel.Name = "longestWordLabel";
            this.longestWordLabel.Size = new System.Drawing.Size(0, 20);
            this.longestWordLabel.TabIndex = 3;
            // 
            // firstWord
            // 
            this.firstWord.AutoSize = true;
            this.firstWord.Location = new System.Drawing.Point(31, 168);
            this.firstWord.Name = "firstWord";
            this.firstWord.Size = new System.Drawing.Size(82, 20);
            this.firstWord.TabIndex = 4;
            this.firstWord.Text = "First Word";
            // 
            // firstWordLabel
            // 
            this.firstWordLabel.AutoSize = true;
            this.firstWordLabel.Location = new System.Drawing.Point(31, 205);
            this.firstWordLabel.Name = "firstWordLabel";
            this.firstWordLabel.Size = new System.Drawing.Size(0, 20);
            this.firstWordLabel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Word";
            // 
            // lastWordLabel
            // 
            this.lastWordLabel.AutoSize = true;
            this.lastWordLabel.Location = new System.Drawing.Point(35, 286);
            this.lastWordLabel.Name = "lastWordLabel";
            this.lastWordLabel.Size = new System.Drawing.Size(0, 20);
            this.lastWordLabel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Most Vowels";
            // 
            // mostVowelsLabel
            // 
            this.mostVowelsLabel.AutoSize = true;
            this.mostVowelsLabel.Location = new System.Drawing.Point(35, 366);
            this.mostVowelsLabel.Name = "mostVowelsLabel";
            this.mostVowelsLabel.Size = new System.Drawing.Size(0, 20);
            this.mostVowelsLabel.TabIndex = 9;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 453);
            this.Controls.Add(this.mostVowelsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastWordLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstWordLabel);
            this.Controls.Add(this.firstWord);
            this.Controls.Add(this.longestWordLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.fileButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label longestWordLabel;
        private System.Windows.Forms.Label firstWord;
        private System.Windows.Forms.Label firstWordLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lastWordLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mostVowelsLabel;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}


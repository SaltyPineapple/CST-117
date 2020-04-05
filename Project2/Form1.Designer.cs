namespace Project2
{
    partial class fruitSelectionForm
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
            this.drawButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameCheckBox = new System.Windows.Forms.CheckBox();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.slicedRadio = new System.Windows.Forms.RadioButton();
            this.wholeRadio = new System.Windows.Forms.RadioButton();
            this.fruitListBox = new System.Windows.Forms.ListBox();
            this.fruitBoxLabel = new System.Windows.Forms.Label();
            this.fruitOutput = new System.Windows.Forms.PictureBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fruitOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(419, 422);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(141, 54);
            this.drawButton.TabIndex = 0;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameCheckBox);
            this.groupBox1.Controls.Add(this.dateCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(63, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Options";
            // 
            // nameCheckBox
            // 
            this.nameCheckBox.AutoSize = true;
            this.nameCheckBox.Location = new System.Drawing.Point(7, 57);
            this.nameCheckBox.Name = "nameCheckBox";
            this.nameCheckBox.Size = new System.Drawing.Size(77, 24);
            this.nameCheckBox.TabIndex = 1;
            this.nameCheckBox.Text = "Name";
            this.nameCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Location = new System.Drawing.Point(7, 26);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(70, 24);
            this.dateCheckBox.TabIndex = 0;
            this.dateCheckBox.Text = "Date";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.slicedRadio);
            this.groupBox2.Controls.Add(this.wholeRadio);
            this.groupBox2.Location = new System.Drawing.Point(63, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Option";
            // 
            // slicedRadio
            // 
            this.slicedRadio.AutoSize = true;
            this.slicedRadio.Location = new System.Drawing.Point(7, 57);
            this.slicedRadio.Name = "slicedRadio";
            this.slicedRadio.Size = new System.Drawing.Size(77, 24);
            this.slicedRadio.TabIndex = 1;
            this.slicedRadio.Text = "Sliced";
            this.slicedRadio.UseVisualStyleBackColor = true;
            // 
            // wholeRadio
            // 
            this.wholeRadio.AutoSize = true;
            this.wholeRadio.Checked = true;
            this.wholeRadio.Location = new System.Drawing.Point(7, 26);
            this.wholeRadio.Name = "wholeRadio";
            this.wholeRadio.Size = new System.Drawing.Size(79, 24);
            this.wholeRadio.TabIndex = 0;
            this.wholeRadio.TabStop = true;
            this.wholeRadio.Text = "Whole";
            this.wholeRadio.UseVisualStyleBackColor = true;
            // 
            // fruitListBox
            // 
            this.fruitListBox.FormattingEnabled = true;
            this.fruitListBox.ItemHeight = 20;
            this.fruitListBox.Items.AddRange(new object[] {
            "Pineapple",
            "Mango",
            "Strawberry",
            "Banana"});
            this.fruitListBox.Location = new System.Drawing.Point(70, 79);
            this.fruitListBox.Name = "fruitListBox";
            this.fruitListBox.Size = new System.Drawing.Size(193, 164);
            this.fruitListBox.TabIndex = 3;
            // 
            // fruitBoxLabel
            // 
            this.fruitBoxLabel.AutoSize = true;
            this.fruitBoxLabel.Location = new System.Drawing.Point(70, 53);
            this.fruitBoxLabel.Name = "fruitBoxLabel";
            this.fruitBoxLabel.Size = new System.Drawing.Size(103, 20);
            this.fruitBoxLabel.TabIndex = 4;
            this.fruitBoxLabel.Text = "Select a Fruit";
            // 
            // fruitOutput
            // 
            this.fruitOutput.Location = new System.Drawing.Point(340, 79);
            this.fruitOutput.Name = "fruitOutput";
            this.fruitOutput.Size = new System.Drawing.Size(302, 279);
            this.fruitOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fruitOutput.TabIndex = 5;
            this.fruitOutput.TabStop = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(336, 361);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 20);
            this.dateLabel.TabIndex = 6;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(522, 361);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 20);
            this.nameLabel.TabIndex = 7;
            // 
            // fruitSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 510);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.fruitOutput);
            this.Controls.Add(this.fruitBoxLabel);
            this.Controls.Add(this.fruitListBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.drawButton);
            this.Name = "fruitSelectionForm";
            this.Text = "Fruit Selection Project 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fruitOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox nameCheckBox;
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton slicedRadio;
        private System.Windows.Forms.RadioButton wholeRadio;
        private System.Windows.Forms.ListBox fruitListBox;
        private System.Windows.Forms.Label fruitBoxLabel;
        private System.Windows.Forms.PictureBox fruitOutput;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}


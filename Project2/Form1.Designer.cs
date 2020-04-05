namespace Project2
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
            this.radioBoxGroup = new System.Windows.Forms.GroupBox();
            this.wholeRadio = new System.Windows.Forms.RadioButton();
            this.slicedRadio = new System.Windows.Forms.RadioButton();
            this.checkBoxGroup = new System.Windows.Forms.GroupBox();
            this.timeCheck = new System.Windows.Forms.CheckBox();
            this.dateCheck = new System.Windows.Forms.CheckBox();
            this.fruitChoiceBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.fruitOutput = new System.Windows.Forms.PictureBox();
            this.radioBoxGroup.SuspendLayout();
            this.checkBoxGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fruitOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // radioBoxGroup
            // 
            this.radioBoxGroup.Controls.Add(this.wholeRadio);
            this.radioBoxGroup.Controls.Add(this.slicedRadio);
            this.radioBoxGroup.Location = new System.Drawing.Point(47, 203);
            this.radioBoxGroup.Name = "radioBoxGroup";
            this.radioBoxGroup.Size = new System.Drawing.Size(200, 100);
            this.radioBoxGroup.TabIndex = 0;
            this.radioBoxGroup.TabStop = false;
            this.radioBoxGroup.Text = "Choose Option";
            // 
            // wholeRadio
            // 
            this.wholeRadio.AutoSize = true;
            this.wholeRadio.Location = new System.Drawing.Point(7, 57);
            this.wholeRadio.Name = "wholeRadio";
            this.wholeRadio.Size = new System.Drawing.Size(79, 24);
            this.wholeRadio.TabIndex = 1;
            this.wholeRadio.TabStop = true;
            this.wholeRadio.Text = "Whole";
            this.wholeRadio.UseMnemonic = false;
            this.wholeRadio.UseVisualStyleBackColor = true;
            // 
            // slicedRadio
            // 
            this.slicedRadio.AutoSize = true;
            this.slicedRadio.Checked = true;
            this.slicedRadio.Location = new System.Drawing.Point(7, 26);
            this.slicedRadio.Name = "slicedRadio";
            this.slicedRadio.Size = new System.Drawing.Size(77, 24);
            this.slicedRadio.TabIndex = 0;
            this.slicedRadio.TabStop = true;
            this.slicedRadio.Text = "Sliced";
            this.slicedRadio.UseVisualStyleBackColor = true;
            // 
            // checkBoxGroup
            // 
            this.checkBoxGroup.Controls.Add(this.timeCheck);
            this.checkBoxGroup.Controls.Add(this.dateCheck);
            this.checkBoxGroup.Location = new System.Drawing.Point(47, 327);
            this.checkBoxGroup.Name = "checkBoxGroup";
            this.checkBoxGroup.Size = new System.Drawing.Size(200, 100);
            this.checkBoxGroup.TabIndex = 1;
            this.checkBoxGroup.TabStop = false;
            this.checkBoxGroup.Text = "Select Options";
            // 
            // timeCheck
            // 
            this.timeCheck.AutoSize = true;
            this.timeCheck.Location = new System.Drawing.Point(7, 70);
            this.timeCheck.Name = "timeCheck";
            this.timeCheck.Size = new System.Drawing.Size(113, 24);
            this.timeCheck.TabIndex = 1;
            this.timeCheck.Text = "Show Time";
            this.timeCheck.UseVisualStyleBackColor = true;
            // 
            // dateCheck
            // 
            this.dateCheck.AutoSize = true;
            this.dateCheck.Location = new System.Drawing.Point(7, 26);
            this.dateCheck.Name = "dateCheck";
            this.dateCheck.Size = new System.Drawing.Size(114, 24);
            this.dateCheck.TabIndex = 0;
            this.dateCheck.Text = "Show Date";
            this.dateCheck.UseVisualStyleBackColor = true;
            // 
            // fruitChoiceBox
            // 
            this.fruitChoiceBox.FormattingEnabled = true;
            this.fruitChoiceBox.ItemHeight = 20;
            this.fruitChoiceBox.Items.AddRange(new object[] {
            "Mango",
            "Pineapple",
            "Strawberry",
            "Kiwi"});
            this.fruitChoiceBox.Location = new System.Drawing.Point(47, 71);
            this.fruitChoiceBox.Name = "fruitChoiceBox";
            this.fruitChoiceBox.Size = new System.Drawing.Size(140, 104);
            this.fruitChoiceBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose One";
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(393, 388);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(105, 39);
            this.drawButton.TabIndex = 5;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(423, 327);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 20);
            this.dateLabel.TabIndex = 6;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(423, 357);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 20);
            this.timeLabel.TabIndex = 7;
            // 
            // fruitOutput
            // 
            this.fruitOutput.Location = new System.Drawing.Point(319, 62);
            this.fruitOutput.Name = "fruitOutput";
            this.fruitOutput.Size = new System.Drawing.Size(290, 241);
            this.fruitOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fruitOutput.TabIndex = 4;
            this.fruitOutput.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 457);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.fruitOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fruitChoiceBox);
            this.Controls.Add(this.checkBoxGroup);
            this.Controls.Add(this.radioBoxGroup);
            this.Name = "Form1";
            this.Text = "Fruit Selector Project 2";
            this.radioBoxGroup.ResumeLayout(false);
            this.radioBoxGroup.PerformLayout();
            this.checkBoxGroup.ResumeLayout(false);
            this.checkBoxGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fruitOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox radioBoxGroup;
        private System.Windows.Forms.RadioButton wholeRadio;
        private System.Windows.Forms.RadioButton slicedRadio;
        private System.Windows.Forms.GroupBox checkBoxGroup;
        private System.Windows.Forms.CheckBox timeCheck;
        private System.Windows.Forms.CheckBox dateCheck;
        private System.Windows.Forms.ListBox fruitChoiceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox fruitOutput;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
    }
}


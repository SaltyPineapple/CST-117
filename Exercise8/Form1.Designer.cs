namespace Exercise8
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
            this.label1 = new System.Windows.Forms.Label();
            this.fatGramsInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.carbGramsInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.carbCalOutput = new System.Windows.Forms.TextBox();
            this.fatCalOutput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of Fat Grams:";
            // 
            // fatGramsInput
            // 
            this.fatGramsInput.Location = new System.Drawing.Point(269, 25);
            this.fatGramsInput.Name = "fatGramsInput";
            this.fatGramsInput.Size = new System.Drawing.Size(100, 26);
            this.fatGramsInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the number of Carb Grams:";
            // 
            // carbGramsInput
            // 
            this.carbGramsInput.Location = new System.Drawing.Point(269, 134);
            this.carbGramsInput.Name = "carbGramsInput";
            this.carbGramsInput.Size = new System.Drawing.Size(100, 26);
            this.carbGramsInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Calories from Fat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Calories from Carbs:";
            // 
            // carbCalOutput
            // 
            this.carbCalOutput.Location = new System.Drawing.Point(255, 184);
            this.carbCalOutput.Name = "carbCalOutput";
            this.carbCalOutput.ReadOnly = true;
            this.carbCalOutput.Size = new System.Drawing.Size(54, 26);
            this.carbCalOutput.TabIndex = 6;
            // 
            // fatCalOutput
            // 
            this.fatCalOutput.Location = new System.Drawing.Point(255, 69);
            this.fatCalOutput.Name = "fatCalOutput";
            this.fatCalOutput.ReadOnly = true;
            this.fatCalOutput.Size = new System.Drawing.Size(54, 26);
            this.fatCalOutput.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(125, 261);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(171, 50);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 351);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.fatCalOutput);
            this.Controls.Add(this.carbCalOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carbGramsInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fatGramsInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fatGramsInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox carbGramsInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox carbCalOutput;
        private System.Windows.Forms.TextBox fatCalOutput;
        private System.Windows.Forms.Button calculateButton;
    }
}


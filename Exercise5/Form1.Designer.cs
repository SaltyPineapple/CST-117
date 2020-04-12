namespace Exercise5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.termsInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.piValueLabel = new System.Windows.Forms.Label();
            this.piOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter # of Terms: ";
            // 
            // termsInput
            // 
            this.termsInput.Location = new System.Drawing.Point(198, 47);
            this.termsInput.Name = "termsInput";
            this.termsInput.Size = new System.Drawing.Size(100, 26);
            this.termsInput.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(28, 130);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(141, 54);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // piValueLabel
            // 
            this.piValueLabel.AutoSize = true;
            this.piValueLabel.Location = new System.Drawing.Point(111, 295);
            this.piValueLabel.Name = "piValueLabel";
            this.piValueLabel.Size = new System.Drawing.Size(276, 20);
            this.piValueLabel.TabIndex = 3;
            this.piValueLabel.Text = "Approximate Value of Pi after 0 Terms";
            // 
            // piOutput
            // 
            this.piOutput.Location = new System.Drawing.Point(115, 336);
            this.piOutput.Name = "piOutput";
            this.piOutput.Size = new System.Drawing.Size(272, 26);
            this.piOutput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 456);
            this.Controls.Add(this.piOutput);
            this.Controls.Add(this.piValueLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.termsInput);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Approximate Pi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox termsInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label piValueLabel;
        private System.Windows.Forms.TextBox piOutput;
    }
}


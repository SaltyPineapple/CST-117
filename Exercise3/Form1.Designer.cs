namespace Exercise3
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
            this.dollarInput = new System.Windows.Forms.TextBox();
            this.euroOutput = new System.Windows.Forms.TextBox();
            this.dollarLabel = new System.Windows.Forms.Label();
            this.euroLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dollarInput
            // 
            this.dollarInput.Location = new System.Drawing.Point(349, 111);
            this.dollarInput.Name = "dollarInput";
            this.dollarInput.Size = new System.Drawing.Size(204, 26);
            this.dollarInput.TabIndex = 0;
            // 
            // euroOutput
            // 
            this.euroOutput.Location = new System.Drawing.Point(349, 188);
            this.euroOutput.Name = "euroOutput";
            this.euroOutput.Size = new System.Drawing.Size(204, 26);
            this.euroOutput.TabIndex = 1;
            // 
            // dollarLabel
            // 
            this.dollarLabel.AutoSize = true;
            this.dollarLabel.Location = new System.Drawing.Point(180, 114);
            this.dollarLabel.Name = "dollarLabel";
            this.dollarLabel.Size = new System.Drawing.Size(163, 20);
            this.dollarLabel.TabIndex = 2;
            this.dollarLabel.Text = "Input a dollar amount:";
            // 
            // euroLabel
            // 
            this.euroLabel.AutoSize = true;
            this.euroLabel.Location = new System.Drawing.Point(213, 188);
            this.euroLabel.Name = "euroLabel";
            this.euroLabel.Size = new System.Drawing.Size(130, 20);
            this.euroLabel.TabIndex = 3;
            this.euroLabel.Text = "Euro Conversion:";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(286, 293);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(121, 69);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.euroLabel);
            this.Controls.Add(this.dollarLabel);
            this.Controls.Add(this.euroOutput);
            this.Controls.Add(this.dollarInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dollarInput;
        private System.Windows.Forms.TextBox euroOutput;
        private System.Windows.Forms.Label dollarLabel;
        private System.Windows.Forms.Label euroLabel;
        private System.Windows.Forms.Button convertButton;
    }
}


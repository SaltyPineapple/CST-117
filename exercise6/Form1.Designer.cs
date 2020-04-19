namespace exercise6
{
    partial class exercise6
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
            this.diceRollButton = new System.Windows.Forms.Button();
            this.diceOneLabel = new System.Windows.Forms.Label();
            this.diceTwoLabel = new System.Windows.Forms.Label();
            this.diceSidesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // diceRollButton
            // 
            this.diceRollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceRollButton.Location = new System.Drawing.Point(12, 12);
            this.diceRollButton.Name = "diceRollButton";
            this.diceRollButton.Size = new System.Drawing.Size(152, 115);
            this.diceRollButton.TabIndex = 0;
            this.diceRollButton.Text = "Roll Dice";
            this.diceRollButton.UseVisualStyleBackColor = true;
            this.diceRollButton.Click += new System.EventHandler(this.diceRollButton_Click);
            // 
            // diceOneLabel
            // 
            this.diceOneLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.diceOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceOneLabel.Location = new System.Drawing.Point(190, 12);
            this.diceOneLabel.Name = "diceOneLabel";
            this.diceOneLabel.Size = new System.Drawing.Size(169, 115);
            this.diceOneLabel.TabIndex = 1;
            this.diceOneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diceTwoLabel
            // 
            this.diceTwoLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.diceTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceTwoLabel.Location = new System.Drawing.Point(380, 12);
            this.diceTwoLabel.Name = "diceTwoLabel";
            this.diceTwoLabel.Size = new System.Drawing.Size(170, 115);
            this.diceTwoLabel.TabIndex = 2;
            this.diceTwoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diceSidesLabel
            // 
            this.diceSidesLabel.AutoSize = true;
            this.diceSidesLabel.Location = new System.Drawing.Point(12, 135);
            this.diceSidesLabel.Name = "diceSidesLabel";
            this.diceSidesLabel.Size = new System.Drawing.Size(0, 20);
            this.diceSidesLabel.TabIndex = 3;
            // 
            // exercise6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 164);
            this.Controls.Add(this.diceSidesLabel);
            this.Controls.Add(this.diceTwoLabel);
            this.Controls.Add(this.diceOneLabel);
            this.Controls.Add(this.diceRollButton);
            this.Name = "exercise6";
            this.Text = "Dice Roll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button diceRollButton;
        private System.Windows.Forms.Label diceOneLabel;
        private System.Windows.Forms.Label diceTwoLabel;
        private System.Windows.Forms.Label diceSidesLabel;
    }
}


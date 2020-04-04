using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Exercise_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {

            try
            {

                decimal seconds = decimal.Parse(secondsInput.Text);
                decimal minutes = seconds / decimal.Parse("60.0");
                decimal hours = minutes / decimal.Parse("60.0");
                decimal days = hours / decimal.Parse("24.0");



                if(seconds > 86400)
                {
                    outputBox.Text = days.ToString("F2");
                    outputLabel.Text = "Number of Days: ";
                }
                else if(seconds > 3600)
                {
                    outputBox.Text = hours.ToString("F2");
                    outputLabel.Text = "Number of Hours: ";
                }
                else if(seconds > 60)
                {
                    outputBox.Text = minutes.ToString("F2");
                    outputLabel.Text = "Number of Minutes: ";
                }
                else
                {
                    outputBox.Text = seconds.ToString();
                    outputLabel.Text = "Number of Seconds: ";
                }


            }
            catch
            {
                MessageBox.Show("Please make sure you enter a valid number. Decimals are OK");
            }


        }
    }
}

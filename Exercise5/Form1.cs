using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            // Encased in a try catch for error handling
            try
            {
                // Initialize Variables
                // Doubles used for decimal approximation
                double counter = 3.0;
                double piValue = 4.0;
                Boolean plus = false;
                long terms = long.Parse(termsInput.Text);
                double[] denom = new double[terms];


                // Populate array of denominator terms
                // increase counter variable twice due to mathematical expression
                for (int x = 0; x < terms; x++)
                {
                    denom[x] = (counter);
                    counter++;
                    counter++;
                }

                // loop through amount of terms, alternate between + and -
                for (int i = 0; i < denom.Length - 1; i++)
                {
                    if (!plus)
                    {
                        piValue = piValue - (4.0 / denom[i]);
                        plus = true;
                    }
                    else
                    {
                        piValue = piValue + (4.0 / denom[i]);
                        plus = false;
                    }
                }
                Console.WriteLine(piValue);

                // Set output strings and labels
                piOutput.Text = piValue.ToString();
                piValueLabel.Text = String.Format("Approximate Value of Pi after {0}", terms);
            }
            catch
            {
                MessageBox.Show("Enter a smaller value");
            }
            
        }
    }
}

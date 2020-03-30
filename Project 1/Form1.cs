using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
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
                decimal num = decimal.Parse(dollarInput.Text);
                decimal conversion = num * decimal.Parse("0.9");

                Console.WriteLine(conversion);

                euroOutput.Text = conversion.ToString("F3");
            }
            catch
            {
                MessageBox.Show("Please make sure you enter a valid number. Decimals are OK");
            }
       
        }
    }
}

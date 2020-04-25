using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int fatGrams = int.Parse(fatGramsInput.Text);
            fatCalOutput.Text = FatCalories(fatGrams).ToString();

            int carbGrams = int.Parse(carbGramsInput.Text);
            carbCalOutput.Text = CarbCalories(carbGrams).ToString();

        }

        public int FatCalories(int fatGrams)
        {
            return fatGrams * 9;
        }

        public int CarbCalories(int carbGrams)
        {
            return carbGrams * 4;
        }
    }
}

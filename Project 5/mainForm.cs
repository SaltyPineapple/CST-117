using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_5 {
    public partial class mainForm : Form {
        public mainForm() {
            InitializeComponent();
        }

        private void resultsButton_Click(object sender, EventArgs e) {
            
            // create instance of second form
            secondForm secondForm = new secondForm();

            // create variables to get data from entered values
            int fruitIndex = fruitChoiceBox.SelectedIndex +1;
            int firstLetIndex = firstLetChoiceBox.SelectedIndex +1;
            int lastLetIndex = lastLetChoiceBox.SelectedIndex +1;

            int favNum = -1;

            // error handling for favorite number input
            try {
                int favNumTest = int.Parse(favNumBox.Text);
                favNum = favNumTest;

            }
            catch {
                MessageBox.Show("Please enter a valid number, no decimals. Ex.) 14");
            }



            
            // Error handling for entries
            // will not show second form if values are not entered
            if(fruitIndex == 0) {
                MessageBox.Show("Please enter a value for Fruit.");
            }
            else if(firstLetIndex == 0) {
                MessageBox.Show("Please enter a value for your first letter.");
            }
            else if(lastLetIndex == 0) {
                MessageBox.Show("Please Enter a value for your last letter.");
            }
            else {
                // formula for lucky number
                int luckyNum = (fruitIndex * firstLetIndex) / lastLetIndex + favNum;

                // set text on second form for lucky number
                secondForm.luckyNumber.Text = luckyNum.ToString();

                // show second form
                secondForm.ShowDialog();
            }

            
        }
    }
}

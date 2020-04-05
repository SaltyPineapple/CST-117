using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            // Choice Box
            int selectedFruitIndex = fruitChoiceBox.SelectedIndex;
            String selectedFruitString = fruitChoiceBox.SelectedItem.ToString();


            if (selectedFruitIndex != -1)
            {
                if(selectedFruitIndex == 0 && slicedRadio.Checked)
                {
                    fruitOutput.Image = Project2.Properties.Resources.slicedMango;
                    
                }
                else if(selectedFruitIndex == 0 && wholeRadio.Checked)
                {
                    fruitOutput.Image = Project2.Properties.Resources.mango;
                }

                if(selectedFruitIndex == 1 && slicedRadio.Checked)
                {
                    fruitOutput.Image = Project2.Properties.Resources.slicedPineapple;
                }
                else if(selectedFruitIndex == 1 && wholeRadio.Checked)
                {
                    fruitOutput.Image = Project2.Properties.Resources.pineapple;
                }

                if (selectedFruitIndex == 2 && slicedRadio.Checked)
                {
                    fruitOutput.Image = Project2.Properties.Resources.slicedStrawberry;
                }
                else if (selectedFruitIndex == 2 && wholeRadio.Checked)
                {
                    fruitOutput.Image = Project2.Properties.Resources.strawberry;
                }

                if (selectedFruitIndex == 3 && slicedRadio.Checked)
                {
                    fruitOutput.Image = Project2.Properties.Resources.slicedKiwi;
                }
                else if (selectedFruitIndex == 3 && wholeRadio.Checked)
                {
                    fruitOutput.Image = Project2.Properties.Resources.kiwi;
                }

            }
          

            // Time and Date -> Check Box
            if (dateCheck.Checked)
            {
                dateLabel.Text = DateTime.Now.ToString("d");
            }
            else
            {
                dateLabel.Text = " ";
            }

            if (timeCheck.Checked)
            {
                timeLabel.Text = DateTime.Now.ToString("HH:mm");
            }
            else
            {
                timeLabel.Text = " ";
            }

           
        }
    }
}

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

            


            if(fruitListBox.SelectedIndex != -1)
            {
                string selectedFruitName = fruitListBox.SelectedItem.ToString();
                int index = fruitListBox.SelectedIndex;


                // Set name label to fruit name if box is checked
                if (nameCheckBox.Checked)
                {
                    nameLabel.Text = selectedFruitName;
                }
                else
                {
                    nameLabel.Text = "";
                }

                //set correct picture depending on radio button selection
                if(index == 0)
                {
                    if (wholeRadio.Checked)
                    {
                        fruitOutput.Image = Project2.Properties.Resources.pineapple;
                    }
                    else
                    {
                        fruitOutput.Image = Project2.Properties.Resources.slicedPineapple;
                    }
                    
                }
                if (index == 1)
                {
                    if (wholeRadio.Checked)
                    {
                        fruitOutput.Image = Project2.Properties.Resources.mango;
                    }
                    else
                    {
                        fruitOutput.Image = Project2.Properties.Resources.slicedMango;
                    }

                }
                if (index == 2)
                {
                    if (wholeRadio.Checked)
                    {
                        fruitOutput.Image = Project2.Properties.Resources.strawberry;
                    }
                    else
                    {
                        fruitOutput.Image = Project2.Properties.Resources.slicedStrawberry;
                    }

                }
                if (index == 3)
                {
                    if (wholeRadio.Checked)
                    {
                        fruitOutput.Image = Project2.Properties.Resources.banana;
                    }
                    else
                    {
                        fruitOutput.Image = Project2.Properties.Resources.slicedBanana;
                    }

                }



            }
            



            //Check Boxes -> Name and Date
            
            if (dateCheckBox.Checked)
            {
                dateLabel.Text = DateTime.Now.ToString("d");
            }
            else
            {
                dateLabel.Text = " ";
            }

           

        }
    }
}

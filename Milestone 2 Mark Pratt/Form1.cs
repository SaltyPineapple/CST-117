using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Milestone_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Initialize each item within inventory
            Item diamondSword = new Item("weapon", "Diamond Sword", 4, 400, "Sword made of Diamond. Very Strong. $400");
            Item steelSword = new Item("weapon", "Steel Sword", 3, 300, "Sword made of Steel. Pretty strong. $300");
            Item ironSword = new Item("weapon", "Iron Sword", 4, 200, "Sword made of Iron. Basic. $200");

            inventoryBox.DisplayMember = "name";            

            inventoryBox.Items.Add(diamondSword);
            inventoryBox.Items.Add(steelSword);
            inventoryBox.Items.Add(ironSword);
            
        }

        // Drops selected item
        private void dropButton_Click(object sender, EventArgs e)
        {
            // Gets selected item
            // casts to Item datatype
            int itemIndex = inventoryBox.SelectedIndex;
            Item selectedItem = (Item)inventoryBox.Items[itemIndex];

            // Removes equipped item if dropped
            if (equippedLabel.Text.Equals(selectedItem.name))
            {
                equippedLabel.Text = "None";
            }

            // Removes selected item from inventory
            inventoryBox.Items.RemoveAt(inventoryBox.SelectedIndex);
        }

        // Sells selected item
        private void sellButton_Click(object sender, EventArgs e)
        {

            // Gets selected item
            // casts to Item datatype
            int itemIndex = inventoryBox.SelectedIndex;
            Item selectedItem = (Item)inventoryBox.Items[itemIndex];

            // Adds funds to pocket
            int balance = int.Parse(moneyLabel.Text);
            int newBalance = balance + selectedItem.getValue();


            // Does not sell if item is equipped
            if (equippedLabel.Text.Equals(selectedItem.name))
            {
                MessageBox.Show("That item is equipped. Cannot sell.");
            }
            else
            {
                moneyLabel.Text = newBalance.ToString();
                inventoryBox.Items.RemoveAt(inventoryBox.SelectedIndex);
            }

        }

        // Sets the equipped item
        private void equipButton_Click(object sender, EventArgs e)
        {
            // Gets selected item
            // casts to Item datatype
            int itemIndex = inventoryBox.SelectedIndex;
            Item selectedItem = (Item)inventoryBox.Items[itemIndex];

            equippedLabel.Text = selectedItem.name;

        }

        // Used to set description box text
        private void inventoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int itemIndex = inventoryBox.SelectedIndex;
                Item selectedItem = (Item)inventoryBox.Items[itemIndex];

                descriptionBox.Text = selectedItem.desc;
            }
            catch
            {
                descriptionBox.Text = " ";
            }
            
        }
    }


    /* Item class
     * Constructor initializes properties
     */
    class Item
    {
        private string type;
        public string name { get; set; }
        public string desc { get; set; }
        private int weight;
        private int value;

        

        public Item(string type, string name, int weight, int value, string desc)
        {
            this.type = type;
            this.name = name;
            this.weight = weight;
            this.value = value;
            this.desc = desc;
        }

        public string getType()
        {
            return type;
        }

        public int getWeight()
        {
            return weight;
        }

        public int getValue()
        {
            return value;
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Milestone_2
{
    public partial class Form1 : Form
    {
        inventoryManager manage = new inventoryManager();
        Form2 equip = new Form2();


        public Form1()
        {
            InitializeComponent();

            

            // Initialize each item within inventory
            Item diamondSword = new Item("weapon", "Diamond Sword", 4, 400, "Sword made of Diamond. Very Strong. $400");
            Item steelSword = new Item("weapon", "Steel Sword", 3, 300, "Sword made of Steel. Pretty strong. $300");
            Item ironSword = new Item("weapon", "Iron Sword", 4, 200, "Sword made of Iron. Basic. $200");

            Item slingshot = new Item("weapon", "Slingshot", 1, 150, "Trusty Slingshot! Shoot faraway objects. $150");
            Item spear = new Item("weapon", "Spear", 5, 450, "Long reach and sharp point! $450");
            Item ironKnife = new Item("weapon", "Iron Knife", 2, 250, "Small yet deadly. $200");
            Item steelKnife = new Item("weapon", "Steel Knife", 2, 350, "Updgrade of the Iron Knife. $350");

            storeBox.Items.Add(slingshot);
            storeBox.Items.Add(slingshot);
            storeBox.Items.Add(spear);
            storeBox.Items.Add(spear);
            storeBox.Items.Add(ironKnife);
            storeBox.Items.Add(steelKnife);

            storeBox.DisplayMember = "name";
            inventoryBox.DisplayMember = "name";

            manage.addItem(inventoryBox, diamondSword);
            manage.addItem(inventoryBox, steelSword);
            manage.addItem(inventoryBox, ironSword);
            
        }

        // Drops selected item
        private void dropButton_Click(object sender, EventArgs e)
        {
            manage.removeItem(inventoryBox, equippedLabel);
        }

        // Sells selected item
        private void sellButton_Click(object sender, EventArgs e)
        {
            manage.sellItem(inventoryBox, storeBox, equippedLabel, moneyLabel);
        }

        // Sets the equipped item
        private void equipButton_Click(object sender, EventArgs e)
        {
            // Gets selected item
            // casts to Item datatype
            int itemIndex = inventoryBox.SelectedIndex;
            Item selectedItem = (Item)inventoryBox.Items[itemIndex];

            equip.equippedItemLabel.Text = selectedItem.name;

            equip.ShowDialog();


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

        // Sets Description box text
        private void storeBox_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                int itemIndex = storeBox.SelectedIndex;
                Item selectedItem = (Item)storeBox.Items[itemIndex];

                descriptionBox.Text = selectedItem.desc;
            }
            catch {
                descriptionBox.Text = " ";
            }
        }

        
        private void restockButton_Click(object sender, EventArgs e) {
            manage.restockItem(inventoryBox);
        }

        // Returns index of searched item, sets selection in inventory to that item
        private void searchButton_Click(object sender, EventArgs e) {
            try {
                int price = int.Parse(priceBox.Text);
                string name = nameBox.Text;

                inventoryBox.SelectedIndex = manage.searchItem(name, price, inventoryBox);
            }
            catch {
                MessageBox.Show("Please input a correct value. If searching without price, enter 0");
            }
        }

        private void storeButton_Click(object sender, EventArgs e) {
            manage.buyItem(inventoryBox, storeBox, moneyLabel);
        }

    }


    // Item class
    class Item
    {
        private string type;
        public string name { get; set; }
        public string desc { get; set; }
        private int weight;
        private int value { get; set; }

        
        // Constructor
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

    // Inventory Manager Class
    class inventoryManager {

        // Used to restock dropped items
        List<Item> removedItemsList = new List<Item>();

        List<Item> inventory = new List<Item>();
        
            
        // Used to add item to inventory
        public void addItem(ListBox inventoryBox, Item item) {
            
            inventory.Add(item);
            inventoryBox.Items.Add(item);

        }

        // Buys selected item from the store and addds to inventory
        public void buyItem(ListBox inventoryBox, ListBox storeBox, Label moneyLabel) {

            //Gets selected item from store
            int itemIndex = storeBox.SelectedIndex;
            Item selectedItem = (Item)storeBox.Items[itemIndex];
            
            // Gets players current balance
            int currentMoney = int.Parse(moneyLabel.Text);


            // If player has enough money, add item to inventory and subtract from balance
            // Otherwise do not buy and say not enough money
            if(currentMoney >= selectedItem.getValue()) {
                addItem(inventoryBox, selectedItem);
                storeBox.Items.RemoveAt(itemIndex);
                moneyLabel.Text = (currentMoney - selectedItem.getValue()).ToString();
            }
            else {
                MessageBox.Show("You do not have the funds to make this purchase");
            }

        }

        public void sellItem(ListBox inventoryBox, ListBox storeBox, Label equippedLabel, Label moneyLabel) {
            
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
                // Sells item to the store
                storeBox.Items.Add(selectedItem);

                inventory.RemoveAt(itemIndex);
                inventoryBox.Items.RemoveAt(inventoryBox.SelectedIndex);
            }

        }

        public void removeItem(ListBox inventoryBox, Label equippedLabel) {

            // Gets selected item
            // casts to Item datatype
            try {
                int itemIndex = inventoryBox.SelectedIndex;
                Item selectedItem = (Item)inventoryBox.Items[itemIndex];

                // Removes equipped item if dropped
                if (equippedLabel.Text.Equals(selectedItem.name)) {
                    equippedLabel.Text = "None";
                }

                // Removes selected item from inventory
                removedItemsList.Add(selectedItem);
                inventory.RemoveAt(itemIndex);
                inventoryBox.Items.RemoveAt(inventoryBox.SelectedIndex);
            }
            catch {
                
            }
            
        }

        // Gets previously dropped items and restocks them in inventory
        public void restockItem(ListBox inventoryBox) {


            // Pick up dropped Items
            for (int x = 0; x < removedItemsList.Count; x++) {

                inventory.Add(removedItemsList[x]);
                addItem(inventoryBox, removedItemsList[x]);

            }

            removedItemsList.Clear();

        }

        // Searches for an item based on name or price within inventory
        public int searchItem(String name, int price, ListBox inventoryBox) {
            
            int returnNum = -1;
            
            for(int x=0; x< inventoryBox.Items.Count; x++) {
                Item selectedItem = (Item)inventoryBox.Items[x];

                if(name == "") {
                    if(price == selectedItem.getValue()) {
                        returnNum = x;
                    }
                }
                else if (selectedItem.name == name) {
                    
                    returnNum = x;
                }
            }

            return returnNum;

        }

    }
}

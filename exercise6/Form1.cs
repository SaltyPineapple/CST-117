using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise6
{
    public partial class exercise6 : Form
    {
        public exercise6()
        {
            InitializeComponent();

        }

        /* Create instance of random
         * Create two dice objects
         * Instantiate roll counter
         */
        static Random random = new Random();
        static int num = random.Next(4, 21);
        Dice diceOne = new Dice(num);
        Dice diceTwo = new Dice(num);
        int rollCount = 0;

       

        private void diceRollButton_Click(object sender, EventArgs e)
        {
            // Set label showing how many sides dice have
            diceSidesLabel.Text = String.Format("The dice have {0} sides", num);
            
            // Create stop case for recursion
            Boolean diceOne1 = false;
            Boolean diceTwo1 = false;
         
            if(!diceOne1 && !diceTwo1)
            {
                // incrementer
                rollCount++;

                // Roll both dice. Uses the same instance of random in order to maintain randomness
                int diceRollOne = diceOne.rollDice(random.Next(1, diceOne.getDiceSides() + 1));
                int diceRollTwo = diceTwo.rollDice(random.Next(1, diceTwo.getDiceSides() + 1));

                // Document each roll
                Console.WriteLine(String.Format("Roll #:{0}", rollCount));
                Console.WriteLine(String.Format("Dice One: {0}", diceRollOne));
                Console.WriteLine(String.Format("Dice Two: {0}", diceRollTwo));
                Console.WriteLine(" ");

                // Show roll on dice in UI
                diceOneLabel.Text = diceRollOne.ToString();
                diceTwoLabel.Text = diceRollTwo.ToString();         

                // If snake eyes are rolled, show how many rolls it took
                // reset roll counter
                // otherwise recursively run again
                if (diceRollOne == 1 && diceRollTwo == 1)
                {
                    diceOne1 = true;
                    diceTwo1 = true;
                    MessageBox.Show(String.Format("It took {0} rolls to get snake eyes!", rollCount));
                    rollCount = 0;
                }
                else
                {
                    diceRollButton_Click(sender, e);
                }
            }
            
        }

       
    }

    /* Dice Class
     * Create dice with given sides
     * Roll dice and return random number
     */
    class Dice
    {
        private int diceSides;
        private Random random = new Random();
        

        public Dice(int sides)
        {
            diceSides = sides;
            Console.WriteLine(sides);
            
        }

        public int getDiceSides()
        {
            return diceSides;
        }

        public int rollDice(int num)
        {
            return num;
        }
    }

}

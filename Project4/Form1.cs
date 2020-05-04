using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4
{
    public partial class Form1 : Form
    {
        
        int turnCounter = 0;
        int boardCounter = 0;
        
        int[,] board = new int[3, 3];


        Boolean isClickedSquare1 = false;
        Boolean isClickedSquare2 = false;
        Boolean isClickedSquare3 = false;
        Boolean isClickedSquare4 = false;
        Boolean isClickedSquare5 = false;
        Boolean isClickedSquare6 = false;
        Boolean isClickedSquare7 = false;
        Boolean isClickedSquare8 = false;
        Boolean isClickedSquare9 = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void square1_Click(object sender, EventArgs e)
        {
            if(!isClickedSquare1){
                fillSquare(square1, 0, 0);
                isClickedSquare1 = true;
            }

        }

        private void square2_Click(object sender, EventArgs e)
        {
            if(!isClickedSquare2){
                fillSquare(square2, 0, 1);
                isClickedSquare2 = true;
            }
            
        }

        private void square3_Click(object sender, EventArgs e)
        {
            if(!isClickedSquare3){
                fillSquare(square3, 0, 2);
                isClickedSquare3 = true;
            }
            
        }

        private void square4_Click(object sender, EventArgs e)
        {
            if(!isClickedSquare4){
                fillSquare(square4, 1, 0);
                isClickedSquare4 = true;
            }
            
        }

        private void square5_Click(object sender, EventArgs e)
        {
            if(!isClickedSquare5){
                fillSquare(square5, 1, 1);
                isClickedSquare5 = true;
            }
            
        }

        private void square6_Click(object sender, EventArgs e)
        {
            if(!isClickedSquare6){
                fillSquare(square6, 1, 2);
                isClickedSquare6 = true;
            }
            
        }

        private void square7_Click(object sender, EventArgs e)
        {
            if(!isClickedSquare7){
                fillSquare(square7, 2, 0);
                isClickedSquare7 = true;
            }
            
        }

        private void square8_Click(object sender, EventArgs e)
        {
            if (!isClickedSquare8) {
                fillSquare(square8, 2, 1);
                isClickedSquare8 = true;
            }
            
        }

        private void square9_Click(object sender, EventArgs e)
        {
            if (!isClickedSquare9) {
                fillSquare(square9, 2, 2);
                isClickedSquare9 = true;
            }
            
        }



        public void fillSquare(Label label, int x, int y){
           
            if (turnCounter % 2 == 0)
            {
                label.Text = "X";
                board[x, y] = 1;
                checkWin(1,"X");
            }
            else
            {
                label.Text = "O";
                board[x, y] = 2;
                checkWin(2,"O");
            }

            printBoard();

            
            turnCounter++;

        }

        public void checkWin(int playerNum, string playerMarker) {

            

            // Check Horizontally
            if(board[0,0] == playerNum && board[0,1] == playerNum && board[0,2] == playerNum) {
                MessageBox.Show(string.Format("Player {0} Wins!", playerMarker));

                isClickedSquare1 = true;
                isClickedSquare2 = true;
                isClickedSquare3 = true;
                isClickedSquare4 = true;
                isClickedSquare5 = true;
                isClickedSquare6 = true;
                isClickedSquare7 = true;
                isClickedSquare8 = true;
                isClickedSquare9 = true;

            }
            else if (board[1, 0] == playerNum && board[1, 1] == playerNum && board[1, 2] == playerNum) {
                MessageBox.Show(string.Format("Player {0} Wins!", playerMarker));

                isClickedSquare1 = true;
                isClickedSquare2 = true;
                isClickedSquare3 = true;
                isClickedSquare4 = true;
                isClickedSquare5 = true;
                isClickedSquare6 = true;
                isClickedSquare7 = true;
                isClickedSquare8 = true;
                isClickedSquare9 = true;

            }
            else if (board[2, 0] == playerNum && board[2, 1] == playerNum && board[2, 2] == playerNum) {
                MessageBox.Show(string.Format("Player {0} Wins!", playerMarker));

                isClickedSquare1 = true;
                isClickedSquare2 = true;
                isClickedSquare3 = true;
                isClickedSquare4 = true;
                isClickedSquare5 = true;
                isClickedSquare6 = true;
                isClickedSquare7 = true;
                isClickedSquare8 = true;
                isClickedSquare9 = true;

            }

            //Check Vertically
            else if (board[0, 0] == playerNum && board[1, 0] == playerNum && board[2, 0] == playerNum) {
                MessageBox.Show(string.Format("Player {0} Wins!", playerMarker));

                isClickedSquare1 = true;
                isClickedSquare2 = true;
                isClickedSquare3 = true;
                isClickedSquare4 = true;
                isClickedSquare5 = true;
                isClickedSquare6 = true;
                isClickedSquare7 = true;
                isClickedSquare8 = true;
                isClickedSquare9 = true;

            }
            else if (board[0, 1] == playerNum && board[1, 1] == playerNum && board[2, 1] == playerNum) {
                MessageBox.Show(string.Format("Player {0} Wins!", playerMarker));

                isClickedSquare1 = true;
                isClickedSquare2 = true;
                isClickedSquare3 = true;
                isClickedSquare4 = true;
                isClickedSquare5 = true;
                isClickedSquare6 = true;
                isClickedSquare7 = true;
                isClickedSquare8 = true;
                isClickedSquare9 = true;

            }
            else if (board[0, 2] == playerNum && board[1, 2] == playerNum && board[2, 2] == playerNum) {
                MessageBox.Show(string.Format("Player {0} Wins!", playerMarker));

                isClickedSquare1 = true;
                isClickedSquare2 = true;
                isClickedSquare3 = true;
                isClickedSquare4 = true;
                isClickedSquare5 = true;
                isClickedSquare6 = true;
                isClickedSquare7 = true;
                isClickedSquare8 = true;
                isClickedSquare9 = true;

            }

            //Check Diagonal
            else if (board[0, 0] == playerNum && board[1, 1] == playerNum && board[2, 2] == playerNum) {
                MessageBox.Show(string.Format("Player {0} Wins!", playerMarker));

                isClickedSquare1 = true;
                isClickedSquare2 = true;
                isClickedSquare3 = true;
                isClickedSquare4 = true;
                isClickedSquare5 = true;
                isClickedSquare6 = true;
                isClickedSquare7 = true;
                isClickedSquare8 = true;
                isClickedSquare9 = true;

            }
            else if (board[2, 0] == playerNum && board[1, 1] == playerNum && board[0, 2] == playerNum) {
                MessageBox.Show(string.Format("Player {0} Wins!", playerMarker));

                isClickedSquare1 = true;
                isClickedSquare2 = true;
                isClickedSquare3 = true;
                isClickedSquare4 = true;
                isClickedSquare5 = true;
                isClickedSquare6 = true;
                isClickedSquare7 = true;
                isClickedSquare8 = true;
                isClickedSquare9 = true;

            }
            else {
                if(turnCounter == 8) {
                    MessageBox.Show("Cats Game!");
                }
                
            }

        }

        private void exitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void playButton_Click(object sender, EventArgs e) {
            for(int x=0; x<3; x++) {
                for(int y=0; y<3; y++) {
                    board[x, y] = 0;
                }
            }

            turnCounter = 0;

            square1.Text = " ";
            isClickedSquare1 = false;

            square2.Text = " ";
            isClickedSquare2 = false;

            square3.Text = " ";
            isClickedSquare3 = false;

            square4.Text = " ";
            isClickedSquare4 = false;

            square5.Text = " ";
            isClickedSquare5 = false;

            square6.Text = " ";
            isClickedSquare6 = false;

            square7.Text = " ";
            isClickedSquare7 = false;

            square8.Text = " ";
            isClickedSquare8 = false;

            square9.Text = " ";
            isClickedSquare9 = false;

        }

        public void printBoard() {
            Console.WriteLine(string.Format("{0}, {1}, {2}", board[0, 0], board[0, 1], board[0, 2]));
            Console.WriteLine(string.Format("{0}, {1}, {2}", board[1, 0], board[1, 1], board[1, 2]));
            Console.WriteLine(string.Format("{0}, {1}, {2}", board[2, 0], board[2, 1], board[2, 2]));
            Console.WriteLine(string.Format("TurnCounter: {0}", turnCounter));
        }
    }
}

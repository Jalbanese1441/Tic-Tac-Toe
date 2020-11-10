using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {

        public bool player1 = true; // If it equals false then it is players two turn
        public int turns = 0; // Total mumber of turns taken
        public int xWins = 0; // X wins
        public int oWins = 0; // O wins
        public int draws = 0; // Draws


        void newGame()
        {
            player1 = true;
            turns = 0;
            // Resets all of the button
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";
            XAmount.Text = xWins.ToString();
            OAmount.Text = oWins.ToString();
            drawsAmount.Text = draws.ToString();
        }

        bool checkDraw()
        {
            if ((turns == 9) && (!checkWinner()))
            { return true; }
            else { return false;  }
        }

        bool checkWinner()
        {
            // Think of the board like a 2d array. Its format is A (Array) N (Number one) N (Number two)
            // It is numbered like an array, so the top left square is A00.

            // Checks horizontal
            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && (A00.Text != ""))
                return true;

            else if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && (A10.Text != ""))
                return true;

            else if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && (A20.Text != ""))
                return true;


            // Checks vertical
            if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && (A00.Text != ""))
                return true;

            else if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && (A01.Text != ""))
                return true;

            else if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && (A02.Text != ""))
                return true;


            // Checks diagnoal
            if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && (A00.Text != ""))
                return true;

            else if ((A02.Text == A11.Text) && (A11.Text == A20.Text) && (A02.Text != ""))
                return true;

            else
                return false;


        }

        void messageUser(string text)
        {
            if (MessageBox.Show(text+ "\nWould you like to play again?", "Play again?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                newGame(); // If the user wants to play again then the game restarts
            }
            else
            {
                this.Close(); // Otherwise it is closed
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttionClick(object sender, EventArgs e)
        {
            // Activates each time a button is clicked
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (player1)
                {
                    button.Text = "X";
                }
                else
                {
                    button.Text = "O";
                }
                player1 = !player1;
                turns++;
            }
            
            if (checkDraw())
            {
                draws++;
                messageUser("It’s a draw!");
            }

            if (checkWinner())
            {
                if (button.Text == "X")
                {
                    xWins++;
                    messageUser("X Won!");
                }
                else
                {
                    oWins++;
                    messageUser("O Won!");
                }
            }
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            newGame();
        }
    }
}

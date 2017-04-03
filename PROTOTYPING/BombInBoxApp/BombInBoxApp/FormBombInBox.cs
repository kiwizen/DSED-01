using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombInBoxApp
{
    public partial class FormBoxInBox : Form
    {
        private BombInBoxGame myClassRoulette;

        public FormBoxInBox()
        {        
            InitializeComponent();

            myClassRoulette = new BombInBoxGame();

            setupFormBoxInBox();
            refreshScreen();
        }

        private void refreshScreen()
        {
            labelBombLocation.Text = myClassRoulette.SecretBoxID.ToString();
            labelCurrentID.Text = myClassRoulette.CurrentBoxID.ToString();

            labelGame.Text = myClassRoulette.TotalGamePlayed.ToString();
            labelWin.Text = myClassRoulette.Win.ToString();
            labelLoss.Text = myClassRoulette.Lose.ToString();
            labelNoOfRobot.Text = "You have " + myClassRoulette.RobotCount + " robot" + 
                                    (myClassRoulette.RobotCount <2 ? " ": "s ") + "left.";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (myClassRoulette.isBomb())
            {
                MessageBox.Show("You have just detonated a bomb in the Box!!!\nYou Lose!!!\nPlease try again");
                myClassRoulette.YouLose();
                myClassRoulette.NewGame();
            }
            else
            {
                myClassRoulette.Next();
                if (myClassRoulette.CurrentBoxID == myClassRoulette.NoOfBox)
                {
                    MessageBox.Show($"You have open all {myClassRoulette.NoOfBox - 1} box and found the bomb in the 6th box.\nWell Done.\nYou have won the game!!!");
                    myClassRoulette.YouWon();
                    myClassRoulette.NewGame();
                }
            }
            refreshScreen();
        }


        private void buttonRobotOpen_Click(object sender, EventArgs e)
        {
            if (myClassRoulette.isBomb())
            {
                MessageBox.Show("You have used a robot to defuse a bomb.\nWell Done.\nYou have won the game!!!");
                myClassRoulette.YouWon();
                myClassRoulette.NewGame();

            }
            else
            {
                myClassRoulette.RobotCount--;
                if (myClassRoulette.RobotCount == 0)
                {
                    MessageBox.Show("Sorry You used up all the robot and still could not find the bomb.\nYou lose!!!\nPlease try again");
                    myClassRoulette.YouLose();
                    myClassRoulette.NewGame();
                }
            }
            refreshScreen();
        }
    }
}

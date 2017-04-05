using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED_01_App
{
    public partial class FormDSED01 : Form
    {
        // A User defined Class to store all dependent variable related to the Game Form
        //private CommonControlClass _myCommonClass;
        private BombInBoxGame myGame;

        public FormDSED01()
        {
            // Initialize a user defined class object
            //_myCommonClass = new CommonControlClass();
            myGame = new BombInBoxGame();


            // Default method call to initialize component
            InitializeComponent();

            // Initialize screen control object
            InitializeGameScreenLayout();
        }

        private void NewGame()
        {
            myGame.NewGame();
            this.messagePanel.Enabled = false;
            this.pictureBox.TimerStart();
        }

        private void getNoOfRobotAvailable()
        {
            labelNoOfRobot.Text = "You have " + this.myGame.RobotCount + " robot" +
                                 (myGame.RobotCount < 2 ? " " : "s ") + "left.";
        }

        private void EnableButton()
        {
            showButton();
            getNoOfRobotAvailable();
            this.labelNoOfRobot.Visible = true;
        }

        public void showButton(bool flag = true)
        {
            buttonOpen.Enabled = flag;
            buttonRobotOpen.Enabled = flag;
        }

        private void refreshScreen()
        {
            labelBombLocation.Text = myGame.SecretBoxID.ToString();
            labelCurrentID.Text = myGame.CurrentBoxID.ToString();

            labelGame.Text = myGame.TotalGamePlayed.ToString();
            labelWin.Text = myGame.Win.ToString();
            labelLoss.Text = myGame.Lose.ToString();
            getNoOfRobotAvailable();

            showButton(false);
            pictureBox.Reset();
            pictureBox.TimerStart();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (myGame.isBomb())
            {
                //MessageBox.Show("You have just detonated a bomb in the Box!!!\nYou Lose!!!\nPlease try again");
                this.messagePanel.Text = "You have just detonated a bomb in the Box!!!\nYou Lose!!!\nPlease try again";
                myGame.YouLose();
                myGame.NewGame();
                //pictureBox1.Reset();
                //pictureBox1.TimerStart();
            }
            else
            {
                myGame.Next();
                if (myGame.CurrentBoxID == myGame.NoOfBox)
                {
                    //MessageBox.Show($"You have open all {myGame.NoOfBox - 1} box and found the bomb in the 6th box.\nWell Done.\nYou have won the game!!!");
                    this.messagePanel.Text = $"You have open all {myGame.NoOfBox - 1} box and found the bomb in the 6th box.\nWell Done.\nYou have won the game!!!";
                    myGame.YouWon();
                    myGame.NewGame();
                }
            }
            //showButton(false);
            refreshScreen();
        }

        private void buttonRobotOpen_Click(object sender, EventArgs e)
        {
            if (myGame.isBomb())
            {
                //MessageBox.Show("You have used a robot to defuse a bomb.\nWell Done.\nYou have won the game!!!");
                this.messagePanel.Text = "You have used a robot to defuse a bomb.\nWell Done.\nYou have won the game!!!";
                myGame.YouWon();
                //myGame.NewGame();
                //pictureBox1.Reset();
                //pictureBox1.TimerStart();
            }
            else
            {
                myGame.RobotCount--;
                if (myGame.RobotCount == 0)
                {
                    //MessageBox.Show("Sorry You used up all the robot and still could not find the bomb.\nYou lose!!!\nPlease try again");
                    this.messagePanel.Text = "Sorry You used up all the robot and still could not find the bomb.\nYou lose!!!\nPlease try again";
                    myGame.YouLose();
                    //myGame.NewGame();
                    //pictureBox1.Reset();
                    //pictureBox1.TimerStart();
                }
            }
            //showButton(false);
            refreshScreen();
            //pictureBox.Reset();
            //pictureBox.TimerStart();
        }
    }
}


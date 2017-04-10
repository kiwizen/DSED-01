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
        /// <summary>
        /// User-defined Game Class. contain all information related to the game.
        /// </summary>
        private BombInBoxGame myGame;
        /// <summary>
        /// property field that set the visiblity of a set of buttons on the screen.
        /// </summary>
        private bool showButton {
            set
            {
                buttonOpen.Enabled = value;
                buttonRobotOpen.Enabled = value;
            }
        }
        /// <summary>
        /// Constructor for the FormDSED01
        /// </summary>
        public FormDSED01()
        {
            // Initialize a user defined class object
            myGame = new BombInBoxGame();

            // Default method call to initialize component
            InitializeComponent();

            // Initialize screen control object
            InitializeGameScreenLayout();
        }
        /// <summary>
        /// start a new game, reset box counter and update the game score on the screen.
        /// </summary>
        private void NewGame()
        {
            myGame.NewGame();
            messagePanel.ShowGameRule();
            UpdateGameScoreToScreen();
            //CommonControlClass.LetPlaySound();
            MoveBox();
            setCallMethodToMoveBox();
        }

        /// <summary>
        /// display the latest game score onto the screen.
        /// </summary>
        private void UpdateGameScoreToScreen()
        {
            /*
             * refresh the screen control object with 
             *    the updated game score from the game class
             */
            labelGame.Text = myGame.TotalGamePlayed.ToString();
            labelWin.Text = myGame.Win.ToString();
            labelLoss.Text = myGame.Lose.ToString();
            ShowNoOfRobotArm();
            /*
             * The following control object will only be visible on the screen 
             *     when the user selected DEBUG mode.
             */
            labelBombLocation.Text = myGame.SecretBoxID.ToString();
            labelCurrentID.Text = myGame.CurrentBoxID.ToString();
        }
        /// <summary>
        /// to be call by mean of delegation in MessagePanel class.
        /// start a new game once the user press the OK button on the MessagePanel object.
        /// </summary>
        private void setCallMethodToNewGame()
        {
            showButton=false;
            messagePanel.CallBackMethod = null;
            messagePanel.CallBackMethod = NewGame;
            //
        }
        /// <summary>
        /// to be call by mean of delegation in MessagePanel class.
        /// start the PictureBoxWithTimer object moving to the middle of the screen
        ///   once the user press the OK button on the Message Panel object 
        /// </summary>
        private void setCallMethodToMoveBox()
        {
            showButton=false;
            messagePanel.CallBackMethod = MoveBox;
        }
        /// <summary>
        /// initiate the timer control in the PictureBoxWithTimer class
        ///    which move the PictureBoxWithTimer object to the middle of the screen.
        /// </summary>
        public void MoveBox()
        {
            messagePanel.Enabled = false;
            showButton = false;

            string currentID = myGame.CurrentBoxID.ToString();
            pictureBox.Text = currentID;
            labelCurrentID.Text = currentID;
            if(myGame.CurrentBoxID == 1)
                CommonControlClass.LetPlaySound();
            else
                CommonControlClass.playNextMoveSound();
            pictureBox.StartMoving();
        }
        /// <summary>
        /// to be call by mean of delegation in PictureBoxWithTimer class.
        /// once the PictureBoxWithTimer object moved to the middle of the screen,
        ///     enable a set of buttons on the screen.
        /// </summary>
        private void EnableButton()
        {
            showButton=true;
            ShowNoOfRobotArm();
            this.labelNoOfRobot.Visible = true;
        }

        private void ShowNoOfRobotArm()
        {
            labelNoOfRobot.Text = "You have " + myGame.RobotCount + " robot arm"
                                  + (myGame.RobotCount < 2 ? " " : "s ") + "left.";
        }
        /// <summary>
        /// close the game application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayPanelMessage(string text)
        {
            messagePanel.ShowMessage(text);
            showButton = false;
            setCallMethodToNewGame();
        }


        private void buttonOpen_Click(object sender, EventArgs e)
        {
            this.pictureBox.BringImageToFront();
            if (myGame.isMatch())
            {
                pictureBox.Image = CommonControlClass.BombImage;
                DisplayPanelMessage("You have just detonated a bomb in the Box!!!\n\nYou Lose!!!\n\nPlease try again");
                CommonControlClass.PlayFindBombSound();
                myGame.YouLose();
            }
            else
            {
                pictureBox.Image = CommonControlClass.getRandomImage(this.myGame.RandomImageNo);
                myGame.CurrentBoxID++;
                if (myGame.CurrentBoxID == myGame.NoOfBox)
                {
                    DisplayPanelMessage($"You have open all {myGame.NoOfBox - 1} box and found the bomb in the 6th box.\n\nYou have won the game!!!\n\nLet's have another game.");
                    DisplayWinningMessage();
                }
                else
                {
                    ShowBoxIsSafeMessage();
                }
            }     
        }

        private void ShowBoxIsSafeMessage()
        {
            messagePanel.ShowMessage("This box is safe!!\n\nLet's move on the next box.");
            CommonControlClass.playSafeMoveSound();
            setCallMethodToMoveBox();
        }

        private void buttonRobotOpen_Click(object sender, EventArgs e)
        {
            this.pictureBox.BringImageToFront();
            myGame.RobotCount--;
            if (myGame.isMatch())
            {
                ShowNoOfRobotArm();
                pictureBox.Image = CommonControlClass.BombImage;
                DisplayPanelMessage("You have used a robot to defuse a bomb.\n\nYou have won the game!!!\n\nLet's have another game.");
                DisplayWinningMessage();
            }
            else
            {
                pictureBox.Image = CommonControlClass.getRandomImage(this.myGame.RandomImageNo);
                myGame.CurrentBoxID++;
                UpdateGameScoreToScreen();
                if (myGame.RobotCount == 0)
                {
                    DisplayPanelMessage("Sorry You used up all the robot arms and still could not find the bomb.\n\nYou lose!!!\n\nPlease try again.");
                    CommonControlClass.playUsedAllRobotArmSound();
                    myGame.YouLose();
                }
                else
                {
                    ShowBoxIsSafeMessage();
                }
            }
        }

        private void DisplayWinningMessage()
        {
            CommonControlClass.playWinningSound();
            myGame.YouWon();
        }

        private void ComboDebug_SelctionChange(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox temp = sender as System.Windows.Forms.ComboBox;
            DisplayDebugInformation(temp.SelectedIndex == FormDSED01.DEBUG_MODE_ON);
        }

    }
}


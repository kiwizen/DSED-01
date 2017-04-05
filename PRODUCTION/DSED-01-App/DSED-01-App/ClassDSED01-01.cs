using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSED_01_App
{
    /// <summary>
    /// This file contains all Methods that initialise all control objects for the FormDSED01
    /// </summary>
    partial class FormDSED01
    {
        /// <summary>
        /// label control that store the title of the game
        /// </summary>
        private System.Windows.Forms.Label labelGameTitle;


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label labelGame;
        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.Label labelLoss;

        private System.Windows.Forms.Label labelNoOfRobot;
        private System.Windows.Forms.Label labelCurrentID;
        private System.Windows.Forms.Label labelBombLocation;
  
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonRobotOpen;
        private System.Windows.Forms.Button buttonExit;

        // User-defined Custom Control Class
        private PictureBoxWithTimer pictureBox;
        private MessagePanel messagePanel;

        private void InitializeGameScreenLayout()
        {
            // Initialize the basic form FormDSED01
            InitializeForm();

            // Initialize label control that hold the title of the Game
            InitializeGameTitle();

            // Initialize control object that show game information on the form
            InitializeGameInfoComponent();

            // Initialize buttons on the form
            InitializeButton();

            // Initialze the user define custom panel that display game-related message
            InitializeMessagePanel();

            // Initialize a user-defined picture box that moving along the screen with timer control
            //   also display the box number
            InitializePictureBoxTimer();
        }


        /// <summary>
        /// This method initializes the form
        /// </summary>
        private void InitializeForm()
        {
            // No Max/Min/Exit Control button on the Form
            this.ControlBox = false;
            // set to Borderless
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            // set the form size
            this.Size = new System.Drawing.Size(800, 600);
            // Center the form on the screen                                                                  
            this.CenterToScreen();
        }

        /// <summary>
        /// This method intialize the label control that display the title of the game
        /// Display "Bomb in the Box" on a label control
        /// </summary>
        private void InitializeGameTitle()
        {
            this.labelGameTitle = new System.Windows.Forms.Label();

            this.labelGameTitle.AutoSize = true;
            this.labelGameTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelGameTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGameTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelGameTitle.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelGameTitle.Location = new System.Drawing.Point(200, 25);
            this.labelGameTitle.Name = "labelGameTitle";
            this.labelGameTitle.Size = new System.Drawing.Size(400, 60);
            this.labelGameTitle.TabIndex = CommonControlClass.getTabIndex();
            this.labelGameTitle.Text = "Bomb  in  the  Box";
            this.labelGameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.Controls.Add(this.labelGameTitle);

            //this.labelGameTitle.Visible = false;
        }

        void InitializeGameInfoComponent()
        {
            CommonControlClass.initialiseLabelControl(out this.label1, "Game :", 25, 150);
            CommonControlClass.initialiseLabelControl(out this.label2, "Win :", 25, 200);
            CommonControlClass.initialiseLabelControl(out this.label3, "Loss :", 25, 250);

            CommonControlClass.initialiseLabelControl(out this.labelGame, "", 100, 150, textalign: System.Drawing.ContentAlignment.MiddleCenter, FixBorder: true);
            CommonControlClass.initialiseLabelControl(out this.labelWin, "", 100, 200, textalign: System.Drawing.ContentAlignment.MiddleCenter, FixBorder: true);
            CommonControlClass.initialiseLabelControl(out this.labelLoss, "", 100, 250, textalign: System.Drawing.ContentAlignment.MiddleCenter, FixBorder: true);

            CommonControlClass.initialiseLabelControl(out this.label4, "Secret :", 25, 20);
            CommonControlClass.initialiseLabelControl(out this.label5, "Current :", 25, 70);

            CommonControlClass.initialiseLabelControl(out this.labelBombLocation, "", 100, 20, textalign: System.Drawing.ContentAlignment.MiddleCenter, FixBorder: true);
            CommonControlClass.initialiseLabelControl(out this.labelCurrentID, "", 100, 70, textalign: System.Drawing.ContentAlignment.MiddleCenter, FixBorder: true);

            CommonControlClass.initialiseLabelControl(out this.labelNoOfRobot, "You have ? robots left.", 550, 340, 149, 83, font_size : 18F,  FixBorder: true);

            this.labelNoOfRobot.Visible = false;

            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelGame);
            this.Controls.Add(this.labelWin);
            this.Controls.Add(this.labelLoss);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelNoOfRobot);
            this.Controls.Add(this.labelBombLocation);
            this.Controls.Add(this.labelCurrentID);
        }

        private void InitializeButton()
        {
            // 
            // buttonOpen
            // 
            CommonControlClass.initialiseButtonControl(out this.buttonOpen, "You open\nthe box.", 550, 120, 200, 80);
            this.buttonOpen.Enabled = false;
            //this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            this.Controls.Add(this.buttonOpen);
            // 
            // buttonRobot
            // 
            CommonControlClass.initialiseButtonControl(out this.buttonRobotOpen, "Use Robot Arm\nto open the box.", 550, 220, 200, 100);
            this.buttonRobotOpen.Enabled = false;
            //this.buttonRobotOpen.Click += new System.EventHandler(this.buttonRobotOpen_Click);
            this.Controls.Add(this.buttonRobotOpen);
            // 
            // buttonExit
            // 
            CommonControlClass.initialiseButtonControl(out this.buttonExit, "Exit App", 600, 450, 100, 55);
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.Controls.Add(this.buttonExit);
        }

        private void InitializeMessagePanel()
        {
            this.messagePanel = new MessagePanel();
            this.messagePanel.CallBackMethod += this.NewGame;
            this.Controls.Add(this.messagePanel);
        }

        private void InitializePictureBoxTimer()
        {
            this.pictureBox = new PictureBoxWithTimer();
            this.pictureBox.CallBackMethod += this.EnableButton;
            this.pictureBox.Visible = false;
            this.Controls.Add(this.pictureBox);
        }

    }
}

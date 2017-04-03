using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombInBoxApp
{
    partial class FormBoxInBox
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label labelGame;
        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.Label labelLoss;

        private System.Windows.Forms.Label labelGameTitle;
        //private System.Windows.Forms.Label labelText;

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonRobotOpen;

        // Custom Controls
        private PictureBoxWithTimer pictureBox1;
        //private LabelWithText labelGameTotal;

        private void setupFormBoxInBox()
        {

            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            // Display "Bomb in the Box" on a label
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
            this.labelGameTitle.TabIndex = 6;
            this.labelGameTitle.Text = "Bomb  in  the  Box";
            this.labelGameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(this.labelGameTitle);

            setupGameInfoDisplay(this.Controls);

            setupScreenButton(this.Controls);
            // 
            // pictureBox1
            // 
            this.pictureBox1 = new PictureBoxWithTimer();
            this.pictureBox1.Name = "pictureBox1";
            this.Controls.Add(this.pictureBox1);


            // Center the form on the screen
            this.CenterToScreen();

            this.pictureBox1.TimerStart();
        }

        private void setupGameInfoDisplay(Control.ControlCollection controls)
        {

            void initialiseLabelControl(out System.Windows.Forms.Label label,
                string labelText, int x, int y, System.Drawing.ContentAlignment textalign = System.Drawing.ContentAlignment.MiddleLeft, bool FixBorder = false) 
            {
                label = new System.Windows.Forms.Label();
                label.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Location = new System.Drawing.Point(x, y);
                label.Size = new System.Drawing.Size(70, 30);
                label.Text = labelText;
                label.TextAlign = textalign;
                if(FixBorder)
                    label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            };

            // 
            // 
            //
            initialiseLabelControl(out this.label1, "Game :", 25, 120);
            initialiseLabelControl(out this.label2, "Win :", 25, 170);
            initialiseLabelControl(out label3, "Loss :", 25, 220);
            // 
            // 
            // 
            initialiseLabelControl(out this.labelGame, "", 100, 120, System.Drawing.ContentAlignment.MiddleCenter, FixBorder: true);
            initialiseLabelControl(out this.labelWin, "", 100, 170, System.Drawing.ContentAlignment.MiddleCenter, FixBorder: true);
            initialiseLabelControl(out this.labelLoss, "", 100, 220, System.Drawing.ContentAlignment.MiddleCenter, FixBorder: true);

            controls.Add(this.label1);
            controls.Add(this.labelGame);
            controls.Add(this.label2);
            controls.Add(this.labelWin);
            controls.Add(this.label3);
            controls.Add(this.labelLoss);

        }


        private void setupScreenButton(Control.ControlCollection controls)
        {

            void initialiseButtonControl(out System.Windows.Forms.Button button,
                string buttonText, int x, int y, int width, int height)
            {
                button = new System.Windows.Forms.Button();
                button.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
                button.Location = new System.Drawing.Point(x, y);

                button.Size = new System.Drawing.Size(width, height);

                button.Text = buttonText;
                button.UseVisualStyleBackColor = true;
            }

            // 
            // buttonOpen
            // 
            initialiseButtonControl(out this.buttonOpen, "You open\nthe box.", 600, 150, 150, 80);
            //this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            controls.Add(this.buttonOpen);

            // 
            // buttonRobot
            // 
            initialiseButtonControl(out this.buttonRobotOpen, "Use Robot Arm\nto open the box.", 600, 250, 200, 100);
            //this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            controls.Add(this.buttonRobotOpen);

            // 
            // buttonExit
            // 
            initialiseButtonControl(out this.buttonExit, "Exit App", 600, 450, 100, 55);
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            controls.Add(this.buttonExit);

        }

    }
}

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


            setupGameInfoDisplay(this.Controls);

            /*
            //
            // Create a label box to display text on the screen
            //
            this.labelText = new System.Windows.Forms.Label();
            this.labelText.AutoSize = false;
            this.labelText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelText.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelText.Location = new System.Drawing.Point(175, 100);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(450, 300);
            this.labelText.TabIndex = 6;
            this.labelText.Text = Properties.Resources.Story;
            this.labelText.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            */
            // 
            // buttonExit
            // 
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonExit.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonExit.Location = new System.Drawing.Point(650, 450);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 55);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit App";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);

            // 
            // pictureBox1
            // 
            this.pictureBox1 = new PictureBoxWithTimer();
            this.pictureBox1.Name = "pictureBox1";
            /*
            this.labelGameTotal = new LabelWithText("Game Total:");
            this.labelGameTotal.Name = "labelGameTotal";
            this.labelGameTotal.Location = new System.Drawing.Point(50, 50);
            */
            /*
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelWin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelLoss);
            */

            this.Controls.Add(this.labelGameTitle);
            //this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBox1);
            //this.Controls.Add(this.labelGameTotal);


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
                //label.TabIndex = 15;
                label.Text = labelText;
                label.TextAlign = textalign;
                if(FixBorder)
                    label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            };

            // 
            // 
            //
            initialiseLabelControl(out label1, "Game :", 25, 120);
            initialiseLabelControl(out label2, "Win :", 25, 170);
            initialiseLabelControl(out label3, "Loss :", 25, 220);
            // 
            // 
            // 
            initialiseLabelControl(out labelGame, "", 100, 120, System.Drawing.ContentAlignment.MiddleCenter, FixBorder: true);
            initialiseLabelControl(out labelWin, "", 100, 170, System.Drawing.ContentAlignment.MiddleCenter, FixBorder: true);
            initialiseLabelControl(out labelLoss, "", 100, 220, System.Drawing.ContentAlignment.MiddleCenter, FixBorder: true);

            controls.Add(this.label1);
            controls.Add(this.labelGame);
            controls.Add(this.label2);
            controls.Add(this.labelWin);
            controls.Add(this.label3);
            controls.Add(this.labelLoss);

        }
    }
}

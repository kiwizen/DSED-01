using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Func<System.Drawing.Size> getLabelStandardSize = () =>
            {
                return new System.Drawing.Size(70, 30);
            };

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
            // 
            // label1
            // 
            this.label1 = new System.Windows.Forms.Label();
            this.label1.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 120);
            this.label1.Name = "label1";
            this.label1.Size = getLabelStandardSize();
            this.label1.TabIndex = 15;
            this.label1.Text = "Game :";
            // 
            // labelGame
            // 
            this.labelGame = new System.Windows.Forms.Label();
            this.labelGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGame.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGame.Location = new System.Drawing.Point(100, 120);
            this.labelGame.Name = "labelGame";
            this.labelGame.Size = getLabelStandardSize();
            this.labelGame.TabIndex = 9;
            this.labelGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2 = new System.Windows.Forms.Label();
            this.label2.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 170);
            this.label2.Name = "label2";
            this.label2.Size = getLabelStandardSize();
            this.label2.TabIndex = 15;
            this.label2.Text = "Win :";
            // 
            // labelWin
            // 
            this.labelWin = new System.Windows.Forms.Label();
            this.labelWin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWin.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWin.Location = new System.Drawing.Point(100, 170);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = getLabelStandardSize();
            this.labelWin.TabIndex = 14;
            this.labelWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3 = new System.Windows.Forms.Label();
            this.label3.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 220);
            this.label3.Name = "label3";
            this.label3.Size = getLabelStandardSize();
            this.label3.TabIndex = 15;
            this.label3.Text = "Loss :";
            // 
            // labelLoss
            // 
            this.labelLoss = new System.Windows.Forms.Label();
            this.labelLoss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLoss.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoss.Location = new System.Drawing.Point(100, 220);
            this.labelLoss.Name = "labelLoss";
            this.labelLoss.Size = getLabelStandardSize();
            this.labelLoss.TabIndex = 12;
            this.labelLoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

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

            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelWin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelLoss);

            this.Controls.Add(this.labelGameTitle);
            //this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBox1);
            //this.Controls.Add(this.labelGameTotal);


            // Center the form on the screen
            this.CenterToScreen();

            this.pictureBox1.TimerStart();
        }

    }
}

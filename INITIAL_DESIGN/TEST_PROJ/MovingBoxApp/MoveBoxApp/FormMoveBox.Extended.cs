using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveBoxApp
{
    partial class FormMoveBox
    {
        private System.Windows.Forms.Timer timerMoveBox;
        private System.Windows.Forms.Label labelGameTitle;
        private System.Windows.Forms.Label labelMessage;

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPressed;

        private System.Windows.Forms.PictureBox pictureBox1;

        private static int initial_picBox_X = 80;
        private static int initial_picBox_Y = 350;

        private void InitializeMyForm()
        {
            ///
            /// setting the screen size
            /// 
            this.SetBounds(0, 0, 850, 570);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.components = new System.ComponentModel.Container();
            this.timerMoveBox = new System.Windows.Forms.Timer(this.components);
            initializeTimerMoveBox();
            //
            // Display "Bomb in the Box" on a label
            //
            this.labelGameTitle = new System.Windows.Forms.Label();
            this.labelGameTitle.AutoSize = true;
            this.labelGameTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelGameTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGameTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelGameTitle.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelGameTitle.Location = new System.Drawing.Point(250, 25);
            this.labelGameTitle.Name = "labelGameTitle";
            this.labelGameTitle.Size = new System.Drawing.Size(400, 60);
            this.labelGameTitle.TabIndex = 6;
            this.labelGameTitle.Text = "Bomb  in  the  Box";
            this.labelGameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // Display "Message" on a label
            //
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelMessage.AutoSize = false;
            this.labelMessage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMessage.Font = new System.Drawing.Font("Old English Text MT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelMessage.Location = new System.Drawing.Point(250, 250);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(350, 100);
            this.labelMessage.TabIndex = 6;
            this.labelMessage.Text = "Message";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1.Image = global::MoveBoxApp.Properties.Resources.box;
            this.pictureBox1.Location = new System.Drawing.Point(initial_picBox_X, initial_picBox_Y);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonExit.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonExit.Location = new System.Drawing.Point(650, 450);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(125, 50);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit App";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            //
            // buttonPressed
            //
            this.buttonPressed = new System.Windows.Forms.Button();
            this.buttonPressed.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonPressed.Location = new System.Drawing.Point(650, 250);
            this.buttonPressed.Name = "buttonPressed";
            this.buttonPressed.Size = new System.Drawing.Size(125, 50);
            this.buttonPressed.TabIndex = 0;
            this.buttonPressed.Text = "Pressed Me!";
            this.buttonPressed.UseVisualStyleBackColor = true;
            this.buttonPressed.Click += new System.EventHandler(this.buttonPressed_Click);
            ///
            /// add all create controls onto the form
            /// 
            this.Controls.Add(this.labelGameTitle);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPressed);
            ///
            /// Center the form on the screen
            /// 
            this.CenterToScreen();
        }

        private void initializeTimerMoveBox()
        {
            count = 0;
            // set timer interval to 0.085 second
            timerMoveBox.Interval = 35;
            // add a event hander for timer class
            timerMoveBox.Tick += new System.EventHandler(Tick);
            // start the timer
            //timerMoveBox.Start();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPressed_Click(object sender, EventArgs e)
        {
            DisplayMovingBox();
        }
        private int count = 0, i = 0;
        private void Tick(object sender, EventArgs e)
        {
            if (++count % 250 == 0)  // when counter reach 250, do something
            {
                this.timerMoveBox.Stop();
                count = 0;
            }
            System.Drawing.Point newPoint = pictureBox1.Location;
            pictureBox1.Location = new System.Drawing.Point(newPoint.X + 1, newPoint.Y);
            pictureBox1.Refresh();
        }

        private void DisplayMovingBox()
        {
            this.pictureBox1.Location = new System.Drawing.Point(initial_picBox_X, initial_picBox_Y);
            //
            //this.timerMoveBox
            initializeTimerMoveBox();
            this.timerMoveBox.Start();
        }
    }
}
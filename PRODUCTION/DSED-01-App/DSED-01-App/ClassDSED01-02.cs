﻿using System;

namespace DSED_01_App
{
    /// <summary>
    /// This file contains a Custom Control Class.
    /// This custom control display an image, and also display the box number
    /// It also contain a timer, which control the movement of the custom control on the form
    /// </summary>  
    public class PictureBoxWithTimer : System.Windows.Forms.Panel
    {
        
        public delegate void DelegateMethod();
        public DelegateMethod CallBackMethod = null;

        private int _step;
        private static int initial_picBox_X = 80;
        private static int initial_picBox_Y = 380;
        private System.ComponentModel.Container components;

        private System.Windows.Forms.PictureBox _picBox;
        private System.Windows.Forms.Label _number;
        private System.Windows.Forms.Timer timer;

        public PictureBoxWithTimer() : base()
        {
            this.Size = new System.Drawing.Size(150, 150);
            this.Location = new System.Drawing.Point(initial_picBox_X, initial_picBox_Y);

            InitializePictureBox();

            InitializeTimer();

            InitializeNumBox();

        }

        private void InitializeNumBox()
        {
            _number = new System.Windows.Forms.Label();
            _number.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _number.Location = new System.Drawing.Point(60, 75);
            _number.Size = new System.Drawing.Size(35, 35);
            _number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _number.Text = "1";
            this.Controls.Add(_number);
            _number.BringToFront();
        }

        private void InitializeTimer()
        {
            this.components = new System.ComponentModel.Container();
            timer = new System.Windows.Forms.Timer(this.components);

            // Initialize the Timer control object
            _step = 0;
            // set timer interval to 0.085 second
            timer.Interval = 10;
            // add a event hander for timer class
            timer.Tick += new System.EventHandler(Tick);
        }

        private void InitializePictureBox()
        {
            // Initialize the Picture Box control object
            _picBox = new System.Windows.Forms.PictureBox();
            _picBox.Image = CommonControlClass.BoxImage;
            _picBox.Location = new System.Drawing.Point(0, 0);
            _picBox.Name = "PictureBox";
            _picBox.Size = new System.Drawing.Size(150, 150);
            _picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            _picBox.TabIndex = CommonControlClass.getTabIndex();
            _picBox.TabStop = false;

            this.Controls.Add(_picBox);
        }

        internal void StartMoving()
        {
            this.BringNumberToFront();
            ResetParameter();
            timer.Start();
        }

        private void ResetParameter()
        {
            _picBox.Image = CommonControlClass.BoxImage;
            this.Location = new System.Drawing.Point(initial_picBox_X, initial_picBox_Y);
            this._step = 0;
            this.Visible = true;
        }

        public void TimerStop() { timer.Stop(); }

        private void Tick(object sender, EventArgs e)
        {
            if (++_step % 200 == 0)  // when counter reach 200, do something
            {
                TimerStop();
                if (this.CallBackMethod != null)
                {
                    this.CallBackMethod.Invoke();
                    return;
                }
                _step = 0;
            }
            System.Drawing.Point newPoint = this.Location;
            this.Location = new System.Drawing.Point(newPoint.X + 1, newPoint.Y);
            this.Refresh();
        }

        public new string Text {
            set { _number.Text = value; }
            get => _number.Text;
        }

        public System.Drawing.Bitmap Image
        {
            set
            {
                this._picBox.Image = value;
                this.Refresh();
            }
        }

        public void BringImageToFront()
        {
            this._picBox.BringToFront();
        }

        public void BringNumberToFront()
        {
            this._number.BringToFront();
        }
    }
}

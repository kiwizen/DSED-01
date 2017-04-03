using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombInBoxApp
{
    public partial class PictureBoxWithTimer : System.Windows.Forms.PictureBox
    {
        public delegate void ptrMethod(bool flag = true);

        public ptrMethod CallBack = null;

        private int count ;
        private static int initial_picBox_X = 80;
        private static int initial_picBox_Y = 350;
        private System.ComponentModel.Container components;

        private System.Windows.Forms.Timer timer;

        public PictureBoxWithTimer():base()
        {      
            this.Image = global::BombInBoxApp.Properties.Resources.box;
            this.Location = new System.Drawing.Point(initial_picBox_X, initial_picBox_Y);
            this.Name = "PictureBoxWithTimer";
            this.Size = new System.Drawing.Size(150, 150);
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            //this.TabIndex = 1;
            this.TabStop = false;

            this.components = new System.ComponentModel.Container();
            timer = new System.Windows.Forms.Timer(this.components);
            initializeTimerMoveBox();
        }

        public void TimerStart() { timer.Start(); }
        public void TimerStop() { timer.Stop(); }

        public void Reset()
        {
            this.Image = global::BombInBoxApp.Properties.Resources.box;
            this.Location = new System.Drawing.Point(initial_picBox_X, initial_picBox_Y);
            count = 0;
        }

        private void initializeTimerMoveBox()
        {
            count = 0;
            // set timer interval to 0.085 second
            timer.Interval = 25;
            // add a event hander for timer class
            timer.Tick += new System.EventHandler(Tick);

        }

        private void Tick(object sender, EventArgs e)
        {
            if (++count % 200 == 0)  // when counter reach 200, do something
            {
                TimerStop();
                this.CallBack.Invoke();
                count = 0;
            }
            System.Drawing.Point newPoint = this.Location;
            this.Location = new System.Drawing.Point(newPoint.X + 1, newPoint.Y);
            this.Refresh();
        }
    }
}

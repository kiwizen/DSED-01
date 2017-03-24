using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingBoxApp
{
    public partial class FormMovingBox : Form
    {
        const int INITIAL_X = 55;
        const int INITIAL_Y = 80;
        const int STEP = 15;

        private int count = 0;

        public FormMovingBox()
        {
            InitializeComponent();



            labelTimer.Text = "1";
            // set timer interval to 5 second
            timer1.Interval = 1000;
            // add a event hander for timer class
            timer1.Tick += new System.EventHandler(Tick);
            // start the timer
            timer1.Start();
        }

        private void Tick(object sender, EventArgs e)
        {
            int getInt(string text) { return int.Parse(text); }

            int i = getInt(labelTimer.Text);
            i = i % 5 + 1;

            if (count / 6 == 6) panelPictureBox.Visible = false;

            if(++count%6==0)
            {
                if(count/6==6)
                {
                    List <string> listPicBoxName = new List<string> { "pictureBox1","pictureBox2","pictureBox3",
                                                                "pictureBox4","pictureBox5","pictureBox6" };

                    foreach (Control screenControl in panelPictureBox.Controls)
                        if (screenControl is PictureBox && listPicBoxName.Contains(screenControl.Name))
                            screenControl.Visible = true;

                    count = 0;
                }
                else
                {
                    int index = count / 6 ;
                    foreach (Control screenControl in panelPictureBox.Controls)
                        if (screenControl is PictureBox && 
                            screenControl.Name == "pictureBox" + index)
                            screenControl.Visible = false;
                }
            }

            if (count % 2 == 0)
                picBoxConveyorBelt.Image = Properties.Resources.conveyorbell01;
            else
                picBoxConveyorBelt.Image = Properties.Resources.conveyorbell02;

            labelTimer.Text = "" + i;

            panelPictureBox.Visible = true;
            panelPictureBox.Location = new Point(INITIAL_X + STEP * (count), INITIAL_Y);
            panelPictureBox.Refresh();
        }
        private void FormMovingBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            // stop the timer
            timer1.Stop();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenBoxApp
{
    
    public partial class BoxOpeningForm : Form
    {
        private PanelTimer myPanelTimer;
        public static event EventHandler _show;

        public BoxOpeningForm()
        {
            InitializeComponent();
            myPanelTimer = new PanelTimer();
            myPanelTimer.PanelControl = panelPictureBox;
            myPanelTimer.start();
        }

        private void BoxOpeningForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myPanelTimer.stop();
        }

        public void moveBox()
        {

        }
    }

    public class PanelTimer 
    {
        internal int INITIAL_X { get => PanelControl.Location.X; }
        internal int INITIAL_Y { get => PanelControl.Location.Y; }

        private List<string> listPicBoxName = new List<string> { "pictureBox1","pictureBox2","pictureBox3",
                                                                "pictureBox4","pictureBox5","pictureBox6" };
        const int STEP = 15;

        private int origianl_x, original_y;
        private int count;
        private int picBoxIndex;

        private Timer myTimer;
        private Panel myPanel;

        public Panel PanelControl
        {
            set {
                myPanel = value;
                origianl_x = myPanel.Location.X;
                original_y = myPanel.Location.Y;
            }
            get => myPanel;
        }

        public PanelTimer()
        {
            count = 0;
            myTimer = new Timer();
            // set timer interval to 5 second
            myTimer.Interval = 1000;
            // add a event hander for timer class
            myTimer.Tick += new System.EventHandler(Tick);

            picBoxIndex = 1;

        }

        public void start()
        {
            myTimer.Start();
        }


        private void Tick(object sender, EventArgs e)
        {
            if (++count % 5 == 0)  // Every 5 seconds, do something
            {
                MoveBox();
                myTimer.Stop();
                //BoxOpeningForm._show += new EventHandler(BoxOpeningForm.M)

                if (++picBoxIndex > 6)
                {
                    count = 0;
                    picBoxIndex = 1;
                    foreach (Control screenControl in PanelControl.Controls)
                        if (screenControl is PictureBox && listPicBoxName.Contains(screenControl.Name))
                            screenControl.Visible = true;
                }

            }

            if(count==0)
                PanelControl.Location = new Point(origianl_x, original_y);
            else
                PanelControl.Location = new Point(INITIAL_X + STEP, INITIAL_Y);

            PanelControl.Visible = true;
            
            PanelControl.Refresh();

        }

        public void MoveBox()
        {
            int index = count / 5;
            foreach (Control screenControl in PanelControl.Controls)
                if (screenControl is PictureBox &&
                    screenControl.Name == "pictureBox" + index)
                    screenControl.Visible = false;
        }

        private void myTick(object sender, EventArgs e)
        {
            if (++count % 5 == 0)  // Every 5 seconds, do something
            {
                //int index = count / 6;
                foreach (Control screenControl in PanelControl.Controls)
                    if (screenControl is PictureBox &&
                        screenControl.Name == "pictureBox" + picBoxIndex)
                        screenControl.Visible = false;
                myTimer.Stop();
 

                if (++picBoxIndex > 6)
                {
                    count = 0;
                    picBoxIndex = 1;
                    foreach (Control screenControl in PanelControl.Controls)
                        if (screenControl is PictureBox && listPicBoxName.Contains(screenControl.Name))
                            screenControl.Visible = true;
                }

            }

            if (count == 0)
                PanelControl.Location = new Point(origianl_x, original_y);
            else
                PanelControl.Location = new Point(INITIAL_X + STEP, INITIAL_Y);

            PanelControl.Visible = true;

            PanelControl.Refresh();
        }

        internal void stop()
        {
            myTimer.Stop();
        }
    }
}

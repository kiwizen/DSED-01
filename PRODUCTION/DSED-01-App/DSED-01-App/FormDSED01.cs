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
        //private CommonControlClass _myCommonClass;
        private BombInBoxGame _myGame;
        // Custom Controls
        private PictureBoxWithTimer pictureBox1;

        public FormDSED01()
        {
            //_myCommonClass = new CommonControlClass();
            _myGame = new BombInBoxGame();


            InitializeComponent();
            InitializeGameScreenLayout();

            // 
            // pictureBox1
            // 
            this.pictureBox1 = new PictureBoxWithTimer();
            this.pictureBox1.Name = "pictureBox1";

            //this.pictureBox1.CallBack += this.showButton;
            //this.pictureBox1.Visible = true;
            this.Controls.Add(this.pictureBox1);
            this.pictureBox1.TestCall += this.testMovingBox;
            this.pictureBox1.Image = CommonControlClass.getRandomImage(_myGame.getRandomNumber());
            pictureBox1.TimerStart();
        }

        private void testMovingBox()
        {
            /*
            _myGame.Next();
            if(_myGame.CurrentBoxID < 7)
            {
                //this.pictureBox1.Text = _myGame.CurrentBoxID.ToString();
                pictureBox1.TimerStart();
            }
            */

            this.pictureBox1.Image = CommonControlClass.getRandomImage(_myGame.getRandomNumber());
            pictureBox1.TimerStart();
        }
    }
}

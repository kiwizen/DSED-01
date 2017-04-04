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
            this.pictureBox1.CallBackMethod += this.testMovingBox;
            /*
            //int c = int.Parse(pictureBox1.Tag.ToString());
            int i = _myGame.getRandomNumber();

            this.pictureBox1.Image = CommonControlClass.getRandomImage(i);
            this.pictureBox1.Tag = i.ToString();
            */

            pictureBox1.TimerStart();
        }

        private void testMovingBox(bool flag = true)
        {
            
            _myGame.Next();
            if(_myGame.CurrentBoxID == 7)
                _myGame.NewGame();

            this.pictureBox1.Text = _myGame.CurrentBoxID.ToString();

            pictureBox1.TimerStart();
            /*
            int c = int.Parse(pictureBox1.Tag.ToString());
            int i = _myGame.getRandomNumber(currentNum: c);
            this.pictureBox1.Image = CommonControlClass.getRandomImage(i);
            this.pictureBox1.Tag = i.ToString();
            pictureBox1.TimerStart();
            */

        }
    }
}


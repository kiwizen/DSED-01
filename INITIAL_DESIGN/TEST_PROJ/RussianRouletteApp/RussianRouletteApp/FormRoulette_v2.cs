using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRouletteApp
{
    public partial class FormRoulette_v2 : Form
    {
        private ClassRoulette myClassRoulette;
        public FormRoulette_v2()
        {
            myClassRoulette = new ClassRoulette();
            myClassRoulette.NewGame();
            InitializeComponent();
            refreshScreen();
        }

        private void refreshScreen ()
        {
            labelBullet.Text = myClassRoulette.Value.ToString();
            labelNum.Text = myClassRoulette.Counter.ToString();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            myClassRoulette.NewGame();
            refreshScreen();
        }

        private void buttonFire_Click(object sender, EventArgs e)
        {
            if (myClassRoulette.isShoot())
            {
                MessageBox.Show("You have been shot!!!\nPlease try again");

                myClassRoulette.NewGame();
            }
            else
            {
                myClassRoulette.Next();
            }
            refreshScreen();
            
        }
    }
}

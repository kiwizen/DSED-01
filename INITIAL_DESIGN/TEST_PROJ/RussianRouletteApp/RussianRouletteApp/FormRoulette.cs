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
    public partial class FormRoulette : Form
    {
        RouletteClass myRoulette;
        public FormRoulette()
        {
            InitializeComponent();
            myRoulette = new RouletteClass();
            clearForm();
            //refreshForm();
        }


        private void clearForm()
        {
            //labelBullet.Text = string.Empty;        
            newGame();
            labelGame.Text = myRoulette.NumberOfGamePlayed().ToString();
            labelWin.Text = myRoulette.Win.ToString();
            labelLoss.Text = myRoulette.Loss.ToString();
            labelChance.Text = "You have on " + myRoulette.Try + " chance left.";
        }

        private void refreshForm()
        {
            //labelNum.Text = string.Empty;

        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void newGame()
        {
            labelNum.Text = "1";
            myRoulette.NewGame();
            labelBullet.Text = myRoulette.Value.ToString();
            timer1.Start();
        }

        private void buttonSpin_Click(object sender, EventArgs e)
        {
            myRoulette.Roll();
            labelNum.Text = myRoulette.Selected.ToString();
        }

        private void buttonFire_Click(object sender, EventArgs e)
        {
            if (labelNum.Text == string.Empty || labelBullet.Text == string.Empty) return;

            timer1.Stop();
            myRoulette.Selected = int.Parse(labelNum.Text);

            bool refresh = false;

            if (myRoulette.isShoot())
            {
                MessageBox.Show("You have been shot!!!\nPlease try again");
                refresh = true;
            }
            else
            {
                MessageBox.Show("You lived !!!");

                if (myRoulette.isWon())
                {
                    MessageBox.Show("You won the game !!!");
                    refresh = true;
                }
                else
                    timer1.Start();

                //labelNum.Text = string.Empty;
                labelChance.Text = "You have on " + myRoulette.Try + " chance left.";
            }

            if(refresh)
            {             
                clearForm();
                //buttonLoad_Click(sender, e);
                //refreshForm();
                newGame();
            }
        }


        private void buttonNew_Click(object sender, EventArgs e)
        {
            clearForm();
            buttonLoad_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //int count = ;
            labelNum.Text = (int.Parse(labelNum.Text) % 6 + 1).ToString();
        }
    }
}
        

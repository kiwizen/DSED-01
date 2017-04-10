using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSED_01_App
{
    class CommonControlClass
    {
        private static int _index = 0;

        public static System.Drawing.Bitmap BoxImage
        {
            get => global::DSED_01_App.Properties.Resources.box;
        }

        public static System.Drawing.Bitmap BombImage
        {
            get => global::DSED_01_App.Properties.Resources.bomb;
        }

        public static string TextFile
        {
            get => global::DSED_01_App.Properties.Resources.Story;
        }

        public static string [] ImageList
        {
            get => new string [] { "bird", "cat", "dog", "duck", "giraffe", "guitar", "seahorse" };
        }

        public static int getTabIndex() { return ++_index; }

        public static System.Drawing.Bitmap getRandomImage(int i)
        {
            return global::DSED_01_App.Properties.Resources.ResourceManager.GetObject(ImageList[i])
                            as System.Drawing.Bitmap;
        }

        public static void LetPlaySound()
        {
            playSound(global::DSED_01_App.Properties.Resources.lets_play);
        }

        public static void PlayFindBombSound()
        {         
            playSound(global::DSED_01_App.Properties.Resources.absolute_end);
        }

        public static void playUsedAllRobotArmSound()
        {
            playSound(global::DSED_01_App.Properties.Resources.aah_aah);
        }

        public static void playWinningSound()
        {
            playSound(global::DSED_01_App.Properties.Resources.Cheering);
        }

        public static void playNextMoveSound()
        {
            playSound(global::DSED_01_App.Properties.Resources.back_4_more_fun);
        }

        public static void playSafeMoveSound()
        {
            playSound(global::DSED_01_App.Properties.Resources.all_system_go);
        }
        private static void playSound(UnmanagedMemoryStream wave)
        {
            System.Media.SoundPlayer player =
                new System.Media.SoundPlayer();
            player.Stream = wave;
            player.LoadAsync();
            player.Play();
        }

        /// <summary>
        /// This method create a unified label control on the form. 
        /// </summary>
        /// <param name="label">label control.</param>
        /// <param name="labelText">text to be display on the label control.</param>
        /// <param name="x">x coordinate of the label control.</param>
        /// <param name="y">y coordinate of the label control.</param>
        /// <param name="width">width of the label control.</param>
        /// <param name="height">height of the label control.</param>
        /// <param name="font_size">font size of the label control</param>
        /// <param name="textalign">set alignment of the text on the label control</param>
        /// <param name="FixBorder">set whether the border of the label control is fixed.</param>
        public static void initialiseLabelControl(
            out System.Windows.Forms.Label label,
            string labelText, int x, int y, int width = 70, int height = 30,
            System.Single font_size = 12F,
            System.Drawing.ContentAlignment textalign = System.Drawing.ContentAlignment.MiddleLeft,
            bool FixBorder = false)
        {
            label = new System.Windows.Forms.Label();
            label.Font = new System.Drawing.Font("Papyrus", font_size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(x, y);
            label.Size = new System.Drawing.Size(width, height);
            label.Text = labelText;
            label.TabIndex = CommonControlClass.getTabIndex();
            label.TextAlign = textalign;
            if (FixBorder)
                label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        /// <summary>
        /// This method create a unified button control on the form.
        /// </summary>
        /// <param name="button"></param>
        /// <param name="buttonText"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="font_size"></param>
        public static void initialiseButtonControl(
            out System.Windows.Forms.Button button,
            string buttonText, int x, int y, int width, int height,
            System.Single font_size = 12F)
        {
            button = new System.Windows.Forms.Button();
            button.Font = new System.Drawing.Font("Papyrus", font_size, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            button.Location = new System.Drawing.Point(x, y);
            button.Size = new System.Drawing.Size(width, height);          
            button.Text = buttonText;
            button.UseVisualStyleBackColor = true;
            button.TabIndex = CommonControlClass.getTabIndex();
        }

        public static void intialiseComboBoxControl(out System.Windows.Forms.ComboBox combo,
            int x, int y, int width = 150, int height = 30, System.Single font_size = 10F)
        {
            combo = new System.Windows.Forms.ComboBox();
            combo.Location = new System.Drawing.Point(x, y);
            combo = new System.Windows.Forms.ComboBox();
            combo.Font = new System.Drawing.Font("Papyrus", font_size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            combo.Location = new System.Drawing.Point(x, y);
            combo.Size = new System.Drawing.Size(width, height);

        }
        /*
        public static void playSound(string path)
        {
            System.Media.SoundPlayer player =
                new System.Media.SoundPlayer();
            //player.SoundLocation = path;
            player.SoundLocation = path;
            player.Load();
            player.Play();
        }
        */
    }
}

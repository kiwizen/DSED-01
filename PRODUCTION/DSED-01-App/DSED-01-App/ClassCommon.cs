using System;
using System.Collections.Generic;
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

        public static int getTabIndex() { return ++_index; }

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





    }
}

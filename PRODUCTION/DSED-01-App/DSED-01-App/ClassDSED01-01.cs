using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSED_01_App
{
    /// <summary>
    /// This file contains all Methods that initialise all control objects for the FormDSED01
    /// </summary>
    partial class FormDSED01
    {
        /// <summary>
        /// label control that store the title of the game
        /// </summary>
        private System.Windows.Forms.Label labelGameTitle;

        private void InitializeGameScreenLayout()
        {
            InitializeForm();
            SetGameTitle();
        }

        /// <summary>
        /// This method initializes the form
        /// </summary>
        private void InitializeForm()
        {
            // No Max/Min/Exit Control button on the Form
            this.ControlBox = false;
            // set to Borderless
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            // set the form size
            this.Size = new System.Drawing.Size(800, 600);
            // Center the form on the screen                                                                  
            this.CenterToScreen();
        }

        /// <summary>
        /// This method intialize the label control that display the title of the game
        /// Display "Bomb in the Box" on a label control
        /// </summary>
        private void SetGameTitle()
        {
            this.labelGameTitle = new System.Windows.Forms.Label();

            this.labelGameTitle.AutoSize = true;
            this.labelGameTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelGameTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGameTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelGameTitle.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelGameTitle.Location = new System.Drawing.Point(200, 25);
            this.labelGameTitle.Name = "labelGameTitle";
            this.labelGameTitle.Size = new System.Drawing.Size(400, 60);
            this.labelGameTitle.TabIndex = CommonControlClass.getTabIndex();
            this.labelGameTitle.Text = "Bomb  in  the  Box";
            this.labelGameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.Controls.Add(this.labelGameTitle);

            this.labelGameTitle.Visible = false;
        }
    }
}

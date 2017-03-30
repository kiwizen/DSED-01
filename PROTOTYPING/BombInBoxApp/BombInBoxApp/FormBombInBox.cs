using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombInBoxApp
{
    public partial class FormBoxInBox : Form
    {
        private System.Windows.Forms.Label labelGameTitle;
        private System.Windows.Forms.Button buttonExit;

        public FormBoxInBox()
        {        
            InitializeComponent();
            setupFormBoxInBox();
        }

        private void setupFormBoxInBox()
        {
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            // Display "Bomb in the Box" on a label
            this.labelGameTitle = new System.Windows.Forms.Label();
            this.labelGameTitle.AutoSize = true;
            this.labelGameTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelGameTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGameTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelGameTitle.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelGameTitle.Location = new System.Drawing.Point(250, 25);
            this.labelGameTitle.Name = "label1";
            this.labelGameTitle.Size = new System.Drawing.Size(400, 60);
            this.labelGameTitle.TabIndex = 6;
            this.labelGameTitle.Text = "Bomb  in  the  Box";
            this.labelGameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


            // 
            // buttonExit
            // 
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonExit.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonExit.Location = new System.Drawing.Point(550, 450);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(200, 72);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit App";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);

            this.Controls.Add(this.labelGameTitle);
            this.Controls.Add(this.buttonExit);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

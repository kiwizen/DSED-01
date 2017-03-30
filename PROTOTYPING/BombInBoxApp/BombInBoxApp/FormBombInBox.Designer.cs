namespace BombInBoxApp
{
    partial class FormBoxInBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormBoxInBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormBoxInBox";
            this.ResumeLayout(false);

        }

        #endregion

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
            this.labelGameTitle.Location = new System.Drawing.Point(200, 25);
            this.labelGameTitle.Name = "labelGameTitle";
            this.labelGameTitle.Size = new System.Drawing.Size(400, 60);
            this.labelGameTitle.TabIndex = 6;
            this.labelGameTitle.Text = "Bomb  in  the  Box";
            this.labelGameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            //
            // Create a label box to display text on the screen
            //
            this.labelText = new System.Windows.Forms.Label();
            this.labelText.AutoSize = false;
            this.labelText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelText.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelText.Location = new System.Drawing.Point(175, 100);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(450,300);
            this.labelText.TabIndex = 6;
            this.labelText.Text = "Text on Screen";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // buttonExit
            // 
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonExit.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonExit.Location = new System.Drawing.Point(650, 490);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 55);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit App";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);

            this.Controls.Add(this.labelGameTitle);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonExit);


            // Center the form on the screen
            this.CenterToScreen();
        }
        private System.Windows.Forms.Label labelGameTitle;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonExit;
    }
}


namespace RussianRouletteApp
{
    partial class FormRoulette_v2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurrentID = new System.Windows.Forms.Label();
            this.labelBombLocation = new System.Windows.Forms.Label();
            this.labelWin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelLoss = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNoOfRobot = new System.Windows.Forms.Label();
            this.labelGame = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonOpenBox = new System.Windows.Forms.Button();
            this.buttonSpin = new System.Windows.Forms.Button();
            this.buttonUseRobot = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Current Box ID :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bomb is at :";
            // 
            // labelCurrentID
            // 
            this.labelCurrentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCurrentID.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentID.Location = new System.Drawing.Point(201, 163);
            this.labelCurrentID.Name = "labelCurrentID";
            this.labelCurrentID.Size = new System.Drawing.Size(74, 27);
            this.labelCurrentID.TabIndex = 9;
            this.labelCurrentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBombLocation
            // 
            this.labelBombLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBombLocation.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBombLocation.Location = new System.Drawing.Point(201, 127);
            this.labelBombLocation.Name = "labelBombLocation";
            this.labelBombLocation.Size = new System.Drawing.Size(74, 27);
            this.labelBombLocation.TabIndex = 8;
            this.labelBombLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWin
            // 
            this.labelWin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWin.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWin.Location = new System.Drawing.Point(121, 72);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(74, 27);
            this.labelWin.TabIndex = 21;
            this.labelWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 27);
            this.label5.TabIndex = 20;
            this.label5.Text = "Win :";
            // 
            // labelLoss
            // 
            this.labelLoss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLoss.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoss.Location = new System.Drawing.Point(206, 72);
            this.labelLoss.Name = "labelLoss";
            this.labelLoss.Size = new System.Drawing.Size(74, 27);
            this.labelLoss.TabIndex = 19;
            this.labelLoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "Loss :";
            // 
            // labelNoOfRobot
            // 
            this.labelNoOfRobot.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoOfRobot.Location = new System.Drawing.Point(85, 217);
            this.labelNoOfRobot.Name = "labelNoOfRobot";
            this.labelNoOfRobot.Size = new System.Drawing.Size(149, 83);
            this.labelNoOfRobot.TabIndex = 17;
            this.labelNoOfRobot.Text = "You have ? robot left.";
            // 
            // labelGame
            // 
            this.labelGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGame.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGame.Location = new System.Drawing.Point(34, 72);
            this.labelGame.Name = "labelGame";
            this.labelGame.Size = new System.Drawing.Size(74, 27);
            this.labelGame.TabIndex = 16;
            this.labelGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "Game :";
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonNew.Location = new System.Drawing.Point(313, 55);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(140, 62);
            this.buttonNew.TabIndex = 25;
            this.buttonNew.Text = "New Game";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonOpenBox
            // 
            this.buttonOpenBox.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonOpenBox.Location = new System.Drawing.Point(313, 128);
            this.buttonOpenBox.Name = "buttonOpenBox";
            this.buttonOpenBox.Size = new System.Drawing.Size(140, 69);
            this.buttonOpenBox.TabIndex = 24;
            this.buttonOpenBox.Text = "Open the Box";
            this.buttonOpenBox.UseVisualStyleBackColor = true;
            this.buttonOpenBox.Click += new System.EventHandler(this.buttonOpenBox_Click);
            // 
            // buttonSpin
            // 
            this.buttonSpin.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonSpin.Location = new System.Drawing.Point(313, 55);
            this.buttonSpin.Name = "buttonSpin";
            this.buttonSpin.Size = new System.Drawing.Size(140, 60);
            this.buttonSpin.TabIndex = 23;
            this.buttonSpin.Text = "Spin Chambers";
            this.buttonSpin.UseVisualStyleBackColor = true;
            // 
            // buttonUseRobot
            // 
            this.buttonUseRobot.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUseRobot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonUseRobot.Location = new System.Drawing.Point(258, 217);
            this.buttonUseRobot.Name = "buttonUseRobot";
            this.buttonUseRobot.Size = new System.Drawing.Size(195, 71);
            this.buttonUseRobot.TabIndex = 22;
            this.buttonUseRobot.Text = "Use Robot to open the box";
            this.buttonUseRobot.UseVisualStyleBackColor = true;
            this.buttonUseRobot.Click += new System.EventHandler(this.buttonUseRobot_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(27, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 33);
            this.label6.TabIndex = 26;
            this.label6.Text = "Bomb in the Box !!!";
            // 
            // FormRoulette_v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 300);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonOpenBox);
            this.Controls.Add(this.buttonUseRobot);
            this.Controls.Add(this.labelWin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelLoss);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNoOfRobot);
            this.Controls.Add(this.labelGame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCurrentID);
            this.Controls.Add(this.labelBombLocation);
            this.Controls.Add(this.buttonSpin);
            this.Name = "FormRoulette_v2";
            this.Text = "Russian Roulette version 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCurrentID;
        private System.Windows.Forms.Label labelBombLocation;
        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelLoss;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNoOfRobot;
        private System.Windows.Forms.Label labelGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonOpenBox;
        private System.Windows.Forms.Button buttonSpin;
        private System.Windows.Forms.Button buttonUseRobot;
        private System.Windows.Forms.Label label6;
    }
}
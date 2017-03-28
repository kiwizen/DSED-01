namespace RussianRouletteApp
{
    partial class FormRoulette
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
            this.components = new System.ComponentModel.Container();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSpin = new System.Windows.Forms.Button();
            this.buttonFire = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.labelBullet = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelGame = new System.Windows.Forms.Label();
            this.labelChance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelLoss = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelWin = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonLoad.Location = new System.Drawing.Point(447, 19);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(140, 72);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load Bullet";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSpin
            // 
            this.buttonSpin.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonSpin.Location = new System.Drawing.Point(447, 107);
            this.buttonSpin.Name = "buttonSpin";
            this.buttonSpin.Size = new System.Drawing.Size(140, 65);
            this.buttonSpin.TabIndex = 1;
            this.buttonSpin.Text = "Spin Chambers";
            this.buttonSpin.UseVisualStyleBackColor = true;
            this.buttonSpin.Click += new System.EventHandler(this.buttonSpin_Click);
            // 
            // buttonFire
            // 
            this.buttonFire.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonFire.Location = new System.Drawing.Point(447, 189);
            this.buttonFire.Name = "buttonFire";
            this.buttonFire.Size = new System.Drawing.Size(140, 54);
            this.buttonFire.TabIndex = 2;
            this.buttonFire.Text = "Fire";
            this.buttonFire.UseVisualStyleBackColor = true;
            this.buttonFire.Click += new System.EventHandler(this.buttonFire_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonNew.Location = new System.Drawing.Point(447, 258);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(140, 58);
            this.buttonNew.TabIndex = 3;
            this.buttonNew.Text = "New Game";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // labelBullet
            // 
            this.labelBullet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBullet.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBullet.Location = new System.Drawing.Point(174, 19);
            this.labelBullet.Name = "labelBullet";
            this.labelBullet.Size = new System.Drawing.Size(74, 29);
            this.labelBullet.TabIndex = 4;
            this.labelBullet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNum
            // 
            this.labelNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNum.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum.Location = new System.Drawing.Point(174, 58);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(74, 29);
            this.labelNum.TabIndex = 5;
            this.labelNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bullet Loaded at :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "You Fire at :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Game :";
            // 
            // labelGame
            // 
            this.labelGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGame.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGame.Location = new System.Drawing.Point(174, 157);
            this.labelGame.Name = "labelGame";
            this.labelGame.Size = new System.Drawing.Size(74, 29);
            this.labelGame.TabIndex = 9;
            this.labelGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChance
            // 
            this.labelChance.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChance.Location = new System.Drawing.Point(77, 207);
            this.labelChance.Name = "labelChance";
            this.labelChance.Size = new System.Drawing.Size(303, 36);
            this.labelChance.TabIndex = 10;
            this.labelChance.Text = "You have on ? chance left.";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Loss :";
            // 
            // labelLoss
            // 
            this.labelLoss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLoss.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoss.Location = new System.Drawing.Point(174, 258);
            this.labelLoss.Name = "labelLoss";
            this.labelLoss.Size = new System.Drawing.Size(74, 29);
            this.labelLoss.TabIndex = 12;
            this.labelLoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Win :";
            // 
            // labelWin
            // 
            this.labelWin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWin.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWin.Location = new System.Drawing.Point(174, 306);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(74, 29);
            this.labelWin.TabIndex = 14;
            this.labelWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormRoulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 362);
            this.Controls.Add(this.labelWin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelLoss);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelChance);
            this.Controls.Add(this.labelGame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.labelBullet);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonFire);
            this.Controls.Add(this.buttonSpin);
            this.Controls.Add(this.buttonLoad);
            this.Name = "FormRoulette";
            this.Text = "Russian Roulette";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSpin;
        private System.Windows.Forms.Button buttonFire;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Label labelBullet;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelGame;
        private System.Windows.Forms.Label labelChance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelLoss;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.Timer timer1;
    }
}


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
            this.labelNum = new System.Windows.Forms.Label();
            this.labelBullet = new System.Windows.Forms.Label();
            this.labelWin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelLoss = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelChance = new System.Windows.Forms.Label();
            this.labelGame = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonFire = new System.Windows.Forms.Button();
            this.buttonSpin = new System.Windows.Forms.Button();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "You start fire at :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bullet Loaded at :";
            // 
            // labelNum
            // 
            this.labelNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNum.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum.Location = new System.Drawing.Point(194, 157);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(74, 29);
            this.labelNum.TabIndex = 9;
            this.labelNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBullet
            // 
            this.labelBullet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBullet.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBullet.Location = new System.Drawing.Point(194, 118);
            this.labelBullet.Name = "labelBullet";
            this.labelBullet.Size = new System.Drawing.Size(74, 29);
            this.labelBullet.TabIndex = 8;
            this.labelBullet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWin
            // 
            this.labelWin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWin.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWin.Location = new System.Drawing.Point(114, 59);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(74, 29);
            this.labelWin.TabIndex = 21;
            this.labelWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Win :";
            // 
            // labelLoss
            // 
            this.labelLoss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLoss.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoss.Location = new System.Drawing.Point(199, 59);
            this.labelLoss.Name = "labelLoss";
            this.labelLoss.Size = new System.Drawing.Size(74, 29);
            this.labelLoss.TabIndex = 19;
            this.labelLoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Loss :";
            // 
            // labelChance
            // 
            this.labelChance.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChance.Location = new System.Drawing.Point(32, 207);
            this.labelChance.Name = "labelChance";
            this.labelChance.Size = new System.Drawing.Size(303, 36);
            this.labelChance.TabIndex = 17;
            this.labelChance.Text = "You have on ? chance left.";
            // 
            // labelGame
            // 
            this.labelGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGame.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGame.Location = new System.Drawing.Point(27, 59);
            this.labelGame.Name = "labelGame";
            this.labelGame.Size = new System.Drawing.Size(74, 29);
            this.labelGame.TabIndex = 16;
            this.labelGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Game :";
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonNew.Location = new System.Drawing.Point(313, 11);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(140, 62);
            this.buttonNew.TabIndex = 25;
            this.buttonNew.Text = "New Game";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonFire
            // 
            this.buttonFire.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonFire.Location = new System.Drawing.Point(313, 159);
            this.buttonFire.Name = "buttonFire";
            this.buttonFire.Size = new System.Drawing.Size(140, 75);
            this.buttonFire.TabIndex = 24;
            this.buttonFire.Text = "Fire";
            this.buttonFire.UseVisualStyleBackColor = true;
            this.buttonFire.Click += new System.EventHandler(this.buttonFire_Click);
            // 
            // buttonSpin
            // 
            this.buttonSpin.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonSpin.Location = new System.Drawing.Point(313, 82);
            this.buttonSpin.Name = "buttonSpin";
            this.buttonSpin.Size = new System.Drawing.Size(140, 65);
            this.buttonSpin.TabIndex = 23;
            this.buttonSpin.Text = "Spin Chambers";
            this.buttonSpin.UseVisualStyleBackColor = true;
            // 
            // buttonSkip
            // 
            this.buttonSkip.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSkip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonSkip.Location = new System.Drawing.Point(12, 257);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(309, 46);
            this.buttonSkip.TabIndex = 22;
            this.buttonSkip.Text = "Take a chance and skip the number.";
            this.buttonSkip.UseVisualStyleBackColor = true;
            // 
            // FormRoulette_v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 325);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonFire);
            this.Controls.Add(this.buttonSpin);
            this.Controls.Add(this.buttonSkip);
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
            this.Name = "FormRoulette_v2";
            this.Text = "Russian Roulette version 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelBullet;
        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelLoss;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelChance;
        private System.Windows.Forms.Label labelGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonFire;
        private System.Windows.Forms.Button buttonSpin;
        private System.Windows.Forms.Button buttonSkip;
    }
}
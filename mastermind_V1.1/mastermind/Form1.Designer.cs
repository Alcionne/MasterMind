
namespace mastermind
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNewGame = new System.Windows.Forms.Button();
            this.picSolution1 = new System.Windows.Forms.PictureBox();
            this.picSolution2 = new System.Windows.Forms.PictureBox();
            this.picSolution3 = new System.Windows.Forms.PictureBox();
            this.picSolution4 = new System.Windows.Forms.PictureBox();
            this.Red = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Orange = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.White = new System.Windows.Forms.Button();
            this.Purple = new System.Windows.Forms.Button();
            this.Pink = new System.Windows.Forms.Button();
            this.lblG = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSolution1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSolution2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSolution3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSolution4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(22, 12);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(266, 30);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "Nouvelle Partie";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // picSolution1
            // 
            this.picSolution1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSolution1.Location = new System.Drawing.Point(22, 56);
            this.picSolution1.Name = "picSolution1";
            this.picSolution1.Size = new System.Drawing.Size(60, 45);
            this.picSolution1.TabIndex = 1;
            this.picSolution1.TabStop = false;
            this.picSolution1.Visible = false;
            // 
            // picSolution2
            // 
            this.picSolution2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSolution2.Location = new System.Drawing.Point(90, 56);
            this.picSolution2.Name = "picSolution2";
            this.picSolution2.Size = new System.Drawing.Size(60, 45);
            this.picSolution2.TabIndex = 2;
            this.picSolution2.TabStop = false;
            this.picSolution2.Visible = false;
            // 
            // picSolution3
            // 
            this.picSolution3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSolution3.Location = new System.Drawing.Point(158, 56);
            this.picSolution3.Name = "picSolution3";
            this.picSolution3.Size = new System.Drawing.Size(60, 45);
            this.picSolution3.TabIndex = 3;
            this.picSolution3.TabStop = false;
            this.picSolution3.Visible = false;
            // 
            // picSolution4
            // 
            this.picSolution4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSolution4.Location = new System.Drawing.Point(226, 56);
            this.picSolution4.Name = "picSolution4";
            this.picSolution4.Size = new System.Drawing.Size(60, 45);
            this.picSolution4.TabIndex = 4;
            this.picSolution4.TabStop = false;
            this.picSolution4.Visible = false;
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(22, 609);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(60, 35);
            this.Red.TabIndex = 16;
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(90, 609);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(60, 35);
            this.Yellow.TabIndex = 17;
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.Location = new System.Drawing.Point(158, 609);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(60, 35);
            this.Blue.TabIndex = 18;
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Orange
            // 
            this.Orange.BackColor = System.Drawing.Color.Orange;
            this.Orange.Location = new System.Drawing.Point(226, 609);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(60, 35);
            this.Orange.TabIndex = 19;
            this.Orange.UseVisualStyleBackColor = false;
            this.Orange.Click += new System.EventHandler(this.Orange_Click);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Green;
            this.Green.Location = new System.Drawing.Point(22, 645);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(60, 35);
            this.Green.TabIndex = 20;
            this.Green.UseVisualStyleBackColor = false;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // White
            // 
            this.White.BackColor = System.Drawing.Color.White;
            this.White.Location = new System.Drawing.Point(90, 645);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(60, 35);
            this.White.TabIndex = 21;
            this.White.UseVisualStyleBackColor = false;
            this.White.Click += new System.EventHandler(this.White_Click);
            // 
            // Purple
            // 
            this.Purple.BackColor = System.Drawing.Color.Purple;
            this.Purple.Location = new System.Drawing.Point(158, 645);
            this.Purple.Name = "Purple";
            this.Purple.Size = new System.Drawing.Size(60, 35);
            this.Purple.TabIndex = 22;
            this.Purple.UseVisualStyleBackColor = false;
            this.Purple.Click += new System.EventHandler(this.Purple_Click);
            // 
            // Pink
            // 
            this.Pink.BackColor = System.Drawing.Color.Pink;
            this.Pink.Location = new System.Drawing.Point(226, 645);
            this.Pink.Name = "Pink";
            this.Pink.Size = new System.Drawing.Size(60, 35);
            this.Pink.TabIndex = 23;
            this.Pink.UseVisualStyleBackColor = false;
            this.Pink.Click += new System.EventHandler(this.Pink_Click);
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblG.Location = new System.Drawing.Point(305, 56);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(86, 13);
            this.lblG.TabIndex = 24;
            this.lblG.Text = "Parties gagnées:";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblP.Location = new System.Drawing.Point(305, 88);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(83, 13);
            this.lblP.TabIndex = 25;
            this.lblP.Text = "Parties perdues:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(429, 693);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.Pink);
            this.Controls.Add(this.Purple);
            this.Controls.Add(this.picSolution1);
            this.Controls.Add(this.White);
            this.Controls.Add(this.picSolution2);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.picSolution3);
            this.Controls.Add(this.Orange);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.picSolution4);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.Red);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterMind";
            ((System.ComponentModel.ISupportInitialize)(this.picSolution1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSolution2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSolution3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSolution4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.PictureBox picSolution1;
        private System.Windows.Forms.PictureBox picSolution2;
        private System.Windows.Forms.PictureBox picSolution3;
        private System.Windows.Forms.PictureBox picSolution4;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Orange;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button White;
        private System.Windows.Forms.Button Purple;
        private System.Windows.Forms.Button Pink;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblP;
    }
}


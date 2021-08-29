
namespace Alien_Invasion
{
    partial class Form1
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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.ufo = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pillar2 = new System.Windows.Forms.PictureBox();
            this.pillar1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(13, 13);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(118, 26);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "SCORE: 0";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(801, 13);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(112, 26);
            this.lblLevel.TabIndex = 5;
            this.lblLevel.Text = "LEVEL: 1";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblGameOver.Location = new System.Drawing.Point(277, 192);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(391, 70);
            this.lblGameOver.TabIndex = 6;
            this.lblGameOver.Text = "         GAME OVER! \r\nPRESS ENTER TO RETRY";
            this.lblGameOver.Visible = false;
            // 
            // ufo
            // 
            this.ufo.Image = global::Alien_Invasion.Properties.Resources.alien1;
            this.ufo.Location = new System.Drawing.Point(820, 283);
            this.ufo.Name = "ufo";
            this.ufo.Size = new System.Drawing.Size(66, 40);
            this.ufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ufo.TabIndex = 3;
            this.ufo.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::Alien_Invasion.Properties.Resources.Spaceship1;
            this.player.Location = new System.Drawing.Point(101, 154);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(133, 35);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // pillar2
            // 
            this.pillar2.Image = global::Alien_Invasion.Properties.Resources.pillar5;
            this.pillar2.Location = new System.Drawing.Point(244, 304);
            this.pillar2.Name = "pillar2";
            this.pillar2.Size = new System.Drawing.Size(66, 174);
            this.pillar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillar2.TabIndex = 1;
            this.pillar2.TabStop = false;
            this.pillar2.Tag = "pillar";
            // 
            // pillar1
            // 
            this.pillar1.BackColor = System.Drawing.Color.Transparent;
            this.pillar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pillar1.Image = global::Alien_Invasion.Properties.Resources.pillar5;
            this.pillar1.Location = new System.Drawing.Point(576, -1);
            this.pillar1.Name = "pillar1";
            this.pillar1.Size = new System.Drawing.Size(66, 190);
            this.pillar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillar1.TabIndex = 0;
            this.pillar1.TabStop = false;
            this.pillar1.Tag = "pillar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(925, 478);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.ufo);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pillar2);
            this.Controls.Add(this.pillar1);
            this.Name = "Form1";
            this.Text = "Alien Invasion";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pillar1;
        private System.Windows.Forms.PictureBox pillar2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ufo;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblGameOver;
    }
}


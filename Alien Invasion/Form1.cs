using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Alien_Invasion
{
    public partial class Form1 : Form
    {
        bool goUp, goDown, shot, gameOver;
        int score = 0;
        int speed = 8;
        int UFOspeed = 10;

        Random rand = new Random();

        int playerSpeed = 7;
        int index = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            lblGameOver.Visible = false;
            txtScore.Text = "SCORE: " + score;
            lblLevel.ForeColor = Color.White;

            if (goUp == true && player.Top > 0)
            {
                player.Top -= playerSpeed;
            }
            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += playerSpeed;
            }

            ufo.Left -= UFOspeed;

            if(ufo.Left + ufo.Width < 0)
            {
                ChangeUFO();
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "pillar")
                {
                    x.Left -= speed;


                    if (x.Left < -200)
                    {
                        x.Left = 1000;
                    }

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameOver();
                    }

                }

                if (x is PictureBox && (string)x.Tag == "bullet")
                {
                    x.Left += 25;

                    if (x.Left > 900)
                    {
                        RemoveBullet(((PictureBox)x));
                    }


                    if (ufo.Bounds.IntersectsWith(x.Bounds))
                    {
                        RemoveBullet(((PictureBox)x));
                        score += 1;
                        ChangeUFO();
                    }

                    if (x.Bounds.IntersectsWith(pillar1.Bounds))
                    {
                        RemoveBullet(((PictureBox)x));
                    }
                    if (x.Bounds.IntersectsWith(pillar2.Bounds))
                    {
                        RemoveBullet(((PictureBox)x));
                    }

                }

            }


            if (player.Bounds.IntersectsWith(ufo.Bounds))
            {
                GameOver();
            }

            if (score > 4)
            {
                speed = 12;
                UFOspeed = 18;
                lblLevel.Text = "LEVEL: 2";
                lblLevel.ForeColor = Color.Yellow;
            }
            if (score > 8 )
            {
                speed = 15;
                UFOspeed = 20;
                lblLevel.Text = "LEVEL: 3";
                lblLevel.ForeColor = Color.Red;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }

            if (e.KeyCode == Keys.Space && shot == false)
            {
                MakeBullet();
                shot = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (shot == true)
            {
                shot = false;
            }

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }

        private void RestartGame()
        {
            goUp = false;
            goDown = false;
            shot = false;
            gameOver = false;
            score = 0;
            speed = 8;
            UFOspeed = 10;


            txtScore.Text = "SCORE: " + score;
            lblLevel.Text = "LEVEL: 1";

            ChangeUFO();

            player.Top = 119;
            pillar1.Left = 617;
            pillar2.Left = 244;

            GameTimer.Start();
        }

        private void GameOver()
        {
            GameTimer.Stop();
            txtScore.Text = "SCORE: " + score;
            lblGameOver.Visible = true;
            gameOver = true;
        }

        

        private void RemoveBullet(PictureBox bullet)
        {
            this.Controls.Remove(bullet);
            bullet.Dispose();
        }

        private void MakeBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.BackColor = Color.Yellow;
            bullet.Height = 5;
            bullet.Width = 10;

            bullet.Left = player.Left + player.Width;
            bullet.Top = player.Top + player.Height / 2;

            bullet.Tag = "bullet";

            this.Controls.Add(bullet);
        }

        private void ChangeUFO()
        {
            if(index > 3)
            {
                index = 1;

            }
            else
            {
                index += 1;
            }

            switch (index)
            {
                case 1:
                    ufo.Image = Properties.Resources.alien1;
                    break;
                case 2:
                    ufo.Image = Properties.Resources.alien2;
                    break;
                case 3:
                    ufo.Image = Properties.Resources.alien3;
                    break;
            }
            ufo.Left = 1000;
            ufo.Top = rand.Next(20, this.ClientSize.Height - ufo.Height);
        }
    }
}

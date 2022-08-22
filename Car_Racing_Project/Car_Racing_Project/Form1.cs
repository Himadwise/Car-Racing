using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Project
{
    public partial class Form1 : Form
    {
        int roadSpeed = 15;
        int trafficSpeed = 15;
        int playerSpeed = 12;
        int score;
        int carImage;

        Random rand = new Random();
        Random carPosition = new Random();
        bool goLeft, goRight;

        public Form1()
        {
            InitializeComponent();
        }

        private void restartGame(object sender, EventArgs e)
        {
            ResetGame();
        }
        private void ResetGame()
        {
            btnStart.Enabled = false;
            explosion.Visible = false;
            award.Visible = false;
            goLeft = false;
            goRight = false;
            score = 0;
            award.Image = Properties.Resources.award;
            roadSpeed = 12;
            trafficSpeed = 15;
            A1.Top = carPosition.Next(200, 500) * -1;
            A1.Top = carPosition.Next(5, 200);
            A2.Top = carPosition.Next(200, 500) * -1;
            A2.Top = carPosition.Next(245, 422);
            gameTimer.Start();
                
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            textScore.Text = "Score :" + score;
            score++;

            if(goLeft==true && Player.Left > 10)
            {
                Player.Left -= playerSpeed;
            }
            if(goRight==true && Player.Left < 415)
            {
                Player.Left += playerSpeed;
            }
            roadTruck1.Top += roadSpeed;
            roadTruck2.Top += roadSpeed;

            if(roadTruck2.Top > 519)
            {
                roadTruck2.Top = -519;
            }
            if (roadTruck1.Top > 519)
            {
                roadTruck1.Top = -519;
            }

            A1.Top += trafficSpeed;
            A2.Top += trafficSpeed;
            if(A1.Top > 530)
            {
                changeAcars(A1);
            }
            if(A2.Top > 530)
            {
                changeAcars(A2);
            }

            if(Player.Bounds.IntersectsWith(A1.Bounds) || Player.Bounds.IntersectsWith(A2.Bounds))
            {
                gameOver();
            }
            if(score >40 && score < 500)
            {
                award.Image = Properties.Resources.award;
            }
            if (score > 500 && score < 2000)
            {
                award.Image = Properties.Resources.award;
                roadSpeed = 20;
                trafficSpeed = 22;
            }
            if (score > 2000)
            {
                award.Image = Properties.Resources.award;
                roadSpeed = 27;
                trafficSpeed = 25;
            }
        }
        private async void gameOver()
        {
            gameTimer.Stop();
            explosion.Visible = true; ;
            Player.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);
            explosion.BackColor = Color.Transparent;
            award.Visible = true;
            award.BringToFront();
            btnStart.Enabled = true;

        }
        private void changeAcars(PictureBox temCar)
        {
            carImage = rand.Next(1, 7);
            switch (carImage)
            {
                case 1:
                    temCar.Image = Properties.Resources.A1_removebg_preview;
                    break;
                case 2:
                    temCar.Image = Properties.Resources.A2_removebg_preview;
                    break;
                case 3:
                    temCar.Image = Properties.Resources.A3_removebg_preview;
                    break;
                case 4:
                    temCar.Image = Properties.Resources.A4_removebg_preview;
                    break;
                case 5:
                    temCar.Image = Properties.Resources.A5_removebg_preview;
                    break;
            }
            temCar.Top = carPosition.Next(100, 400) * -1;
            if ((string)temCar.Tag == "carLeft")
            {
                temCar.Left = carPosition.Next(5, 200);
            }
            if ((string)temCar.Tag == "carRight")
            {
                temCar.Left = carPosition.Next(245, 422);
            }
        }
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }
    }
}

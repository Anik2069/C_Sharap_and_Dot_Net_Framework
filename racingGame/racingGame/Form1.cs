using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace racingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over_text.Visible = false;
        }
        int currentSpeed = 1;
        int PlayerSpeed = 0;
        private void Gameover()
        {
            if (player1.Bounds.IntersectsWith(e1.Bounds))
            {
                timer1.Enabled = false;
                over_text.Visible = true;
                lbl_speed.Text = "Speed -0 MPH";
            }
            if (player1.Bounds.IntersectsWith(e2.Bounds))
            {
                timer1.Enabled = false;
                over_text.Visible = true;
                lbl_speed.Text = "Speed -0 MPH";
            }
            if (player1.Bounds.IntersectsWith(e3.Bounds))
            {
                timer1.Enabled = false;
                over_text.Visible = true;
                lbl_speed.Text = "Speed -0 MPH";
            }
        }

        private void trackLine(int speed)
        {
            if (t1.Top >= 700)
            {
                t1.Top = 0;
            }
            else
            {
                t1.Top+=speed ;
            }
            if (t2.Top >= 700)
            {
                t2.Top = 0;
            }
            else
            {
                t2.Top += speed;
            }
            if (t3.Top >= 700)
            {
                t3.Top = 0;
            }
            else
            {
                t3.Top += speed;
            }
            Random rmd = new Random();
            int x, y,z;
            if (e1.Top >= 650)
            {
                x = rmd.Next(0, 200);
                e1.Location = new Point(x, 0);
            }
            else
            {
                e1.Top += speed;
            }
            if (e2.Top >= 500)
            {
                y = rmd.Next(0, 400);
                e2.Location = new Point(y, 0);
            }
            else
            {
                e2.Top += speed;
            }
            if (e3.Top >= 500)
            {
                z = rmd.Next(0, 400);
                e3.Location = new Point(z, 0);
            }
            else
            {
                e3.Top += speed;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int score = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            trackLine(currentSpeed);
            Gameover();
            if (e1.Top > 560)
            {
                e1.Top = 0;

                score += 10;
                score_txt.Text = "Score - " + score;
            }
            else if (e2.Top > 560)
            {
                e2.Top = 0;
                score += 10;
                score_txt.Text = "Score - " + score;
            }
            else if (e3.Top > 560)
            {
                e3.Top = 0;
                score += 10;
                score_txt.Text = "Score - " + score;
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (player1.Left > 50)
                {
                    player1.Left += -35;
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (player1.Right < 451)
                {
                    player1.Left += 35;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (PlayerSpeed < 50)
                    PlayerSpeed++;
                lbl_speed.Text = "Speed -" + currentSpeed + "MPH".ToString();
                currentSpeed++;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (PlayerSpeed < 50)
                    PlayerSpeed--;
                lbl_speed.Text = "Speed -" + currentSpeed + "MPH".ToString();
                currentSpeed--;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

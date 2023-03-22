using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class gametimer : Form
    {
        int pipe_speed = 15;
        int gravity = 20;
        int score = 0;

        Random random = new Random();
        public gametimer()
        {
            InitializeComponent();
        }

        private void pipetop_Click(object sender, EventArgs e)
        {

        }

        private void timerevent(object sender, EventArgs e)
        {
            label1.Text ="";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            score += 10;
            score_value.Text = "Score : " +score.ToString();
            flappybird.Top += gravity;
            pipetop.Left -= pipe_speed;
            pipebottom.Left -= pipe_speed;
            if (pipetop.Left < -50)
            {
                pipetop.Left = random.Next(800,955);
            }
            if (pipebottom.Left < -100)
            {
                pipebottom.Left = random.Next(800, 955);
            }
            if (flappybird.Top<5)
            {
                flappybird.Top = 15;
            }
            if (flappybird.Bounds.IntersectsWith(pipebottom.Bounds) 
                || flappybird.Bounds.IntersectsWith(pipetop.Bounds )
                || flappybird.Bounds.IntersectsWith(ground.Bounds))
            {
                timer1.Stop();
                score_value.Text = "game over ! " + "score : " + score.ToString();
                label1.Text = "Press Enter to play again";
            }
        }

        private void keyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                gravity = 10;
            }
        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if (timer1.Enabled == false)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    timer1.Start();
                    flappybird.Top = 209;
                    flappybird.Left = 58;
                    pipebottom.Left = 360;
                    pipetop.Left = 629;
                    score = 0;
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                gravity = -10;
            }
            if (e.KeyCode == Keys.Right)
            {
                flappybird.Left += 10;
            }
            if (e.KeyCode == Keys.Left)
            {
                flappybird.Left -= 10;
            }
            if (e.KeyCode == Keys.P)
            {
                timer1.Enabled = false;
            }
            if (e.KeyCode == Keys.R)
            {
                timer1.Enabled = true;
            }


        }

        private void flappybird_Click(object sender, EventArgs e)
        {

        }

        private void score_value_Click(object sender, EventArgs e)
        {

        }

        private void gametimer_Load(object sender, EventArgs e)
        {

        }
    }
    }


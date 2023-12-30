using System;
using System.Drawing;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        Back back = new Back();

        // CONFIG
        bool classicmode = false; // turn it on and see
        bool singleplayer = true ; //  whether p2 can be controlled with up and down keys. note that only one player can be controlled at a time.
        int tickspeed = 50; // how fast the game updates, smaller the number, faster the update

        // BALL STUFF
        string balldir = "tl"; // ball direction
        string balldirlast = "tl"; // last direction before pausing
        int xchange = 5; // ball x offset
        int ychange = 5; // bal y offset

        // PLAYER + MISC
        int p2offset = 0;  // offsets p2 so you can win
        int score = 0; // p1's score as int
        bool paused = false; // self explanatory


        private void Form1_Load(object sender, EventArgs e)
        {
            update.Interval = tickspeed;
            p2offset = p2.Height / 2;
            if (classicmode)
            {
                FormBorderStyle = FormBorderStyle.None;
                TopMost = true;
                back.Show();
                BringToFront();
            }
            pause.Hide();
            if (!singleplayer)
            {
                scoretext.Hide();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!paused)
            {
                if (e.KeyCode == Keys.W)
                {
                    if (p1.Top - 10 >= 0)
                    {
                        p1.Top -= 10;
                    }
                }
                if (e.KeyCode == Keys.S)
                {
                    if (p1.Bottom + p1.Height / 2 <= Height)
                    {
                        p1.Top += 10;
                    }
                }

                if (!singleplayer)
                {
                    if (e.KeyCode == Keys.Up)
                    {
                        if (p2.Top - 10 >= 0)
                        {
                            p2.Top -= 10;
                        }
                    }
                    if (e.KeyCode == Keys.Down)
                    {
                        if (p2.Bottom + p2.Height / 2 <= Height)
                        {
                            p2.Top += 10;
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Space)
            {
                paused = !paused;
                if (paused)
                {
                    balldirlast = balldir;
                    balldir = "static";
                    pause.Show();
                }
                if (!paused)
                {
                    balldir = balldirlast;
                    pause.Hide();
                }
            }
        }

        private void update_Tick(object sender, EventArgs e)
        {
            if (singleplayer)
            {
                p2.Location = new Point(p2.Location.X, ball.Location.Y - p2offset);
                scoretext.Text = score.ToString();
            }

            if (balldir == "tl") // topleft
            {
                ball.Location = new Point(ball.Location.X - xchange, ball.Location.Y - ychange);
            }
            if (balldir == "br") // bottomright
            {
                ball.Location = new Point(ball.Location.X + xchange, ball.Location.Y + ychange);
            }

            if (p1.Bounds.IntersectsWith(ball.Bounds)) // collision for p1
            {
                balldir = "br";
                xchange = rand.Next(2, 6);
                score++;
                tickspeed = tickspeed - 5;
                p2offset = rand.Next(-110, 110); // offset so you have a chance to win
            }
            if (p2.Bounds.IntersectsWith(ball.Bounds)) // collision for p2
            {
                balldir = "tl";
                xchange = rand.Next(2, 6);
                tickspeed = tickspeed - 5;
            }

            if (ball.Location.Y + ball.Height + 50 > Height) // check offscreen vertically
            {
                ychange = ychange - (ychange * 2);
            }
            if (ball.Location.Y - 20 < 0) // also check offscreen vertically
            {
                ychange = ychange - (ychange * 2);
            }

            if (ball.Location.X < 0) // check offscreen horizontally p1
            {
                ball.Location = new Point(Width / 2, Height / 2);
                balldir = "tl";
                p2.Location = new Point(p2.Location.X, Height / 2 - p2.Height / 2);
                p1.Location = new Point(p1.Location.X, Height / 2 - p1.Height / 2);
                SendKeys.SendWait(" "); // some reason setting paused to true doesn't work?
                MessageBox.Show("Player 2 won!");
            }
            if (ball.Location.X > Width) // check offscreen horizontally p2
            {
                ball.Location = new Point(Width / 2, Height / 2);
                balldir = "tl";
                p1.Location = new Point(p1.Location.X, Height / 2 - p1.Height / 2);
                p2.Location = new Point(p2.Location.X, Height / 2 - p2.Height / 2);
                SendKeys.SendWait(" "); // some reason setting paused to true doesn't work?
                MessageBox.Show("Player 1 won!");
            }
        }

        private void Form1_Resize(object sender, EventArgs e) // no maximising
        {
            WindowState = FormWindowState.Normal;
        }
    }
}
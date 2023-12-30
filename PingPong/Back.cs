using System;
using System.Drawing;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Back : Form
    {
        public Back()
        {
            InitializeComponent();
        }

        private void Back_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            button1.Location = new Point((Width / 2) - button1.Width / 2, Height / 2);
            hint.Location = new Point((Width / 2) - hint.Width / 2, Height - 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

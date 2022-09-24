using System;
using System.Drawing;
using System.Windows.Forms;

namespace Starbucks
{
    public partial class screen_home : Form
    {
        public screen_home()
        {
            InitializeComponent();
            home_dynamicIsland.Location = new Point((ClientSize.Width / 2) - (home_dynamicIsland.Width / 2), (starbucks_logo.Height / 2) - (home_dynamicIsland.Height / 2));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}

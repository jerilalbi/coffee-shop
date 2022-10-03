using Guna.UI2.WinForms;
using Starbucks.application.events;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Starbucks
{
    public partial class screen_home : Form
    {
        public static screen_home sc_home_instance;
        bool home_dynamicIsland_active = false;
        public Guna2Panel home_dynamic_island;
        Dynamic_island dynamic_island = new Dynamic_island();

        public screen_home()
        {
            InitializeComponent();
            sc_home_instance = this;
            home_dynamic_island = home_dynamicIsland;
            home_dynamicIsland.Location = new Point((ClientSize.Width / 2) - (home_dynamicIsland.Width / 2),5);
            home_parentForm.Size = new Size(1439, 781);
            mouseClick();
        }

        void mouseClick()
        {
            home_parentForm.MouseClick += new MouseEventHandler(home_ParentPanel_Mouseclick);
            home_dynamicIsland.MouseClick += new MouseEventHandler(dynamicIsland_click);
        }


        void home_ParentPanel_Mouseclick(object sender, EventArgs e) {
            home_dynamicIsland_timer.Enabled = true;
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!home_dynamicIsland_active)
            {
                home_dynamicIsland_timer.Enabled = true;
            }
        }

        private void dynamicIsland_click(object sender, EventArgs e)
        {
                home_dynamicIsland_timer.Enabled = true;
        }

        private void home_dynamicIsland_timer_Tick(object sender, EventArgs e)
        {
            if (home_dynamicIsland_active)
            {
                dynamic_island.srinkDynamicIsland();
                home_dynamicIsland_active = false;
            }
            else
            {
                dynamic_island.expandDynamicIsland();
                home_dynamicIsland_active = true;
            }
            home_dynamicIsland_timer.Enabled = false;
        }
    }
}

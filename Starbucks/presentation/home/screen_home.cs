﻿using Guna.UI2.WinForms;
using Starbucks.application.events;
using Starbucks.presentation.login;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
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
            home_dynamic_island.Size = new Size(200, 50);
            home_dynamic_island.Location = new Point((ClientSize.Width / 2) - (home_dynamic_island.Width / 2),6);
            foreach(Guna2Panel categoryTile in home_dynamicIsland.Controls)
            {
                categoryTile.Visible = false;
            }
            mouseClick();
        }

        void mouseClick()
        {
            home_dynamicIsland.MouseClick += new MouseEventHandler(dynamicIsland_click);
            
        }

        // color = 0, 102, 0  name = home_dynamicIsland  size = 200, 50
        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!home_dynamicIsland_active)
            {
                home_dynamicIsland_timer_expand.Enabled = true;
               
            }
        }

        private void dynamicIsland_click(object sender, EventArgs e)
        {
                home_dynamicIsland_timer_expand.Enabled = true;
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
            home_dynamicIsland_timer_expand.Enabled = false;
        }


        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
            Screen_Login.screen_Login.Show();
            Dispose();
        }
    }
}

using System;
using System.Drawing;

namespace Starbucks.application.events
{
    
    public class Dynamic_island
    {
        public  void expandDynamicIsland()
        {
            while (screen_home.sc_home_instance.home_dynamic_island.Width < 600 || screen_home.sc_home_instance.home_dynamic_island.Height < 100)
            {
                if (screen_home.sc_home_instance.home_dynamic_island.Width < 600)
                {
                    screen_home.sc_home_instance.home_dynamic_island.Width += 8;
                    screen_home.sc_home_instance.home_dynamic_island.Location = new Point((screen_home.sc_home_instance.ClientSize.Width / 2) - (screen_home.sc_home_instance.home_dynamic_island.Width / 2), 5);
                    screen_home.sc_home_instance.home_dynamic_island.Refresh();
                }
                if (screen_home.sc_home_instance.home_dynamic_island.Height < 100)
                {
                    screen_home.sc_home_instance.home_dynamic_island.Height++;
                    screen_home.sc_home_instance.home_dynamic_island.Location = new Point((screen_home.sc_home_instance.ClientSize.Width / 2) - (screen_home.sc_home_instance.home_dynamic_island.Width / 2), 5);
                    screen_home.sc_home_instance.home_dynamic_island.Refresh();
                }
            }
        }

        public void srinkDynamicIsland()
        {
            while (screen_home.sc_home_instance.home_dynamicIsland.Width > 200 || screen_home.sc_home_instance.home_dynamicIsland.Height > 50)
            {
                if (screen_home.sc_home_instance.home_dynamicIsland.Width > 200)
                {
                    screen_home.sc_home_instance.home_dynamicIsland.Width -= 12;
                    screen_home.sc_home_instance.home_dynamic_island.Location = new Point((screen_home.sc_home_instance.ClientSize.Width / 2) - (screen_home.sc_home_instance.home_dynamic_island.Width / 2), 5);
                    screen_home.sc_home_instance.home_dynamic_island.Refresh();
                }
                if (screen_home.sc_home_instance.home_dynamicIsland.Height > 50)
                {
                    screen_home.sc_home_instance.home_dynamicIsland.Height--;
                    screen_home.sc_home_instance.home_dynamic_island.Location = new Point((screen_home.sc_home_instance.ClientSize.Width / 2) - (screen_home.sc_home_instance.home_dynamic_island.Width / 2), 5);
                    screen_home.sc_home_instance.home_dynamic_island.Refresh();
                }
            }
        }
    }
}

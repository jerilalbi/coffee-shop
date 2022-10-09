using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbucks.application.events
{
    public class AlignCategoryTile
    {
        int categoryTile_leftMargin = 27,category_tile_width = 93;
       public void alignCategoryTile()
        {
            alignCategoryBox(screen_home.sc_home_instance.h_coffee_category_tile, categoryTile_leftMargin);
            alignCategoryBox(screen_home.sc_home_instance.c_coffee_category_tile, categoryTile_leftMargin * 2 + category_tile_width);
            alignCategoryBox(screen_home.sc_home_instance.c_drink_category_tile, categoryTile_leftMargin * 3 + category_tile_width * 2);
            alignCategoryBox(screen_home.sc_home_instance.frapuccino_category_tile, categoryTile_leftMargin * 4 + category_tile_width * 3);
            alignCategoryBox(screen_home.sc_home_instance.bakery_category_tile, categoryTile_leftMargin * 5 + category_tile_width * 4);
        }

        void alignCategoryBox(Guna2Panel panel,int leftMargin)
        {
            panel.Location = new Point(leftMargin, (screen_home.sc_home_instance.home_dynamicIsland.Height - panel.Height) / 2);
        }
    }
}

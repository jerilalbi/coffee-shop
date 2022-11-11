using Guna.UI2.WinForms;
using Starbucks.presentation.product;
using System;
using System.Drawing;

namespace Starbucks.application.events
{
    
    public class Dynamic_island
    {
        AlignCategoryTile alignCategory = new AlignCategoryTile();
        int topPadding = 6;

        public  void expandDynamicIsland(Guna2Panel panel,bool isProductPage)
        {
            panel.AutoRoundedCorners = false;
            while (panel.Width < 600 || panel.Height < 100)
            {
                if (panel.Width < 600)
                {
                    panel.Width += 8;
                    panel.Location = isProductPage ? new Point((Screen_Product.screen_product.ClientSize.Width / 2) - (panel.Width / 2), topPadding) : new Point((screen_home.sc_home_instance.ClientSize.Width / 2) - (panel.Width / 2), topPadding);
                    panel.Refresh();
                }
                if (panel.Height < 100)
                {
                    panel.Height++;
                    panel.Location = isProductPage ? new Point((Screen_Product.screen_product.ClientSize.Width / 2) - (panel.Width / 2), topPadding) : new Point((screen_home.sc_home_instance.ClientSize.Width / 2) - (panel.Width / 2), topPadding);
                    panel.Refresh();
                }
                panel.BorderRadius = 13;
            }
            foreach(Guna2Panel categoryTile in panel.Controls)
            {
                categoryTile.Visible = true;
            }
            alignCategory.alignCategoryTile(isProductPage);
        }

        public void srinkDynamicIsland(Guna2Panel panel, bool isProductPage )
        {
            panel.AutoRoundedCorners = true;
            foreach (Guna2Panel categoryTile in panel.Controls)
            {
                categoryTile.Visible = false;
            }
            while (panel.Width > 200 || panel.Height > 50)
            {
                if (panel.Width > 200)
                {
                    panel.Width -= 8;
                    panel.Invalidate();
                    panel.Refresh();
                    panel.Location = isProductPage ? new Point((Screen_Product.screen_product.ClientSize.Width / 2) - (panel.Width / 2), topPadding) : new Point((screen_home.sc_home_instance.ClientSize.Width / 2) - (panel.Width / 2), topPadding);
                }
                if (panel.Height > 50)
                {
                    panel.Height--;
                    panel.Invalidate();
                    panel.Refresh();
                    panel.Location = isProductPage ? new Point((Screen_Product.screen_product.ClientSize.Width / 2) - (panel.Width / 2), topPadding) : new Point((screen_home.sc_home_instance.ClientSize.Width / 2) - (panel.Width / 2), topPadding);
                }
                
            }
            panel.Location = isProductPage ? new Point(406, topPadding) : new Point((screen_home.sc_home_instance.ClientSize.Width / 2) - (panel.Width / 2), topPadding);
        }
    }
}

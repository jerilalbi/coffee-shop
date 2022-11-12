using Starbucks.application.datas;
using Starbucks.infrastructure.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbucks.presentation.basket
{
    public partial class Screen_MyBasket : Form
    {
        int row = 1;
        public static Screen_MyBasket sc_basket;
        public Screen_MyBasket()
        {
            InitializeComponent();
            sc_basket = this;
            my_basket_label.Location = new Point((ClientSize.Width / 2) - (my_basket_label.Width / 2), 10);
            loadItems();
        }

        void loadItems()
        {
            if (row == 0)
            {
                cart_items_panel.Controls.Add(
                    new 
                    Label { 
                        Text = "No Items in the cart",
                        AutoSize = true,
                        Font = new Font("",20),
                    }
                    );
                total_price.Visible = false;
                next_btn.Visible = false;
            }
            else {
                for (int i = 0; i < 5; i++)
                {
                    cart_items_panel.Controls.Add(
                        new Product_Tile
                        {
                            Title = "Pumbikn\nFrappuccino",
                            Image = Starbucks.Properties.Resources.prod_frap,
                            Price = 785,
                        });
                    data.totalPrice += 785;
                    total_price.Text = $"Total: {data.totalPrice.ToString()}";
                    total_price.Refresh();
                }
            }
           
        }
    }
}

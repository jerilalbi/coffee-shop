using Guna.UI2.WinForms;
using Starbucks.application.datas;
using Starbucks.application.events;
using Starbucks.domain;
using Starbucks.domain.user;
using Starbucks.infrastructure.components;
using Starbucks.presentation.basket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace Starbucks.presentation.product
{
    public partial class Screen_Product : Form
    {

        public static Screen_Product screen_product;
        GetProduct products = new GetProduct();
        bool product_dynamic_island_active = false;
        int categoryNo;
        string category;
        byte[] photo_aray;
        public Screen_Product(int categoryno)
        {
            InitializeComponent();
            screen_product = this;
            categoryNo = categoryno;
            category_circleFill(categoryNo);
            product_dynamicIsland.Size = new Size(200, 50);
            product_dynamicIsland.Location = new Point(406, 6);
            foreach (Guna2Panel categoryTile in product_dynamicIsland.Controls)
            {
                categoryTile.Visible = false;
            }
            mouseClicks();
            //addProduct();
        }

        void mouseClicks()
        {
            product_dynamicIsland.MouseClick += new MouseEventHandler(dynamic_islandClick); 
        }

        void dynamic_islandClick(Object o, EventArgs e) {
            prod_dyna_island_timer.Enabled = true;
        }

        private void prod_dyna_island_timer_Tick(object sender, EventArgs e)
        {
            Dynamic_island dynamic_Island = new Dynamic_island();
            if (product_dynamic_island_active)
            {
                dynamic_Island.srinkDynamicIsland(product_dynamicIsland, true);
                product_dynamic_island_active = false;
            }
            else
            {
                dynamic_Island.expandDynamicIsland(product_dynamicIsland, true);
                product_dynamic_island_active = true;
            }
            prod_dyna_island_timer.Enabled = false;
        }

        void category_circleFill(int cat_no)
        {
            switch (cat_no)
            {
                case 1: category_img.Image = Starbucks.Properties.Resources.hot_coffee;
                    category = "hot_coffee";
                    category_label.Text = "Hot Coffee";
                    break;
                case 2:
                    category_img.Image = Starbucks.Properties.Resources.cold_cofee_logo;
                    category = "cold_coffee";
                    category_label.Text = "Cold Coffee";
                    break;
                case 3:
                    category_img.Image = Starbucks.Properties.Resources.cold_drink_logo;
                    category = "cold_drink";
                    category_label.Text = "Cold Drink";
                    break;
                case 4:
                    category_img.Image = Starbucks.Properties.Resources.frappuccino;
                    category = "frappuccino";
                    category_label.Text = "Frappuccino";
                    break;
                case 5:
                    category_img.Image = Starbucks.Properties.Resources.snacks_logo;
                    category = "bakery";
                    category_label.Text = "Bakery";
                    break;
            }
        }

        void category_change(int category_no)
        {
            Dynamic_island dynamic_Island = new Dynamic_island();
            category_circleFill(category_no);
            dynamic_Island.srinkDynamicIsland(product_dynamicIsland, true);
            product_dynamic_island_active = false;
            addProduct();
            this.Refresh();
        }

        void addProduct()
        {
            SqlDataReader data = products.getData(category);
            product_display_panel.Controls.Clear();
            while (data.Read())
            {
                photo_aray = (byte[])data["image"];
                product_display_panel.Controls.Add(
                    new ProductCard
                    {
                        Title = data["name"].ToString(),
                        Price = int.Parse(data["price"].ToString()),
                        Image = photo_aray,
                        Category = category,
                    }) ;
            }
            data.Close();
            Database.connection.Close();
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            category_change(1);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            category_change(1);
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            category_change(2);
        }

        private void c_coffee_label_Click(object sender, EventArgs e)
        {
            category_change(2);
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            category_change(3);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            category_change(3);
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            category_change(4);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            category_change(4);
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            category_change(5);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            category_change(5);
        }

        private void cart_btn_Click(object sender, EventArgs e)
        {
            Screen_MyBasket myBasket = new Screen_MyBasket();
            myBasket.Show();
            Hide();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            Screen_MyBasket myBasket = new Screen_MyBasket();
            myBasket.Show();
            Hide();
        }

        private void Screen_Product_Load(object sender, EventArgs e)
        {
            addProduct();
            cart_product_no.Text = $"{data.cartProducts}";
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbucks.infrastructure.components
{
    public partial class ProductCard : UserControl
    {
        int price;
        public ProductCard()
        {
            InitializeComponent();
            size_combo_bx.SelectedIndex = 0;
        }

        #region properties
        private Image _image;
        private String _title;
        private int _price;

        public Image Image
        {
            get { return _image; }
            set { _image = value; product_img.Image = value; }
        }

        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public String Title
        {
            get { return _title; }
            set { _title = value; product_name.Text = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; product_price.Text = $"₹ {value}"; }
        }


        #endregion

        private async void add_to_basket_btn_Click(object sender, EventArgs e)
        {
            add_to_basket_btn.Text = "Added";
            add_to_basket_btn.FillColor = Color.White;
            add_to_basket_btn.ForeColor = Color.Black;
            await Task.Delay(2000);
            add_to_basket_btn.Text = "Add to Basket";
            add_to_basket_btn.FillColor = Color.FromArgb(0, 113, 67);
            add_to_basket_btn.ForeColor = Color.White;
        }

        private void size_combo_bx_SelectedIndexChanged(object sender, EventArgs e)
        {
            price = _price;
            switch (size_combo_bx.SelectedIndex)
            {
                case 0: product_price.Text = product_price.Text = $"₹ {price}";
                    break;
                case 1:
                    price += 50;
                    product_price.Text = product_price.Text = $"₹ {price}";
                    break;
                case 2:
                    price += 100;
                    product_price.Text = product_price.Text = $"₹ {price}";
                    break;
            }
        }

        private void flavour_combo_bx_SelectedIndexChanged(object sender, EventArgs e)
        {
            price += 100;
            product_price.Text = product_price.Text = $"₹ {price}";
        }
    }
}

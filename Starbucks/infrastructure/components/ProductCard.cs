using Starbucks.application.datas;
using Starbucks.domain.user;
using Starbucks.presentation.product;
using System;
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
        byte[] bitImg;
        string size;
        string flavour;

        ImageConverter imageConverter = new ImageConverter();
        public ProductCard()
        {
            InitializeComponent();
            size_combo_bx.SelectedIndex = 0;
        }

        #region properties
        private byte[] _image;
        private String _title;
        private String _category;
        private int _price;
        int count = 1;

        public byte[] Image
        {
            get { return _image; }
            set { _image = value;
                bitImg = value;
                Image img = (Image)imageConverter.ConvertFrom(value);
                product_img.Image = img;
            }
        }

        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public String Title
        {
            get { return _title; }
            set { _title = value;
                product_name.Text = value; }
        }

        public String Category
        {
            get { return _title; }
            set
            {
                _category = value;
            }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value;
                price = value;
                product_price.Text = $"₹ {value}"; }
        }


        #endregion

        private void add_to_basket_btn_Click(object sender, EventArgs e)
        {
           AddCart cart = new AddCart();
            bool res = cart.addToCart(_title,price,size,flavour,count,bitImg,_category);
            if (res)
            {
                successAddCart();
                count++;
            }
        }

       async void successAddCart()
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
                case 0:
                    size = "small";
                    product_price.Text = $"₹ {price}";
                    break;
                case 1:
                    size = "medium";
                    price += 50;
                    product_price.Text = $"₹ {price}";
                    break;
                case 2:
                    size = "large";
                    price += 100;
                    product_price.Text = $"₹ {price}";
                    break;
            }
        }

        private void flavour_combo_bx_SelectedIndexChanged(object sender, EventArgs e)
        {
            int flavourPrice = price;

            switch (flavour_combo_bx.SelectedIndex)
            {
                case 0:
                    flavour = "caramel";
                    flavourPrice += 100;
                    product_price.Text = $"₹ {flavourPrice}";
                    break;
                case 1:
                    flavour = "apple";
                    flavourPrice += 100;
                    product_price.Text = $"₹ {flavourPrice}";
                    break;
                case 2:
                    flavour = "vanila";
                    flavourPrice += 100;
                    product_price.Text = $"₹ {flavourPrice}";
                    break;
            }
        }
    }
}

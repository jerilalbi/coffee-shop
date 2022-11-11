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
        public ProductCard()
        {
            InitializeComponent();
        }

        #region properties
        private Image _image;
        private String _title;
        private String _sizelist;
        private String _flavourlist;
        private String _price;

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

        public String SizeList
        {
            get { return _sizelist; }
            set {_sizelist += value; size_combo_bx.Items.Add(value); }
        }

        public String FlavourList
        {
            get { return _flavourlist; }
            set { _flavourlist += value; flavour_combo_bx.Items.Add(value); }
        }
        public String Price
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
    }
}

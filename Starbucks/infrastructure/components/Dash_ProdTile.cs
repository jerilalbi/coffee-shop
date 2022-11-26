using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.DrawingCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbucks.infrastructure.components
{
    public partial class Dash_ProdTile : UserControl
    {
        System.Drawing.ImageConverter imageConverter = new System.Drawing.ImageConverter();
        bool isEdit = true;
        bool imgEdit = false;
        public Dash_ProdTile()
        {
            InitializeComponent();
        }
        #region properties
        private byte[] _image;
        private String _title;
        private int _price;
        private string _name;

        public byte[] Image
        {
            get { return _image; }
            set
            {
                _image = value;
                System.Drawing.Image img = (System.Drawing.Image)imageConverter.ConvertFrom(value);
                prodImg.Image = img;
            }
        }

        public String Title
        {
            get { return _title; }
            set { _title = value;
                prodTypeLabel.Text = _title;
                prodNameTxt.Text = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value;
                prodAmountLabel.Text = $"{value}";
                prodAmtTxt.Text = $"{value}"; }
        }

        #endregion

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                prodTypeLabel.Visible = false;
                prodAmountLabel.Visible = false;
                prodNameTxt.Visible = true;
                prodAmtTxt.Visible = true;
                editBtn.Image = Starbucks.Properties.Resources.tick_logo;
                imgEdit = true;
            }
            else
            {
                prodTypeLabel.Visible = true;
                prodAmountLabel.Visible = true;
                prodNameTxt.Visible = false;
                prodAmtTxt.Visible = false;
                editBtn.Image = Starbucks.Properties.Resources.edit_logo;
                imgEdit = false;
            }
            isEdit = !isEdit;
        }

        private void prodImg_Click(object sender, EventArgs e)
        {
            if (imgEdit)
            {
                //jfdklds
            }
        }
    }
}

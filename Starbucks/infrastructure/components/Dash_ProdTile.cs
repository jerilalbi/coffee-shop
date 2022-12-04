using Starbucks.domain.admin;
using Starbucks.presentation.admin.dash_add_prod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
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
        MemoryStream ms;
        public Dash_ProdTile()
        {
            InitializeComponent();
        }
        #region properties
        private byte[] _image;
        private String _title;
        private int _price;
        private string _tileName;
        private string category;

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

        public String TileName
        {
            get { return _tileName; }
            set
            {
                _tileName = value;
            }
        }

        public String ProdCategory
        {
            get { return category; }
            set
            {
                category = value;
            }
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
                byte[] image = convertImage();
                AddProduct updtProd = new AddProduct();
                Console.WriteLine($"update {category} set name = {prodNameTxt.Text},price = {prodAmtTxt.Text}, image = @image where  name = {_title} and amount = {_price}");
                bool result = updtProd.updateProduct($"update {category} set name = '{prodNameTxt.Text}',price = {prodAmtTxt.Text}, image = @image where  name = '{_title}' and price = {_price}",image);
                if (result)
                {
                    prodTypeLabel.Visible = true;
                    prodAmountLabel.Visible = true;
                    prodNameTxt.Visible = false;
                    prodAmtTxt.Visible = false;
                    prodTypeLabel.Text = prodNameTxt.Text;
                    prodAmountLabel.Text = prodAmtTxt.Text;
                    editBtn.Image = Starbucks.Properties.Resources.edit_logo;
                    imgEdit = false;
                }
            }
            isEdit = !isEdit;
        }

        private void prodImg_Click(object sender, EventArgs e)
        {
            if (imgEdit)
            {
                openFile();
            }
        }

        string openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "png|*.png";
            DialogResult res = openFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                prodImg.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                prodImg.SizeMode = PictureBoxSizeMode.Zoom;
                return openFileDialog.FileName;
            }
            return "";
        }

        byte[] convertImage()
        {
            if (prodImg.Image != null)
            {
                ms = new MemoryStream();
                prodImg.Image.Save(ms, prodImg.Image.RawFormat);
                Console.WriteLine(ms.ToString());
                return ms.GetBuffer();
            }
            return null;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            AdminDbOP dbop = new AdminDbOP();
            bool result = dbop.adminQuery($"delete from {category} where name='{_title}' and price='{_price}'");
            if (result)
            {
                Dash_Prod.dash_prod_insts.prodDisplayPanel.Controls.RemoveByKey(_tileName);
            }
        }
    }
}

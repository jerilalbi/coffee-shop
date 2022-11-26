using Starbucks.domain.admin;
using Starbucks.presentation.admin.dash_add_exp;
using Starbucks.presentation.admin.dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbucks.presentation.admin.dash_add_prod
{
    public partial class Dash_addProd : UserControl
    {
        string category = "hot_coffee";
        MemoryStream ms;
        public Dash_addProd()
        {
            InitializeComponent();
            category_comboBx.SelectedIndex = 0;
        }

        private async void add_btn_Click(object sender, EventArgs e)
        {
            AddProduct adProd = new AddProduct();
            byte[] image = convertImage();
            bool res = adProd.insertProduct(category, prod_name.Text, int.Parse(prod_price.Text), image);
            if (res)
            {
                successInsert();
            }
        }

       async void successInsert()
        {
            add_btn.Text = "ADDED";
            add_btn.FillColor = Color.Blue;
            await Task.Delay(2000);
            add_btn.Text = "ADD";
            add_btn.FillColor = Color.FromArgb(0, 102, 0);
        }

        private void category_comboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (category_comboBx.SelectedIndex)
            {
                case 0: category = "hot_coffee";
                break;
                case 1:
                    category = "cold_coffee";
                    break;
                case 2:
                    category = "cold_drink";
                    break;
                case 3:
                    category = "frappuccino";
                    break;
                case 4:
                    category = "bakery";
                    break;
            }
        }

        private void add_btn_click_Click(object sender, EventArgs e)
        {
            openFile();
        }

        string openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "png|*.png";
            DialogResult res = openFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                prod_img.Image = Image.FromFile(openFileDialog.FileName);
                prod_img.SizeMode = PictureBoxSizeMode.Zoom;
                return openFileDialog.FileName;
            }
            return "";
        }

        byte[] convertImage()
        {
            if(prod_img.Image != null)
            {
                ms = new MemoryStream();
                prod_img.Image.Save(ms, prod_img.Image.RawFormat);
                Console.WriteLine(ms.ToString());
                return ms.GetBuffer();
            }
            return null;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Dash_Prod dash_Prod = new Dash_Prod();
            Screen_Dashboard.sc_dash.base_dashboard.Controls.Clear();
            dash_Prod.BringToFront();
            Screen_Dashboard.sc_dash.base_dashboard.Controls.Add(dash_Prod);
        }
    }
}

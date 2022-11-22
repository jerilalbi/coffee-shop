
using IronBarCode;
using Starbucks.application.datas;
using Starbucks.domain;
using Starbucks.domain.user;
using Starbucks.infrastructure.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbucks.presentation.payment
{
    public partial class Screen_Payment : Form
    {
        string text;
        public Screen_Payment()
        {
            InitializeComponent();
            getData();
        }

        void getData()
        {
            AddCart cart = new AddCart();
            SqlDataReader cartdata = cart.showCart();
            while (cartdata.Read())
            {
                text += $"Product: {cartdata["name"]},Size: {cartdata["size"]}, Flavour: {cartdata["flavour"]} ";
                text += Environment.NewLine;
            }
            cartdata.Close();
            Database.connection.Close();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
        }
    }
}

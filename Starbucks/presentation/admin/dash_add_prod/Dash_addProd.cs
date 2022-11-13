using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbucks.presentation.admin.dash_add_prod
{
    public partial class Dash_addProd : UserControl
    {
        public Dash_addProd()
        {
            InitializeComponent();
            category_comboBx.SelectedIndex = 0;
        }

        private async void add_btn_Click(object sender, EventArgs e)
        {
            add_btn.Text = "ADDED";
            add_btn.FillColor = Color.Blue;
            await Task.Delay(2000);
            add_btn.Text = "ADD";
            add_btn.FillColor = Color.FromArgb(0, 102, 0);
        }
    }
}

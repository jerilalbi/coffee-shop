using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbucks.presentation.admin.dash_add_exp
{
    public partial class Dash_addExp : UserControl
    {
        public Dash_addExp()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            addFunction();
        }

         async void addFunction()
        {
            add_btn.Text = "ADDED";
            add_btn.FillColor = Color.Blue;
            await Task.Delay(2000);
            add_btn.Text = "ADD";
            add_btn.FillColor = Color.FromArgb(0, 102, 0);
        }
    }
}

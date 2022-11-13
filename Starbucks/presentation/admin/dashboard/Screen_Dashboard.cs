using Guna.UI2.WinForms;
using Starbucks.presentation.admin.dash_add_exp;
using Starbucks.presentation.admin.dash_add_prod;
using Starbucks.presentation.admin.dash_overview;
using Starbucks.presentation.login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbucks.presentation.admin.dashboard
{
    public partial class Screen_Dashboard : Form
    {
        Dash_Overview overview = new Dash_Overview();

        public Screen_Dashboard()
        {
            InitializeComponent();
            addScreens(overview);
            
        }

        void addScreens(UserControl screen)
        {
            base_dashboard.Controls.Clear();
            screen.BringToFront();
            base_dashboard.Controls.Add(screen);
        }

        void changeBtncolor(Guna2Panel panel,Label text)
        {
            panel.FillColor = Color.Transparent;
            text.ForeColor = Color.White;
        }

        void dashboardBtnClick()
        {
            changeBtncolor(expenseBtn, add_exp_label);
            changeBtncolor(add_prod, add_prod_label);
            changeBtncolor(products, products_label);
            dashboardBtn.FillColor = Color.White;
            dashboard_btn_labe.ForeColor = Color.Black;
            addScreens(overview);
        }

        void expenseBtnClick()
        {
            Dash_addExp expScreen = new Dash_addExp();
            changeBtncolor(dashboardBtn, dashboard_btn_labe);
            changeBtncolor(add_prod, add_prod_label);
            changeBtncolor(products, products_label);
            expenseBtn.FillColor = Color.White;
            add_exp_label.ForeColor = Color.Black;
            addScreens(expScreen);
        }

        void addProductBtn()
        {
            Dash_addProd add_Product =  new Dash_addProd();
            changeBtncolor(dashboardBtn, dashboard_btn_labe);
            changeBtncolor(expenseBtn, add_exp_label);
            changeBtncolor(products, products_label);
            add_prod.FillColor = Color.White;
            add_prod_label.ForeColor = Color.Black;
            addScreens(add_Product);
        }

        void productsBtn()
        {
            changeBtncolor(dashboardBtn, dashboard_btn_labe);
            changeBtncolor(expenseBtn, add_exp_label);
            changeBtncolor(add_prod, add_prod_label);
            products.FillColor = Color.White;
            products_label.ForeColor = Color.Black;
        }

        private void guna2Panel3_Click(object sender, EventArgs e)
        {
            expenseBtnClick();
        }

        private void add_exp_label_Click(object sender, EventArgs e)
        {
            expenseBtnClick();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            dashboardBtnClick();
        }

        private void dashboard_btn_labe_Click(object sender, EventArgs e)
        {
            dashboardBtnClick();
        }

        private void add_prod_Click(object sender, EventArgs e)
        {
            addProductBtn();
        }

        private void add_prod_label_Click(object sender, EventArgs e)
        {
            addProductBtn();
        }

        private void products_Click(object sender, EventArgs e)
        {
            productsBtn();
        }

        private void products_label_Click(object sender, EventArgs e)
        {
            productsBtn();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Screen_Login login = new Screen_Login();
            login.Show();
            Close();
        }
    }
}

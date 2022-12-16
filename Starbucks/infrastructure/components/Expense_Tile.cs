using Starbucks.domain.admin;
using Starbucks.presentation.admin.dash_add_exp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbucks.infrastructure.components
{
    public partial class Expense_Tile : UserControl
    {
        bool isEdit = true;
        public Expense_Tile()
        {
            InitializeComponent();
        }

        #region properties
        private string _exptype;
        private int _expAmount;
        private int _expMonth;
        private int _expYear;
        private string _tileName;

        public string ExpType
        {
            get { return _exptype; }
            set { _exptype = value; expTypeLabel.Text = value; expTypeTxt.Text = $"{value}"; }
        }

        public int ExpAmount
        {
            get { return _expAmount; }
            set
            {
                _expAmount = value;
                expAmountLabel.Text = $"{value}";
                expAmtTxt.Text = $"{value}";
            }
        }

        public int ExpMonth
        {
            get { return _expMonth; }
            set
            {
                _expMonth = value;
                monthLabel.Text = $"( {_expMonth} )";
            }
        }

        public int ExpYear
        {
            get { return _expYear; }
            set
            {
                _expYear = value;
            }
        }

        public string TileName
        {
            get { return _tileName; }
            set { _tileName = value; }
        }

        #endregion

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                expTypeLabel.Visible = false;
                expAmountLabel.Visible = false;
                monthLabel.Visible = false;
                expTypeTxt.Visible = true;
                expAmtTxt.Visible = true;
                editBtn.Image = Starbucks.Properties.Resources.tick_logo;
            }
            else
            {
                AdminDbOP dbOP = new AdminDbOP();
                bool result = dbOP.adminQuery($"update expense set type = '{expTypeTxt.Text}',amount = {expAmtTxt.Text} where type = '{_exptype}' and amount = {_expAmount} and month = {_expMonth} and year = {_expYear}");
                if (result)
                {
                    expTypeLabel.Visible = true;
                    expAmountLabel.Visible = true;
                    monthLabel.Visible = true;
                    expTypeTxt.Visible = false;
                    expAmtTxt.Visible = false;
                    expTypeLabel.Text = expTypeTxt.Text;
                    expAmountLabel.Text = expAmtTxt.Text;
                    editBtn.Image = Starbucks.Properties.Resources.edit_logo;
                    Dash_Exp.Dashexpense.fetchAlldata();
                }
            }
            isEdit = !isEdit;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            AdminDbOP dbOP = new AdminDbOP();
            bool result = dbOP.adminQuery($"delete from expense where type = '{_exptype}' and amount = {_expAmount} and month = {_expMonth} and year = {_expYear} ");
            if (result)
            {
                Dash_Exp.Dashexpense.expDisplayPanel.Controls.RemoveByKey(_tileName);
                Dash_Exp.Dashexpense.fetchAlldata();
            }
        }
    }
}

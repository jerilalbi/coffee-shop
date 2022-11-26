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

        public string ExpType
        {
            get { return _exptype; }
            set { _exptype = value; expTypeLabel.Text = value; }
        }

        public int ExpAmount
        {
            get { return _expAmount; }
            set
            {
                _expAmount = value;
                expAmountLabel.Text = $"{value}";
            }
        }

        #endregion

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                expTypeLabel.Visible = false;
                expAmountLabel.Visible = false;
                expTypeTxt.Visible = true;
                expAmtTxt.Visible = true;
                editBtn.Image = Starbucks.Properties.Resources.tick_logo;
            }
            else
            {
                expTypeLabel.Visible = true;
                expAmountLabel.Visible = true;
                expTypeTxt.Visible = false;
                expAmtTxt.Visible = false;
                editBtn.Image = Starbucks.Properties.Resources.edit_logo;
            }
            isEdit = !isEdit;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbucks.infrastructure.components
{
    public partial class Final_Products : UserControl
    {
        public Final_Products()
        {
            InitializeComponent();
        }

        #region properties
        private string _prodName;
        private string _prodSize;
        private string _prodFlavour;
        private string _prodcount;

        public string Name
        {
            get { return _prodName; }
            set
            {
                prod_name.Text = value;
            }
        }

        public string Prod_Size
        {
            get { return _prodSize; }
            set
            {
                size_label.Text = value;
            }
        }

        public string Flavour
        {
            get { return _prodFlavour; }
            set
            {
                flavour_label.Text = value;
            }
        }

        public string Count
        {
            get { return _prodcount; }
            set
            {
                countLabel.Text = $"( {value} )";
            }
        }

        #endregion
    }
}

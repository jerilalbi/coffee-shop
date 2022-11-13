using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbucks.presentation.admin.dash_overview
{
    public partial class Dash_Overview : UserControl
    {
        public Dash_Overview()
        {
            InitializeComponent();
            period_combobx.SelectedIndex = 0;
        }

    }
}

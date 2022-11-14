using Starbucks.application.datas;
using Starbucks.presentation.summary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbucks.presentation.email
{
    public partial class Screen_email : Form
    {
        public Screen_email()
        {
            InitializeComponent();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            data.emailId = email_textBox.Text;
            Screen_orderSum summary = new Screen_orderSum();
            summary.Show();
            Close();
        }
    }
}

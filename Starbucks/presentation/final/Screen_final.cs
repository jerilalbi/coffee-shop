using Starbucks.application.datas;
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

namespace Starbucks.presentation.final
{
    public partial class Screen_final : Form
    {
        public Screen_final()
        {
            InitializeComponent();
            bg_img.Location = new Point((ClientSize.Width / 2) - (bg_img.Width / 2), -14);
            starbucks_txt.Location = new Point((ClientSize.Width / 2) - (starbucks_txt.Width / 2), 200);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            data datas = new data();
            data.totalPrice = 0;
            datas.clearData();
            screen_home home = new screen_home();
            home.Show();
            Close();
        }

    }
}

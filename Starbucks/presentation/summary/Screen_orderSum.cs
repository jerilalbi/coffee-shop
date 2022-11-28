using Starbucks.application.datas;
using Starbucks.application.events;
using Starbucks.presentation.final;
using Starbucks.presentation.payment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbucks.presentation.summary
{
    public partial class Screen_orderSum : Form
    {
        bool isTakeAway = false;
        bool isDinein = true;
       static int packing_crg = 0;
        static int  total = data.totalPrice;
       static double gst = total*.10;
        int final_amt = total + packing_crg + Convert.ToInt32(gst);
        public Screen_orderSum()
        {
            InitializeComponent();
            total_amount.Text = $"Total Amount: {total}";
            gst_label.Text = $"GST ( 10 % ) : {gst}";
            final_amount.Text = $"Final Amount: {final_amt}";
        }

        void deliveryType()
        {
            if (isTakeAway)
            {
                take_away_panel.FillColor = Color.FromArgb(0, 102, 0);
                dine_in_panel.FillColor = Color.Gray;
                final_amt += 30; 
                packing_charge.Visible = true;
                final_amount.Text = $"Final Amount: {final_amt}";
            }
            else
            {
                dine_in_panel.FillColor = Color.FromArgb(0, 102, 0);
                take_away_panel.FillColor = Color.Gray;
                final_amt -= 30;
                packing_charge.Visible = false;
                final_amount.Text = $"Final Amount: {final_amt}";
            }
        }

        private void dine_in_panel_Click(object sender, EventArgs e)
        {
            if (!isDinein)
            {
                isTakeAway = false;
                isDinein = true;
                deliveryType();
            }
        }

        private void take_away_panel_Click(object sender, EventArgs e)
        {
            if (!isTakeAway)
            {
                isTakeAway = true;
                isDinein = false;
                deliveryType();
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (!isDinein)
            {
                isDinein = true;
                isTakeAway = false;
                deliveryType();
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            if (!isTakeAway)
            {
                isTakeAway = true;
                isDinein = false;
                deliveryType();
            }
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            Screen_Payment payment = new Screen_Payment();
            payment.Show();
            Hide();
        }
    }
}

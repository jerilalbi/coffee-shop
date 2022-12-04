namespace Starbucks.presentation.basket
{
    partial class Screen_MyBasket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen_MyBasket));
            this.my_basket_label = new System.Windows.Forms.Label();
            this.total_price = new System.Windows.Forms.Label();
            this.next_btn = new Guna.UI2.WinForms.Guna2TileButton();
            this.cart_btn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.back_button = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cart_items_panel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.cart_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).BeginInit();
            this.SuspendLayout();
            // 
            // my_basket_label
            // 
            this.my_basket_label.AutoSize = true;
            this.my_basket_label.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_basket_label.Location = new System.Drawing.Point(458, 9);
            this.my_basket_label.Name = "my_basket_label";
            this.my_basket_label.Size = new System.Drawing.Size(198, 45);
            this.my_basket_label.TabIndex = 20;
            this.my_basket_label.Text = "My Basket";
            // 
            // total_price
            // 
            this.total_price.AutoSize = true;
            this.total_price.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.total_price.Location = new System.Drawing.Point(933, 610);
            this.total_price.Name = "total_price";
            this.total_price.Size = new System.Drawing.Size(128, 38);
            this.total_price.TabIndex = 24;
            this.total_price.Text = "Total: 0";
            // 
            // next_btn
            // 
            this.next_btn.BorderRadius = 10;
            this.next_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.next_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.next_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.next_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.next_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.next_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_btn.ForeColor = System.Drawing.Color.White;
            this.next_btn.Location = new System.Drawing.Point(1141, 597);
            this.next_btn.Name = "next_btn";
            this.next_btn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.next_btn.Size = new System.Drawing.Size(179, 63);
            this.next_btn.TabIndex = 25;
            this.next_btn.Text = "NEXT";
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // cart_btn
            // 
            this.cart_btn.BackColor = System.Drawing.Color.Transparent;
            this.cart_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cart_btn.Image = global::Starbucks.Properties.Resources.cart_logo;
            this.cart_btn.ImageRotate = 0F;
            this.cart_btn.Location = new System.Drawing.Point(800, 13);
            this.cart_btn.Name = "cart_btn";
            this.cart_btn.Size = new System.Drawing.Size(40, 40);
            this.cart_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cart_btn.TabIndex = 22;
            this.cart_btn.TabStop = false;
            this.cart_btn.UseTransparentBackground = true;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Transparent;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.Image = ((System.Drawing.Image)(resources.GetObject("back_button.Image")));
            this.back_button.ImageRotate = 0F;
            this.back_button.Location = new System.Drawing.Point(63, 20);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(38, 22);
            this.back_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_button.TabIndex = 19;
            this.back_button.TabStop = false;
            this.back_button.UseTransparentBackground = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // cart_items_panel
            // 
            this.cart_items_panel.AutoScroll = true;
            this.cart_items_panel.Location = new System.Drawing.Point(63, 88);
            this.cart_items_panel.Name = "cart_items_panel";
            this.cart_items_panel.Size = new System.Drawing.Size(1288, 492);
            this.cart_items_panel.TabIndex = 23;
            // 
            // Screen_MyBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 687);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.total_price);
            this.Controls.Add(this.cart_items_panel);
            this.Controls.Add(this.cart_btn);
            this.Controls.Add(this.my_basket_label);
            this.Controls.Add(this.back_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Screen_MyBasket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyBasket";
            this.Load += new System.EventHandler(this.Screen_MyBasket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cart_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox back_button;
        private System.Windows.Forms.Label my_basket_label;
        private Guna.UI2.WinForms.Guna2PictureBox cart_btn;
        private Guna.UI2.WinForms.Guna2TileButton next_btn;
        public System.Windows.Forms.Label total_price;
        public System.Windows.Forms.FlowLayoutPanel cart_items_panel;
    }
}
namespace Starbucks.infrastructure.components
{
    partial class ProductCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.add_to_basket_btn = new Guna.UI2.WinForms.Guna2TileButton();
            this.product_price = new System.Windows.Forms.Label();
            this.flavour_combo_bx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.size_combo_bx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.size_label = new System.Windows.Forms.Label();
            this.product_name = new System.Windows.Forms.Label();
            this.product_img = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_img)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 25;
            this.guna2Panel1.Controls.Add(this.add_to_basket_btn);
            this.guna2Panel1.Controls.Add(this.product_price);
            this.guna2Panel1.Controls.Add(this.flavour_combo_bx);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.size_combo_bx);
            this.guna2Panel1.Controls.Add(this.size_label);
            this.guna2Panel1.Controls.Add(this.product_name);
            this.guna2Panel1.Controls.Add(this.product_img);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(274, 449);
            this.guna2Panel1.TabIndex = 0;
            // 
            // add_to_basket_btn
            // 
            this.add_to_basket_btn.BackColor = System.Drawing.Color.Transparent;
            this.add_to_basket_btn.BorderColor = System.Drawing.Color.White;
            this.add_to_basket_btn.BorderRadius = 10;
            this.add_to_basket_btn.BorderThickness = 2;
            this.add_to_basket_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_to_basket_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_to_basket_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_to_basket_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_to_basket_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_to_basket_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.add_to_basket_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_to_basket_btn.ForeColor = System.Drawing.Color.White;
            this.add_to_basket_btn.Location = new System.Drawing.Point(27, 381);
            this.add_to_basket_btn.Name = "add_to_basket_btn";
            this.add_to_basket_btn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.add_to_basket_btn.Size = new System.Drawing.Size(216, 50);
            this.add_to_basket_btn.TabIndex = 11;
            this.add_to_basket_btn.Text = "Add to Basket";
            this.add_to_basket_btn.Click += new System.EventHandler(this.add_to_basket_btn_Click);
            // 
            // product_price
            // 
            this.product_price.AutoSize = true;
            this.product_price.BackColor = System.Drawing.Color.Transparent;
            this.product_price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_price.ForeColor = System.Drawing.SystemColors.Control;
            this.product_price.Location = new System.Drawing.Point(22, 329);
            this.product_price.Name = "product_price";
            this.product_price.Size = new System.Drawing.Size(71, 27);
            this.product_price.TabIndex = 10;
            this.product_price.Text = "₹ 350";
            // 
            // flavour_combo_bx
            // 
            this.flavour_combo_bx.AutoRoundedCorners = true;
            this.flavour_combo_bx.BackColor = System.Drawing.Color.Transparent;
            this.flavour_combo_bx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.flavour_combo_bx.BorderRadius = 17;
            this.flavour_combo_bx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flavour_combo_bx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.flavour_combo_bx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flavour_combo_bx.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.flavour_combo_bx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.flavour_combo_bx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.flavour_combo_bx.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flavour_combo_bx.ForeColor = System.Drawing.Color.White;
            this.flavour_combo_bx.FormattingEnabled = true;
            this.flavour_combo_bx.ItemHeight = 30;
            this.flavour_combo_bx.Items.AddRange(new object[] {
            "caramel",
            "apple"});
            this.flavour_combo_bx.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.flavour_combo_bx.Location = new System.Drawing.Point(117, 267);
            this.flavour_combo_bx.Name = "flavour_combo_bx";
            this.flavour_combo_bx.Size = new System.Drawing.Size(126, 36);
            this.flavour_combo_bx.TabIndex = 9;
            this.flavour_combo_bx.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(22, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Flavour";
            // 
            // size_combo_bx
            // 
            this.size_combo_bx.AutoRoundedCorners = true;
            this.size_combo_bx.BackColor = System.Drawing.Color.Transparent;
            this.size_combo_bx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.size_combo_bx.BorderRadius = 17;
            this.size_combo_bx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.size_combo_bx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.size_combo_bx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.size_combo_bx.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.size_combo_bx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.size_combo_bx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.size_combo_bx.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.size_combo_bx.ForeColor = System.Drawing.Color.White;
            this.size_combo_bx.FormattingEnabled = true;
            this.size_combo_bx.ItemHeight = 30;
            this.size_combo_bx.Items.AddRange(new object[] {
            "granny"});
            this.size_combo_bx.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.size_combo_bx.Location = new System.Drawing.Point(87, 222);
            this.size_combo_bx.Name = "size_combo_bx";
            this.size_combo_bx.Size = new System.Drawing.Size(156, 36);
            this.size_combo_bx.TabIndex = 6;
            this.size_combo_bx.Tag = "";
            // 
            // size_label
            // 
            this.size_label.AutoSize = true;
            this.size_label.BackColor = System.Drawing.Color.Transparent;
            this.size_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size_label.ForeColor = System.Drawing.SystemColors.Control;
            this.size_label.Location = new System.Drawing.Point(22, 231);
            this.size_label.Name = "size_label";
            this.size_label.Size = new System.Drawing.Size(59, 27);
            this.size_label.TabIndex = 5;
            this.size_label.Text = "Size";
            // 
            // product_name
            // 
            this.product_name.AutoSize = true;
            this.product_name.BackColor = System.Drawing.Color.Transparent;
            this.product_name.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_name.ForeColor = System.Drawing.SystemColors.Control;
            this.product_name.Location = new System.Drawing.Point(20, 135);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(192, 114);
            this.product_name.TabIndex = 3;
            this.product_name.Text = "Coffee\r\nFrappuccino\r\n\r\n";
            // 
            // product_img
            // 
            this.product_img.Image = global::Starbucks.Properties.Resources.prod_frap;
            this.product_img.ImageRotate = 0F;
            this.product_img.Location = new System.Drawing.Point(69, 14);
            this.product_img.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.product_img.Name = "product_img";
            this.product_img.Size = new System.Drawing.Size(150, 122);
            this.product_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.product_img.TabIndex = 0;
            this.product_img.TabStop = false;
            this.product_img.UseTransparentBackground = true;
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(274, 449);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox product_img;
        private System.Windows.Forms.Label product_name;
        private System.Windows.Forms.Label size_label;
        private Guna.UI2.WinForms.Guna2ComboBox size_combo_bx;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox flavour_combo_bx;
        private System.Windows.Forms.Label product_price;
        private Guna.UI2.WinForms.Guna2TileButton add_to_basket_btn;
    }
}

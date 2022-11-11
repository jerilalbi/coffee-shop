namespace Starbucks.infrastructure.components
{
    partial class Product_Tile
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
            this.cart_prod_label = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.price_label = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.prod_amount = new System.Windows.Forms.Label();
            this.cart_prod_img = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cart_prod_img)).BeginInit();
            this.SuspendLayout();
            // 
            // cart_prod_label
            // 
            this.cart_prod_label.AutoSize = true;
            this.cart_prod_label.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cart_prod_label.ForeColor = System.Drawing.SystemColors.Control;
            this.cart_prod_label.Location = new System.Drawing.Point(109, 28);
            this.cart_prod_label.Name = "cart_prod_label";
            this.cart_prod_label.Size = new System.Drawing.Size(318, 38);
            this.cart_prod_label.TabIndex = 1;
            this.cart_prod_label.Text = "Caramel Frappuccino";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 25;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.price_label);
            this.guna2Panel1.Controls.Add(this.guna2Panel4);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.cart_prod_label);
            this.guna2Panel1.Controls.Add(this.cart_prod_img);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1257, 135);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2PictureBox1.Image = global::Starbucks.Properties.Resources.delete_64;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1113, 28);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(45, 72);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.ForeColor = System.Drawing.SystemColors.Control;
            this.price_label.Location = new System.Drawing.Point(920, 90);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(138, 32);
            this.price_label.TabIndex = 5;
            this.price_label.Text = "Price: 250";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.SystemColors.Control;
            this.guna2Panel4.BorderRadius = 10;
            this.guna2Panel4.BorderThickness = 2;
            this.guna2Panel4.Controls.Add(this.label1);
            this.guna2Panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel4.CustomizableEdges.BottomRight = false;
            this.guna2Panel4.CustomizableEdges.TopRight = false;
            this.guna2Panel4.FillColor = System.Drawing.Color.White;
            this.guna2Panel4.Location = new System.Drawing.Point(926, 43);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(40, 40);
            this.guna2Panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "+";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.SystemColors.Control;
            this.guna2Panel3.BorderRadius = 10;
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel3.CustomizableEdges.BottomLeft = false;
            this.guna2Panel3.CustomizableEdges.TopLeft = false;
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(1018, 43);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(40, 40);
            this.guna2Panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "-";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.SystemColors.Control;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.prod_amount);
            this.guna2Panel2.Location = new System.Drawing.Point(972, 43);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(40, 40);
            this.guna2Panel2.TabIndex = 2;
            // 
            // prod_amount
            // 
            this.prod_amount.AutoSize = true;
            this.prod_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_amount.ForeColor = System.Drawing.SystemColors.Control;
            this.prod_amount.Location = new System.Drawing.Point(3, 7);
            this.prod_amount.Name = "prod_amount";
            this.prod_amount.Size = new System.Drawing.Size(24, 25);
            this.prod_amount.TabIndex = 0;
            this.prod_amount.Text = "1";
            // 
            // cart_prod_img
            // 
            this.cart_prod_img.BackColor = System.Drawing.Color.Transparent;
            this.cart_prod_img.Image = global::Starbucks.Properties.Resources.prod_frap;
            this.cart_prod_img.ImageRotate = 0F;
            this.cart_prod_img.Location = new System.Drawing.Point(21, 15);
            this.cart_prod_img.Name = "cart_prod_img";
            this.cart_prod_img.Size = new System.Drawing.Size(98, 101);
            this.cart_prod_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cart_prod_img.TabIndex = 0;
            this.cart_prod_img.TabStop = false;
            this.cart_prod_img.UseTransparentBackground = true;
            // 
            // Product_Tile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Product_Tile";
            this.Size = new System.Drawing.Size(1257, 135);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cart_prod_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox cart_prod_img;
        private System.Windows.Forms.Label cart_prod_label;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label prod_amount;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

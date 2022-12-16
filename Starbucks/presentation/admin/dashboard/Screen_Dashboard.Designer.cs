namespace Starbucks.presentation.admin.dashboard
{
    partial class Screen_Dashboard
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
            this.sideMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.employees = new Guna.UI2.WinForms.Guna2Panel();
            this.products_label = new System.Windows.Forms.Label();
            this.products = new Guna.UI2.WinForms.Guna2Panel();
            this.add_prod_label = new System.Windows.Forms.Label();
            this.expenseBtn = new Guna.UI2.WinForms.Guna2Panel();
            this.add_exp_label = new System.Windows.Forms.Label();
            this.dashboardBtn = new Guna.UI2.WinForms.Guna2Panel();
            this.dashboard_btn_labe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.base_dashboard = new Guna.UI2.WinForms.Guna2Panel();
            this.sideMenu.SuspendLayout();
            this.employees.SuspendLayout();
            this.products.SuspendLayout();
            this.expenseBtn.SuspendLayout();
            this.dashboardBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.sideMenu.Controls.Add(this.label4);
            this.sideMenu.Controls.Add(this.employees);
            this.sideMenu.Controls.Add(this.products);
            this.sideMenu.Controls.Add(this.expenseBtn);
            this.sideMenu.Controls.Add(this.dashboardBtn);
            this.sideMenu.Controls.Add(this.label1);
            this.sideMenu.Controls.Add(this.guna2CirclePictureBox1);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 0);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(235, 687);
            this.sideMenu.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(45, 615);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "SIGN OUT";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // employees
            // 
            this.employees.BackColor = System.Drawing.Color.Transparent;
            this.employees.BorderColor = System.Drawing.SystemColors.Control;
            this.employees.BorderThickness = 1;
            this.employees.Controls.Add(this.products_label);
            this.employees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employees.FillColor = System.Drawing.Color.Transparent;
            this.employees.ForeColor = System.Drawing.SystemColors.Control;
            this.employees.Location = new System.Drawing.Point(3, 352);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(235, 74);
            this.employees.TabIndex = 4;
            this.employees.Click += new System.EventHandler(this.products_Click);
            // 
            // products_label
            // 
            this.products_label.AutoSize = true;
            this.products_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_label.ForeColor = System.Drawing.SystemColors.Control;
            this.products_label.Location = new System.Drawing.Point(47, 24);
            this.products_label.Name = "products_label";
            this.products_label.Size = new System.Drawing.Size(144, 25);
            this.products_label.TabIndex = 0;
            this.products_label.Text = "EMPLOYEES";
            this.products_label.Click += new System.EventHandler(this.products_label_Click);
            // 
            // products
            // 
            this.products.BackColor = System.Drawing.Color.Transparent;
            this.products.BorderColor = System.Drawing.SystemColors.Control;
            this.products.BorderThickness = 1;
            this.products.Controls.Add(this.add_prod_label);
            this.products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.products.FillColor = System.Drawing.Color.Transparent;
            this.products.ForeColor = System.Drawing.SystemColors.Control;
            this.products.Location = new System.Drawing.Point(3, 272);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(235, 74);
            this.products.TabIndex = 4;
            this.products.Click += new System.EventHandler(this.add_prod_Click);
            // 
            // add_prod_label
            // 
            this.add_prod_label.AutoSize = true;
            this.add_prod_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_prod_label.ForeColor = System.Drawing.SystemColors.Control;
            this.add_prod_label.Location = new System.Drawing.Point(47, 25);
            this.add_prod_label.Name = "add_prod_label";
            this.add_prod_label.Size = new System.Drawing.Size(132, 25);
            this.add_prod_label.TabIndex = 0;
            this.add_prod_label.Text = "PRODUCTS";
            this.add_prod_label.Click += new System.EventHandler(this.add_prod_label_Click);
            // 
            // expenseBtn
            // 
            this.expenseBtn.BackColor = System.Drawing.Color.Transparent;
            this.expenseBtn.BorderColor = System.Drawing.SystemColors.Control;
            this.expenseBtn.BorderThickness = 1;
            this.expenseBtn.Controls.Add(this.add_exp_label);
            this.expenseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expenseBtn.FillColor = System.Drawing.Color.Transparent;
            this.expenseBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.expenseBtn.Location = new System.Drawing.Point(0, 192);
            this.expenseBtn.Name = "expenseBtn";
            this.expenseBtn.Size = new System.Drawing.Size(235, 74);
            this.expenseBtn.TabIndex = 3;
            this.expenseBtn.Click += new System.EventHandler(this.guna2Panel3_Click);
            // 
            // add_exp_label
            // 
            this.add_exp_label.AutoSize = true;
            this.add_exp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_exp_label.ForeColor = System.Drawing.SystemColors.Control;
            this.add_exp_label.Location = new System.Drawing.Point(54, 23);
            this.add_exp_label.Name = "add_exp_label";
            this.add_exp_label.Size = new System.Drawing.Size(128, 25);
            this.add_exp_label.TabIndex = 0;
            this.add_exp_label.Text = "EXPENSES";
            this.add_exp_label.Click += new System.EventHandler(this.add_exp_label_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.BorderColor = System.Drawing.SystemColors.Control;
            this.dashboardBtn.BorderThickness = 1;
            this.dashboardBtn.Controls.Add(this.dashboard_btn_labe);
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBtn.FillColor = System.Drawing.SystemColors.Control;
            this.dashboardBtn.Location = new System.Drawing.Point(0, 112);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(235, 74);
            this.dashboardBtn.TabIndex = 2;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // dashboard_btn_labe
            // 
            this.dashboard_btn_labe.AutoSize = true;
            this.dashboard_btn_labe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn_labe.Location = new System.Drawing.Point(50, 21);
            this.dashboard_btn_labe.Name = "dashboard_btn_labe";
            this.dashboard_btn_labe.Size = new System.Drawing.Size(147, 25);
            this.dashboard_btn_labe.TabIndex = 0;
            this.dashboard_btn_labe.Text = "DASHBOARD";
            this.dashboard_btn_labe.Click += new System.EventHandler(this.dashboard_btn_labe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(99, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "KOCHI";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::Starbucks.Properties.Resources.starbucks_logo1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // base_dashboard
            // 
            this.base_dashboard.Location = new System.Drawing.Point(235, 0);
            this.base_dashboard.Name = "base_dashboard";
            this.base_dashboard.Size = new System.Drawing.Size(1171, 687);
            this.base_dashboard.TabIndex = 1;
            // 
            // Screen_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 687);
            this.Controls.Add(this.base_dashboard);
            this.Controls.Add(this.sideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Screen_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.sideMenu.ResumeLayout(false);
            this.sideMenu.PerformLayout();
            this.employees.ResumeLayout(false);
            this.employees.PerformLayout();
            this.products.ResumeLayout(false);
            this.products.PerformLayout();
            this.expenseBtn.ResumeLayout(false);
            this.expenseBtn.PerformLayout();
            this.dashboardBtn.ResumeLayout(false);
            this.dashboardBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel sideMenu;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Panel dashboardBtn;
        private Guna.UI2.WinForms.Guna2Panel expenseBtn;
        private System.Windows.Forms.Label add_exp_label;
        private System.Windows.Forms.Label dashboard_btn_labe;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel employees;
        private System.Windows.Forms.Label products_label;
        private Guna.UI2.WinForms.Guna2Panel products;
        private System.Windows.Forms.Label add_prod_label;
        public Guna.UI2.WinForms.Guna2Panel base_dashboard;
    }
}
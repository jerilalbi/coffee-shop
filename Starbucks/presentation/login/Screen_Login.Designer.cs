namespace Starbucks.presentation.login
{
    partial class Screen_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen_Login));
            this.login_side_img = new Guna.UI2.WinForms.Guna2PictureBox();
            this.login_back_logo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.user_toggle_btn = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.admin_box = new Guna.UI2.WinForms.Guna2Panel();
            this.admin_label = new System.Windows.Forms.Label();
            this.customer_box = new Guna.UI2.WinForms.Guna2Panel();
            this.customer_label = new System.Windows.Forms.Label();
            this.login_customer_text1 = new System.Windows.Forms.Label();
            this.login_customer_text2 = new System.Windows.Forms.Label();
            this.continue_customer_btn = new Guna.UI2.WinForms.Guna2TileButton();
            this.admin_user_txtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.admin_passwrd_txtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.admin_login_btn = new Guna.UI2.WinForms.Guna2TileButton();
            ((System.ComponentModel.ISupportInitialize)(this.login_side_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_back_logo)).BeginInit();
            this.admin_box.SuspendLayout();
            this.customer_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_side_img
            // 
            this.login_side_img.Image = ((System.Drawing.Image)(resources.GetObject("login_side_img.Image")));
            this.login_side_img.ImageRotate = 0F;
            this.login_side_img.Location = new System.Drawing.Point(-2, 0);
            this.login_side_img.Name = "login_side_img";
            this.login_side_img.Size = new System.Drawing.Size(652, 738);
            this.login_side_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.login_side_img.TabIndex = 0;
            this.login_side_img.TabStop = false;
            // 
            // login_back_logo
            // 
            this.login_back_logo.BackColor = System.Drawing.Color.Transparent;
            this.login_back_logo.Image = global::Starbucks.Properties.Resources.starbucks_logo1;
            this.login_back_logo.ImageRotate = 0F;
            this.login_back_logo.Location = new System.Drawing.Point(1043, 171);
            this.login_back_logo.Name = "login_back_logo";
            this.login_back_logo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.login_back_logo.Size = new System.Drawing.Size(759, 738);
            this.login_back_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.login_back_logo.TabIndex = 1;
            this.login_back_logo.TabStop = false;
            this.login_back_logo.UseTransparentBackground = true;
            this.login_back_logo.Click += new System.EventHandler(this.login_back_logo_Click);
            // 
            // user_toggle_btn
            // 
            this.user_toggle_btn.Animated = true;
            this.user_toggle_btn.BackColor = System.Drawing.Color.Transparent;
            this.user_toggle_btn.Checked = true;
            this.user_toggle_btn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.user_toggle_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.user_toggle_btn.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.user_toggle_btn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.user_toggle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_toggle_btn.Location = new System.Drawing.Point(877, 67);
            this.user_toggle_btn.Name = "user_toggle_btn";
            this.user_toggle_btn.Size = new System.Drawing.Size(292, 36);
            this.user_toggle_btn.TabIndex = 2;
            this.user_toggle_btn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.user_toggle_btn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.user_toggle_btn.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.user_toggle_btn.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.user_toggle_btn.CheckedChanged += new System.EventHandler(this.user_toggle_btn_CheckedChanged);
            // 
            // admin_box
            // 
            this.admin_box.AutoRoundedCorners = true;
            this.admin_box.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_box.BorderRadius = 17;
            this.admin_box.BorderThickness = 3;
            this.admin_box.Controls.Add(this.admin_label);
            this.admin_box.CustomBorderColor = System.Drawing.Color.Transparent;
            this.admin_box.ForeColor = System.Drawing.Color.DarkGray;
            this.admin_box.Location = new System.Drawing.Point(705, 67);
            this.admin_box.Name = "admin_box";
            this.admin_box.Size = new System.Drawing.Size(143, 36);
            this.admin_box.TabIndex = 3;
            // 
            // admin_label
            // 
            this.admin_label.BackColor = System.Drawing.Color.Transparent;
            this.admin_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_label.ForeColor = System.Drawing.Color.DarkGray;
            this.admin_label.Location = new System.Drawing.Point(0, 0);
            this.admin_label.Name = "admin_label";
            this.admin_label.Size = new System.Drawing.Size(143, 36);
            this.admin_label.TabIndex = 0;
            this.admin_label.Text = "ADMIN";
            this.admin_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customer_box
            // 
            this.customer_box.AutoRoundedCorners = true;
            this.customer_box.BorderColor = System.Drawing.Color.DarkGray;
            this.customer_box.BorderRadius = 17;
            this.customer_box.BorderThickness = 3;
            this.customer_box.Controls.Add(this.customer_label);
            this.customer_box.CustomBorderColor = System.Drawing.Color.Transparent;
            this.customer_box.ForeColor = System.Drawing.Color.DarkGray;
            this.customer_box.Location = new System.Drawing.Point(1195, 67);
            this.customer_box.Name = "customer_box";
            this.customer_box.Size = new System.Drawing.Size(143, 36);
            this.customer_box.TabIndex = 4;
            // 
            // customer_label
            // 
            this.customer_label.BackColor = System.Drawing.Color.Transparent;
            this.customer_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customer_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_label.ForeColor = System.Drawing.Color.DarkGray;
            this.customer_label.Location = new System.Drawing.Point(0, 0);
            this.customer_label.Name = "customer_label";
            this.customer_label.Size = new System.Drawing.Size(143, 36);
            this.customer_label.TabIndex = 1;
            this.customer_label.Text = "CUSTOMER";
            this.customer_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login_customer_text1
            // 
            this.login_customer_text1.AutoSize = true;
            this.login_customer_text1.BackColor = System.Drawing.Color.Transparent;
            this.login_customer_text1.Font = new System.Drawing.Font("Calisto MT", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_customer_text1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.login_customer_text1.Location = new System.Drawing.Point(700, 268);
            this.login_customer_text1.Name = "login_customer_text1";
            this.login_customer_text1.Size = new System.Drawing.Size(393, 102);
            this.login_customer_text1.TabIndex = 5;
            this.login_customer_text1.Text = "Today\'s good mood\r\nis sponsored by ";
            // 
            // login_customer_text2
            // 
            this.login_customer_text2.AutoSize = true;
            this.login_customer_text2.BackColor = System.Drawing.Color.Transparent;
            this.login_customer_text2.Font = new System.Drawing.Font("Calisto MT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_customer_text2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.login_customer_text2.Location = new System.Drawing.Point(700, 364);
            this.login_customer_text2.Name = "login_customer_text2";
            this.login_customer_text2.Size = new System.Drawing.Size(228, 53);
            this.login_customer_text2.TabIndex = 6;
            this.login_customer_text2.Text = "Starbucks";
            // 
            // continue_customer_btn
            // 
            this.continue_customer_btn.Animated = true;
            this.continue_customer_btn.BorderRadius = 10;
            this.continue_customer_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continue_customer_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.continue_customer_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.continue_customer_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.continue_customer_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.continue_customer_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.continue_customer_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continue_customer_btn.ForeColor = System.Drawing.Color.White;
            this.continue_customer_btn.Location = new System.Drawing.Point(709, 434);
            this.continue_customer_btn.Name = "continue_customer_btn";
            this.continue_customer_btn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.continue_customer_btn.Size = new System.Drawing.Size(219, 62);
            this.continue_customer_btn.TabIndex = 7;
            this.continue_customer_btn.Text = "CONTINUE";
            this.continue_customer_btn.Click += new System.EventHandler(this.continue_customer_btn_Click);
            // 
            // admin_user_txtBox
            // 
            this.admin_user_txtBox.Animated = true;
            this.admin_user_txtBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.admin_user_txtBox.BorderRadius = 15;
            this.admin_user_txtBox.BorderThickness = 3;
            this.admin_user_txtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.admin_user_txtBox.DefaultText = "";
            this.admin_user_txtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.admin_user_txtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.admin_user_txtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.admin_user_txtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.admin_user_txtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.admin_user_txtBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_user_txtBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.admin_user_txtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.admin_user_txtBox.Location = new System.Drawing.Point(701, 268);
            this.admin_user_txtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.admin_user_txtBox.Name = "admin_user_txtBox";
            this.admin_user_txtBox.PasswordChar = '\0';
            this.admin_user_txtBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.admin_user_txtBox.PlaceholderText = "USERNAME";
            this.admin_user_txtBox.SelectedText = "";
            this.admin_user_txtBox.Size = new System.Drawing.Size(392, 55);
            this.admin_user_txtBox.TabIndex = 8;
            this.admin_user_txtBox.Visible = false;
            // 
            // admin_passwrd_txtBox
            // 
            this.admin_passwrd_txtBox.Animated = true;
            this.admin_passwrd_txtBox.BackColor = System.Drawing.Color.Transparent;
            this.admin_passwrd_txtBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.admin_passwrd_txtBox.BorderRadius = 15;
            this.admin_passwrd_txtBox.BorderThickness = 3;
            this.admin_passwrd_txtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.admin_passwrd_txtBox.DefaultText = "";
            this.admin_passwrd_txtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.admin_passwrd_txtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.admin_passwrd_txtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.admin_passwrd_txtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.admin_passwrd_txtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.admin_passwrd_txtBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_passwrd_txtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.admin_passwrd_txtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.admin_passwrd_txtBox.Location = new System.Drawing.Point(701, 331);
            this.admin_passwrd_txtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.admin_passwrd_txtBox.Name = "admin_passwrd_txtBox";
            this.admin_passwrd_txtBox.PasswordChar = '\0';
            this.admin_passwrd_txtBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.admin_passwrd_txtBox.PlaceholderText = "PASSWORD";
            this.admin_passwrd_txtBox.SelectedText = "";
            this.admin_passwrd_txtBox.Size = new System.Drawing.Size(392, 54);
            this.admin_passwrd_txtBox.TabIndex = 9;
            this.admin_passwrd_txtBox.Visible = false;
            // 
            // admin_login_btn
            // 
            this.admin_login_btn.Animated = true;
            this.admin_login_btn.BorderRadius = 10;
            this.admin_login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_login_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_login_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_login_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_login_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_login_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.admin_login_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_login_btn.ForeColor = System.Drawing.Color.White;
            this.admin_login_btn.Location = new System.Drawing.Point(709, 405);
            this.admin_login_btn.Name = "admin_login_btn";
            this.admin_login_btn.Size = new System.Drawing.Size(219, 62);
            this.admin_login_btn.TabIndex = 10;
            this.admin_login_btn.Text = "LOGIN";
            this.admin_login_btn.Visible = false;
            // 
            // Screen_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 734);
            this.Controls.Add(this.admin_login_btn);
            this.Controls.Add(this.admin_passwrd_txtBox);
            this.Controls.Add(this.admin_user_txtBox);
            this.Controls.Add(this.continue_customer_btn);
            this.Controls.Add(this.login_customer_text1);
            this.Controls.Add(this.login_customer_text2);
            this.Controls.Add(this.customer_box);
            this.Controls.Add(this.admin_box);
            this.Controls.Add(this.user_toggle_btn);
            this.Controls.Add(this.login_back_logo);
            this.Controls.Add(this.login_side_img);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Screen_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen_Login";
            this.Load += new System.EventHandler(this.Screen_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.login_side_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_back_logo)).EndInit();
            this.admin_box.ResumeLayout(false);
            this.customer_box.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox login_side_img;
        private Guna.UI2.WinForms.Guna2CirclePictureBox login_back_logo;
        private Guna.UI2.WinForms.Guna2ToggleSwitch user_toggle_btn;
        private Guna.UI2.WinForms.Guna2Panel admin_box;
        private System.Windows.Forms.Label admin_label;
        private Guna.UI2.WinForms.Guna2Panel customer_box;
        private System.Windows.Forms.Label customer_label;
        private System.Windows.Forms.Label login_customer_text1;
        private System.Windows.Forms.Label login_customer_text2;
        private Guna.UI2.WinForms.Guna2TileButton continue_customer_btn;
        private Guna.UI2.WinForms.Guna2TextBox admin_user_txtBox;
        private Guna.UI2.WinForms.Guna2TextBox admin_passwrd_txtBox;
        private Guna.UI2.WinForms.Guna2TileButton admin_login_btn;
    }
}
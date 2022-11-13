namespace Starbucks.presentation.email
{
    partial class Screen_email
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
            this.label1 = new System.Windows.Forms.Label();
            this.email_textBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.next_btn = new Guna.UI2.WinForms.Guna2TileButton();
            this.starbucks_logo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.starbucks_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1180, 102);
            this.label1.TabIndex = 13;
            this.label1.Text = "To save our planet, the company has decided to reduce paper bills,\r\nso kindly ent" +
    "er your email to sent the bill and show it in the counter to recieve the order. " +
    "\r\nThank You";
            // 
            // email_textBox
            // 
            this.email_textBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.email_textBox.BorderRadius = 10;
            this.email_textBox.BorderThickness = 2;
            this.email_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_textBox.DefaultText = "";
            this.email_textBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email_textBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email_textBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_textBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_textBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.email_textBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_textBox.ForeColor = System.Drawing.Color.Black;
            this.email_textBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_textBox.Location = new System.Drawing.Point(88, 279);
            this.email_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.PasswordChar = '\0';
            this.email_textBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.email_textBox.PlaceholderText = "Enter The Email";
            this.email_textBox.SelectedText = "";
            this.email_textBox.Size = new System.Drawing.Size(738, 56);
            this.email_textBox.TabIndex = 14;
            // 
            // next_btn
            // 
            this.next_btn.BorderRadius = 15;
            this.next_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.next_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.next_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.next_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.next_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.next_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_btn.ForeColor = System.Drawing.Color.White;
            this.next_btn.Location = new System.Drawing.Point(88, 369);
            this.next_btn.Name = "next_btn";
            this.next_btn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.next_btn.Size = new System.Drawing.Size(180, 60);
            this.next_btn.TabIndex = 15;
            this.next_btn.Text = "NEXT";
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // starbucks_logo
            // 
            this.starbucks_logo.BackColor = System.Drawing.Color.Transparent;
            this.starbucks_logo.FillColor = System.Drawing.Color.Transparent;
            this.starbucks_logo.Image = global::Starbucks.Properties.Resources.starbucks_logo1;
            this.starbucks_logo.ImageRotate = 0F;
            this.starbucks_logo.Location = new System.Drawing.Point(63, 1);
            this.starbucks_logo.Margin = new System.Windows.Forms.Padding(4);
            this.starbucks_logo.Name = "starbucks_logo";
            this.starbucks_logo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.starbucks_logo.Size = new System.Drawing.Size(98, 98);
            this.starbucks_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.starbucks_logo.TabIndex = 12;
            this.starbucks_logo.TabStop = false;
            this.starbucks_logo.UseTransparentBackground = true;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::Starbucks.Properties.Resources.starbucks_logo_op;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(902, 31);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(1000, 1000);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // Screen_email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 687);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.starbucks_logo);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Screen_email";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen_email";
            ((System.ComponentModel.ISupportInitialize)(this.starbucks_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox starbucks_logo;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox email_textBox;
        private Guna.UI2.WinForms.Guna2TileButton next_btn;
    }
}
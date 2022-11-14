namespace Starbucks.presentation.final
{
    partial class Screen_final
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
            this.bg_img = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.starbucks_txt = new System.Windows.Forms.Label();
            this.exit_btn = new Guna.UI2.WinForms.Guna2TileButton();
            this.next_btn = new Guna.UI2.WinForms.Guna2TileButton();
            ((System.ComponentModel.ISupportInitialize)(this.bg_img)).BeginInit();
            this.SuspendLayout();
            // 
            // bg_img
            // 
            this.bg_img.BackColor = System.Drawing.Color.Transparent;
            this.bg_img.Image = global::Starbucks.Properties.Resources.starbucks_logo_op;
            this.bg_img.ImageRotate = 0F;
            this.bg_img.Location = new System.Drawing.Point(207, -14);
            this.bg_img.Name = "bg_img";
            this.bg_img.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.bg_img.Size = new System.Drawing.Size(670, 670);
            this.bg_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bg_img.TabIndex = 0;
            this.bg_img.TabStop = false;
            this.bg_img.UseTransparentBackground = true;
            // 
            // starbucks_txt
            // 
            this.starbucks_txt.AutoSize = true;
            this.starbucks_txt.BackColor = System.Drawing.Color.Transparent;
            this.starbucks_txt.Font = new System.Drawing.Font("Baskerville Old Face", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starbucks_txt.Location = new System.Drawing.Point(28, 215);
            this.starbucks_txt.Name = "starbucks_txt";
            this.starbucks_txt.Size = new System.Drawing.Size(1070, 49);
            this.starbucks_txt.TabIndex = 1;
            this.starbucks_txt.Text = "Thank you for using Starbucks. Enjoy the day in Starbucks";
            // 
            // exit_btn
            // 
            this.exit_btn.BorderRadius = 15;
            this.exit_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exit_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exit_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exit_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exit_btn.FillColor = System.Drawing.Color.DarkSlateGray;
            this.exit_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Location = new System.Drawing.Point(34, 628);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.PressedColor = System.Drawing.Color.DarkSlateGray;
            this.exit_btn.Size = new System.Drawing.Size(190, 75);
            this.exit_btn.TabIndex = 2;
            this.exit_btn.Text = "EXIT";
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
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
            this.next_btn.Location = new System.Drawing.Point(1189, 628);
            this.next_btn.Name = "next_btn";
            this.next_btn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.next_btn.Size = new System.Drawing.Size(190, 75);
            this.next_btn.TabIndex = 3;
            this.next_btn.Text = "NEXT";
            // 
            // Screen_final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 734);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.bg_img);
            this.Controls.Add(this.starbucks_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Screen_final";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen_final";
            ((System.ComponentModel.ISupportInitialize)(this.bg_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox bg_img;
        private System.Windows.Forms.Label starbucks_txt;
        private Guna.UI2.WinForms.Guna2TileButton exit_btn;
        private Guna.UI2.WinForms.Guna2TileButton next_btn;
    }
}
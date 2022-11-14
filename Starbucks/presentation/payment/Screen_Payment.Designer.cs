namespace Starbucks.presentation.payment
{
    partial class Screen_Payment
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
            this.qrCodebx = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodebx)).BeginInit();
            this.SuspendLayout();
            // 
            // qrCodebx
            // 
            this.qrCodebx.ImageRotate = 0F;
            this.qrCodebx.Location = new System.Drawing.Point(414, 135);
            this.qrCodebx.Name = "qrCodebx";
            this.qrCodebx.Size = new System.Drawing.Size(265, 225);
            this.qrCodebx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrCodebx.TabIndex = 0;
            this.qrCodebx.TabStop = false;
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton1.Location = new System.Drawing.Point(455, 396);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.Size = new System.Drawing.Size(180, 114);
            this.guna2TileButton1.TabIndex = 1;
            this.guna2TileButton1.Text = "guna2TileButton1";
            this.guna2TileButton1.Click += new System.EventHandler(this.guna2TileButton1_Click);
            // 
            // Screen_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 547);
            this.Controls.Add(this.guna2TileButton1);
            this.Controls.Add(this.qrCodebx);
            this.Name = "Screen_Payment";
            this.Text = "Screen_Payment";
            ((System.ComponentModel.ISupportInitialize)(this.qrCodebx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox qrCodebx;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
    }
}
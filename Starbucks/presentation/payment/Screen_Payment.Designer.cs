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
            this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.qrCodebx = new Guna.UI2.WinForms.Guna2PictureBox();
            this.baseContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodebx)).BeginInit();
            this.baseContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.guna2TileButton1.BorderRadius = 10;
            this.guna2TileButton1.BorderThickness = 3;
            this.guna2TileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2TileButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TileButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2TileButton1.Location = new System.Drawing.Point(1250, 621);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.Size = new System.Drawing.Size(141, 54);
            this.guna2TileButton1.TabIndex = 1;
            this.guna2TileButton1.Text = "NEXT";
            this.guna2TileButton1.Click += new System.EventHandler(this.guna2TileButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "SCAN AND PAY";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Starbucks.Properties.Resources.upi_logo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-114, 469);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(594, 105);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // qrCodebx
            // 
            this.qrCodebx.ImageRotate = 0F;
            this.qrCodebx.Location = new System.Drawing.Point(0, 48);
            this.qrCodebx.Name = "qrCodebx";
            this.qrCodebx.Size = new System.Drawing.Size(364, 364);
            this.qrCodebx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrCodebx.TabIndex = 0;
            this.qrCodebx.TabStop = false;
            // 
            // baseContainer
            // 
            this.baseContainer.Controls.Add(this.label2);
            this.baseContainer.Controls.Add(this.guna2PictureBox1);
            this.baseContainer.Controls.Add(this.label1);
            this.baseContainer.Controls.Add(this.qrCodebx);
            this.baseContainer.Location = new System.Drawing.Point(475, 80);
            this.baseContainer.Name = "baseContainer";
            this.baseContainer.Size = new System.Drawing.Size(364, 577);
            this.baseContainer.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Checking Payment";
            this.label2.Visible = false;
            // 
            // Screen_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 687);
            this.Controls.Add(this.baseContainer);
            this.Controls.Add(this.guna2TileButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Screen_Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen_Payment";
            this.Load += new System.EventHandler(this.Screen_Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodebx)).EndInit();
            this.baseContainer.ResumeLayout(false);
            this.baseContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox qrCodebx;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel baseContainer;
        private System.Windows.Forms.Label label2;
    }
}
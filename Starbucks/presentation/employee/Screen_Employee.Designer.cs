namespace Starbucks.presentation.employee
{
    partial class Screen_Employee
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
            this.components = new System.ComponentModel.Container();
            this.qrScanCamera = new Guna.UI2.WinForms.Guna2PictureBox();
            this.productsLabel = new System.Windows.Forms.Label();
            this.productsDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nextBtn = new Guna.UI2.WinForms.Guna2TileButton();
            ((System.ComponentModel.ISupportInitialize)(this.qrScanCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // qrScanCamera
            // 
            this.qrScanCamera.BackColor = System.Drawing.Color.Transparent;
            this.qrScanCamera.BorderRadius = 10;
            this.qrScanCamera.ImageRotate = 0F;
            this.qrScanCamera.Location = new System.Drawing.Point(419, 53);
            this.qrScanCamera.Name = "qrScanCamera";
            this.qrScanCamera.ShadowDecoration.BorderRadius = 10;
            this.qrScanCamera.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.qrScanCamera.ShadowDecoration.Depth = 50;
            this.qrScanCamera.Size = new System.Drawing.Size(421, 432);
            this.qrScanCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrScanCamera.TabIndex = 0;
            this.qrScanCamera.TabStop = false;
            this.qrScanCamera.UseTransparentBackground = true;
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.productsLabel.Location = new System.Drawing.Point(99, 53);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(168, 45);
            this.productsLabel.TabIndex = 1;
            this.productsLabel.Text = "Products";
            this.productsLabel.Visible = false;
            // 
            // productsDisplay
            // 
            this.productsDisplay.AutoScroll = true;
            this.productsDisplay.Location = new System.Drawing.Point(107, 115);
            this.productsDisplay.Name = "productsDisplay";
            this.productsDisplay.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.productsDisplay.Size = new System.Drawing.Size(922, 423);
            this.productsDisplay.TabIndex = 2;
            this.productsDisplay.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nextBtn
            // 
            this.nextBtn.BorderRadius = 20;
            this.nextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nextBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.nextBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.ForeColor = System.Drawing.Color.White;
            this.nextBtn.Location = new System.Drawing.Point(1100, 568);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.nextBtn.Size = new System.Drawing.Size(155, 60);
            this.nextBtn.TabIndex = 5;
            this.nextBtn.Text = "NEXT";
            this.nextBtn.Visible = false;
            this.nextBtn.Click += new System.EventHandler(this.guna2TileButton1_Click);
            // 
            // Screen_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 640);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.productsDisplay);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.qrScanCamera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Screen_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_FormClosing);
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrScanCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox qrScanCamera;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.FlowLayoutPanel productsDisplay;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2TileButton nextBtn;
    }
}
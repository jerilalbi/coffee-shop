namespace Starbucks.presentation.admin.dash_employee
{
    partial class Dash_Employ
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.emp_no_label = new System.Windows.Forms.Label();
            this.noOfExp = new System.Windows.Forms.Label();
            this.empDisplayPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "EMPLOYEES";
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BorderRadius = 15;
            this.guna2Panel6.Controls.Add(this.emp_no_label);
            this.guna2Panel6.Controls.Add(this.noOfExp);
            this.guna2Panel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.guna2Panel6.Location = new System.Drawing.Point(57, 81);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(253, 100);
            this.guna2Panel6.TabIndex = 9;
            // 
            // emp_no_label
            // 
            this.emp_no_label.AutoSize = true;
            this.emp_no_label.BackColor = System.Drawing.Color.Transparent;
            this.emp_no_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_no_label.ForeColor = System.Drawing.SystemColors.Control;
            this.emp_no_label.Location = new System.Drawing.Point(200, 34);
            this.emp_no_label.Name = "emp_no_label";
            this.emp_no_label.Size = new System.Drawing.Size(27, 29);
            this.emp_no_label.TabIndex = 1;
            this.emp_no_label.Text = "4";
            // 
            // noOfExp
            // 
            this.noOfExp.AutoSize = true;
            this.noOfExp.BackColor = System.Drawing.Color.Transparent;
            this.noOfExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfExp.ForeColor = System.Drawing.SystemColors.Control;
            this.noOfExp.Location = new System.Drawing.Point(18, 24);
            this.noOfExp.Name = "noOfExp";
            this.noOfExp.Size = new System.Drawing.Size(118, 50);
            this.noOfExp.TabIndex = 0;
            this.noOfExp.Text = "Number of\r\nEmployees\r\n";
            // 
            // empDisplayPanel
            // 
            this.empDisplayPanel.AutoScroll = true;
            this.empDisplayPanel.Location = new System.Drawing.Point(57, 213);
            this.empDisplayPanel.Name = "empDisplayPanel";
            this.empDisplayPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.empDisplayPanel.Size = new System.Drawing.Size(1026, 450);
            this.empDisplayPanel.TabIndex = 10;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.addBtn.Image = global::Starbucks.Properties.Resources.add_logo;
            this.addBtn.Location = new System.Drawing.Point(1089, 593);
            this.addBtn.Name = "addBtn";
            this.addBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.addBtn.ShadowDecoration.Depth = 20;
            this.addBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.addBtn.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.addBtn.Size = new System.Drawing.Size(70, 70);
            this.addBtn.TabIndex = 13;
            this.addBtn.UseTransparentBackground = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Dash_Employ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.empDisplayPanel);
            this.Controls.Add(this.guna2Panel6);
            this.Controls.Add(this.label1);
            this.Name = "Dash_Employ";
            this.Size = new System.Drawing.Size(1171, 687);
            this.Load += new System.EventHandler(this.Dash_Employ_Load);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private System.Windows.Forms.Label noOfExp;
        private Guna.UI2.WinForms.Guna2CircleButton addBtn;
        public System.Windows.Forms.FlowLayoutPanel empDisplayPanel;
        public System.Windows.Forms.Label emp_no_label;
    }
}

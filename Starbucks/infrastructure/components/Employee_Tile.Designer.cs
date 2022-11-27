namespace Starbucks.infrastructure.components
{
    partial class Employee_Tile
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
            this.editBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.emp_email = new System.Windows.Forms.Label();
            this.emp_name = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.editBtn);
            this.guna2Panel1.Controls.Add(this.deleteBtn);
            this.guna2Panel1.Controls.Add(this.emp_email);
            this.guna2Panel1.Controls.Add(this.emp_name);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(991, 133);
            this.guna2Panel1.TabIndex = 1;
            // 
            // editBtn
            // 
            this.editBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.HoverState.ImageSize = new System.Drawing.Size(32, 38);
            this.editBtn.Image = global::Starbucks.Properties.Resources.edit_logo;
            this.editBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.editBtn.ImageRotate = 0F;
            this.editBtn.ImageSize = new System.Drawing.Size(30, 36);
            this.editBtn.Location = new System.Drawing.Point(820, 43);
            this.editBtn.Name = "editBtn";
            this.editBtn.PressedState.ImageSize = new System.Drawing.Size(32, 38);
            this.editBtn.Size = new System.Drawing.Size(42, 48);
            this.editBtn.TabIndex = 5;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.HoverState.ImageSize = new System.Drawing.Size(32, 38);
            this.deleteBtn.Image = global::Starbucks.Properties.Resources.delete_64;
            this.deleteBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.deleteBtn.ImageRotate = 0F;
            this.deleteBtn.ImageSize = new System.Drawing.Size(30, 36);
            this.deleteBtn.Location = new System.Drawing.Point(924, 43);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.PressedState.ImageSize = new System.Drawing.Size(32, 38);
            this.deleteBtn.Size = new System.Drawing.Size(42, 48);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // emp_email
            // 
            this.emp_email.AutoSize = true;
            this.emp_email.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_email.ForeColor = System.Drawing.SystemColors.Control;
            this.emp_email.Location = new System.Drawing.Point(51, 71);
            this.emp_email.Name = "emp_email";
            this.emp_email.Size = new System.Drawing.Size(362, 38);
            this.emp_email.TabIndex = 3;
            this.emp_email.Text = "curts36jones@gmail.com";
            // 
            // emp_name
            // 
            this.emp_name.AutoSize = true;
            this.emp_name.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_name.ForeColor = System.Drawing.SystemColors.Control;
            this.emp_name.Location = new System.Drawing.Point(51, 33);
            this.emp_name.Name = "emp_name";
            this.emp_name.Size = new System.Drawing.Size(188, 38);
            this.emp_name.TabIndex = 2;
            this.emp_name.Text = "Curtis Jones";
            // 
            // Employee_Tile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Employee_Tile";
            this.Size = new System.Drawing.Size(996, 133);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ImageButton editBtn;
        private Guna.UI2.WinForms.Guna2ImageButton deleteBtn;
        private System.Windows.Forms.Label emp_email;
        private System.Windows.Forms.Label emp_name;
    }
}

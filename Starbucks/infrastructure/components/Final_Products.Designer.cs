namespace Starbucks.infrastructure.components
{
    partial class Final_Products
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
            this.countLabel = new System.Windows.Forms.Label();
            this.flavour_label = new System.Windows.Forms.Label();
            this.size_label = new System.Windows.Forms.Label();
            this.prod_name = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.countLabel);
            this.guna2Panel1.Controls.Add(this.flavour_label);
            this.guna2Panel1.Controls.Add(this.size_label);
            this.guna2Panel1.Controls.Add(this.prod_name);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(852, 144);
            this.guna2Panel1.TabIndex = 0;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.countLabel.Location = new System.Drawing.Point(742, 54);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(89, 45);
            this.countLabel.TabIndex = 6;
            this.countLabel.Text = "( 1 )";
            // 
            // flavour_label
            // 
            this.flavour_label.AutoSize = true;
            this.flavour_label.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flavour_label.ForeColor = System.Drawing.SystemColors.Control;
            this.flavour_label.Location = new System.Drawing.Point(194, 87);
            this.flavour_label.Name = "flavour_label";
            this.flavour_label.Size = new System.Drawing.Size(102, 38);
            this.flavour_label.TabIndex = 5;
            this.flavour_label.Text = "Apple";
            // 
            // size_label
            // 
            this.size_label.AutoSize = true;
            this.size_label.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size_label.ForeColor = System.Drawing.SystemColors.Control;
            this.size_label.Location = new System.Drawing.Point(59, 87);
            this.size_label.Name = "size_label";
            this.size_label.Size = new System.Drawing.Size(95, 38);
            this.size_label.TabIndex = 4;
            this.size_label.Text = "Small";
            // 
            // prod_name
            // 
            this.prod_name.AutoSize = true;
            this.prod_name.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_name.ForeColor = System.Drawing.SystemColors.Control;
            this.prod_name.Location = new System.Drawing.Point(58, 42);
            this.prod_name.Name = "prod_name";
            this.prod_name.Size = new System.Drawing.Size(385, 45);
            this.prod_name.TabIndex = 3;
            this.prod_name.Text = "Caramel Frappuccino";
            // 
            // Final_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Final_Products";
            this.Size = new System.Drawing.Size(864, 150);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label flavour_label;
        private System.Windows.Forms.Label size_label;
        private System.Windows.Forms.Label prod_name;
        private System.Windows.Forms.Label countLabel;
    }
}

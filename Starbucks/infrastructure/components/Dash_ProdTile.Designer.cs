namespace Starbucks.infrastructure.components
{
    partial class Dash_ProdTile
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
            this.prodImg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.prodAmtTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.prodNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.editBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.prodAmountLabel = new System.Windows.Forms.Label();
            this.prodTypeLabel = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodImg)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.prodImg);
            this.guna2Panel1.Controls.Add(this.prodAmtTxt);
            this.guna2Panel1.Controls.Add(this.prodNameTxt);
            this.guna2Panel1.Controls.Add(this.editBtn);
            this.guna2Panel1.Controls.Add(this.deleteBtn);
            this.guna2Panel1.Controls.Add(this.prodAmountLabel);
            this.guna2Panel1.Controls.Add(this.prodTypeLabel);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Location = new System.Drawing.Point(5, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(463, 144);
            this.guna2Panel1.TabIndex = 1;
            // 
            // prodImg
            // 
            this.prodImg.Image = global::Starbucks.Properties.Resources.prod_frap;
            this.prodImg.ImageRotate = 0F;
            this.prodImg.Location = new System.Drawing.Point(12, 20);
            this.prodImg.Name = "prodImg";
            this.prodImg.Size = new System.Drawing.Size(65, 105);
            this.prodImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prodImg.TabIndex = 8;
            this.prodImg.TabStop = false;
            this.prodImg.UseTransparentBackground = true;
            this.prodImg.Click += new System.EventHandler(this.prodImg_Click);
            // 
            // prodAmtTxt
            // 
            this.prodAmtTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodAmtTxt.DefaultText = "";
            this.prodAmtTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prodAmtTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prodAmtTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodAmtTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodAmtTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.prodAmtTxt.FocusedState.BorderColor = System.Drawing.Color.White;
            this.prodAmtTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodAmtTxt.ForeColor = System.Drawing.Color.White;
            this.prodAmtTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodAmtTxt.Location = new System.Drawing.Point(88, 80);
            this.prodAmtTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prodAmtTxt.Name = "prodAmtTxt";
            this.prodAmtTxt.PasswordChar = '\0';
            this.prodAmtTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.prodAmtTxt.PlaceholderText = "Amount";
            this.prodAmtTxt.SelectedText = "";
            this.prodAmtTxt.Size = new System.Drawing.Size(226, 36);
            this.prodAmtTxt.TabIndex = 7;
            this.prodAmtTxt.Visible = false;
            // 
            // prodNameTxt
            // 
            this.prodNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodNameTxt.DefaultText = "";
            this.prodNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prodNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prodNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodNameTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.prodNameTxt.FocusedState.BorderColor = System.Drawing.Color.White;
            this.prodNameTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodNameTxt.ForeColor = System.Drawing.Color.White;
            this.prodNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodNameTxt.Location = new System.Drawing.Point(88, 33);
            this.prodNameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prodNameTxt.Name = "prodNameTxt";
            this.prodNameTxt.PasswordChar = '\0';
            this.prodNameTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.prodNameTxt.PlaceholderText = "Name";
            this.prodNameTxt.SelectedText = "";
            this.prodNameTxt.Size = new System.Drawing.Size(226, 36);
            this.prodNameTxt.TabIndex = 6;
            this.prodNameTxt.Visible = false;
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
            this.editBtn.Location = new System.Drawing.Point(336, 43);
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
            this.deleteBtn.Location = new System.Drawing.Point(408, 43);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.PressedState.ImageSize = new System.Drawing.Size(32, 38);
            this.deleteBtn.Size = new System.Drawing.Size(42, 48);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // prodAmountLabel
            // 
            this.prodAmountLabel.AutoSize = true;
            this.prodAmountLabel.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodAmountLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.prodAmountLabel.Location = new System.Drawing.Point(83, 80);
            this.prodAmountLabel.Name = "prodAmountLabel";
            this.prodAmountLabel.Size = new System.Drawing.Size(60, 26);
            this.prodAmountLabel.TabIndex = 3;
            this.prodAmountLabel.Text = "1504";
            // 
            // prodTypeLabel
            // 
            this.prodTypeLabel.AutoSize = true;
            this.prodTypeLabel.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodTypeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.prodTypeLabel.Location = new System.Drawing.Point(83, 43);
            this.prodTypeLabel.Name = "prodTypeLabel";
            this.prodTypeLabel.Size = new System.Drawing.Size(231, 26);
            this.prodTypeLabel.TabIndex = 2;
            this.prodTypeLabel.Text = "Caramel Frappuccino";
            // 
            // Dash_ProdTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Dash_ProdTile";
            this.Size = new System.Drawing.Size(473, 150);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox prodAmtTxt;
        private Guna.UI2.WinForms.Guna2TextBox prodNameTxt;
        private Guna.UI2.WinForms.Guna2ImageButton editBtn;
        private Guna.UI2.WinForms.Guna2ImageButton deleteBtn;
        private System.Windows.Forms.Label prodAmountLabel;
        private System.Windows.Forms.Label prodTypeLabel;
        private Guna.UI2.WinForms.Guna2PictureBox prodImg;
    }
}

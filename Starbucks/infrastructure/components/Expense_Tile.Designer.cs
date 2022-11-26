namespace Starbucks.infrastructure.components
{
    partial class Expense_Tile
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
            this.expAmtTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.expTypeTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.editBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.expAmountLabel = new System.Windows.Forms.Label();
            this.expTypeLabel = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.expAmtTxt);
            this.guna2Panel1.Controls.Add(this.expTypeTxt);
            this.guna2Panel1.Controls.Add(this.editBtn);
            this.guna2Panel1.Controls.Add(this.deleteBtn);
            this.guna2Panel1.Controls.Add(this.expAmountLabel);
            this.guna2Panel1.Controls.Add(this.expTypeLabel);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(463, 144);
            this.guna2Panel1.TabIndex = 0;
            // 
            // expAmtTxt
            // 
            this.expAmtTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expAmtTxt.DefaultText = "";
            this.expAmtTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.expAmtTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.expAmtTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expAmtTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expAmtTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.expAmtTxt.FocusedState.BorderColor = System.Drawing.Color.White;
            this.expAmtTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expAmtTxt.ForeColor = System.Drawing.Color.White;
            this.expAmtTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expAmtTxt.Location = new System.Drawing.Point(34, 72);
            this.expAmtTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.expAmtTxt.Name = "expAmtTxt";
            this.expAmtTxt.PasswordChar = '\0';
            this.expAmtTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.expAmtTxt.PlaceholderText = "Amount";
            this.expAmtTxt.SelectedText = "";
            this.expAmtTxt.Size = new System.Drawing.Size(198, 36);
            this.expAmtTxt.TabIndex = 7;
            this.expAmtTxt.Visible = false;
            // 
            // expTypeTxt
            // 
            this.expTypeTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expTypeTxt.DefaultText = "";
            this.expTypeTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.expTypeTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.expTypeTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expTypeTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expTypeTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.expTypeTxt.FocusedState.BorderColor = System.Drawing.Color.White;
            this.expTypeTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expTypeTxt.ForeColor = System.Drawing.Color.White;
            this.expTypeTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expTypeTxt.Location = new System.Drawing.Point(34, 30);
            this.expTypeTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.expTypeTxt.Name = "expTypeTxt";
            this.expTypeTxt.PasswordChar = '\0';
            this.expTypeTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.expTypeTxt.PlaceholderText = "Type";
            this.expTypeTxt.SelectedText = "";
            this.expTypeTxt.Size = new System.Drawing.Size(198, 36);
            this.expTypeTxt.TabIndex = 6;
            this.expTypeTxt.Visible = false;
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
            this.editBtn.Click += new System.EventHandler(this.guna2ImageButton2_Click);
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
            // 
            // expAmountLabel
            // 
            this.expAmountLabel.AutoSize = true;
            this.expAmountLabel.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expAmountLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.expAmountLabel.Location = new System.Drawing.Point(27, 66);
            this.expAmountLabel.Name = "expAmountLabel";
            this.expAmountLabel.Size = new System.Drawing.Size(85, 38);
            this.expAmountLabel.TabIndex = 3;
            this.expAmountLabel.Text = "1504";
            // 
            // expTypeLabel
            // 
            this.expTypeLabel.AutoSize = true;
            this.expTypeLabel.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expTypeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.expTypeLabel.Location = new System.Drawing.Point(27, 28);
            this.expTypeLabel.Name = "expTypeLabel";
            this.expTypeLabel.Size = new System.Drawing.Size(83, 38);
            this.expTypeLabel.TabIndex = 2;
            this.expTypeLabel.Text = "Rent";
            // 
            // Expense_Tile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Expense_Tile";
            this.Size = new System.Drawing.Size(473, 150);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label expAmountLabel;
        private System.Windows.Forms.Label expTypeLabel;
        private Guna.UI2.WinForms.Guna2ImageButton editBtn;
        private Guna.UI2.WinForms.Guna2ImageButton deleteBtn;
        private Guna.UI2.WinForms.Guna2TextBox expTypeTxt;
        private Guna.UI2.WinForms.Guna2TextBox expAmtTxt;
    }
}

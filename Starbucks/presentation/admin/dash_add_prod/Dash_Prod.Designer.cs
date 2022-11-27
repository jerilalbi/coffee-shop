namespace Starbucks.presentation.admin.dash_add_prod
{
    partial class Dash_Prod
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
            Guna.Charts.WinForms.ChartFont chartFont17 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont18 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont19 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont20 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid7 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick7 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont21 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid8 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick8 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont22 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid9 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel3 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont23 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick9 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont24 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.LPoint lPoint1 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint2 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint3 = new Guna.Charts.WinForms.LPoint();
            this.label1 = new System.Windows.Forms.Label();
            this.period_combobx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.category_comboBx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.prodNoVal = new System.Windows.Forms.Label();
            this.noOfProd = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.highDemVal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.totalAmtVal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prodDisplayPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.productChart = new Guna.Charts.WinForms.GunaChart();
            this.gunaDoughnutDataset1 = new Guna.Charts.WinForms.GunaDoughnutDataset();
            this.addBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "PRODUCTS";
            // 
            // period_combobx
            // 
            this.period_combobx.BackColor = System.Drawing.Color.Transparent;
            this.period_combobx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.period_combobx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.period_combobx.FocusedColor = System.Drawing.Color.Transparent;
            this.period_combobx.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.period_combobx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.period_combobx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.period_combobx.ItemHeight = 30;
            this.period_combobx.Items.AddRange(new object[] {
            "This Month",
            "This Year"});
            this.period_combobx.Location = new System.Drawing.Point(888, 25);
            this.period_combobx.Name = "period_combobx";
            this.period_combobx.Size = new System.Drawing.Size(166, 36);
            this.period_combobx.TabIndex = 12;
            this.period_combobx.SelectedIndexChanged += new System.EventHandler(this.period_combobx_SelectedIndexChanged);
            // 
            // category_comboBx
            // 
            this.category_comboBx.BackColor = System.Drawing.Color.Transparent;
            this.category_comboBx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.category_comboBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category_comboBx.FocusedColor = System.Drawing.Color.Transparent;
            this.category_comboBx.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.category_comboBx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.category_comboBx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.category_comboBx.ItemHeight = 30;
            this.category_comboBx.Items.AddRange(new object[] {
            "Hot Coffee",
            "Cold Coffee",
            "Cold Drinks",
            "Frappuccino",
            "Bakery"});
            this.category_comboBx.Location = new System.Drawing.Point(57, 52);
            this.category_comboBx.Name = "category_comboBx";
            this.category_comboBx.Size = new System.Drawing.Size(166, 36);
            this.category_comboBx.TabIndex = 13;
            this.category_comboBx.SelectedIndexChanged += new System.EventHandler(this.category_comboBx_SelectedIndexChanged);
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BorderRadius = 15;
            this.guna2Panel6.Controls.Add(this.prodNoVal);
            this.guna2Panel6.Controls.Add(this.noOfProd);
            this.guna2Panel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.guna2Panel6.Location = new System.Drawing.Point(57, 103);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(253, 100);
            this.guna2Panel6.TabIndex = 14;
            // 
            // prodNoVal
            // 
            this.prodNoVal.AutoSize = true;
            this.prodNoVal.BackColor = System.Drawing.Color.Transparent;
            this.prodNoVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodNoVal.ForeColor = System.Drawing.SystemColors.Control;
            this.prodNoVal.Location = new System.Drawing.Point(171, 34);
            this.prodNoVal.Name = "prodNoVal";
            this.prodNoVal.Size = new System.Drawing.Size(60, 25);
            this.prodNoVal.TabIndex = 1;
            this.prodNoVal.Text = "1574";
            // 
            // noOfProd
            // 
            this.noOfProd.AutoSize = true;
            this.noOfProd.BackColor = System.Drawing.Color.Transparent;
            this.noOfProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfProd.ForeColor = System.Drawing.SystemColors.Control;
            this.noOfProd.Location = new System.Drawing.Point(18, 24);
            this.noOfProd.Name = "noOfProd";
            this.noOfProd.Size = new System.Drawing.Size(111, 50);
            this.noOfProd.TabIndex = 0;
            this.noOfProd.Text = "Number of\r\nProducts\r\n";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.highDemVal);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Location = new System.Drawing.Point(386, 103);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(342, 100);
            this.guna2Panel1.TabIndex = 7;
            // 
            // highDemVal
            // 
            this.highDemVal.AutoSize = true;
            this.highDemVal.BackColor = System.Drawing.Color.Transparent;
            this.highDemVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highDemVal.ForeColor = System.Drawing.SystemColors.Control;
            this.highDemVal.Location = new System.Drawing.Point(221, 34);
            this.highDemVal.Name = "highDemVal";
            this.highDemVal.Size = new System.Drawing.Size(60, 25);
            this.highDemVal.TabIndex = 1;
            this.highDemVal.Text = "1574";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(18, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 50);
            this.label3.TabIndex = 0;
            this.label3.Text = "High\r\nDemand";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 15;
            this.guna2Panel2.Controls.Add(this.totalAmtVal);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.guna2Panel2.Location = new System.Drawing.Point(801, 103);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(253, 100);
            this.guna2Panel2.TabIndex = 7;
            // 
            // totalAmtVal
            // 
            this.totalAmtVal.AutoSize = true;
            this.totalAmtVal.BackColor = System.Drawing.Color.Transparent;
            this.totalAmtVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmtVal.ForeColor = System.Drawing.SystemColors.Control;
            this.totalAmtVal.Location = new System.Drawing.Point(171, 34);
            this.totalAmtVal.Name = "totalAmtVal";
            this.totalAmtVal.Size = new System.Drawing.Size(60, 25);
            this.totalAmtVal.TabIndex = 1;
            this.totalAmtVal.Text = "1574";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(18, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 50);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total\r\nAmount\r\n";
            // 
            // prodDisplayPanel
            // 
            this.prodDisplayPanel.AutoScroll = true;
            this.prodDisplayPanel.Location = new System.Drawing.Point(57, 225);
            this.prodDisplayPanel.Name = "prodDisplayPanel";
            this.prodDisplayPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prodDisplayPanel.Size = new System.Drawing.Size(504, 443);
            this.prodDisplayPanel.TabIndex = 15;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.guna2Panel3.BorderThickness = 3;
            this.guna2Panel3.Controls.Add(this.label6);
            this.guna2Panel3.Controls.Add(this.productChart);
            this.guna2Panel3.Location = new System.Drawing.Point(573, 225);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(481, 443);
            this.guna2Panel3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Product Sale";
            // 
            // productChart
            // 
            this.productChart.BackColor = System.Drawing.Color.White;
            this.productChart.Datasets.AddRange(new Guna.Charts.Interfaces.IGunaDataset[] {
            this.gunaDoughnutDataset1});
            chartFont17.FontName = "Arial";
            this.productChart.Legend.LabelFont = chartFont17;
            this.productChart.Location = new System.Drawing.Point(12, 59);
            this.productChart.Name = "productChart";
            this.productChart.Size = new System.Drawing.Size(459, 370);
            this.productChart.TabIndex = 9;
            chartFont18.FontName = "Arial";
            chartFont18.Size = 12;
            chartFont18.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.productChart.Title.Font = chartFont18;
            chartFont19.FontName = "Arial";
            this.productChart.Tooltips.BodyFont = chartFont19;
            chartFont20.FontName = "Arial";
            chartFont20.Size = 9;
            chartFont20.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.productChart.Tooltips.TitleFont = chartFont20;
            this.productChart.XAxes.GridLines = grid7;
            chartFont21.FontName = "Arial";
            tick7.Font = chartFont21;
            this.productChart.XAxes.Ticks = tick7;
            this.productChart.YAxes.GridLines = grid8;
            chartFont22.FontName = "Arial";
            tick8.Font = chartFont22;
            this.productChart.YAxes.Ticks = tick8;
            this.productChart.ZAxes.GridLines = grid9;
            chartFont23.FontName = "Arial";
            pointLabel3.Font = chartFont23;
            this.productChart.ZAxes.PointLabels = pointLabel3;
            chartFont24.FontName = "Arial";
            tick9.Font = chartFont24;
            this.productChart.ZAxes.Ticks = tick9;
            // 
            // gunaDoughnutDataset1
            // 
            lPoint1.Label = "Caramel Frappuccino";
            lPoint1.Y = 15D;
            lPoint2.Label = "Apple Frappuccino";
            lPoint2.Y = 12D;
            lPoint3.Label = "Vanilla Frappuccino";
            lPoint3.Y = 9D;
            this.gunaDoughnutDataset1.DataPoints.AddRange(new Guna.Charts.WinForms.LPoint[] {
            lPoint1,
            lPoint2,
            lPoint3});
            this.gunaDoughnutDataset1.Label = "Doughnut1";
            this.gunaDoughnutDataset1.TargetChart = this.productChart;
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
            this.addBtn.Location = new System.Drawing.Point(1060, 598);
            this.addBtn.Name = "addBtn";
            this.addBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.addBtn.ShadowDecoration.Depth = 20;
            this.addBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.addBtn.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.addBtn.Size = new System.Drawing.Size(70, 70);
            this.addBtn.TabIndex = 16;
            this.addBtn.UseTransparentBackground = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Dash_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.prodDisplayPanel);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel6);
            this.Controls.Add(this.category_comboBx);
            this.Controls.Add(this.period_combobx);
            this.Controls.Add(this.label1);
            this.Name = "Dash_Prod";
            this.Size = new System.Drawing.Size(1171, 687);
            this.Load += new System.EventHandler(this.Dash_Prod_Load);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox period_combobx;
        private Guna.UI2.WinForms.Guna2ComboBox category_comboBx;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private System.Windows.Forms.Label prodNoVal;
        private System.Windows.Forms.Label noOfProd;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label highDemVal;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label totalAmtVal;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label6;
        private Guna.Charts.WinForms.GunaChart productChart;
        private Guna.Charts.WinForms.GunaDoughnutDataset gunaDoughnutDataset1;
        private Guna.UI2.WinForms.Guna2CircleButton addBtn;
        public System.Windows.Forms.FlowLayoutPanel prodDisplayPanel;
    }
}

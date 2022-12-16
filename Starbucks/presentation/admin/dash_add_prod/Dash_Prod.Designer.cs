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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.prod_sale_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.addBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prod_sale_chart)).BeginInit();
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
            this.highDemVal.Location = new System.Drawing.Point(194, 34);
            this.highDemVal.Name = "highDemVal";
            this.highDemVal.Size = new System.Drawing.Size(0, 25);
            this.highDemVal.TabIndex = 1;
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
            this.totalAmtVal.Location = new System.Drawing.Point(127, 34);
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
            this.guna2Panel3.Controls.Add(this.prod_sale_chart);
            this.guna2Panel3.Controls.Add(this.label6);
            this.guna2Panel3.Location = new System.Drawing.Point(573, 225);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(481, 443);
            this.guna2Panel3.TabIndex = 11;
            // 
            // prod_sale_chart
            // 
            this.prod_sale_chart.BackColor = System.Drawing.SystemColors.Control;
            this.prod_sale_chart.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.prod_sale_chart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.SystemColors.Control;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.prod_sale_chart.Legends.Add(legend1);
            this.prod_sale_chart.Location = new System.Drawing.Point(12, 58);
            this.prod_sale_chart.Name = "prod_sale_chart";
            series1.BorderColor = System.Drawing.SystemColors.Control;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.White;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.LabelForeColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "prod_sales";
            series1.ToolTip = "#LABEL";
            this.prod_sale_chart.Series.Add(series1);
            this.prod_sale_chart.Size = new System.Drawing.Size(447, 370);
            this.prod_sale_chart.TabIndex = 13;
            this.prod_sale_chart.GetToolTipText += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs>(this.prod_sale_chart_GetToolTipText);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Top Products";
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
            ((System.ComponentModel.ISupportInitialize)(this.prod_sale_chart)).EndInit();
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
        private Guna.UI2.WinForms.Guna2CircleButton addBtn;
        public System.Windows.Forms.FlowLayoutPanel prodDisplayPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart prod_sale_chart;
    }
}

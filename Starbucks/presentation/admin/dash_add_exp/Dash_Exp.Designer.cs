namespace Starbucks.presentation.admin.dash_add_exp
{
    partial class Dash_Exp
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
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.noExpVal = new System.Windows.Forms.Label();
            this.noOfExp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.highExpVal = new System.Windows.Forms.Label();
            this.highExp = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.totalExpVal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.expDisplayPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.exp_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.period_combobx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.addBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exp_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BorderRadius = 15;
            this.guna2Panel6.Controls.Add(this.noExpVal);
            this.guna2Panel6.Controls.Add(this.noOfExp);
            this.guna2Panel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.guna2Panel6.Location = new System.Drawing.Point(57, 89);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(253, 100);
            this.guna2Panel6.TabIndex = 6;
            // 
            // noExpVal
            // 
            this.noExpVal.AutoSize = true;
            this.noExpVal.BackColor = System.Drawing.Color.Transparent;
            this.noExpVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noExpVal.ForeColor = System.Drawing.SystemColors.Control;
            this.noExpVal.Location = new System.Drawing.Point(171, 34);
            this.noExpVal.Name = "noExpVal";
            this.noExpVal.Size = new System.Drawing.Size(24, 25);
            this.noExpVal.TabIndex = 1;
            this.noExpVal.Text = "0";
            // 
            // noOfExp
            // 
            this.noOfExp.AutoSize = true;
            this.noOfExp.BackColor = System.Drawing.Color.Transparent;
            this.noOfExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfExp.ForeColor = System.Drawing.SystemColors.Control;
            this.noOfExp.Location = new System.Drawing.Point(18, 24);
            this.noOfExp.Name = "noOfExp";
            this.noOfExp.Size = new System.Drawing.Size(111, 50);
            this.noOfExp.TabIndex = 0;
            this.noOfExp.Text = "Number of\r\nExpense\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "EXPENSES";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.highExpVal);
            this.guna2Panel1.Controls.Add(this.highExp);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Location = new System.Drawing.Point(413, 89);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(306, 100);
            this.guna2Panel1.TabIndex = 7;
            // 
            // highExpVal
            // 
            this.highExpVal.AutoSize = true;
            this.highExpVal.BackColor = System.Drawing.Color.Transparent;
            this.highExpVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highExpVal.ForeColor = System.Drawing.SystemColors.Control;
            this.highExpVal.Location = new System.Drawing.Point(202, 34);
            this.highExpVal.Name = "highExpVal";
            this.highExpVal.Size = new System.Drawing.Size(0, 25);
            this.highExpVal.TabIndex = 1;
            // 
            // highExp
            // 
            this.highExp.AutoSize = true;
            this.highExp.BackColor = System.Drawing.Color.Transparent;
            this.highExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highExp.ForeColor = System.Drawing.SystemColors.Control;
            this.highExp.Location = new System.Drawing.Point(18, 24);
            this.highExp.Name = "highExp";
            this.highExp.Size = new System.Drawing.Size(96, 50);
            this.highExp.TabIndex = 0;
            this.highExp.Text = "Highest \r\nExpense";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 15;
            this.guna2Panel2.Controls.Add(this.totalExpVal);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.guna2Panel2.Location = new System.Drawing.Point(811, 89);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(253, 100);
            this.guna2Panel2.TabIndex = 7;
            // 
            // totalExpVal
            // 
            this.totalExpVal.AutoSize = true;
            this.totalExpVal.BackColor = System.Drawing.Color.Transparent;
            this.totalExpVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalExpVal.ForeColor = System.Drawing.SystemColors.Control;
            this.totalExpVal.Location = new System.Drawing.Point(145, 34);
            this.totalExpVal.Name = "totalExpVal";
            this.totalExpVal.Size = new System.Drawing.Size(24, 25);
            this.totalExpVal.TabIndex = 1;
            this.totalExpVal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(18, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 50);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total\r\nExpenses";
            // 
            // expDisplayPanel
            // 
            this.expDisplayPanel.AutoScroll = true;
            this.expDisplayPanel.Location = new System.Drawing.Point(57, 211);
            this.expDisplayPanel.Name = "expDisplayPanel";
            this.expDisplayPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.expDisplayPanel.Size = new System.Drawing.Size(504, 443);
            this.expDisplayPanel.TabIndex = 8;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.guna2Panel3.BorderThickness = 3;
            this.guna2Panel3.Controls.Add(this.exp_chart);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Location = new System.Drawing.Point(583, 211);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(481, 443);
            this.guna2Panel3.TabIndex = 10;
            // 
            // exp_chart
            // 
            this.exp_chart.BackColor = System.Drawing.SystemColors.Control;
            this.exp_chart.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.exp_chart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.SystemColors.Control;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.exp_chart.Legends.Add(legend1);
            this.exp_chart.Location = new System.Drawing.Point(12, 57);
            this.exp_chart.Name = "exp_chart";
            series1.BorderColor = System.Drawing.SystemColors.Control;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.White;
            series1.IsXValueIndexed = true;
            series1.LabelForeColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "expenses";
            this.exp_chart.Series.Add(series1);
            this.exp_chart.Size = new System.Drawing.Size(447, 370);
            this.exp_chart.TabIndex = 12;
            this.exp_chart.GetToolTipText += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs>(this.exp_chart_GetToolTipText);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Expense Type";
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
            this.period_combobx.Location = new System.Drawing.Point(888, 28);
            this.period_combobx.Name = "period_combobx";
            this.period_combobx.Size = new System.Drawing.Size(166, 36);
            this.period_combobx.TabIndex = 11;
            this.period_combobx.SelectedIndexChanged += new System.EventHandler(this.period_combobx_SelectedIndexChanged);
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
            this.addBtn.Location = new System.Drawing.Point(1070, 584);
            this.addBtn.Name = "addBtn";
            this.addBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.addBtn.ShadowDecoration.Depth = 20;
            this.addBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.addBtn.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.addBtn.Size = new System.Drawing.Size(70, 70);
            this.addBtn.TabIndex = 12;
            this.addBtn.UseTransparentBackground = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Dash_Exp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.period_combobx);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.expDisplayPanel);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel6);
            this.Name = "Dash_Exp";
            this.Size = new System.Drawing.Size(1171, 687);
            this.Load += new System.EventHandler(this.Dash_Exp_Load);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exp_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private System.Windows.Forms.Label noExpVal;
        private System.Windows.Forms.Label noOfExp;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label highExpVal;
        private System.Windows.Forms.Label highExp;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label totalExpVal;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox period_combobx;
        private Guna.UI2.WinForms.Guna2CircleButton addBtn;
        public System.Windows.Forms.FlowLayoutPanel expDisplayPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart exp_chart;
    }
}

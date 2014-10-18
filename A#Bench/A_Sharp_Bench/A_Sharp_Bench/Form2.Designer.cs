namespace A_Sharp_Bench
{
    partial class Chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CPU_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Load_Chart_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // CPU_Chart
            // 
            this.CPU_Chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.CPU_Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CPU_Chart.Legends.Add(legend1);
            this.CPU_Chart.Location = new System.Drawing.Point(26, 28);
            this.CPU_Chart.Name = "CPU_Chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Time";
            this.CPU_Chart.Series.Add(series1);
            this.CPU_Chart.Size = new System.Drawing.Size(473, 334);
            this.CPU_Chart.TabIndex = 0;
            this.CPU_Chart.Text = "CPU_Chart";
            // 
            // Load_Chart_Button
            // 
            this.Load_Chart_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Load_Chart_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Load_Chart_Button.Location = new System.Drawing.Point(180, 392);
            this.Load_Chart_Button.Name = "Load_Chart_Button";
            this.Load_Chart_Button.Size = new System.Drawing.Size(144, 43);
            this.Load_Chart_Button.TabIndex = 1;
            this.Load_Chart_Button.Text = "Load Chart";
            this.Load_Chart_Button.UseVisualStyleBackColor = true;
            this.Load_Chart_Button.Click += new System.EventHandler(this.Load_Chart_Button_Click);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 457);
            this.Controls.Add(this.Load_Chart_Button);
            this.Controls.Add(this.CPU_Chart);
            this.Name = "Chart";
            this.Text = "Chart";
            ((System.ComponentModel.ISupportInitialize)(this.CPU_Chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart CPU_Chart;
        private System.Windows.Forms.Button Load_Chart_Button;
    }
}
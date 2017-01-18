namespace ProInvest
{
    partial class IrrChartForm
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IrrChartForm));
            this.IrrChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.IrrChart)).BeginInit();
            this.SuspendLayout();
            // 
            // IrrChart
            // 
            this.IrrChart.BackColor = System.Drawing.SystemColors.InactiveBorder;
            chartArea1.Name = "ChartArea1";
            this.IrrChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.IrrChart.Legends.Add(legend1);
            this.IrrChart.Location = new System.Drawing.Point(0, 0);
            this.IrrChart.Name = "IrrChart";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.DarkCyan;
            series1.Legend = "Legend1";
            series1.LegendText = "NPV";
            series1.Name = "Series1";
            this.IrrChart.Series.Add(series1);
            this.IrrChart.Size = new System.Drawing.Size(781, 552);
            this.IrrChart.TabIndex = 0;
            this.IrrChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Зависимость NPV от барьерной ставки";
            this.IrrChart.Titles.Add(title1);
            // 
            // IrrChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.IrrChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IrrChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "График определения внутренней нормы доходности";
            this.Load += new System.EventHandler(this.IrrChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IrrChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart IrrChart;

    }
}
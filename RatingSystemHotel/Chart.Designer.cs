
namespace RatingSystemHotel
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
            this.feedBackChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.feedBackChart)).BeginInit();
            this.SuspendLayout();
            // 
            // feedBackChart
            // 
            chartArea1.Name = "ChartArea1";
            this.feedBackChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.feedBackChart.Legends.Add(legend1);
            this.feedBackChart.Location = new System.Drawing.Point(57, 63);
            this.feedBackChart.Name = "feedBackChart";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Turquoise;
            series1.Legend = "Legend1";
            series1.Name = "Feedbacks";
            this.feedBackChart.Series.Add(series1);
            this.feedBackChart.Size = new System.Drawing.Size(1061, 602);
            this.feedBackChart.TabIndex = 0;
            this.feedBackChart.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 690);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 741);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.feedBackChart);
            this.MaximizeBox = false;
            this.Name = "Chart";
            this.Text = "Chart";
            ((System.ComponentModel.ISupportInitialize)(this.feedBackChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart feedBackChart;
        private System.Windows.Forms.Button button1;
    }
}

namespace RatingSystemHotel
{
    partial class MainPanelAdmin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.feedbackGrid = new System.Windows.Forms.DataGridView();
            this.btnImport = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.foodQualityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodQualityChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1191, 722);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLogOut);
            this.tabPage1.Controls.Add(this.btnSort);
            this.tabPage1.Controls.Add(this.btnGenerateReport);
            this.tabPage1.Controls.Add(this.feedbackGrid);
            this.tabPage1.Controls.Add(this.btnImport);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1183, 693);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AdminPanel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogOut.Location = new System.Drawing.Point(830, 579);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(200, 45);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSort.Location = new System.Drawing.Point(969, 69);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(150, 45);
            this.btnSort.TabIndex = 10;
            this.btnSort.Text = "Sort By Food Quality";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerateReport.Location = new System.Drawing.Point(494, 579);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(200, 45);
            this.btnGenerateReport.TabIndex = 9;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // feedbackGrid
            // 
            this.feedbackGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feedbackGrid.Location = new System.Drawing.Point(53, 140);
            this.feedbackGrid.Name = "feedbackGrid";
            this.feedbackGrid.RowHeadersWidth = 51;
            this.feedbackGrid.RowTemplate.Height = 24;
            this.feedbackGrid.Size = new System.Drawing.Size(1076, 381);
            this.feedbackGrid.TabIndex = 8;
            this.feedbackGrid.Tag = "Data Import";
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImport.Location = new System.Drawing.Point(147, 579);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(200, 45);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "Import From CSV";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Snow;
            this.tabPage2.Controls.Add(this.foodQualityChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1183, 693);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ChartPanel";
            // 
            // foodQualityChart
            // 
            chartArea1.Name = "ChartArea1";
            this.foodQualityChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.foodQualityChart.Legends.Add(legend1);
            this.foodQualityChart.Location = new System.Drawing.Point(38, 131);
            this.foodQualityChart.Name = "foodQualityChart";
            this.foodQualityChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Food Quality";
            this.foodQualityChart.Series.Add(series1);
            this.foodQualityChart.Size = new System.Drawing.Size(1110, 478);
            this.foodQualityChart.TabIndex = 13;
            this.foodQualityChart.Text = "chart1";
            // 
            // MainPanelAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 722);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainPanelAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPanelAdmin";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.feedbackGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foodQualityChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.DataGridView feedbackGrid;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart foodQualityChart;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}
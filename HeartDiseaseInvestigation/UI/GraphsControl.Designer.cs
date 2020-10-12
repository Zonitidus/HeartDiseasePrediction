namespace HeartDiseaseInvestigation.UI
{
    partial class GraphsControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gender_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.exang_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.fbs_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.age_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chol_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.gender_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exang_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbs_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chol_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // gender_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.gender_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.gender_chart.Legends.Add(legend1);
            this.gender_chart.Location = new System.Drawing.Point(3, 3);
            this.gender_chart.Name = "gender_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.gender_chart.Series.Add(series1);
            this.gender_chart.Size = new System.Drawing.Size(300, 300);
            this.gender_chart.TabIndex = 0;
            this.gender_chart.Text = "gender_chart";
            // 
            // exang_chart
            // 
            chartArea2.Name = "ChartArea1";
            this.exang_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.exang_chart.Legends.Add(legend2);
            this.exang_chart.Location = new System.Drawing.Point(309, 3);
            this.exang_chart.Name = "exang_chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.exang_chart.Series.Add(series2);
            this.exang_chart.Size = new System.Drawing.Size(300, 300);
            this.exang_chart.TabIndex = 1;
            this.exang_chart.Text = "exang_chart";
            // 
            // fbs_chart
            // 
            chartArea3.Name = "ChartArea1";
            this.fbs_chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.fbs_chart.Legends.Add(legend3);
            this.fbs_chart.Location = new System.Drawing.Point(615, 3);
            this.fbs_chart.Name = "fbs_chart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.fbs_chart.Series.Add(series3);
            this.fbs_chart.Size = new System.Drawing.Size(300, 300);
            this.fbs_chart.TabIndex = 2;
            this.fbs_chart.Text = "fbs_chart";
            // 
            // age_chart
            // 
            chartArea4.Name = "ChartArea1";
            this.age_chart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.age_chart.Legends.Add(legend4);
            this.age_chart.Location = new System.Drawing.Point(3, 309);
            this.age_chart.Name = "age_chart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.age_chart.Series.Add(series4);
            this.age_chart.Size = new System.Drawing.Size(300, 300);
            this.age_chart.TabIndex = 3;
            this.age_chart.Text = "age_chart";
            // 
            // chol_chart
            // 
            chartArea5.Name = "ChartArea1";
            this.chol_chart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chol_chart.Legends.Add(legend5);
            this.chol_chart.Location = new System.Drawing.Point(309, 309);
            this.chol_chart.Name = "chol_chart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chol_chart.Series.Add(series5);
            this.chol_chart.Size = new System.Drawing.Size(300, 300);
            this.chol_chart.TabIndex = 4;
            this.chol_chart.Text = "chol_chart";
            // 
            // GraphsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chol_chart);
            this.Controls.Add(this.age_chart);
            this.Controls.Add(this.fbs_chart);
            this.Controls.Add(this.exang_chart);
            this.Controls.Add(this.gender_chart);
            this.Name = "GraphsControl";
            this.Size = new System.Drawing.Size(919, 617);
            ((System.ComponentModel.ISupportInitialize)(this.gender_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exang_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbs_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chol_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart gender_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart exang_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart fbs_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart age_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chol_chart;
    }
}

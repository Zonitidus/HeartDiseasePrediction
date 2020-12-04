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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gender_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.exang_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.fbs_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.age_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chol_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gender_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exang_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbs_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chol_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // gender_chart
            // 
            chartArea11.Name = "ChartArea1";
            this.gender_chart.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.gender_chart.Legends.Add(legend11);
            this.gender_chart.Location = new System.Drawing.Point(3, 3);
            this.gender_chart.Name = "gender_chart";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.gender_chart.Series.Add(series11);
            this.gender_chart.Size = new System.Drawing.Size(300, 300);
            this.gender_chart.TabIndex = 0;
            this.gender_chart.Text = "gender_chart";
            // 
            // exang_chart
            // 
            chartArea12.Name = "ChartArea1";
            this.exang_chart.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.exang_chart.Legends.Add(legend12);
            this.exang_chart.Location = new System.Drawing.Point(309, 3);
            this.exang_chart.Name = "exang_chart";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.exang_chart.Series.Add(series12);
            this.exang_chart.Size = new System.Drawing.Size(300, 300);
            this.exang_chart.TabIndex = 1;
            this.exang_chart.Text = "exang_chart";
            // 
            // fbs_chart
            // 
            chartArea13.Name = "ChartArea1";
            this.fbs_chart.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.fbs_chart.Legends.Add(legend13);
            this.fbs_chart.Location = new System.Drawing.Point(615, 3);
            this.fbs_chart.Name = "fbs_chart";
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.fbs_chart.Series.Add(series13);
            this.fbs_chart.Size = new System.Drawing.Size(300, 300);
            this.fbs_chart.TabIndex = 2;
            this.fbs_chart.Text = "fbs_chart";
            // 
            // age_chart
            // 
            chartArea14.Name = "ChartArea1";
            this.age_chart.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.age_chart.Legends.Add(legend14);
            this.age_chart.Location = new System.Drawing.Point(921, 3);
            this.age_chart.Name = "age_chart";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.age_chart.Series.Add(series14);
            this.age_chart.Size = new System.Drawing.Size(300, 300);
            this.age_chart.TabIndex = 3;
            this.age_chart.Text = "age_chart";
            // 
            // chol_chart
            // 
            chartArea15.Name = "ChartArea1";
            this.chol_chart.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.chol_chart.Legends.Add(legend15);
            this.chol_chart.Location = new System.Drawing.Point(1227, 3);
            this.chol_chart.Name = "chol_chart";
            series15.ChartArea = "ChartArea1";
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            this.chol_chart.Series.Add(series15);
            this.chol_chart.Size = new System.Drawing.Size(300, 300);
            this.chol_chart.TabIndex = 4;
            this.chol_chart.Text = "chol_chart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(729, 70);
            this.label1.TabIndex = 5;
            this.label1.Text = "Graphs from the Dataset";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(325, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(887, 10);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(377, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(779, 10);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // GraphsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chol_chart);
            this.Controls.Add(this.age_chart);
            this.Controls.Add(this.fbs_chart);
            this.Controls.Add(this.exang_chart);
            this.Controls.Add(this.gender_chart);
            this.Name = "GraphsControl";
            this.Size = new System.Drawing.Size(1536, 617);
            ((System.ComponentModel.ISupportInitialize)(this.gender_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exang_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbs_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chol_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart gender_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart exang_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart fbs_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart age_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chol_chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}

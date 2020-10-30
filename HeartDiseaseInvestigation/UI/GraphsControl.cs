using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeartDiseaseInvestigation.Model;

namespace HeartDiseaseInvestigation.UI
{
    public partial class GraphsControl : UserControl
    {
        DataManager dm = new DataManager();
        public DataTable dt = new DataTable();
        public GraphsControl()
        {
            InitializeComponent();
            dt = dm.LoadCSV();
            DrawPieChart(dm.CreateDataToCharts(dt, "sex"));
            DrawPieChartExang(dm.CreateDataToCharts(dt, "exang"));
            DrawBarsChartFBS(dm.CreateDataToCharts(dt, "fbs"));
            DrawBarsChartAge(dm.CreateDataToBarAgeChart(dt, "age"));
            DrawBarsChartChol(dm.CreateDataToBarAgeChart(dt, "chol"));
        }

        private void DrawPieChart(Dictionary<string, int> dictValuesChart)
        {
            gender_chart.Titles.Add("Sex of persons that suffer hearth disease             (1 = male; 0 = female) ");
            gender_chart.Series["Series1"].IsValueShownAsLabel = true;

            foreach (KeyValuePair<string, int> item in dictValuesChart)
            {
                gender_chart.Series["Series1"].Points.AddXY(item.Key, item.Value);
            }
        }

        private void DrawPieChartExang(Dictionary<string, int> dictValuesChart)
        {
            exang_chart.Titles.Add("Exercise induced angina                                  (1 = yes; 0 = no) ");
            exang_chart.Series["Series1"].IsValueShownAsLabel = true;

            foreach (KeyValuePair<string, int> item in dictValuesChart)
            {
                exang_chart.Series["Series1"].Points.AddXY(item.Key, item.Value);
            }
        }

        private void DrawBarsChartFBS(Dictionary<string, int> dictValuesChart)
        {
            fbs_chart.Titles.Add("Fasting blood sugar &gt; 120 mg/dl          (1 = true; 0 = false) ");

            var list = dictValuesChart.Keys.ToList();
            list.Sort();

            foreach (var key in list)
            {
                fbs_chart.Series["Series1"].Points.AddXY(key, dictValuesChart[key]);
            }
        }

        private void DrawBarsChartAge(Dictionary<string, int> dictValuesChart)
        {
            age_chart.Titles.Add("Age in years");
            var list = dictValuesChart.Keys.ToList();
            list.Sort();

            Console.WriteLine(list.Count());

            foreach (var key in list)
            {
                age_chart.Series["Series1"].Points.AddXY(key, dictValuesChart[key]);
            }
        }


        private void DrawBarsChartChol(Dictionary<string, int> dictValuesChart)
        {
            chol_chart.Titles.Add("Serum cholestoral in mg/dl ");
            var list = dictValuesChart.Keys.ToList();
            list.Sort();

            Console.WriteLine(list.Count());

            foreach (var key in list)
            {
                chol_chart.Series["Series1"].Points.AddXY(key, dictValuesChart[key]);
            }
        }


        private void exang_chart_Click(object sender, EventArgs e)
        {

        }

        private void fbs_chart_Click(object sender, EventArgs e)
        {

        }

        private void age_chart_Click(object sender, EventArgs e)
        {

        }

        private void chol_chart_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

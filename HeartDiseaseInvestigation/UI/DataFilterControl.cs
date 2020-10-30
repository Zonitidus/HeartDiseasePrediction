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
    public partial class DataFilterControl : UserControl
    {
        public DataTable dt = new DataTable();
        DataManager dm = new DataManager();

        public DataFilterControl()
        {
            InitializeComponent();
            LoadDt();
        }

        private void LoadDt()
        {
            dt = dm.LoadCSV();
            dm.fillComboBox(comboBoxHeartData);
            heartDataTable.DataSource = dt;
        }

        private void addfilterButton_Click(object sender, EventArgs e)
        {
            dm.addFilter(filtersLabel, textBox1, textBox2, comboBoxHeartData);
        }

        private void filter_Click(object sender, EventArgs e)
        {
            try
            {
                dm.Filter(dt);
            }
            catch (Exception)
            {
                MessageBox.Show("Please add a filter", "Error", MessageBoxButtons.OK);
            }
        }

        private void buttonResetFilters_Click(object sender, EventArgs e)
        {
            dm.resetFilters(filtersLabel, dt);
        }

        private void showGraphsButton_Click(object sender, EventArgs e)
        {
            Graphs gp = new Graphs();
            gp.Show();
        }
    }

}

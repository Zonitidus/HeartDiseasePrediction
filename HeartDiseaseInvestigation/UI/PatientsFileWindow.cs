using HeartDiseaseInvestigation.Model;
using HeartDiseaseInvestigation.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartDiseaseInvestigation
{

    public partial class PatientsFileWindow : Form
    {
        public DataTable dt = new DataTable();
        DataManager dm = new DataManager();

        public PatientsFileWindow()
        {
            InitializeComponent();
            LoadDt();
        }


        //this method load the csv and load this data into a dataTable
        private void LoadDt()
        {
            dt = dm.LoadCSV(comboBoxHeartData);
            heartDataTable.DataSource = dt;
        }

        private void filter_Click(object sender, EventArgs e)
        {
            dm.Filter(dt, comboBoxHeartData, textBox1, textBox2);
        }

        private void showGraphsBttn_Click(object sender, EventArgs e)
        {
            Graphs gp = new Graphs();
            gp.Show();
        }
    }
}

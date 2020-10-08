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
    
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            loadDt();
        }

        //this method load the csv and load this data into a dataTable
        private void loadDt()
        {
            dt.Clear();
            string dir = "../../Data/heart.csv";
            if (File.Exists(dir))
            {

                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(dir);
                string[] columns = lines[0].Split(',');

                for (int i = 0; i < columns.Length; i++)
                {
                    dt.Columns.Add(columns[i]);
                    comboBoxHeartData.Items.Add(columns[i]);
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    //split the line by ","
                    string[] aux = lines[i].Split(',');
                    dt.Rows.Add(aux);
                }
            }
            heartDataTable.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void filter_Click(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = comboBoxHeartData.Text + " >= " + "'" + textBox1.Text + "'" + " AND " + comboBoxHeartData.Text + " <= " + "'" + textBox2.Text + "'";
        }
    }
}

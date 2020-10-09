using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartDiseaseInvestigation.Model
{
    class DataManager
    {
        public DataManager()
        {

        }

        public void filter(DataTable dt, ComboBox cb, TextBox tb1, TextBox tb2)
        {
            dt.DefaultView.RowFilter = cb.Text + " >= " + "'" + tb1.Text + "'" + " AND " + cb.Text + " <= " + "'" + tb2.Text + "'";
        }

        public DataTable loadCSV(ComboBox cb)
        {
            DataTable dt = new DataTable();
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
                    cb.Items.Add(columns[i]);
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    //split the line by ","
                    string[] aux = lines[i].Split(',');
                    dt.Rows.Add(aux);
                }
            }
            return dt;
        }
    }
}

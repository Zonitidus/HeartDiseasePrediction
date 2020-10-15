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
        private Dictionary<String, Patient> dataSetPatients { get; set; }
        private Dictionary<String, Patient> classifiedPatients { get; set; }

        List<string> listFilters = new List<string>();

        //Class constructor
        public DataManager()
        {
            this.dataSetPatients = new Dictionary<String, Patient>();
            this.classifiedPatients = new Dictionary<string, Patient>();
        }

        //This method filters the data
        public void Filter(DataTable dt)
        {
            //dt.DefaultView.RowFilter = 
            string aux = "";
            for(int i = 0; i < listFilters.Count()-1; i++)
            {
                aux = aux + listFilters[i] + " AND ";
            }
            aux = aux + listFilters[listFilters.Count-1];
            dt.DefaultView.RowFilter = aux;
        }

        public void addFilter(Label l, TextBox tb1, TextBox tb2, ComboBox cb)
        {
            
            if (tb2.Text.Equals(""))
            {
                listFilters.Add(cb.Text + " = " + "'" + tb1.Text + "'");
                l.Text = l.Text + "\n" + cb.Text + ": " + tb1.Text;
            }
            else
            {
                listFilters.Add(cb.Text + " >= " + "'" + tb1.Text + "'" + " AND " + cb.Text + " <= " + "'" + tb2.Text + "'");
                l.Text = l.Text + "\n" + cb.Text + ": " + tb1.Text + "-" + tb2.Text;
            }
            
            tb1.Text = "";
            tb2.Text = "";
        }

        public void resetFilters(Label l, DataTable dt)
        {
            l.Text = "Filters:";
            listFilters.Clear();
            dt.DefaultView.RowFilter = "sex <> '-1'";
        }

        //This method loads the CSV file into de data table
        public DataTable LoadCSV(ComboBox cb)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            string dir = "../../Data/heart.csv";
            if (File.Exists(dir))
            {

                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(dir);
                string[] columns = lines[0].Split(',');

                //This for adds the columns on the data table and adds all the categories that can be filtered on the combo box
                for (int i = 0; i < columns.Length; i++)
                {
                    dt.Columns.Add(columns[i]);
                    cb.Items.Add(columns[i]);
                }

                //This for adds the rows to the data table
                for (int i = 1; i < lines.Length; i++)
                {
                    //split the line by ","
                    string[] aux = lines[i].Split(',');
                    AddPatient(aux, i);
                    dt.Rows.Add(aux);
                }
            }

            return dt;
        }

        private void AddPatient(String[] attributes, int id)
        {
            int[] cAtt = new int[attributes.Length];

            for (int i = 0; i < attributes.Length; i++)
            {
                if (i != 9)
                {
                    cAtt[i] = Convert.ToInt32(attributes[i]);
                }
            }


            Patient p = new Patient(id+"",cAtt[0], cAtt[1], cAtt[2], cAtt[3], cAtt[4], cAtt[5], cAtt[6], cAtt[7], 
                cAtt[8], Convert.ToDouble(attributes[9]), cAtt[10], cAtt[11], cAtt[12], cAtt[13]);

            dataSetPatients.Add(id+"",p);
        }

        public void AddPatient(string id, int age, int sex, int cp, int trestbps, int chol, int fbs, int restecg, int thalach, int exang, double oldpeak, int slope, int ca, int thal, int target)
        {
            Patient p = new Patient(id, age, sex, cp, trestbps, chol, fbs, restecg, thalach, exang, oldpeak, slope, ca, thal, target);

            this.classifiedPatients.Add(id, p);
        }

    }
}

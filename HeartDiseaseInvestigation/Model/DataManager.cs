using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using HeartDiseaseInvestigation.DecisionTreeClassifier;

namespace HeartDiseaseInvestigation.Model
{
    public class DataManager
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

        public Dictionary<string, int> CreateDataToCharts(DataTable dt, String nameCol)
        {
            Dictionary<string, int> dictNumberTypeAccidents = new Dictionary<string, int>();
            DataRow[] foundRows = dt.Select();


            foreach (DataRow row in dt.Rows)
            {
                if (!row.Equals("") && !dictNumberTypeAccidents.ContainsKey(row[nameCol].ToString()))
                {
                    dictNumberTypeAccidents.Add(row[nameCol].ToString(), 1);
                }
                else if (dictNumberTypeAccidents.ContainsKey(row[nameCol].ToString()))
                {
                    dictNumberTypeAccidents[row[nameCol].ToString()] = dictNumberTypeAccidents[row[nameCol].ToString()] + 1;
                }
                else
                {
                    Console.WriteLine("Bad type accident format");
                }
            }

            return dictNumberTypeAccidents;
        }


        public Dictionary<string, int> CreateDataToBarAgeChart(DataTable dt, String nameCol)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            DataRow[] foundRows = dt.Select();


            foreach (DataRow row in dt.Rows)
            {
                int number = Int32.Parse(row[nameCol].ToString());

                String nameMethodInterval = nameCol.Equals("age") ? setIntervalAge(number) : setIntervalChol(number);

                if (!row.Equals(""))
                {
                    if (!dict.ContainsKey(nameMethodInterval))
                    {
                        dict.Add(nameMethodInterval, 1);
                    }
                    else if (dict.ContainsKey(nameMethodInterval))
                    {
                        dict[nameMethodInterval] = dict[nameMethodInterval] + 1;
                    }
                }
            }

            Console.WriteLine(dict.Count());
            return dict;
        }

        private String setIntervalAge(int number)
        {

            if (number >= 28 && number <= 35)
            {
                return "28-35";
            }
            else if (number >= 36 && number <= 43)
            {
                return "36-43";
            }
            else if (number >= 44 && number <= 51)
            {
                return "44-51";
            }
            else if (number >= 52 && number <= 59)
            {
                return "52-59";
            }
            else if (number >= 60 && number <= 67)
            {
                return "60-67";
            }
            else if (number >= 68 && number <= 75)
            {
                return "68-75";
            }
            else if (number >= 76 && number <= 83)
            {
                return "76-83";
            }
            else
            {
                return "";
            }
        }

        private String setIntervalChol(float number)
        {

            if (number >= 126.00 && number <= 169.80)
            {
                return "126.00-169.80";
            }
            else if (number >= 169.81 && number <= 213.60)
            {
                return "169.81-213.60";
            }
            else if (number >= 213.61 && number <= 257.40)
            {
                return "213.61-257.40";
            }
            else if (number >= 257.41 && number <= 301.20)
            {
                return "257.41-301.20";
            }
            else if (number >= 301.20 && number <= 345.00)
            {
                return "301.20-345.00";
            }
            else if (number >= 345.01 && number <= 388.80)
            {
                return "345.01-388.80";
            }
            else if (number >= 388.81 && number <= 432.60)
            {
                return "388.81-432.60";
            }
            else
            {
                return "> 432.60";
            }
        }
        /*
        public static List<T> ConvertRowsToList<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
        */
        private Patient CreatePatient(string id, int age, int sex, int cp, int trestbps, int chol, int fbs, int restecg, int thalach, int exang, double oldpeak, int slope, int ca, int thal, int target) {
            Patient p = new Patient(id, age, sex, cp, trestbps, chol, fbs, restecg, thalach, exang, oldpeak, slope, ca, thal, target);
            return p;
        }
        public String tasGordo(string id, int age, int sex, int cp, int trestbps, int chol, int fbs, int restecg, int thalach, int exang, double oldpeak, int slope, int ca, int thal, int target) {
            string value = "";
            List<Patient> tmpList = new List<Patient>(dataSetPatients.Keys.Count);
            DecisionTree<Patient> treeds = new DecisionTree<Patient>(dataSetPatients);
            
            Node<Patient> treeToUse = treeds.BuildTree(tmpList);
            Patient newPatient = CreatePatient(id, age, sex, cp, trestbps, chol, fbs, restecg, thalach, exang, oldpeak, slope, ca, thal, target);
            Dictionary<String, Int32>  resul = treeds.Classify(newPatient, treeToUse);
            foreach (KeyValuePair<String, Int32> key in resul) {
                value += key.Key + " " + key.Value;
            }
            return value;
        }

    }
}

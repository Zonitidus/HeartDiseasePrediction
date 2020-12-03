using HeartDiseaseInvestigation.DecisionTreeClassifier;
using HeartDiseaseInvestigation.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartDiseaseInvestigation.ExperimentData
{
    public class Experiment
    {

        private int[] case1 = { 250, 10 };
        private int[] case2 = { 250, 20 };
        private int[] case3 = { 250, 30 };
        private int[] case4 = { 200, 10 };
        private int[] case5 = { 200, 20 };
        private int[] case6 = { 200, 30 };
        private int[] case7 = { 150, 10 };
        private int[] case8 = { 150, 20 };
        private int[] case9 = { 150, 30 };

        private List<Int32[]> Cases;

        private Dictionary<String, Double> results = new Dictionary<string, double>();

        private Dictionary<String, Patient> dataSetPatients { get; set; }
        private Dictionary<String, Patient> classifiedPatients { get; set; }


        public Experiment()
        {
            this.Cases = new List<int[]>();

            this.Cases.Add(case1);
            this.Cases.Add(case2);
            this.Cases.Add(case3);
            this.Cases.Add(case4);
            this.Cases.Add(case5);
            this.Cases.Add(case6);
            this.Cases.Add(case7);
            this.Cases.Add(case8);
            this.Cases.Add(case9);

            this.dataSetPatients = new Dictionary<string, Patient>();
            this.classifiedPatients = new Dictionary<string, Patient>();
        }

        public void RunExperiment()
        {
            
            foreach(Int32[] cas in this.Cases)
            {
                for (int i = 1; i <= 3; i++)
                {
                    this.RunCase(cas, i);
                }
            }

            MessageBox.Show("Done.", "Experiment conluded");

            this.ConvertToCSV();
        }

        public void RunCase(int[] cases, int rep)
        {
            this.dataSetPatients = new Dictionary<string, Patient>();
            this.classifiedPatients = new Dictionary<string, Patient>();

            this.LoadCSV(cases[0]);

            Console.WriteLine("EEEEEEEEEEEEEEEEEEEEEEY ---> "+this.dataSetPatients.Count);

            Dictionary<String, Patient> trainData = this.dataSetPatients;

            DecisionTree<Patient> destree = new DecisionTree<Patient>(trainData);

            List<Patient> rows = new List<Patient>();

            foreach (String k in trainData.Keys)
            {
                rows.Add(trainData[k]);
            }

            Node<Patient> t = destree.BuildTree(rows);
            
            this.LoadCSVTest(cases[1]);
            Console.WriteLine("EEEEEEEEEEEEEEEEEEEEEEY ---> " + this.classifiedPatients.Count);

            Dictionary<String, Patient> test = this.classifiedPatients;

            List<String> classification = new List<string>();

            double correct = 0;
            double total = 0;

            foreach (String k in test.Keys)
            {

                String a = test[k].getAttributes()[test[k].getAttributes().Length - 1];
                String b = destree.PrintLeaf(destree.Classify(test[k], t))[1];

                if (a.Equals(b))
                    correct++;

                total++;

            }

            double accurracy = (correct / total);

            String key = "["+cases[0]+","+cases[1]+"] Rep: "+rep;

            this.results[key] = accurracy;
        }

        public DataTable LoadCSV(int training)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            string dir = "../../Data/ExperimentData.csv";
            if (File.Exists(dir))
            {

                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(dir);
                string[] columns = lines[0].Split(',');

                //This for adds the columns on the data table and adds all the categories that can be filtered on the combo box


                for (int i = 0; i < columns.Length; i++)
                {
                    dt.Columns.Add(columns[i]);
                }

                //This for adds the rows to the data table
                for (int i = 1; i < lines.Length && i <= training; i++)
                {
                    string[] aux = lines[i].Split(',');
                    AddPatient(aux, i);
                    dt.Rows.Add(aux);
                }
            }
            else {

                Console.WriteLine("GET A LOAD OF THIS DOUCHEBAG XDDDDDDDDDDDDDDDDDD 11111");
            }

            return dt;
        }

        public DataTable LoadCSVTest(int test)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            string dir = "../../Data/ExperimentTest.csv";
            if (File.Exists(dir))
            {
                Console.WriteLine("Biem");
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(dir);
                string[] columns = lines[0].Split(',');

                //This for adds the columns on the data table and adds all the categories that can be filtered on the combo box
                for (int i = 0; i < columns.Length; i++)
                {
                    dt.Columns.Add(columns[i]);
                }

                //This for adds the rows to the data table
                for (int i = 1; i < lines.Length && i <= test; i++)
                {
                    //split the line by ","
                    string[] aux = lines[i].Split(',');
                    addTestData(aux, i);
                    dt.Rows.Add(aux);
                }
            }
            else
            {
                Console.WriteLine("GET A LOAD OF THIS DOUCHEBAG XDDDDDDDDDDDDDDDDDD 222222");
            }

            return dt;
        }

        private void addTestData(String[] attributes, int id)
        {
            int[] cAtt = new int[attributes.Length];

            for (int i = 0; i < attributes.Length; i++)
            {
                if (i != 9)
                {
                    cAtt[i] = Convert.ToInt32(attributes[i]);
                }
            }

            AddPatient(id + "", cAtt[0], cAtt[1], cAtt[2], cAtt[3], cAtt[4], cAtt[5], cAtt[6], cAtt[7],
                cAtt[8], Convert.ToDouble(attributes[9]), cAtt[10], cAtt[11], cAtt[12], cAtt[13]);
        }

        public void AddPatient(string id, int age, int sex, int cp, int trestbps, int chol, int fbs, int restecg, int thalach, int exang, double oldpeak, int slope, int ca, int thal, int target)
        {
            Patient p = new Patient(id, age, sex, cp, trestbps, chol, fbs, restecg, thalach, exang, oldpeak, slope, ca, thal, target);

            this.classifiedPatients.Add(id, p);
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


            Patient p = new Patient(id + "", cAtt[0], cAtt[1], cAtt[2], cAtt[3], cAtt[4], cAtt[5], cAtt[6], cAtt[7],
                cAtt[8], Convert.ToDouble(attributes[9]), cAtt[10], cAtt[11], cAtt[12], cAtt[13]);

            dataSetPatients.Add(id + "", p);
        }

        public void ConvertToCSV()
        {
            String res = String.Join(
                Environment.NewLine,
                this.results.Select(d => $"{d.Key};{string.Join(";", d.Value)}")
            );
            System.IO.File.WriteAllText("../../Data/ExperimentResults.csv", res);
        }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeartDiseaseInvestigation.DecisionTreeClassifier;
using HeartDiseaseInvestigation.Model;

namespace HeartDiseaseInvestigation.UI
{
    public partial class TreeWindow : Form
    {

        private DataManager dataManager;

        public TreeWindow()
        {
            InitializeComponent();
            dataManager = new DataManager();
        }

        public void InitializeTree()
        {
            dataManager.LoadCSV();

            Dictionary<String, Patient> trainData = dataManager.GetPatients();

            DecisionTree<Patient> destree = new DecisionTree<Patient>(trainData);

            List<Patient> rows = new List<Patient>();

            foreach (String k in trainData.Keys)
            {
                rows.Add(trainData[k]);
            }

            Node<Patient> t = destree.BuildTree(rows);
            
        }
    }
}

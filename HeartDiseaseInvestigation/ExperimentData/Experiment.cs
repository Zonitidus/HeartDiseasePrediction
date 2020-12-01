using HeartDiseaseInvestigation.DecisionTreeClassifier;
using HeartDiseaseInvestigation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private Dictionary<String, Double> results = new Dictionary<string, double>();

        private Node<Patient> root;
        private DecisionTree<Patient> tree;

        public Experiment(DecisionTree<Patient> tree, Node<Patient> root)
        {
            this.tree = tree;
            this.root = root;
        }

        public void RunExperiment()
        {

        }


        public void RunCase(int[] cases)
        {
            
        }

        public void ConvertToCSV()
        {
            String res = String.Join(
                Environment.NewLine,
                this.results.Select(d => $"{d.Key};{string.Join(";", d.Value)}")
            );
            System.IO.File.WriteAllText("../ExperimentResults.csv", res);
        }

    }
}
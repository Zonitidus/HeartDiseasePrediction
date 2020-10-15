using HeartDiseaseInvestigation.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartDiseaseInvestigation.DecisionTreeClassifier
{
    class DecisionTree<T> where T: DatasetRow
    {
        private Node root { get; set; }
        private DataTable dataset { get; set; }
        private Dictionary<String, T> datasetDictionary { get; set; }
        private Dictionary<String, Int32> labelDistribution { get; set; }

        public DecisionTree(Dictionary<String, T> dataset)
        {
            this.datasetDictionary = dataset;
            CountLabelDistribution();
        }

        private void CountLabelDistribution()
        {
            Dictionary<String, Int32> distribution = new Dictionary<String, Int32>();

            foreach (String row in datasetDictionary.Keys)
            {
                String[] attributes = datasetDictionary[row].getAttributes();

                String label = attributes[attributes.Length - 1];

                if (distribution.Keys.Contains(label))
                {
                    distribution[label] +=1;
                }
                else
                {
                    distribution.Add(label, 0);
                }

            }

            this.labelDistribution = distribution;
        }
    }
}

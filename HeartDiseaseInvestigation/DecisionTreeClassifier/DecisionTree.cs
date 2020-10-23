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
        private Dictionary<String, T> dataDic { get; set; }

        public DecisionTree()
        {

        }

        private Dictionary<String, Int32> CountLabelDistribution()
        {
            Dictionary<String, Int32> distribution = new Dictionary<String, Int32>();

            foreach (String row in dataDic.Keys)
            {
                String[] attributes = dataDic[row].getAttributes();

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

            return distribution;
        }
    }
}

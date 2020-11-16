using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartDiseaseInvestigation.DecisionTreeClassifier
{
    public class Node<T> where T: DatasetRow
    {
        private Query<T> query;
        private Node<T> trueNode;
        private Node<T> falseNode;

        private Dictionary<String, Int32> labelCount;

        public Node(Query<T> query, Node<T> trueNode, Node<T> falseNode)
        {
            this.query = query;
            this.trueNode = trueNode;
            this.falseNode = falseNode;
        }

        public Node(Dictionary<String, Int32> labelCount)
        {
            this.labelCount = labelCount;
        }

        public Query<T> GetQuery()
        {
            return this.query;
        }

        public Node<T> GetTrueNode()
        {
            return this.trueNode;
        }
        public Node<T> GetFalseNode()
        {
            return this.falseNode;
        }

        public Dictionary<String, Int32> GetPredictions()
        {
            return this.labelCount;
        }

        public String ToString()
        {
            String r = query.ToString()+"\n";

            if(this.labelCount != null)
            {

                int total = 0;

                foreach(String key in this.labelCount.Keys)
                {
                    total+= this.labelCount[key];
                }

                foreach (String key in this.labelCount.Keys)
                {
                    double a = Convert.ToDouble(this.labelCount[key]) / Convert.ToDouble(total);

                   r += key+" "+a+"%\n";
                }
            }

            return r;
        }
    }
}

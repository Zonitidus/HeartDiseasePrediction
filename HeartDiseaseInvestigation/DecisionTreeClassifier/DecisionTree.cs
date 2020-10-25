using HeartDiseaseInvestigation.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartDiseaseInvestigation.DecisionTreeClassifier
{
    class DecisionTree<T> where T: DatasetRow
    {
        private Node<T> root { get; set; }
        private DataTable dataset { get; set; }
        private Dictionary<String, T> datasetDictionary { get; set; }

        public DecisionTree(Dictionary<String, T> dataset)
        {
            this.datasetDictionary = dataset;
        }

        private Dictionary<String, Int32> CountLabelDistribution(List<T> rows)
        {
            Dictionary<String, Int32> distribution = new Dictionary<String, Int32>();

            foreach (T row in rows)
            {
                String[] attributes = row.getAttributes();

                //We supose that the last attribute it's our label.
                String label = attributes[attributes.Length - 1];

                if (distribution.Keys.Contains(label))
                {
                    distribution[label] +=1; //Que hace aqui?
                }
                else
                {
                    distribution.Add(label, 0);
                }

            }

            return distribution;
        }

        public List<T>[] Partition(List<T> rows, Query<T> query)
        {
            List<T>[] partition = {new List<T>(), new List<T>()};

            foreach (T row in rows)
            {
                if (query.Compare(row))//explicar que significa este if
                {
                    partition[0].Add(row);
                }
                else
                {
                    partition[1].Add(row);
                }
            }

            return partition;
        }

        public double Gini(List<T> rows)
        {
            double impurity = 1;

            Dictionary<String, Int32> distribution = this.CountLabelDistribution(rows);

            foreach (String label in distribution.Keys)
            {
                double prob = distribution[label] / rows.Count;
                impurity -= Math.Pow(prob, 2) ;
            }

            return impurity;
        }

        public double InformationGain(List<T> left, List<T> right, double impurity)
        {

            double proportion = Convert.ToDouble(left.Count) / (Convert.ToDouble(left.Count) + Convert.ToDouble(right.Count));

            return impurity - proportion * this.Gini(left) - (1 - proportion) * this.Gini(right);
        }

        public OptimalSolution<T> FindBestPartition(List<T> rows) //Esto que hace? Es la mejor pregunta?Esto en si que es lo que retorna?El pedacito de arbol y abajo lo va construyendo?
        {
            OptimalSolution<T> solution = new OptimalSolution<T>();
            double bestGain = 0;
            Query<T> bestQuery = null;
            double currentImpurity = this.Gini(rows);

            int attributesN = rows.ElementAt(0).getAttributes().Length;

            for(int i = 0; i < attributesN; i++)
            {
                List<String> attributesValue = new List<string>();

                foreach (T row in rows)
                {
                    String value = row.getAttributes()[i];

                    foreach(String val in attributesValue)
                    {
                        Query<T> query = new Query<T>(i, val); //para que sirve el val? Y porque 0? //TODOS LOS QUERY DEBERIAN SER I

                        List<T>[] partition = this.Partition(rows, query);//

                        if (partition[0].Count > 0 && partition[1].Count > 0) //
                        {

                            double gain = InformationGain(partition[0], partition[1], currentImpurity);

                            if(gain >= bestGain)
                            {
                                bestGain = gain;
                                bestQuery = query;

                                solution.SetGain(gain);
                                solution.SetQuery(query);
                            }

                        }
                    }


                }
            }

            return solution;
        }

        public Node<T> BuildTree(List<T> rows)
        {
            OptimalSolution<T> solution = this.FindBestPartition(rows);

            if(solution.GetGain() == 0)
            {
                return new Node<T>(this.CountLabelDistribution(rows));
            }
            List<T>[] partition = this.Partition(rows, solution.GetQuery());

            Node<T> trueBranch = BuildTree(partition[0]);
            Node<T> falseBranch = BuildTree(partition[1]);

            return new Node<T>(solution.GetQuery(), trueBranch, falseBranch);
        }


        public Dictionary<String, Int32> Classify(T row, Node<T> node) {

            if (node.GetPredictions() != null)
                return node.GetPredictions();

            if (node.GetQuery().Compare(row))
                return Classify(row, node.GetTrueNode());
            else
                return Classify(row, node.GetFalseNode());
        }
    }
}
//Cual es la diferencia entre la information gain y la impureza?
//Si le quiero insertar datos para que los clasifique meto una data table o crea otro arbol o que?
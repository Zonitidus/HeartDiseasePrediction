using HeartDiseaseInvestigation.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartDiseaseInvestigation.DecisionTreeClassifier
{
    public class DecisionTree<T> where T: DatasetRow
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
                    distribution[label] += 1;
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
            List<T>[] partition = { new List<T>(), new List<T>() };

            foreach (T row in rows)
            {
                if (query.Compare(row))
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

            //Console.WriteLine("GINIIIIIIIIIIIIIIIII ------> \n\n\n ---> "+distribution.Count);

            foreach (String label in distribution.Keys)
            {
                double prob = Convert.ToDouble(distribution[label]) / Convert.ToDouble(rows.Count);
                impurity -= Math.Pow(prob, 2);
            }

            return impurity;
        }

        public double InformationGain(List<T> left, List<T> right, double impurity)
        {

            double proportion = Convert.ToDouble(left.Count) / (Convert.ToDouble(left.Count) + Convert.ToDouble(right.Count));

            //Console.WriteLine("\t\t\tProportion -> "+proportion+ "\n\t\t\tCurrent Impurity -> " + impurity);
            //Console.WriteLine("\t\t\t\t"+ (impurity - proportion * this.Gini(left) - (1 - proportion) * this.Gini(right)));
            return impurity - proportion * this.Gini(left) - (1 - proportion) * this.Gini(right);
        }

        public OptimalSolution<T> FindBestPartition(List<T> rows)
        {
            OptimalSolution<T> solution = new OptimalSolution<T>();
            double bestGain = 0;
            Query<T> bestQuery = null;
            double currentImpurity = this.Gini(rows);

            Console.WriteLine("Rows: "+rows.Count+"\nGini: "+currentImpurity);

            int attributesN = rows.ElementAt(0).getAttributes().Length-1;

            for (int i = 0; i < attributesN; i++)
            {
                List<String> attributesValue = new List<string>();

                foreach (T row in rows)
                {
                    String val = row.getAttributes()[i];

                    /*foreach (String val in attributesValue)
                    {*/
                        Query<T> query = new Query<T>(i, val);

                        List<T>[] partition = this.Partition(rows, query);

                        if (partition[0].Count > 0 && partition[1].Count > 0)
                        {
                            double gain = InformationGain(partition[0], partition[1], currentImpurity);
                            if (gain >= bestGain)
                            {
                                bestGain = gain;
                                bestQuery = query;

                                solution.SetGain(gain);
                                solution.SetQuery(query);
                            }

                        /*}*/
                    }


                }
            }

            //Console.WriteLine("Gain -> "+solution.GetGain()+"\nQuery -> "+solution.GetQuery());
            return solution;
        }

        public Node<T> BuildTree(List<T> rows)
        {
            OptimalSolution<T> solution = this.FindBestPartition(rows);

            //Console.WriteLine("Solution - >"+solution.GetGain());

            if (solution.GetGain() == 0)
            {
                return new Node<T>(this.CountLabelDistribution(rows));
            }

            List<T>[] partition = this.Partition(rows, solution.GetQuery());

            //Console.WriteLine("AAAAAAAHH - > "+partition[0].Count+"\nBEEEEHH - > "+partition[1].Count);

            Node<T> trueBranch = BuildTree(partition[0]);
            Node<T> falseBranch = BuildTree(partition[1]);

            return new Node<T>(solution.GetQuery(), trueBranch, falseBranch);
        }


        public Dictionary<String, Int32> Classify(T row, Node<T> node)
        {
            if (node.GetPredictions() != null)
                return node.GetPredictions();

            if (node.GetQuery().Compare(row))
                return Classify(row, node.GetTrueNode());
            else
                return Classify(row, node.GetFalseNode());
        }

        public String[] PrintLeaf(Dictionary<String, Int32> counts)
        {

            String[] res = new string[2];
            String clas = "";

            Console.WriteLine("AAAAAHHH COunts -> "+counts.Count);

            double total = 0;

            foreach (String key in counts.Keys)
            {
                total += counts[key] * 1.0;
            }

            Dictionary<String, Int32> probs = new Dictionary<string, int>();

            foreach (String key in counts.Keys)
            {

                //Console.WriteLine("Counts -> "+counts[key]+"\ntotal - >"+total);

                if(total != 0)
                {
                    double tem = counts[key] / total * 100;
                    int temp = Convert.ToInt32(tem);

                    probs.Add(key, temp);
                }
                else
                {
                    probs.Add(key, 100);

                }
            }


            String pre = "";

            double maxP = 0;

            foreach (String k in probs.Keys)
            {
                if (maxP < probs[k]) { 
                    maxP = probs[k];
                    clas = k;
                }
                pre += k + " " + probs[k] + "%" + "\n\t\t";
            }

            res[0] = pre;
            res[1] = clas;

            return res;
        }
    }
}

using HeartDiseaseInvestigation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace HeartDiseaseInvestigation.DecisionTreeClassifier
{
    class Node<T> where T: DatasetRow
    {
        private Query<T> query;
        private List<T>[] partition;
        public Node(Query<T> query, List<T>[] partition)
        {
            this.query = query;
            this.partition = partition;
        }

        public Query<T> GetQuery()
        {
            return this.query;
        }
        public void SetQuery(Query<T> query)
        {
            this.query = query;
        }

        public List<T>[] GetPartition()
        {
            return this.partition;
        }
        public void SetPartition(List<T>[] partition)
        {
            this.partition = partition;
        }
    }
}

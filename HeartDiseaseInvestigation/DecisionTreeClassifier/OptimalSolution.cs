using HeartDiseaseInvestigation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace HeartDiseaseInvestigation.DecisionTreeClassifier
{ 
    class OptimalSolution<T> where T: DatasetRow
    {

        private double gain;
        private Query<T> query;

        public OptimalSolution()
        {

        }

        public OptimalSolution(double gain, Query<T> query)
        {
            this.gain = gain;
            this.query = query;
        }

        public Query<T> GetQuery()
        {
            return this.query;
        }

        public double GetGain()
        {
            return this.gain;
        }

        public void SetQuery(Query<T> query)
        {
            this.query = query;
        }
        public void SetGain(double gain)
        {
            this.gain = gain;
        }

    }
}

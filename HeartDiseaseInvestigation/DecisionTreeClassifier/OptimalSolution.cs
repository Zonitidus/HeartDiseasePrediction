using HeartDiseaseInvestigation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartDiseaseInvestigation.DecisionTreeClassifier
{ 
    class OptimalSolution<T> where T: DatasetRow
    {

        private double gain { get; set; }
        private Query<T> query { get; set; }
        public OptimalSolution(double gain, Query<T> query)
        {
            this.gain = gain;
            this.query = query;
        }
    }
}

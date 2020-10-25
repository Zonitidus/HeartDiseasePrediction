using HeartDiseaseInvestigation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HeartDiseaseInvestigation.DecisionTreeClassifier
{
    class Query<T> where T: DatasetRow
    {

        private int attribute;
        private String value;

        public Query(int attribute, string value)
        {
            this.attribute = attribute;
            this.value = value;
        }

        public bool Compare(T example)
        {
            bool response;
            String temp = example.getAttributes()[this.attribute];
            //4 modulo 1 //4.3 modulo 1

            if (Convert.ToDouble(this.value)%1 != 0) {
                response = Convert.ToDouble(this.value) >= Convert.ToDouble(temp);
            }
            else
            {
                response = this.value.Equals(temp);
            }
            return response;
        }

    }
}

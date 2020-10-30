using System;
using System.Collections.Generic;
using System.Linq;
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

            try
            {
                response = Convert.ToDouble(this.value) >= Convert.ToDouble(temp);
            }
            catch (Exception e)
            {
                response = this.value.Equals(temp);
            }

            return response;
        }
    }
}

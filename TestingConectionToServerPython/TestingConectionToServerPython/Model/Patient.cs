using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConectionToServerPython.Model
{
    //Cuestiones a tener en cuenta en esta clase, 1 Se elimino tanto el id como el target, 2 Se pusieron los atributos como publicos, 3 oldpeak era double y fue necesario cambiarlo a int
    public class Patient
    {
        public int age { get; set; }
        public int sex { get; set; }
        public int cp { get; set; }
        public int trestbps { get; set; }
        public int chol { get; set; }
        public int fbs { get; set; }
        public int restecg { get; set; }
        public int thalach { get; set; }
        public int exang { get; set; }
        public int oldpeak { get; set; }
        public int slope { get; set; }
        public int ca { get; set; }
        public int thal { get; set; }
      
        public Patient(int age, int sex, int cp, int trestbps, int chol, int fbs, int restecg, int thalach, int exang, int oldpeak, int slope, int ca, int thal)
        {
            this.age = age;
            this.sex = sex;
            this.cp = cp;
            this.trestbps = trestbps;
            this.chol = chol;
            this.fbs = fbs;
            this.restecg = restecg;
            this.thalach = thalach;
            this.exang = exang;
            this.oldpeak = oldpeak;
            this.slope = slope;
            this.ca = ca;
            this.thal = thal;
        }
        

        public string[] getAttributes()
        {
            String[] attributes = { "" + age, "" + sex, "" + cp, "" + trestbps, "" + chol, "" + fbs, "" + restecg, "" + thalach, "" + exang, "" + oldpeak, "" + slope, "" + ca, "" + thal };

            return attributes;
        }
    }
}

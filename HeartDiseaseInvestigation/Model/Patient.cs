using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartDiseaseInvestigation.Model
{
    class Patient
    {
        private String id { get; set; }
        private int age { get; set; }
        private int sex { get; set; }
        private int cp { get; set; }
        private int trestbps { get; set; }
        private int chol { get; set; }
        private int fbs { get; set; }
        private int restecg { get; set; }
        private int thalach { get; set; }
        private int exang { get; set; }
        private double oldpeak { get; set; }
        private int slope { get; set; }
        private int ca { get; set; }
        private int thal { get; set; }
        private int target { get; set; }

        public Patient(string id, int age, int sex, int cp, int trestbps, int chol, int fbs, int restecg, int thalach, int exang, double oldpeak, int slope, int ca, int thal, int target)
        {
            this.id = id;
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
            this.target = target;
        }
    }
}

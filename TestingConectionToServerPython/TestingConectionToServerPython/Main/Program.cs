using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TestingConectionToServerPython.Model;
using Newtonsoft.Json;

namespace TestingConectionToServerPython
{
    public class Program
    {
        static void Main(string[] args)
        {
            //url = "";
            string link1 = "https://pi-final-app.herokuapp.com/";
            string link2 = "https://pi-final-app.herokuapp.com/train";
            string link3 = "https://pi-final-app.herokuapp.com/draw-tree";

            Conecction connect = new Conecction();
            //Console.WriteLine(connect.ImageFromAnURI(link3));
            //Console.WriteLine(connect.GetImageURL(link3));
            //Console.ReadKey();
            //Console.WriteLine(connect.SendCSVtoServer(link1, "path del csv poner aqui"));
            //Console.ReadKey();
            //string id, int age, int sex, int cp, int trestbps, int chol, int fbs, int restecg, int thalach, int exang, double oldpeak, int slope, int ca, int thal, int target
            Patient patient = new Patient(66,0,2,146,278,0,0,125,0,0,1,1,2);
            string stringJson = JsonConvert.SerializeObject(patient);
            Console.WriteLine(stringJson);
            Console.ReadKey();
            /*
            Console.WriteLine(string.Join(",",patient.getAttributes()));
            Console.ReadKey();
            */
            /*
            Console.WriteLine(conect.GetReleases1(lind)) ;
            Console.ReadLine();
            */

        }
    }

}

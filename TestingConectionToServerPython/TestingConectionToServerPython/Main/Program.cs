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
            string link4 = "https://pi-final-app.herokuapp.com/classify-patient";

            Conecction connect = new Conecction();
            
            Patient patient = new Patient(66,0,2,146,278,0,0,125,0,0,1,1,2);
            Console.WriteLine(connect.SendPatientToServer(link4,patient));
            Console.ReadKey();
            //string stringJson = JsonConvert.SerializeObject(patient);
            //Console.WriteLine(stringJson);
            //Console.ReadKey();
        }
    }

}

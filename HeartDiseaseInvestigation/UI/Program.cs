using HeartDiseaseInvestigation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartDiseaseInvestigation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {





            //Recordar hacer referencia a algo del proyecto no me acuerdo que era jeje pero si hay algun error en el proyecto oficial es porque falta una assembly reference
            //url = "";
            string link1 = "https://pi-final-app.herokuapp.com/";
            string link2 = "https://pi-final-app.herokuapp.com/train";
            string link3 = "https://pi-final-app.herokuapp.com/draw-tree";
            string link4 = "https://pi-final-app.herokuapp.com/classify-patient";

            Connection connect = new Connection();

            //Patient patient1 = new Patient("dd",66,0,2,146,278,0,0,125,0,0,1,1,2,0);
            Patient patient2 = new Patient("dd",68, 1, 2, 180, 274, 1, 0, 150, 1, 1.6, 1, 0, 3, 0);


            //Console.WriteLine(connect.ImageFromAnURI(link3));
            //Console.ReadKey();



            //Console.WriteLine(connect.Train(link2));
            //Console.ReadKey();


            Console.WriteLine(connect.SendPatientToServer(link4,patient2));
            Console.ReadKey();


            //string stringJson = JsonConvert.SerializeObject(patient2);
            //Console.WriteLine(stringJson);
            //Console.ReadKey();








            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PatientsFileWindow());
        }
    }
}

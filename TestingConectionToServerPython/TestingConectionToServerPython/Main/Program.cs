using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TestingConectionToServerPython.Model;

namespace TestingConectionToServerPython
{
    public class Program
    {
        static void Main(string[] args)
        {
            //url = "";
            string lind = "";
            Conecction conect = new Conecction();
            Console.WriteLine(conect.GetReleases1(lind)) ;
            Console.ReadLine();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_02uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.Policininkas();
        }
        public void Policininkas()
        {
            var vardas = "Jonas";
            var pavardė = "Jonaitis";
            var amžius = 40;
            var alga = 1580;
            var etatas = 0.5;
            var specializacija = "Budėtojas";
            Console.WriteLine("Policininkas {0} {1}, kuriam {2} metų, dirba {3} etatu, gauna {4} algos" +
                " ir dirba {5}", vardas, pavardė, amžius, etatas, alga, specializacija);
        }

    }
}

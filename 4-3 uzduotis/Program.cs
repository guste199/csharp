using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite gyvūną: ");
            var gyvūnas = Console.ReadLine();
            Console.WriteLine("Įveskite gyvūno šeimą: ");
            var šeima = Console.ReadLine();
            Console.WriteLine("Įveskite gyvūno regioną: ");
            var regionas = Console.ReadLine();

            Console.WriteLine("gyvūnas " + gyvūnas + " " + "yra priskiriamas " + šeima +
                " šeimai ir gyvena " + regionas);
        }
    }
}

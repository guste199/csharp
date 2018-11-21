using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite savo vardą: ");
            var vardas = Console.ReadLine();
            Console.WriteLine("Įveskite savo amžių: ");
            var amžius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {1}", vardas, amžius);
        }
    }
}

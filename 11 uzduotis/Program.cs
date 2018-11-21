using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite teigiamą skaičių:");
            var skaičius = Convert.ToInt32(Console.ReadLine());
            if (skaičius % 7 == 0)
            {
                Console.WriteLine("Skaičius dalinasi iš 7");

            }
            else
            {
                Console.WriteLine("Skaičius netinka");
            }
        }
    }
}

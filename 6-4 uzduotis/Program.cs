using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite pirmą skaičių: ");
            var skaičius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrą skaičių: ");
            var skaičius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite trečia skaičių: ");
            var skaičius3 = Convert.ToInt32(Console.ReadLine());
            if(skaičius > skaičius2 && skaičius > skaičius3)
            {
                Console.WriteLine("Pirmas skaičius yra didžiausias");
            }
            else if(skaičius2 > skaičius && skaičius2 > skaičius3)
            {
                Console.WriteLine("Antras skaičius yra didžiausias");
            }
            else
            {
                Console.WriteLine("Trečias skaičius yra didžiausias");
            }
        }
    }
}

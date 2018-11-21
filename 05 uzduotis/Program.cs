using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite teigiamą skaičių: ");
            var skaičius = Convert.ToInt32(Console.ReadLine());
            if(skaičius < 0)
            {
                Console.WriteLine("Neatitinka sąlygos");
            }
            if(skaičius > 0)
            {
                Console.WriteLine("Sąlyga tinkama");
            }
            if(skaičius % 2 == 0)
            {
                Console.WriteLine("Skaičius lyginis");
            }
            if(skaičius % 4 == 0)
            {
                Console.WriteLine("Skaičius dalinasi iš 4");
            }
            if(skaičius > 10)
            {
                Console.WriteLine("Skaičius didesnis už 10");

            }
        }
    }
}

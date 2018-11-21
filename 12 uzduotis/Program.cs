using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite pirmą skaičių:");
            var skaičius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrą skaičių:");
            var skaičius2 = Convert.ToInt32(Console.ReadLine());
            if(skaičius > skaičius2)
            {
                Console.WriteLine("Pirmas skaičius didesnis už antrąjį");
            }
            else
            {
                Console.WriteLine("Klaida");

            }
        }
    }
}

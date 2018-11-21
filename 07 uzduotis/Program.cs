using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_uzduotis
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
            if(skaičius > skaičius2)
            {
                Console.WriteLine("Pirmas skaičius didesnis už antrą");
            }
            else if (skaičius < skaičius2)
                {
                Console.WriteLine("Pirmas skaičius yra mažesnis už antrą");
            }
            if(skaičius3 > skaičius)
            {
                Console.WriteLine("Trečias skaičius didesnis už pirmą");
            }
            else if(skaičius3 < skaičius)
            {
                Console.WriteLine(" Trečias skaičius mažesnis už pirmą");
            }
            if(skaičius == skaičius2)
            {
                Console.WriteLine("Skaičiai lygūs ");
            }
            else if(skaičius != skaičius2)
            {
                Console.WriteLine("Skaičiai nelygūs");
            }
            if(skaičius2 == skaičius3)
            {
                Console.WriteLine("Skaičiai lygūs");
            }
            else if (skaičius2 != skaičius3)
            {
                Console.WriteLine("Skaičiai nelygūs");
            }

        }
    }
}

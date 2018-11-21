using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite pirmą skaičių: ");
            var skaičius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrą skaičių: ");
            var skaičius2 = Convert.ToInt32(Console.ReadLine());
            if(skaičius > skaičius2 || skaičius == 0)
            {
                Console.WriteLine("Pirmas skaičius yra didesnis už antrąjį arba lygus nuliui");
            }
            if(skaičius2 > skaičius || skaičius ==5)
            {
                Console.WriteLine("Antras skaičius yra didesnis už pirmą arba lygus 5");
            }
            if(skaičius > skaičius2 && skaičius == 20)
            {
                Console.WriteLine("Pirmas skaičius yra didesnis už antrą ir lygus 20");
            }
            if(skaičius2 > skaičius && skaičius < 100)
            {
                Console.WriteLine("Antras skaičius yra didesnis už pirmą ir yra mažesnis už 100");
            }
        }
    }
}

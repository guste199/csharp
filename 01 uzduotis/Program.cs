using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite pirmąjį skaičių: ");
            var skaičius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrąjį skaičių: ");
            var skaičius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite trečiajį skaičių: ");
            var skaičius3 = Convert.ToInt32(Console.ReadLine());
            if(skaičius == skaičius2)
            {
                Console.WriteLine("Skaičiai yra lygūs");
            }
            if (skaičius2 == skaičius3)
            {
                Console.WriteLine("Skaičiai yra lygūs");
            }

            if(skaičius > skaičius2)
            { 
                Console.WriteLine("Pirmas skaičius yra didesnis už antrąjį");

            }
            if(skaičius2 > skaičius3 * 2)
            {
                Console.WriteLine("skaičius yra didesnis už dvigubą trečiojo skaičiaus reikšmę");
            }
            if(skaičius % 2 == 0)
            {
                Console.WriteLine("Skaičius yra lyginis");
            }
            if(skaičius2 % 2 != 0)
            {
                Console.WriteLine("Skaičius yra nelyginis");

            }
            if (skaičius3 > 0)
            {
                Console.WriteLine("Skaičius yra teigiamas");
            }
                if(skaičius < 0)
            {
                Console.WriteLine("Skaičius yra neigiamas");
            }
                if(skaičius2 % 4 == 0 )
            {
                Console.WriteLine("Skaičius dalinasi iš 4");
            }
                if(skaičius3 % 8 == 0)
            {
                Console.WriteLine("Skaičius dalinasi iš 8");
            }
               
        }
    }
}

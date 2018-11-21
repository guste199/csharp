using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_12uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite pirmąjį skaičių:");
            var skaičius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrąjį skaičių:");
            var skaičius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite trečiajį skaičių:");
            var skaičius3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {1} {2} {3}", skaičius, skaičius * skaičius,
                skaičius * skaičius * skaičius, skaičius / 2);
            Console.WriteLine("{0} {1} {2} {3}", skaičius2, skaičius2 * skaičius2, 
                skaičius2 * skaičius2 * skaičius2, skaičius2 / 2);
            Console.WriteLine("{0} {1} {2} {3}", skaičius3, skaičius3 * skaičius3,
                skaičius3 * skaičius3 * skaičius3, skaičius3 / 2);

        }
    }
}

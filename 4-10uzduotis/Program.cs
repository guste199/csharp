using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_10uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite pirmą skaičių:");
            var skaičius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrą skaičių:");
            var skaičius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite trečią skaičių:");
            var skaičius3 = Convert.ToInt32(Console.ReadLine());
            var vidurkis = (skaičius + skaičius2 + skaičius3) / 3;
            Console.WriteLine("Įvestų skaičių {0} {1} {2} vidurkis: {3}",
                skaičius, skaičius2, skaičius3, vidurkis);

        }
    }
}

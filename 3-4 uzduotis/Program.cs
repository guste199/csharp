using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaičius = 10;
            var skaičius1 = 5;
            var skaičius2 = 8;
            var skaičius3 = 15;
            var vidurkis = (skaičius + skaičius1 + skaičius2 + skaičius3) / 4;
            Console.WriteLine("Skaičių vidurkis: " + vidurkis);

        }
    }
}

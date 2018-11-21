using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaičius = Convert.ToInt32(Console.ReadLine());
            var skaičius1 = Convert.ToInt32(Console.ReadLine());
            var skaičius2 = Convert.ToInt32(Console.ReadLine());
            var skaičius3 = Convert.ToInt32(Console.ReadLine());
            var skaičius4 = Convert.ToInt32(Console.ReadLine());
            var vidurkis = (skaičius + skaičius1 + skaičius2 + skaičius3 + skaičius4) / 5;
            Console.WriteLine("Vidurkis " + vidurkis);

        }
    }
}

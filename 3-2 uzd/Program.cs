using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaičius = 5;
            var skaičius1 = 9;
            var skaičius2 = 15;
            var suma = skaičius + skaičius1 + skaičius2;
            var sandauga = skaičius * skaičius1 * skaičius2;
            Console.WriteLine("Skaičių suma: " + suma);
            Console.WriteLine("Skaičių sandauga: " + sandauga);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaičius = Convert.ToInt32(Console.ReadLine());
            var skaičius2 = Convert.ToInt32(Console.ReadLine());
            var suma = skaičius + skaičius2;
            Console.WriteLine("{0} + {1} = {2}", skaičius, skaičius2, suma);
        }
    }
}

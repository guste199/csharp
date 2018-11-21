using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaičius = 9;
            var skaičius2 = 10;
            var suma = skaičius + skaičius2;
            var atimtis = skaičius - skaičius2;
            var sandauga = skaičius * skaičius2;
            var dalyba = skaičius / skaičius2;
            Console.WriteLine("{0} + {1} = {2}", skaičius, skaičius2, suma);
            Console.WriteLine("{0} - {1} = {2}", skaičius, skaičius2, atimtis);
            Console.WriteLine("{0} * {1} = {2}", skaičius, skaičius2, sandauga);
            Console.WriteLine("{0} / {1} = {2}", skaičius, skaičius2, dalyba);
        }
    }
}

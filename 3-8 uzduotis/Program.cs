using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaičius = 78;
            var skaičius1 = skaičius / 10;
            var skaičius2 = skaičius % 10;
            Console.WriteLine(" {0} + {1} = {2}", skaičius1, skaičius2, skaičius1 + skaičius2);
        }
    }
}

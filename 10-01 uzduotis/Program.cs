using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaičius = 1;
            do
            {
                Console.WriteLine(skaičius);
                skaičius++;
            } while (skaičius % 17 == 0);
        }
    }
}

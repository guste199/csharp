using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaičius = 100;
            var suma = 0;
            do
            {
                if (skaičius % 2 == 0)
                {
                    suma += skaičius;

                    skaičius++;

                } while (skaičius <= 1) ;

                Console.WriteLine("{0}", suma);
            }
            
        }
    }
}
            
        
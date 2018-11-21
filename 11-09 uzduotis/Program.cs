using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_09_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaičiai = new int[4] { 4, 7, 6, 5 };
            var skaičiai2 = new int[4] { 1, 2, 3, 4 };
            var suma = 0;
            var suma2 = 0;
            foreach (int sk in skaičiai)
            {
                suma += sk;
            }
            Console.WriteLine("Pirmo masyvo skaičių suma {0}", suma);

            foreach(int sk1 in skaičiai2)
            {
                suma2 += sk1;
            }
            Console.WriteLine("Antro masyvo skaičių suma {0}", suma2);
            if(suma > suma2)
            {
                Console.WriteLine("Pirmo masyvo skaičių suma didesnė už antrą");
            }
            else if(suma < suma2)
            {
                Console.WriteLine("Antro masyvo skaičių suma didesnė už pirmą");
            }

        }

    }
}

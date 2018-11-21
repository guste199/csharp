using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite skaičių: ");
            var skaičius = Convert.ToInt32(Console.ReadLine());

            if(skaičius % 2 == 0)
            {
                var skaičius1 = Math.Pow(skaičius, 5);
                Console.WriteLine("{0} {1} ", skaičius, skaičius1);
                
            }
            if(skaičius % 4 != 0)
            {
                Console.WriteLine("Įveskite antrą skaičių: ");
                var skaičius2 = Convert.ToInt32(Console.ReadLine());
                var suma = skaičius + skaičius2;
                var sandauga = skaičius * skaičius2;
                Console.WriteLine(" Skaičių suma : {0} ir sandauga : {1}", suma, sandauga);

            }

        }
    }
}

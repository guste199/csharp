using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite skaičių: ");
            var skaičius = Convert.ToInt32(Console.ReadLine());
            
            if(skaičius % 5 == 0)
            {
                Console.WriteLine("{0} * 1 = {1}", skaičius, skaičius * 1);
                Console.WriteLine("{0} * 2 = {1}",skaičius, skaičius * 2);
                Console.WriteLine("{0} * 3 = {1}", skaičius, skaičius * 3);
                Console.WriteLine("{0} * 4 = {1}", skaičius, skaičius * 4);
                Console.WriteLine("{0} * 5 = {1}", skaičius, skaičius * 5);
            }
            if(skaičius % 2 == 0)
            {
                Console.WriteLine("{0} {1} {2}", skaičius, skaičius * skaičius, skaičius / 2);
            }
            if(skaičius % 7 != 0)
            {
                Console.WriteLine("Antras skaičius:");
                var skaičius2 = Convert.ToInt32(Console.ReadLine());
                var suma = skaičius + skaičius2;
                var skirtumas = skaičius - skaičius2;
                var sandauga = skaičius * skaičius2;
                var dalmuo = skaičius / skaičius2;
                Console.WriteLine("Jų suma = {0} , skirtumas = {1}, sandauga = {2} " +
                    ", dalmuo = {3}", suma, skirtumas, sandauga, dalmuo);
            }


        }
    }
}

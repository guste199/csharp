using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_08uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var kiekis = 100;
            var suma = 0;
            var vidurkis = 0;
            while (kiekis >= 0)
            {
                kiekis++;

                var skaičius = rand.Next();
                Console.Write("{0},", skaičius);
                suma += skaičius;
                vidurkis = suma / kiekis;
                Console.WriteLine();
            }

            Console.WriteLine("suma : {0}, vidurkis : {1}", suma, vidurkis);
            
        }
    }
}

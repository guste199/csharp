using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_06_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            var suma = 0;
            var kiekis = 0;
            while (kiekis < 10)
            {
                
                var skaičius = rand.Next(1, 10);
                suma = suma +  skaičius;
                kiekis++;
            }
            Console.WriteLine("{0}", suma);


        }
    }
}


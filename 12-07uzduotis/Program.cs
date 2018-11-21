using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_07uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaičiai = new List<int>();
            var rand = new Random();
            var kiekis = 100;
            for(int i = 0; i < 100; i++)
            {
                skaičiai.Add(rand.Next(100));
            }
            Console.WriteLine("Sugeneruoti skaičiai :");

            foreach (int skaičius in skaičiai)
            {
                Console.Write("{0},", skaičius);

            }
            Console.WriteLine();
            Console.WriteLine("Pirmas skaičius: " + skaičiai.First());
            Console.WriteLine("Paskutinis skaičius: " + skaičiai.Last());
            Console.WriteLine("Mažiausias skaičius: " + skaičiai.Min());
            Console.WriteLine("Didžiausias skaičius: " + skaičiai.Max());
            Console.WriteLine("Skaičių suma : " + skaičiai.Sum());
            Console.WriteLine("Skaičių vidurkis : " + skaičiai.Average());
            var lyginiai = 0;
            foreach (int lyginis in skaičiai)
            {
                if (lyginis % 2 == 0)
                {
                    lyginiai++;

                }
            }
            Console.WriteLine("Lyginių skaičių kiekis : " + lyginiai);
        }
    }
}

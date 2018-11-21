using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_07uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            Console.WriteLine("Kiek atsitiktinių skaičių norite sugeneruoti?");
            var kiek = Convert.ToInt32(Console.ReadLine());
            programa.Atrinkti(kiek);
        }
        public void Atrinkti(int kiek)
        {
            Console.WriteLine("Galimo skaičiaus minimumas: ");
            var min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Galimo skaičiaus maksimumas: ");
            var max = Convert.ToInt32(Console.ReadLine());
            var rand = new Random();
            for (int i = 0; i < kiek; i++)
            {
                var pirmas = rand.Next(1, 100);
                if (pirmas > min && pirmas < max)
                {
                    Console.WriteLine(pirmas);
                }
            }
        }
    }
}
    


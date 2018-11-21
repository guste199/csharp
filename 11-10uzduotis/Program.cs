using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_10uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaičius = new int[4] { 7, 1, 2, 3 };
            var skaičius2 = new int[4] { 8, 4, 1, 7 };
            var suma = 0;
            var suma2 = 0;
            var vidurkis = 0;
            var vidurkis1 = 0;
            foreach (int sk in skaičius)
            {
                suma += sk;
            }
            vidurkis = suma / skaičius.Length;

            Console.WriteLine("Pirmo masyvo skaičių suma {0} ir vidurkis {1}", suma, vidurkis);
            foreach(int sk in skaičius2)
            {
                suma2 += sk;
            }
            vidurkis1 = suma2 / skaičius.Length;
            Console.WriteLine("Antro masyvo skaičių suma {0} ir vidurkis {1}", suma2, vidurkis1);
            if (vidurkis > vidurkis1)
            {
                Console.WriteLine("Pirmas vidurkis yra didesnis");
            }
            else Console.WriteLine("Antras vidurkis didesnis");
        }
    }
}

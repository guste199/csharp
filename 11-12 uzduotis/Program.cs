using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var nuvažiuoti_kilometrai = new[] { 100, 40, 50, 70 };
            var vidutinis_greitis = 80; //km/h
            double benzino_kaina = 1.2; // už litrą
            var suma = nuvažiuoti_kilometrai.Sum();
                Console.WriteLine("Iš viso nuvažiuota kilometrų: " + suma);
                Console.WriteLine();
            var kaina = benzino_kaina * suma;
            Console.WriteLine("Kelionė kainavo {0} eurų", kaina);
            var laikas = (double) suma / vidutinis_greitis;
            Console.WriteLine("Kelionė užtruko: {0} valandos", laikas);
        }
    }
}

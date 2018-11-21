using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_16_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Studento vardas: ");
            var vardas = Console.ReadLine();
            Console.WriteLine("Studento pavardė: ");
            var pavardė = Console.ReadLine();
            Console.WriteLine("Kodas: ");
            var kodas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Aukštoji mokykla: ");
            var aukštoji_mokykla = Console.ReadLine();
            Console.WriteLine("Studento pažymių kiekis: ");
            var pažymių_kiekis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite {0} pažymius: ", pažymių_kiekis);
            var pažimys = Convert.ToInt32(Console.ReadLine());
            var pažimys2 = Convert.ToInt32(Console.ReadLine());
            var pažimys3 = Convert.ToInt32(Console.ReadLine());
            var pažimys4 = Convert.ToInt32(Console.ReadLine());
            var vidurkis = (pažimys + pažimys2 + pažimys3 + pažimys4) / pažymių_kiekis;
            Console.WriteLine("{0} {1}, kodas {2}, mokinasi {3} aukštojoje mokykloje," +
                " turi {4} pažymius {5} {6} {7} {8}, kurių bendras vidurkis {5}",
                vardas, pavardė, kodas, aukštoji_mokykla, pažymių_kiekis, pažimys,
                pažimys2, pažimys3, pažimys4, vidurkis);
        }
    }
}

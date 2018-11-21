using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_15uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Darbuotojo vardas: ");
            var vardas = Console.ReadLine();
            Console.WriteLine("Darbuotojo pavardė: ");
            var pavardė = Console.ReadLine();
            Console.WriteLine("Darbuotojo gimimo metai: ");
            var gimimo_metai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Darbuotojo specialybė: ");
            var specialybė = Console.ReadLine();
            Console.WriteLine("Darbuotojo etatas (0-1) : ");
            var etatas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Darbuotojo alga (eur/mėn) : ");
            var alga = Convert.ToInt32(Console.ReadLine());
            var metai = 2018 - gimimo_metai;
            Console.WriteLine("{0} {1} ({2}m.) dirba {3} {4} etatu ir uždirba {5} eurų/mėn.",
                vardas, pavardė, metai, specialybė, etatas, alga);
        }
    }
}

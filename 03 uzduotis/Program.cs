using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite pirmą pažymį: ");
            var pažimys = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrą pažymį: ");
            var pažimys2 = Convert.ToInt32(Console.ReadLine());
            var vidurkis = (pažimys + pažimys2) / 2;
            if (vidurkis >= 5)
            {
                Console.WriteLine("Vidurkis teigiamas");
            }
        }
    }
}

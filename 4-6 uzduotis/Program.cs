using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite sveikąjį skaičių: ");
            var skaičius = Convert.ToInt32(Console.ReadLine());
            var skaičius1 = Math.Pow(skaičius, 2);
            Console.WriteLine(" {0} {1}", skaičius, skaičius1);
        }
    }
}

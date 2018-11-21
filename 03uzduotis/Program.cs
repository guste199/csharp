using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite skaičių: ");
            var skaičius = Convert.ToInt32(Console.ReadLine());
            if (skaičius % 2 == 0 || skaičius % 5 == 0 || skaičius % 7 == 0)
            {
                Console.WriteLine("Skaičius dalinasi iš 2 arba iš 5, arba iš 7");
            }
        }
    }
}

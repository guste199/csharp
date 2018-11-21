using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite skaičių:");
            var skaičius = Convert.ToInt32(Console.ReadLine());
            if (skaičius % 2 ==0)
            {
                Console.WriteLine("Skaičius lyginis");
            }
            else
            {
                Console.WriteLine("Skaičius nelyginis");
            }
        }
    }
}

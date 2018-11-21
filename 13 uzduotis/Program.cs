using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite skaičių");
            var skaičius = Convert.ToInt32(Console.ReadLine());
            if (skaičius % 2 == 0)
            {
                Console.WriteLine("Skaičius dalinasi iš 2");

            }
            else if(skaičius % 3 == 0)
            {
                Console.WriteLine("Skaičius dalinasi iš 3");
            }
            else if(skaičius % 4 == 0)
            {
                Console.WriteLine("Skaičius dalinasi iš 4");
            }
            else if (skaičius % 5 == 0)
            {
                Console.WriteLine("Skaičius dalinasi iš 5");

            }
            else if (skaičius % 7 == 0)
            {
                Console.WriteLine("Skaičius dalinasi iš 7");

            }
            else
            {
                Console.WriteLine("Skaičius iš nieko nesidalina");

            }
        }
    }
}

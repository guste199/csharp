using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_11_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite sveikąjį skaičių: ");
            var skaičius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} * 1 = {1}", skaičius, skaičius * 1);
            Console.WriteLine("{0} * 2 = {1}", skaičius, skaičius * 2);
            Console.WriteLine("{0} * 3 = {1}", skaičius, skaičius * 3);
            Console.WriteLine("{0} * 4 = {1}", skaičius, skaičius * 4);
            Console.WriteLine("{0} * 5 = {1}", skaičius, skaičius * 5);

        }
    }
}

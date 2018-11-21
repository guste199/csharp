using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite teigiamą skaičių:");
            var skaičius = Convert.ToInt32(Console.ReadLine());
            if(skaičius > 0)
            {
                Console.WriteLine("Sveikinu");
            }
            else
            {
                Console.WriteLine("Blogai");
            }
        }
    }
}

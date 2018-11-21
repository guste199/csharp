using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite amžių: ");
            var amžius = Convert.ToInt32(Console.ReadLine());
            if(amžius >= 18)
            {
                Console.WriteLine("Jūs galite balsuoti");
            }
        }
    }
}

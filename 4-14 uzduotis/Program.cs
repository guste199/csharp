using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_14_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite norimą simbolį:");
            var simbolis = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("  {0}", simbolis);
            Console.WriteLine(" {0} {0}", simbolis);
            Console.WriteLine("{0} {0} {0}", simbolis);
          

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_03uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var markės = new List <string> { "Opel", "WV", "Audi", "BMW"};

            for(int i = 0; i < markės.Count; i++)
            {
                Console.Write(markės[i] + "," );
            }
            Console.WriteLine();
        }
    }
}

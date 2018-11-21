using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_02uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaičius = 1;
            while(skaičius < 50)
            {
                if (skaičius % 2 == 0)
                {
                    Console.WriteLine("{0} lyginis", skaičius);
                }
                else Console.WriteLine("{0} nelyginis", skaičius);
                skaičius++;
            }
          
            
        }
    }
}

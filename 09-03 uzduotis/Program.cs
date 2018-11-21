using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaičius = 1;
            while(skaičius < 100)
            {
                Console.Write("{0},",skaičius);
                skaičius++;
            }
            
        }
    }
}

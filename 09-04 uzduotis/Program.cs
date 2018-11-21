using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_04_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaičius = 25;
            while(skaičius < 50)
            {
                skaičius++;
                if(skaičius % 3 == 0 )
                {
                    Console.WriteLine("{0}", "SKaičius dalinasi iš 3");
                    continue;
                }
                Console.WriteLine(skaičius);
                

                
                
            }
        }
    }
}

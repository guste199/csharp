using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaičius = 100;
            do
            {

                if (skaičius % 100 == 0)
                {
                   if(skaičius % 5 ==0 )
                        {
                        Console.WriteLine("Skaičius {0} dalinasi iš 5", skaičius);
                    }
                }
            
                else
                    Console.WriteLine(skaičius);
                skaičius--;

            } while (skaičius > 0);
            
        }
    }
}

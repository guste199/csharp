using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_05uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaičius = 1;
            var suma1 = 0;
            var suma2 = 0;
            while(skaičius < 100)
            {
                skaičius++;
                if(skaičius % 2 ==0)
                {
                    suma1 = skaičius + suma1;
                }
                else if (skaičius % 2 !=0)
                {
                    suma2 = skaičius + suma2;
                }
            }
            Console.WriteLine("{0}", suma1);
            Console.WriteLine("{0}", suma2);
        }
    }
}

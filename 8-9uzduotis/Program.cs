using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_9uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;
            for(int i = 20; i < 50; i++)
            {
                if(i % 2 ==0)
                {
                    suma += i;
                }
            }
            Console.WriteLine("Skaičių nuo 20 iki 50 suma : {0}", suma);

        }
    }
}

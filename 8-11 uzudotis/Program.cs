using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_11_uzudotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;
            for(int i = 0; i < 1000; i++)
            {
                if(i % 3 ==0 || i % 5 ==0)
                {
                    suma += i;
                }
            }
            Console.WriteLine("Skaičių kurie dalinasi iš 3 arba 5 ir yra žemesni negu 1000," +
                " suma: {0} ", suma);
        }
    }
}

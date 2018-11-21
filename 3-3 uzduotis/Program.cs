using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaičius = 10;
            var skaičius1 = 9;
            var suma = skaičius + skaičius1;
            var skirtumas = skaičius - skaičius1;
            var sandauga = suma * skirtumas;
            var dalmuo = suma / skirtumas;
            Console.WriteLine("Skaičių suma : " + suma);
            Console.WriteLine("Skaičių skirtumas: " + skirtumas);
            Console.WriteLine("Sandauga :" + sandauga);
            Console.WriteLine("Dalmuo: " + dalmuo);


        }
    }
}

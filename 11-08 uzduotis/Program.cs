using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_08_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaičiai = new int[5] { 7, 10, 4, 5, 9 };
     
            var suma = skaičiai[0] + skaičiai[1] + skaičiai[2] + skaičiai[3] + skaičiai[4];
            Console.WriteLine("Skaičių suma : {0}", suma);
            var vidurkis = (double)suma / skaičiai.Length;
            Console.WriteLine("Vidurkis : {0}", vidurkis);           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaičius = 5;
            var kvadratas = Math.Pow(skaičius, 2);
            var treciu_laipsniu = Math.Pow(skaičius, 3);
            Console.WriteLine("Skaičius:" + skaičius);
            Console.WriteLine("Skaičiaus kvadratas: " + kvadratas);
            Console.WriteLine("Skaičius pakeltas 3 laipsniu: " + treciu_laipsniu);

        }
    }
}

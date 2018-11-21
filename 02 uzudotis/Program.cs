using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_uzudotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite teigiąmą skaičių: ");
            var skaičius = Convert.ToInt32(Console.ReadLine());
            if(skaičius > 0 && skaičius % 2 ==0 )
            {
                Console.WriteLine("Skaičius yra teigiamas ir lyginis");

            }
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var pradžia = 1;
            var pabaiga = 50;
            Console.WriteLine("Įveskite  skaičių: ");
            var skaičius = Convert.ToInt32(Console.ReadLine());
            if(skaičius > pradžia && skaičius < pabaiga)
            {
                Console.WriteLine("Skaičius patenka į rėžius");
            }
            else
            {
                Console.WriteLine("Netinka ");
               
            }


        }
    }
}

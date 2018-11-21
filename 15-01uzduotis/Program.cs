using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _15_01uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            Console.WriteLine(programa.Metodas());
        }

         public int Metodas()
         {
            var rand = new Random();
            var skaičius = rand.Next(1, 100);
            var skaičius2 = rand.Next(1, 100);
            if (skaičius > skaičius2)
            {
                return skaičius;
            }
         }
    }
}

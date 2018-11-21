using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var skaičius = 1;
            while (skaičius >= 1)
            {
                var skaičius1 = rand.Next(10);
                if(skaičius % 3 ==0 && skaičius % 5 == 0)
                {
                    break;
                }
                Console.WriteLine(skaičius);
                skaičius++;
            }
        }
    }
}

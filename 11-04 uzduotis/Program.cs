using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_04_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaičiai = new int[4] { 4, 5, 8, 6 };
            var skaičiai2 = new int[4] { 1, 2, 3, 4 };
            var skaičiai3 = new int[4] { 9, 3, 4, 8 };
            Console.WriteLine("Pirmo masyvo skaičius : {0}", skaičiai[2]);
            Console.WriteLine("Antro masyvo skaičius : {0}", skaičiai2[0]);
            Console.WriteLine("Trečio masyvo skaičius : {0}", skaičiai3[1]);
            if (skaičiai[2] > skaičiai2[0] && skaičiai[2] > skaičiai3[1])
            {
                Console.WriteLine("Pirmo masyvo skaičius yra didžiausias");
            }
            else if (skaičiai2[0] > skaičiai[2] && skaičiai2[0] > skaičiai3[1])
            {
                Console.WriteLine("Antro masyvo skaičius yra didžiausias");
            }
            else
            {
                Console.WriteLine("Trečio masyvo skaičius didžiausias");

                //var rand = new Random();
                //random indeksas 
                // rand.Next(skaičiai.Length)
                //gauti reiksme is skaičių masyvo
                // skaičiai[indeksas]
                //skaičiai[2]
                //var arski = skaičiai[...];
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_13uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var prekių_pavadinimas = new string[] { "Telefonas", "Stalas", "Ausinukai" };
            var kainos = new [] { 745, 512.2, 30 };
            Console.WriteLine(" Informacija apie prekę"); 
         Console.WriteLine(" --------------------------------------- \r\n"
          + " Prekės pavadinimas   Kaina       \r\n"
          + " --------------------------------------- ");
            Console.WriteLine(" {0, 8} {1,15}\n {2} {3,10} \n {4,5} {5,5}", prekių_pavadinimas[0], kainos[0], 
                prekių_pavadinimas[1], kainos[1], prekių_pavadinimas[2], kainos[2]);
            Console.WriteLine(" --------------------------------------- \n\n");
        }
    }
}

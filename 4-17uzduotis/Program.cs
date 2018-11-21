using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_17uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pirmo automobilio duomenys
            Console.WriteLine("Pirmo automobilio duomenys");
            Console.Write("Pirmo automobilio  markė: ");
            var markė = Console.ReadLine();
            Console.Write("Automobilio modelis: ");
            var modelis = Console.ReadLine();
            Console.Write("Gamybos metai: ");
            var gamybos_metai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Darbinis tūris: ");
            double darbinis_tūris = Convert.ToDouble(Console.ReadLine());
            Console.Write("Rida: ");
            var rida = Convert.ToInt32(Console.ReadLine());
            Console.Write("Techninė apžiūra (true/false) :");
            var TA = Convert.ToBoolean(Console.ReadLine());
            //Antro automobilio duomenys
            Console.WriteLine("Antro automobilio duomenys: ");
            Console.Write("Antro automobilio markė: ");
            var markė2 = Console.ReadLine();
            Console.Write("Automobilio modelis: ");
            var modelis2 = Console.ReadLine();
            Console.Write("Gamybos metai: ");
            var gamybos_metai2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Darbinis tūris: ");
            int darbinis_tūris2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Rida: ");
            var rida2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Techninė apžiūra (true/false): ");
            var TA2 = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("+------------------------------------------------------------+\n" +
                "| Markė | Modelis | Gamybos metai | Darb. tūris | Rida |   TA |\n" +
                "+------------------------------------------------------------+\n" +
                "| {0,4}  | {1,6}  |  {2,9}    | {3,5}    | {4,6}  | {5,6} |\n" + 
                "| {6,4}  | {7,6}  |  {8,9}    | {9,5}    | {10,5}  | {11,6} |\n",
                  markė, modelis, gamybos_metai, darbinis_tūris, rida, TA, markė2, modelis2, 
                  gamybos_metai2, darbinis_tūris2, rida2, TA2);
            Console.WriteLine("+--------------------------------------------------+");

                

            

        }
    }
}

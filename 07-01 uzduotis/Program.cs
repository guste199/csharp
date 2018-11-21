using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite pasirinkimą:");
            Console.WriteLine("1 - jei vanduo");
            Console.WriteLine("2 - limonadas");
            Console.WriteLine("3 - kava");
            Console.WriteLine("4 - arbata");
            var pasirinkimas = Convert.ToInt32(Console.ReadLine());
            switch(pasirinkimas)
            {
                case 1: Console.WriteLine("Vartotojas pasirinko vandenį");
                        break;
                case 2: Console.WriteLine("Vartotojas pasirinko limonadą");
                    break;
                case 3:  Console.WriteLine("Vartotojas pasirinko kavą");
                    break;
                case 4:
                    Console.WriteLine("Vartotojas pasirinko arbatą");
                    break;
                default: Console.WriteLine("Klaida");
                    break;
            }
        }
    }
}

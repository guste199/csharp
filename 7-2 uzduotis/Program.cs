using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite jūsų rolę:");
            var rolė = Console.ReadLine();
            switch(rolė)
            {
                case "vartotojas": Console.WriteLine("Rolė yra vartotojas");
                    break;
                case "moderatorius": Console.WriteLine("Rolė yra moderatorius");
                    break;
                case "administratorius": Console.WriteLine("Rolė yra administratorius");
                    break;
                default: Console.WriteLine("Rolės nėa");
                    break;
            }
        }
    }
}

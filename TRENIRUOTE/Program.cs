using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRENIRUOTE
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
         
            while (true)
            {
                Console.WriteLine("Pasirinkite:");
                Console.WriteLine("1-suma");
                Console.WriteLine("2-skirtumas");
                var var = Convert.ToInt32(Console.ReadLine());

                switch (var)
                {
                    case 1: p.Suma(); break;
                    case 2: p.Skirtumas(); break;
                    default: Console.WriteLine("Nėra pasirinkimo"); break;
                }
                Console.WriteLine("Ar pakartoti? (t/n)");
                var kartoti = Console.ReadLine();
                if(kartoti != "t")
                {
                    break;
                }
            }
        }
        public void Suma()
        {
            Console.WriteLine("Įveskite 2 skaičius:");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            var suma = pirmas + antras;
            Console.WriteLine("Suma " + suma);
        }
        public void Skirtumas()
        {
            Console.WriteLine("Įveskite 2 skaičius:");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            var skirtumas = pirmas - antras;
            Console.WriteLine("Skaičių skirtumas  " + skirtumas);
        }
        

    }
}

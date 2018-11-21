using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_05uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            Console.WriteLine("Įveskite vardą:");
            var vard = Console.ReadLine();
            Console.WriteLine("Įveskite :");
            var pavard = Console.ReadLine();
            Console.WriteLine("Įveskite kodą:");
            var kod = Convert.ToInt32(Console.ReadLine());
            programa.Duomenys(vard, pavard, kod);
            programa.Sujungti("Jonas", "Jonaitis", 5454, 10, 8, 9);
            programa.Sujungti("Petras", "Jonaitis", 4566, 7, 5, 1);

        }
        public void Duomenys( string vardas, string pavardė, int kodas)
        {
            Console.WriteLine("{0} {1} {2}", vardas, pavardė, kodas);
        }
        public void Pažymiai(int a, int b, int c)
        {
            var vidurkis = (a + b + c) / 3;
            Console.WriteLine("Pažymiai : {0},{1},{2}, vidurkis : {3}", a, b, c, vidurkis);
        }
        public void Sujungti(string vardas, string pavardė, int kodas, int a, int b, int c)
        {
            Duomenys(vardas, pavardė, kodas);
            Pažymiai(a, b, c);

        }
    }
}

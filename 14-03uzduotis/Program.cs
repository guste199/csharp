using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_03uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.Skaičiavimai(80, 9);
            programa.Skaičiavimai(485, 100);

        }
        public void Suma(int a, int b)
        {
            var suma = a + b;
            Console.WriteLine("Suma:\n {0} + {1} = {2}", a, b,suma);
        }
        public void Skirtumas(int a, int b)
        {
            var skirtumas = a - b;
            Console.WriteLine("Skirtumas:\n {0} + {1} = {2}", a, b, skirtumas);
        }
        public void Sandauga(int a, int b)
        {
            var sandauga = a * b;
            Console.WriteLine("Sandauga:\n {0} + {1} = {2}", a,b,sandauga);
        }
        public void Dalyba(int a, int b)
        {
            var dalyba = a / b;
            Console.WriteLine("Dalyba:\n {0} + {1} = {2}", a, b,dalyba);
        }
        public void Skaičiavimai(int a, int b)
        {
            Suma(a, b);
            Skirtumas(a, b);
            Sandauga(a, b);
            Dalyba(a, b);
        }

    }
}

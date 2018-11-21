using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.Vardas();
        }
        public void Vardas()
        {
            Console.WriteLine("Įveskite savo vardą:");
            var vardas = Console.ReadLine();
            Console.WriteLine("Labas, {0}", vardas);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_04uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            Console.WriteLine("Įveskite 2 skaičius: ");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            programa.Kviesti(pirmas, antras);
        }
        public void Kviesti(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("Skaičius {0} didesnis", a);
            }
            else if (a < b)
            {
                Console.WriteLine("Skaičius {0} didesnis", b);
            }
            else Console.WriteLine("Skaičiai yra lygūs");
        }
    }
}

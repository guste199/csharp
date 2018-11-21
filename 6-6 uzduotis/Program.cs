using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite pirmo egzamino rezultatą: ");
            var egzaminas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antro egzamino rezultatą: ");
            var egzaminas2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite trečio egzamino rezultatą: ");
            var egzaminas3 = Convert.ToInt32(Console.ReadLine());
            var vidurkis = (egzaminas + egzaminas2 + egzaminas3) / 3;
            if(vidurkis >= 8 && vidurkis <= 10)
            {
                Console.WriteLine("Vidurkis yra tarp 8 ir 10");
            }
            else if(vidurkis >= 5 && vidurkis < 8)
            {
                Console.WriteLine("Vidurkis yra tarp 5 ir 8");
            }
            else if(vidurkis < 5)
            {
                Console.WriteLine("Vidurkis mažiau už 5");
            }
            
        }
    }
}

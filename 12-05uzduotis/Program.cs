using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_05uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek vardų norite įvesti?");
            var kiekis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite vardus:");
            var vardai = new List<string> (kiekis);
            for(int i = 0; i < kiekis; i++)
            {
                vardai.Add(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Pirmasis vardas {0}, o paskutinis vardas yra {1}", 
                vardai.First(), vardai.Last());
            
        }
    }
}

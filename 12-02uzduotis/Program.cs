using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_02uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardai = new List<string> { "Jonė", "Jonas", "Tomas" };
            Console.WriteLine("Pirmas vardas {0}, o antras vardas {1}",
                vardai.First(), vardai.Last());
        }
    }
}

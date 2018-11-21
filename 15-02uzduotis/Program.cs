using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_02uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            var žodžiai = new List<string> { "stalas", "kėdė", "suolas", "la", "g" };
            var trumpiausias = programa.Trumpiausias(žodžiai);
            Console.WriteLine("Trumpiausias žodis: " + trumpiausias);
        }
        public string Trumpiausias(List <string> žodžiai)
        {
            var trumpiausias = žodžiai.First();

            foreach(var žodis in žodžiai)
            {
                if(žodis.Length < trumpiausias.Length)
                {
                    trumpiausias = žodis;
                }
            }
            return trumpiausias;
        }
    }
}

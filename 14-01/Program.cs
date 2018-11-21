using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
             programa.zodis("Stalas");
             programa.zodis("Laukas");
             programa.zodis("Kėdė");
             programa.zodis("Medis");
             programa.zodis("Suolas");
        }
        public void zodis(string žodis)
        {
            Console.WriteLine("--{0}--", žodis);
        }
    }
}

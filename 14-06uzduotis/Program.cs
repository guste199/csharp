using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_06uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            Console.WriteLine("Kiek skaičių norite sugeneruoti?");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            var rand = new Random();
            for(int i =0; i < skaicius; i++)
            {
                var pirmas = rand.Next(1, 100);
                programa.skaičius(pirmas);
            }
        }
        public void skaičius(int a)
        {
            Console.Write("{0} ", a);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_09uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.Metodas();
            programa.Metodas2();
        }
        public void Metodas()
        {
            var žodžiai = new List<string> {"labas", "kėdė", "tulpė" };
            var rand = new Random();
            var kiekis = 1;
            for(int i = 0; i < 1; i++)
            {
                var žodis = rand.Next();
                žodis.Add(žodžiai);
            }
        }
        public void Metodas2()
        {
            var skaičiai = new List<int> { 4, 7, 5, 4 };
            var rand = new Random();
            var kiekis = 1;
            for (int i = 0; i < kiekis; i++)
            {
                var skaičius = rand.Next(10);
                skaičiai.Add(skaičius);
            }
            foreach(int skaičius in skaičiai)
            {
                Console.WriteLine("Sugeneruotas skaičius {0}", skaičius);
            }
            Console.WriteLine();

        }
        public void Metodas3()
        {
           
        }

    }
}

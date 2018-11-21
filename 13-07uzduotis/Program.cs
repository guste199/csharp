using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_07uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.Atrinkti();
        }
        public void Atrinkti()
        {
            var rand = new Random();
            var skaičiai = new List<int>();
            var kiekis = 10;
            for(int i = 0; i < 10; i++)
            {
                var skaičius = rand.Next(10);
                skaičiai.Add(skaičius);
            }
            foreach(int skaičius in skaičiai)
            {
                Console.Write(skaičius + ",");
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_08uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.Skaiciuoti();
            programa.Skaiciuoti();
            programa.Skaiciuoti();

        }
        public void Skaiciuoti()
        {
            var skaičius = new List<int>();
            var rand = new Random();
            var kiekis = 1;
            var simbolis = '*';
            for (int i = 0; i < 1; i++)
            {
                var skaičiuss = rand.Next(100);
                skaičius.Add(skaičiuss);
                foreach(int sk in skaičius)
                {
                    Console.WriteLine(sk + "{0}", simbolis);
    
                }
            }
        }
    }
}

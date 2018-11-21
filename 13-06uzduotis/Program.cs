using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_06uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.Išvesti();
        }
        public void Išvesti()
        {
            var skaičius = new List<int> { 5, 7, 4, 1 };
            foreach(int sk in skaičius)
            {
                Console.Write(sk + ",");
            }
            Console.WriteLine();
        }
    }
}

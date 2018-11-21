using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_03uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
           var programa = new Program();
            programa.Žodis();
        }
        public void Žodis()
        {
            var žodis = Console.ReadLine();
            var žodis2 = Console.ReadLine();
            Console.WriteLine("-{0}", žodis);
            Console.WriteLine("-{0}", žodis2);


        }
    }
}

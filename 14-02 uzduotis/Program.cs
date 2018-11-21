using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.Kviesti("Jonas", "Jonaitis", 20, "administratorius");
            programa.Kviesti("Lina", "Linaitė", 40, "gidė");
        }
        public void Kviesti(string vardas, string pavardė, int amz, string profesija)
        {
            Console.WriteLine("{0} {1} yra {2}m., profesija - {3}.", vardas, pavardė, amz, profesija);
        }
    }
}

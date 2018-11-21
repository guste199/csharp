using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite egzamino pažymį [0-10]");
            var pažymys = Convert.ToInt32(Console.ReadLine());
            if(pažymys == 10)
            {
                Console.WriteLine("Puiku");
            }
            else if (pažymys == 9)
            {
                Console.WriteLine("Labai gerai");
            }
            else if(pažymys >= 7)
            {
                Console.WriteLine("Gerai");
            }
            else if(pažymys >= 5)
            {
                Console.WriteLine("Patenkinamai");
            }
            else if(pažymys < 5)
            {
                Console.WriteLine("Egzaminas neišlaikytas");
            }
        }
    }
}

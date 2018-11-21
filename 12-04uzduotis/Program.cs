using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_04uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaičiai = new List<int> ();
            Console.WriteLine("Įveskite 10 skaičių");
            skaičiai.Add(Convert.ToInt32(Console.ReadLine()));
            skaičiai.Add(Convert.ToInt32(Console.ReadLine()));
            skaičiai.Add(Convert.ToInt32(Console.ReadLine()));
            skaičiai.Add(Convert.ToInt32(Console.ReadLine()));
            skaičiai.Add(Convert.ToInt32(Console.ReadLine()));
            skaičiai.Add(Convert.ToInt32(Console.ReadLine()));
            skaičiai.Add(Convert.ToInt32(Console.ReadLine()));
            skaičiai.Add(Convert.ToInt32(Console.ReadLine()));
            skaičiai.Add(Convert.ToInt32(Console.ReadLine()));
            skaičiai.Add(Convert.ToInt32(Console.ReadLine()));


            for (int i = 0; i < 10; i++)
            {
                Console.Write(skaičiai[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

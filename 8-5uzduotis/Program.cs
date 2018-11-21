using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_5uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite rėžių pradžią:");
            var pradžia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite rėžių pabaigą:");
            var pabaiga = Convert.ToInt32(Console.ReadLine());
               if(pradžia < pabaiga)
            {
                for (int i = pradžia; i < pabaiga; i++)
                {
                    Console.WriteLine("{0} {1}", i, i * i);
                }
            }
            
        }
    }
}

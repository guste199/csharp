using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_6uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite rėžių pradžia:");
            var pradžia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite rėžių pabaigą:");
            var pabaiga = Convert.ToInt32(Console.ReadLine());
            if(pradžia < pabaiga)
            {
                for(int i = pradžia; i < pabaiga; i++)
                {
                    if(i % 2 !=0 || i % 8 ==0 )
                    {
                        Console.WriteLine(i);
                    }
                }

            }
        }
    }
}

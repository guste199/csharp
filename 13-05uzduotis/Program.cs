using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_05uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.Lentelė();
        }
        public void Lentelė()
        {
            var rand = new Random();
            var skaičiai = new List<int>();
            var kiekis = 10;
            skaičiai.Add(Convert.ToInt32(Console.ReadLine()));
            skaičiai.rand
         
                for (int i = 1; i < 10; i++)
                {
                    for (int j = 1; i < 10; i++)
                    {
                        Console.WriteLine("{0,3}", i + j);
                    }
                Console.WriteLine();
                }
            }

        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardai = new string[6] { "Luka", "Jonė", "Laura", "Lina", "Jonas", "Jurgis" };
         
            Console.WriteLine("{0} {1} {2} {3} {4}", vardai[1], vardai[0],
                vardai[4], vardai[2], vardai[5]);
      
        }
    }
}


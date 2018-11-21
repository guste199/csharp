using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_11uzduotiss
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardai = new [] { "Jonas", "Jonė", "Petras", "Lina" };
            
            foreach (string vardas in vardai)
            {
                Console.WriteLine(vardai);
            }
            Console.WriteLine(" ----------------------\r\n" +
                "| Indeksas     Vardas  \r\n" +
                "|     0         {0}  \r\n" +
                "|     1        {1} \r\n" +
                "|     2         {2} \r\n" +
                "|     3         {3}   \r\n" +
                "|------------------------", vardai);


        }
    }
}

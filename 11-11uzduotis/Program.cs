using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_11uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek norite įvesti skaičių?");
            var kiek = Convert.ToInt32(Console.ReadLine());
            var skaičiai = new int[kiek];
            //Skaičių įvedimas
            for (int i = 0; i < skaičiai.Length; i++)
            {
                Console.WriteLine("{0}-ąjis skaičius", i + 1);
                skaičiai[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Skaičių išvedimas

            Console.Write("Įvesti skaičiai : ");
            foreach (var skaičius in skaičiai)
            {
                Console.Write(skaičius + ",");

            }
            Console.WriteLine();
            Console.Write("Įvesti skaičiai: ");
            for (int i = 0; i < skaičiai.Length; i++)
            {
                Console.Write(skaičiai[i] + ",");
            }
            Console.WriteLine();
            // suma
            var suma = 0;
            foreach (int s in skaičiai)
            {
                suma += s;
            }
            Console.WriteLine("Skaičių suma : {0} ", suma);
            //VIDURKIUI
            var vidurkis = (double)suma / skaičiai.Length;
            Console.WriteLine("Vidurkis : {0}", vidurkis);

            // Lyginių skaičių suma ir vidurkis
            var lyginiųSuma = 0;
            var lyginiųKiekis = 0;
            foreach (int skaičius in skaičiai)
            {
                if (skaičius % 2 == 0)
                {
                    lyginiųSuma += skaičius;
                    lyginiųKiekis++;
                }
            }
            var lyginiųVidurkis = (double)lyginiųSuma / lyginiųKiekis;
            Console.WriteLine("Lyginių skaičių suma :" + lyginiųSuma);
            Console.WriteLine("Lyginių skaičių vidurkis: " + lyginiųVidurkis);
            // Lyginių, žemesnių už skaičių vidurkį kiekis

            var zemLyg = 0;
            foreach (int skaičius1 in skaičiai)
            {
                if (skaičius1 % 2 == 0 && skaičius1 < vidurkis)
                {
                    zemLyg++;
                }

            }
            Console.WriteLine("Lyginių. žemesnių už vidurkį kiekis : " + zemLyg);
            //Mažiausias ir didžiausias skaičiai
             var min = skaičiai.First();
             var max = skaičiai.First();

            foreach (var skaičius in skaičiai)
            {
                if (skaičius < min)
                {
                    min = skaičius;
                }
                if (skaičius > max)
                {
                    max = skaičius;
                }
            }
                Console.WriteLine("Mažiausias skaičius : {0} , Didžiausias skaičius : {2}",
                    min, max);
            
            //  Naujas masyvas, sugeneruotas iš atsitiktinių skaičių

            var rand = new Random();
            var dydis = rand.Next(10, 100);
            var atsitiktiniai = new int[dydis];
            var atsitiktiniai2 = new int[rand.Next(10, 100)];
            for(int i = 0; i < atsitiktiniai.Length; i++)
            {
                atsitiktiniai[i] = rand.Next(1000);
            }
            for(int i = 0; i < atsitiktiniai2.Length; i++)
            {
                atsitiktiniai2[i] = rand.Next(500);
                Console.WriteLine("Pirmo masyvo atsitiktiniai skaičiai:");
                foreach(var sk in atsitiktiniai)
                {
                    Console.Write(sk + " ");

                }
                Console.WriteLine();
                Console.WriteLine("Antro masyvo atsitiktiniai skaičiai: ");
                foreach(int sk in atsitiktiniai2)
                {
                    Console.Write(sk + " ");
                }
                Console.WriteLine();
            }
        }
    }
}



            


     
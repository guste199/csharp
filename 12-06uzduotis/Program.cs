using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_06uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek studentų pažymių norite įvesti?");
            var pažymių_kiekis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite pažymius: ");
            var pažymiai = new List <int> (pažymių_kiekis);
            var rand = new Random();
            var kiek = 1;
            for(int i = 0; i < pažymių_kiekis; i++)
            {
                pažymiai.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Didžiausias pažymys : " + pažymiai.Max());
            Console.WriteLine("Mažiausias pažymys : " + pažymiai.Min());
            Console.WriteLine("Pažymių vidurkis: " + pažymiai.Average());

            for (int i = 0; i < kiek; i++)
            {
                pažymiai.Add(rand.Next(10));
            }
            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine("Atsitiktinis pažymys {0}", pažymiai[i]);
            }
            var maxpažymys = 0;
            foreach(int maxpaz in pažymiai)
                {
                if(maxpaz % 10 == 0)
                {
                    maxpažymys++;
                }
            }
            Console.WriteLine("Studentus turi {0} dešimtukus", maxpažymys);
            var neigiamas = 0;
            foreach(int neigiam in pažymiai)
            {
                if( 0 < neigiam && neigiam < 4)
                {
                    neigiamas++;
                }
            }
            Console.WriteLine("Studentas gavo {0} neigiamų pažymių", neigiamas);
        }
    }
}

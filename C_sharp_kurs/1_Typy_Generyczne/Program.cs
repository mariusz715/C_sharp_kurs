using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Typy_Generyczne 
{
    class Program
    {
        static void Main(string[] args)
        {
            var kolejka = new KolejkaKolowa(pojemnosc: 4);




            var zmienna = 0.0;

            while (double.TryParse(Console.ReadLine(), out zmienna))
            {
                kolejka.zapis(zmienna);
            }


            Console.WriteLine("W kolejce znajduja sie liczby :");
            while (!kolejka.pusty)
            {
                Console.WriteLine("\t\t" + kolejka.Wypisz());

            }
            Console.ReadKey();

        }
    }
}


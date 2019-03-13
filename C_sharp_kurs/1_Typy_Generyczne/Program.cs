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
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 4);

            wprowadzaniedanych(kolejka);

            wyprowadzaniedanych(kolejka);

        }

        private static void wyprowadzaniedanych(KolejkaKolowa<double> kolejka)
        {
            Console.WriteLine("W kolejce znajduja sie liczby :");
            var suma = 0.0;
            while (!kolejka.pusty)
            {


                suma += kolejka.Wypisz();


            }
            Console.Write(suma);
            Console.ReadKey();
        }

        private static void wprowadzaniedanych(KolejkaKolowa<double> kolejka)
        {
            var zmienna = 0.0;

            while (double.TryParse(Console.ReadLine(), out zmienna))
            {
                kolejka.zapis(zmienna);
            }
        }
    }
    public class osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
 
    }
}


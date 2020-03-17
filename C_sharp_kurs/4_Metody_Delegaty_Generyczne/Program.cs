using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Metody_Delegaty_Generyczne
{
    class Program
    {

        //static void Konsola_wypisz(double dane)
        //{
        //    Console.WriteLine(dane);
        //}



        static void Main(string[] args)
        {
          //  Action<double> pisz = delegate (double liczby)
          //  {
          //      Console.WriteLine(liczby);
          //  };

          //  pisz(7.1219);


          //  Action<int, int, int> suma =(a,b,c) => Console.WriteLine(a + b + c);
          //  suma(8 ,12,19);

          //  Func<double, double> potegowanie = a => a * a;
          //  Func<double, double, double> dzielenie = (a, b) => a / b;

          //  Console.WriteLine(potegowanie(8.12));
          //  pisz(dzielenie(5.89, 3.13));


          //  Predicate<double> stosunek = a => a < 100;

          //Console.WriteLine( stosunek( potegowanie(dzielenie(9.827, 2.817))));







            var kolejka = new KolejkaKolowa<double>(pojemnosc:3);
            kolejka.elementUsuniety += Kolejka_elementUsuniety;
            WprowadzanieDanych(kolejka);


            //var jako_data = kolejka.Mapuj(a => new DateTime(2019, 12, 8).AddDays(a));

            //foreach (var item in jako_data)
            //{
            //    Console.WriteLine(item);
            //}

            kolejka.Drukuj(d=>Console.WriteLine(d));

            //var elementjakoInt = kolejka.Element_Jako<double,int>();

            //foreach (var item in elementjakoInt)
            //{
            //    Console.WriteLine(item);
            //}


            PrzetwarzanieDanych(kolejka);
        }

        private static void Kolejka_elementUsuniety(object sender, ElementUsunietyEventArgs<double> e)
        {
            Console.WriteLine("Kolejka jest pelna - element usuniety : {0} nowy element : {1} ", e.ElementUsuniety, e.ElementNowy);
        }

        private static void PrzetwarzanieDanych(IKolejka<double> kolejka)
        {
            var suma = 0.0;
            Console.WriteLine("W naszej kolejce jest :");

            while (!kolejka.JestPusty)
            {
                suma += kolejka.Czytaj();
            }
            Console.WriteLine(suma);
        }

        private static void WprowadzanieDanych(IKolejka<double> kolejka)
        {
            while (true)
            {
                var wartosc = 0.0;
                var wartoscWejsciowa = Console.ReadLine();

                if (double.TryParse(wartoscWejsciowa, out wartosc))
                {
                    kolejka.Zapisz(wartosc);
                    continue;
                }
                break;
            }
        }
    }
}

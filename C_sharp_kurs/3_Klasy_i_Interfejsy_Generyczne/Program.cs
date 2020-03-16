using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Klasy_i_Interfejsy_Generyczne
{
    class Program
    {
       
            static void Main(string[] args)
            {
                var kolejka = new KolejkaKolowa<double>();

                WprowadzanieDanych(kolejka);

            foreach (var item in kolejka)
            {
                Console.WriteLine(item);
            }


                PrzetwarzanieDanych(kolejka);
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

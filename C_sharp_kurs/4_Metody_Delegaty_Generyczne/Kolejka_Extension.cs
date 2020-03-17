using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Metody_Delegaty_Generyczne
{
    public static class Kolejka_Extension
    {

        public delegate void Action<T>(T dane);

        public static IEnumerable<Twyjscie> Mapuj<T, Twyjscie>(this DuzaKolejka<T> kolejka,Converter<T,Twyjscie>konwerter)
        {
            
            foreach (var item in kolejka)
            {
                Twyjscie wynik = konwerter(item);
                yield return wynik;
            }
           // return kolejka.Select(i => konwerter(i));
        }
        public static void Drukuj<T>(this DuzaKolejka<T> kolejak,Action<T> wydruk)
        {
            foreach (var item in kolejak)
            {
               wydruk(item);
            }

        }
    }
}

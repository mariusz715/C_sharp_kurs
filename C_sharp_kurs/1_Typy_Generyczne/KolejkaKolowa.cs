using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Typy_Generyczne
{
    public class KolejkaKolowa
    {
        public double[] bufor;
        public int poczatek_bufora;
        public int koniec_bufora;

        public KolejkaKolowa() : this(pojemnosc: 5)
        {

        }

        public KolejkaKolowa(int pojemnosc)
        {
            bufor = new double[pojemnosc + 1];
            poczatek_bufora = 0;
            koniec_bufora = 0;
        }

        public void zapis(double wartosc)
        {
            bufor[koniec_bufora] = wartosc;
            koniec_bufora = (koniec_bufora + 1) % bufor.Length;

            if (koniec_bufora == poczatek_bufora)
            {

                poczatek_bufora = (poczatek_bufora + 1) % bufor.Length;
            }

        }

        public double Wypisz()
        {
            var wynik = bufor[poczatek_bufora];
            poczatek_bufora = (poczatek_bufora + 1) % bufor.Length;
            return wynik;
        }

        public double dlugosc
        {
            get
            {
                return bufor.Length;

            }

        }
        public bool pelny
        {
            get
            {
                return (koniec_bufora + 1) % bufor.Length == poczatek_bufora;
            }
        }
        public bool pusty
        {
            get
            {
                return koniec_bufora == poczatek_bufora;
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Kolekcje_Generyczne
{
    class Program
    {
        static void Main(string[] args)

        {/*
           List< Pracownik> pracownicy = new List<Pracownik>
            {
                new Pracownik{imie ="krol",nazwisko="AVB"  },
                new Pracownik{imie ="pop",nazwisko="AVB"  },
                new Pracownik{imie ="koks",nazwisko="AVB"  },

        };
            foreach(var praca in pracownicy)
            {

                Console.WriteLine(praca.imie + " " + praca.nazwisko);
               
            }*/
         //Array.Resize(ref pracownicy, 4);---Tyko da tabic
         //pracownicy[3] = new Pracownik{ imie="XX",nazwisko="AVB"};

            /*
            var znak = new List <int>();
            var poj = 0;
            while (true)
            {
                znak.Add(1);
                if (poj != znak.Capacity)
                {
                   poj=znak.Capacity;
                    Console.WriteLine(znak.Capacity);
                }
            }*/

            Queue<Pracownik> szereg = new Queue<Pracownik>();
            szereg.Enqueue(new Pracownik { imie = "AB", nazwisko = "CD" });
            szereg.Enqueue(new Pracownik { imie = "EF", nazwisko = "GH" });
            szereg.Enqueue(new Pracownik { imie = "IJ", nazwisko = "KL" });
            szereg.Enqueue(new Pracownik { imie = "MN", nazwisko = "OP" });

            while (szereg.Count() > 0)
            {
                var osoba = szereg.Dequeue();
                Console.WriteLine(osoba.imie + " " + osoba.nazwisko);


            }

            Console.ReadKey();
        }




    }
}

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

        {
            Pracownik[] pracownicy = new Pracownik[]
            {
                new Pracownik{imie ="krol",nazwisko="AVB"  },
                new Pracownik{imie ="pop",nazwisko="AVB"  },
                new Pracownik{imie ="koks",nazwisko="AVB"  },

        };
            foreach(var praca in pracownicy)
            {

                Console.WriteLine(praca.imie + " " + praca.nazwisko);
            }


        }
    }
}

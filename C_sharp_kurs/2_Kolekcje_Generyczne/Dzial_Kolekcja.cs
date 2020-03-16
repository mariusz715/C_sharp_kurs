using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Kolekcje_Generyczne
{
     class Dzial_Kolekcja : SortedDictionary<string, SortedSet<Pracownik>>
    {
        public Dzial_Kolekcja Add(string nazwa_dzialu,Pracownik pracownik )
        {
            if (!ContainsKey(nazwa_dzialu))
            {
                Add(nazwa_dzialu, new SortedSet<Pracownik>(new Pracownik_Comparer()));
               

            }
            this[nazwa_dzialu].Add(pracownik);

            return this;

        }


    }
}

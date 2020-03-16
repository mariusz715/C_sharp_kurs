using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Kolekcje_Generyczne
{
     class Pracownik_Comparer : IEqualityComparer<Pracownik>,IComparer<Pracownik>
    {
        public int Compare(Pracownik x, Pracownik y)
        {
            return string.Compare(x.nazwisko, y.nazwisko);
        }

        public bool Equals(Pracownik x, Pracownik y)
        {
            return String.Equals(x.nazwisko, y.nazwisko);
        }

        public int GetHashCode(Pracownik obj)
        {
            return obj.nazwisko.GetHashCode();
        }
    }
}

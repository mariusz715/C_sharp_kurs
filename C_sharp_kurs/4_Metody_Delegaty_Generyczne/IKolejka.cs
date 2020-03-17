using System.Collections.Generic;

namespace _4_Metody_Delegaty_Generyczne
{
    public interface IKolejka<T>:IEnumerable<T>,IComparer<T>,IEqualityComparer<T>,IReadOnlyCollection<T>,ISet<T>,IDictionary<T,T>,ICollection<T>,IList<T>
    {
        bool JestPelny { get; }
        bool JestPusty { get; }

        T Czytaj();
        void Zapisz(T wartosc);
     // IEnumerable<Twyjscie> Element_Jako<Twyjscie>();

    }
}
﻿using System.Collections.Generic;

namespace _3_Klasy_i_Interfejsy_Generyczne
{
    public interface IKolejka<T>:IEnumerable<T>,IComparer<T>,IEqualityComparer<T>,IReadOnlyCollection<T>,ISet<T>,IDictionary<T,T>,ICollection<T>,IList<T>
    {
        bool JestPelny { get; }
        bool JestPusty { get; }

        T Czytaj();
        void Zapisz(T wartosc);
    }
}
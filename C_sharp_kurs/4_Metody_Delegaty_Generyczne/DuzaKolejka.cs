using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace _4_Metody_Delegaty_Generyczne
{
    public class DuzaKolejka<T>:IKolejka<T>
    {
      protected  Queue<T> kolejka;
        public DuzaKolejka()
        {
            kolejka = new Queue<T>();

        }

        public virtual bool JestPelny => throw new System.NotImplementedException();

        public virtual bool JestPusty
        {
            get {
                return kolejka.Count==0;
            }

        }
     /*   public IEnumerable<Twyjscie> Element_Jako<Twyjscie>()
        {
            var konwerter = TypeDescriptor.GetConverter(typeof(T));
            foreach (var item in kolejka)
            {
                var wynik = konwerter.ConvertTo(item, typeof(Twyjscie));
                yield return  (Twyjscie)wynik;
            }

        }
        */
        public int Count => throw new System.NotImplementedException();

        public ICollection<T> Keys => throw new System.NotImplementedException();

        public ICollection<T> Values => throw new System.NotImplementedException();

        public bool IsReadOnly => throw new System.NotImplementedException();

        public T this[int index] { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public T this[T key] { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public virtual T Czytaj()
        {
            return kolejka.Dequeue();
        }

        public virtual void Zapisz(T wartosc)
        {
            kolejka.Enqueue(wartosc);
        }

        public IEnumerator<T> GetEnumerator()
        {
            // return kolejka.GetEnumerator();
            foreach (var item in kolejka)
            {
                yield return item;
            }

        }

         IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
            

        }

        public int Compare(T x, T y)
        {
            throw new System.NotImplementedException();
        }

        public bool Equals(T x, T y)
        {
            throw new System.NotImplementedException();
        }

        public int GetHashCode(T obj)
        {
            throw new System.NotImplementedException();
        }

        public bool Add(T item)
        {
            throw new System.NotImplementedException();
        }

        public void UnionWith(IEnumerable<T> other)
        {
            throw new System.NotImplementedException();
        }

        public void IntersectWith(IEnumerable<T> other)
        {
            throw new System.NotImplementedException();
        }

        public void ExceptWith(IEnumerable<T> other)
        {
            throw new System.NotImplementedException();
        }

        public void SymmetricExceptWith(IEnumerable<T> other)
        {
            throw new System.NotImplementedException();
        }

        public bool IsSubsetOf(IEnumerable<T> other)
        {
            throw new System.NotImplementedException();
        }

        public bool IsSupersetOf(IEnumerable<T> other)
        {
            throw new System.NotImplementedException();
        }

        public bool IsProperSupersetOf(IEnumerable<T> other)
        {
            throw new System.NotImplementedException();
        }

        public bool IsProperSubsetOf(IEnumerable<T> other)
        {
            throw new System.NotImplementedException();
        }

        public bool Overlaps(IEnumerable<T> other)
        {
            throw new System.NotImplementedException();
        }

        public bool SetEquals(IEnumerable<T> other)
        {
            throw new System.NotImplementedException();
        }

        public bool ContainsKey(T key)
        {
            throw new System.NotImplementedException();
        }

        public void Add(T key, T value)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(T key)
        {
            throw new System.NotImplementedException();
        }

        public bool TryGetValue(T key, out T value)
        {
            throw new System.NotImplementedException();
        }

        public void Add(KeyValuePair<T, T> item)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(KeyValuePair<T, T> item)
        {
            throw new System.NotImplementedException();
        }

        public void CopyTo(KeyValuePair<T, T>[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(KeyValuePair<T, T> item)
        {
            throw new System.NotImplementedException();
        }

        IEnumerator<KeyValuePair<T, T>> IEnumerable<KeyValuePair<T, T>>.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new System.NotImplementedException();
        }

        void ICollection<T>.Add(T item)
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new System.NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        
    }
}
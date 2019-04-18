using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_Kolekcje_generyczne_Tests
{
    [TestClass]
    public class listy_test
    {
        [TestMethod]
        public void dodawanie_do_listy()
        {
            List<int> liczby = new List <int>{ 1, 2, 3 };
            liczby.Add(4);
            Assert.AreEqual(4, liczby[3]);
        }
        [TestMethod]
        public void dodawanie_wartosci()
        {
            List<int> liczby = new List<int> { 1, 2, 3 };
            liczby.Insert(1, 8);
            Assert.AreEqual(8, liczby[1]);
    }
        [TestMethod]
        public void odejmwanie_wartosci()
        {
            List<int> liczby = new List<int> { 1, 2, 3 };
            liczby.Remove(2);
            Assert.AreNotEqual(2, liczby[1]);
        }
        [TestMethod]
        public void wyszukanie_wartosci()
        {
            List<int> liczby = new List<int> { 1, 2, 3 };
            Assert.AreEqual(liczby.IndexOf(3), 2);
        }
        [TestMethod]
        public void wyszukanie2_wartosci()
        {
            List<int> liczby = new List<int> { 1, 2, 3 };
            Assert.IsTrue(liczby.Contains(3));
        }
        [TestMethod]
        public void dodawanie_do_listy_zakres()
        {
            List<int> liczby = new List<int> { 1, 2, 3 };
            var zakres= new List<int> { 4, 5, 6,7 };
            liczby.AddRange(zakres);
            Assert.AreEqual(7, liczby[6]);
        }
    }
}

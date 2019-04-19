using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_Kolekcje_generyczne_Tests
{
    [TestClass]
    public class LinkedlistTest
    {
        [TestMethod]
        public void Dodawanie()
        {
            var lista = new LinkedList<string>();
            lista.AddFirst("AB");
            lista.AddLast("BC");
            lista.AddBefore(lista.Last, "XZ");

            Assert.AreEqual("XZ", lista.First.Next.Value);
        }
        [TestMethod]
        public void Dodawanie2()
        {
            var lista = new LinkedList<string>();
            lista.AddFirst("AB");
            lista.AddLast("BC");
            lista.AddAfter(lista.First, "XZ");

            Assert.AreEqual("XZ", lista.First.Next.Value);
        }
        [TestMethod]
        public void Usuwanie()
        {
            var lista = new LinkedList<string>();
            lista.AddFirst("AB");
            lista.AddLast("BC");
            lista.RemoveLast();

            Assert.AreEqual(lista.First,lista.Last);
        }
        [TestMethod]
        public void Usuwanie2()
        {
            var lista = new LinkedList<string>();
            lista.AddFirst("AB");
            lista.AddLast("BC");
            lista.Remove("AB");

            Assert.AreEqual(lista.First.Value, lista.Last.Value);
        }
        [TestMethod]
        public void Zawiera()
        {
            var lista = new LinkedList<string>();
            lista.AddFirst("AB");
            lista.AddLast("BC");
            lista.Remove("AB");

            Assert.IsFalse(lista.Contains("AB"));
        }
        [TestMethod]
        public void Czyszczenie()
        {
            var lista = new LinkedList<string>();
            lista.AddFirst("AB");
            lista.AddLast("BC");
            lista.Clear();

            Assert.AreEqual(0,lista.Count);
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_Kolekcje_generyczne_Tests
{
    [TestClass]
    public class KolejkaTest1
    {
        [TestMethod]
        public void metoda_Peek()
        {
            var zbior = new Queue<int>();
            zbior.Enqueue(1);
            zbior.Enqueue(2);
            zbior.Enqueue(3);
            zbior.Enqueue(4);

            Assert.AreEqual(1, zbior.Peek());
        }
        [TestMethod]
        public void metoda_Contain()
        {
            var zbior = new Queue<int>();
            zbior.Enqueue(1);
            zbior.Enqueue(2);
            zbior.Enqueue(3);
            zbior.Enqueue(4);

            Assert.IsTrue(zbior.Contains(3));
        }
        [TestMethod]
        public void metoda_ToArray()
        {
            var zbior = new Queue<int>();
            zbior.Enqueue(1);
            zbior.Enqueue(2);
            zbior.Enqueue(3);
            zbior.Enqueue(4);

            var tab = zbior.ToArray();
            zbior.Dequeue();
            Assert.AreEqual(4, tab[3]);
            Assert.IsFalse(zbior.Contains(1));
        }
        [TestMethod]
        public void metoda_Clear()
        {
            var zbior = new Queue<int>();
            zbior.Enqueue(1);
            zbior.Enqueue(2);
            zbior.Enqueue(3);
            zbior.Enqueue(4);

            zbior.Clear();
            Assert.AreEqual(0, zbior.Count);
        }
    }
}

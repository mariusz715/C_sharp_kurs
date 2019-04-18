using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_Kolekcje_generyczne_Tests
{
    [TestClass]
    public class StosTest1
    {
      
            [TestMethod]
            public void metoda_Peek()
            {
                var stos = new Stack<int>();
                stos.Push(1);
                stos.Push(2);
                stos.Push(3);
                stos.Push(4);

                Assert.AreEqual(4, stos.Peek());
            }
            [TestMethod]
            public void metoda_Contain()
            {
                var stos = new Stack<int>();
                stos.Push(1);
                stos.Push(2);
                stos.Push(3);
                stos.Push(4);

                Assert.IsTrue(stos.Contains(3));
            }
            [TestMethod]
            public void metoda_ToArray()
            {
                var stos = new Stack<int>();
                stos.Push(1);
                stos.Push(2);
                stos.Push(3);
                stos.Push(4);

                var tab = stos.ToArray();
                stos.Pop();
                Assert.AreEqual(1, tab[3]);
                Assert.IsFalse(stos.Contains(4));
            }
            [TestMethod]
            public void metoda_Clear()
            {
                var stos = new Stack<int>();
                stos.Push(1);
                stos.Push(2);
                stos.Push(3);
                stos.Push(4);

                stos.Clear();
                Assert.AreEqual(0, stos.Count);
            }
        }
}

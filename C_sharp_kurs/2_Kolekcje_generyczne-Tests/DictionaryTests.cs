using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_Kolekcje_generyczne_Tests
{
    [TestClass]
    public class DictionaryTests
    {
        [TestMethod]
        public void Operacje_na_slowniku()
        {
            var mapa = new Dictionary<int, string>();
            mapa.Add(1,"jeden" );
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");

            Assert.IsNotNull(mapa[1]);
        }
        [TestMethod]
        public void Usuwanie_ze_slownika()
        {
            var mapa = new Dictionary<int, string>();
            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");

            mapa.Remove(2);

            Assert.AreEqual(2, mapa.Count);

        }
        [TestMethod]
        public void wyszukiwanie_w_slowniku()
        {
            var mapa = new Dictionary<int, string>();
            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");

            Assert.IsTrue(mapa.ContainsValue("jeden"));
        }
        [TestMethod]
        public void zerowanie_slownika()
        {
            var mapa = new Dictionary<int, string>();
            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");

            mapa.Clear();
            Assert.AreEqual(0, mapa.Count);
        }
        [TestMethod]
        public void string_slownik()
        {
            var mapa = new Dictionary<string, string>();
            mapa.Add("one", "jeden");
            mapa.Add("two", "dwa");
            mapa.Add("three", "trzy");

            Assert.AreEqual("jeden", mapa["one"]);
            Assert.IsTrue(mapa.ContainsKey("three"));
        }
    }
}

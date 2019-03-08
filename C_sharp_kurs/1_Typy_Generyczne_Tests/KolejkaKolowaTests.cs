using System;
using _1_Typy_Generyczne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1_Typy_Generyczne_Tests
{
    [TestClass]
    public class KolejkaKolowaTests
    {
        [TestMethod]
        public void CzyPusta()
        {
            var kolejka = new KolejkaKolowa();

            Assert.IsTrue(kolejka.pusty);
        }
        [TestMethod]
        public void CzyPelna()
        {
            var kolejka = new KolejkaKolowa( pojemnosc:3);
            var wartosc1 = 3.2;
            var wartosc2 = 2;
            var wartosc3 = 2.11;

            kolejka.zapis(wartosc1);
            kolejka.zapis(wartosc2);
            kolejka.zapis(wartosc3);

            Assert.IsTrue(kolejka.pel)

            Assert.IsTrue(kolejka.pusty);
        }
    }
}

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

            Assert.IsTrue(kolejka.pelny);
        }
        [TestMethod]
        public void CzyCzytaOdPoczatku()
        {
            var kolejka = new KolejkaKolowa(pojemnosc: 3);
            var wartosc1 = 3.2444;
            var wartosc2 = 0.66;
            var wartosc3 = 6.11;

            kolejka.zapis(wartosc1);
            kolejka.zapis(wartosc2);
            kolejka.zapis(wartosc3);

            Assert.AreEqual(wartosc1, kolejka.Wypisz());
            Assert.AreEqual(wartosc2, kolejka.Wypisz());
            Assert.AreEqual(wartosc3, kolejka.Wypisz());
        }
        [TestMethod]
        public void CzyNadpisuje()
        {
            var kolejka = new KolejkaKolowa(pojemnosc: 3);
            var wartosci = new[] { 1, 2, 3, 5.32, 9.32, 12.07 };
            
            foreach( var wartosc in wartosci)
            {
                kolejka.zapis(wartosc);
            }

            Assert.AreEqual(wartosci[3], kolejka.Wypisz());
            Assert.AreEqual(wartosci[4], kolejka.Wypisz());
            Assert.AreEqual(wartosci[5], kolejka.Wypisz());
        }
    }
}

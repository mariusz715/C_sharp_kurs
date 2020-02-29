using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Kolekcje_Generyczne
{
    class Program
    {
        static void Main(string[] args)

        {
            /*  List< Pracownik> pracownicy = new List<Pracownik>
               {
                   new Pracownik{imie ="krol",nazwisko="AVB"  },
                   new Pracownik{imie ="pop",nazwisko="AVB"  },
                   new Pracownik{imie ="koks",nazwisko="AVB"  },

           };
               foreach(var praca in pracownicy)
               {

                   Console.WriteLine(praca.imie + " " + praca.nazwisko);

               }*/
            //Array.Resize(ref pracownicy, 4);---Tyko da tabic
            //pracownicy[3] = new Pracownik{ imie="XX",nazwisko="AVB"};

            /*
            var znak = new List <int>();
            var poj = 0;
            while (true)
            {
                znak.Add(1);
                if (poj != znak.Capacity)
                {
                   poj=znak.Capacity;
                    Console.WriteLine(znak.Capacity);
                }
            }*/

            // Szereg();
            // Stos();
            //hash();
            // Linkedlist();
            //Linkedlist1();
            //slownik();


           
            

                Dictionary<string, List<Pracownik>> ludzie = new Dictionary<string, List<Pracownik>>();

            ludzie.Add("Sala", new List<Pracownik>(){new Pracownik{nazwisko="Nowak",imie="Piotr" },
                                                           new Pracownik{nazwisko="Nowak",imie="Jan" },
                                                           new Pracownik{nazwisko="Kos",imie="Piotr" },
                                                           new Pracownik{nazwisko="Nowy",imie="Damnian" } });
            ludzie["Sala"].Add(new Pracownik { nazwisko = "Kos", imie = "Wiktor" });


            ludzie.Add("Bar", new List<Pracownik>() { new Pracownik { nazwisko="Dukan", imie="Ola"},
                                                     new Pracownik { nazwisko="Dukan", imie="Ala"}});


            foreach (var a in ludzie)
            {
                foreach (var item in a.Value)
                {
                    Console.WriteLine(a.Key + " - " + item.nazwisko + " " + item.imie);
                }
                Console.WriteLine();

                
            }

            Console.WriteLine("Pracownicy baru: ");

            foreach (var pom in ludzie["Bar"])
            {
                Console.WriteLine("{0}  {1}", pom.imie, pom.nazwisko);
            }
        }
        private static void slownik()
        {

            Dictionary<string, Pracownik> ludzie = new Dictionary<string, Pracownik>();

            ludzie.Add("Kowal", new Pracownik { nazwisko = "Kowal", imie = "Jan" });
            ludzie.Add("Kowalski", new Pracownik { nazwisko = "Kowalski", imie = "Piotr" });
            ludzie.Add("Kowalczyk", new Pracownik { nazwisko = "Kowalczyk", imie = "Tomasz" });

            var sb = ludzie["Kowalski"];

            foreach (var a in ludzie)
            {

                Console.WriteLine("{0} - {1} {2}", a.Key, a.Value.nazwisko, a.Value.imie);
                Console.WriteLine();
            }
            {

            }
        }
        private static void Linkedlist1()
        {
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(1);
            lista.AddFirst(2);
            lista.AddFirst(3);
        
            var a = lista.First;

            lista.AddAfter(a, 9);
           lista.AddBefore(a,8);
          
          
            var p = lista.First;
            while (p != null)
            {
                Console.WriteLine(p.Value);
                p = p.Next;
            }
            Console.ReadKey();
        }

        private static void Linkedlist()
        {
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(1);
            lista.AddFirst(2);
            lista.AddFirst(3);
            lista.AddLast(4);
            lista.AddLast(5);

            foreach (var i in lista)
            {
                Console.WriteLine(i);

            }
            Console.ReadKey();
        }

        private static void hash()
        {
            HashSet<Pracownik> set = new HashSet<Pracownik>();
            var osoba = new Pracownik { imie = "AVB" };
            set.Add(osoba);
            set.Add(osoba);
            set.Add(new Pracownik { imie = "AW" });

            foreach (var m in set)
            {
                Console.WriteLine(m.imie);

            }
            Console.ReadKey();
        }

        private static void Stos()
        {
            Stack<Pracownik> stos = new Stack<Pracownik>();
            stos.Push(new Pracownik { imie = "AB", nazwisko = "CD" });
            stos.Push(new Pracownik { imie = "EF", nazwisko = "GH" });
            stos.Push(new Pracownik { imie = "IJ", nazwisko = "KL" });
            stos.Push(new Pracownik { imie = "MN", nazwisko = "OP" });
            Console.WriteLine("To jest stos");
            while (stos.Count() > 0)
            {
                var osoba = stos.Pop();
                Console.WriteLine(osoba.imie + " " + osoba.nazwisko);


            }

            Console.ReadKey();
        }

        private static void Szereg()
        {
            Queue<Pracownik> szereg = new Queue<Pracownik>();
            szereg.Enqueue(new Pracownik { imie = "AB", nazwisko = "CD" });
            szereg.Enqueue(new Pracownik { imie = "EF", nazwisko = "GH" });
            szereg.Enqueue(new Pracownik { imie = "IJ", nazwisko = "KL" });
            szereg.Enqueue(new Pracownik { imie = "MN", nazwisko = "OP" });
            Console.WriteLine("To jest kolejka");
            while (szereg.Count() > 0)
            {
                var osoba = szereg.Dequeue();
                Console.WriteLine(osoba.imie + " " + osoba.nazwisko);


            }
            Console.WriteLine();
        }
    }
}

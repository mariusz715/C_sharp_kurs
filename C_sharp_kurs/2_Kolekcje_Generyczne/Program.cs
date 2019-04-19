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

        {/*
           List< Pracownik> pracownicy = new List<Pracownik>
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

            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(1);
            lista.AddFirst(2);
            lista.AddFirst(3);

            var a = lista.First;

            lista.AddAfter(a, 9);
            lista.AddBefore(a, 6);

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

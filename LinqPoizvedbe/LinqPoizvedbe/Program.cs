using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPoizvedbe
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //var prva = 7;
            //Console.WriteLine(prva.GetType());
            //var druga = "Pozdravljen svet";
            //Console.WriteLine(druga.GetType());
            //var tretja = druga;
            //Console.WriteLine(tretja.GetType());

            //omejitve: ne sme biti izvodova spremenljivka
            //ne sme biti izvodova spremenjivka
            //ne sme biti tip vrnjene vrednosti
            //ne smemo ji prirediti null

            //string[] države = { "USA", "Canada", "UK", "Australia", "Germany", "Sweden", "Mexico", "France", "Italy", "Uganda", "Ukraine", "Spain" };
            ////brez linq
            //for (int k=0; k < države.Length; k++)
            //{
            //    if (države[k].StartsWith("U"))
            //        Console.WriteLine(države[k]);
            //}
            ////z linq
            //var uDržave = from d in države
            //              where d.StartsWith("U")
            //              select d;
            //Console.WriteLine("*******************************");
            //foreach(var x in uDržave)
            //    Console.WriteLine(x);

            ////izpiši države, ki imajo ime daljše od 5
            //var xDržave = from d in države
            //              where d.Length >= 5
            //              select d;
            //Console.WriteLine("*******************************");
            //foreach (var x in xDržave)
            //    Console.WriteLine(x);

            ////vse države, ki se začnejo z U in ime je daljše od 5

            //var yDržave = from d in države
            //              where d.StartsWith("U") && d.Length >= 5
            //              select d;
            //Console.WriteLine("*******************************");
            //foreach (var x in yDržave)
            //    Console.WriteLine(x);
            //var urejeneDržave = from d in države
            //                    orderby d
            //                    select d;
            //Console.WriteLine("*******************************");
            //foreach (var x in urejeneDržave)
            //    Console.WriteLine(x);
            //Console.ReadLine();


            //tu je glavni program
            List<Naročilo> naročilaList = setupNaročila();
            //izberi vse podatke o naročilih
            var x1 = from a in naročilaList
                     select a;
            Console.WriteLine("**********************************");
            foreach (var x in x1 )
                Console.WriteLine(x.NaročiloID + " " + x.Datum.ToString());
            //v rezultatu bi želel samo datume
            var x2 = from a in naročilaList
                     select a.Datum;
            Console.WriteLine("**********************************");
            foreach (var x in x2)
                Console.WriteLine(x.ToShortDateString());

            //v rezultatu hočem samo id naročila in datum
            var x3 = from a in naročilaList
                     select new {a.NaročiloID, a.Datum};
            Console.WriteLine("**********************************");
            foreach (var x in x3)
                Console.WriteLine(x.NaročiloID + " " + x.Datum.ToShortDateString());
            
            //podrobnosti naročila
            var x4= from a in naročilaList
                    from b in a.Elementi
                    select b;
            Console.WriteLine("**********************************");
            foreach (var x in x4)
                Console.WriteLine(x.ImeIzdelka + " " + x.Količina);

            //izpiši naročilo 9010
            var x5 = from a in naročilaList
                     where a.NaročiloID == 9010
                     select new { a.Datum };
            Console.WriteLine("**********************************");
            foreach (var x in x5)
                Console.WriteLine(x.Datum.ToShortDateString());

            var x6 = (from a in naročilaList
                     where a.NaročiloID == 9010
                     select new { a.Datum }).FirstOrDefault();
            Console.WriteLine("Datum je "+x6.Datum.ToShortDateString());

            //izpiši naročila, ki imajo več kot 2 vrstici
            var x7 = from a in naročilaList
                     where a.Elementi.Count > 2
                     select a;
            Console.WriteLine("**********************************");
            foreach (var x in x7)
                Console.WriteLine(x.NaročiloID + " " + x.Datum.ToShortDateString());

            int[] števila = { 46, 24, 79, 35, 12, 57, 80, 68 };
            var r1 = števila.Count();
            Console.WriteLine("\t" + r1);
            var r2 = števila.Sum();
            Console.WriteLine("\t"+r2);
            var r3 = števila.Min();
            Console.WriteLine("\t"+r3);
            var r4 = števila.First();
            Console.WriteLine("\t"+r4);
            var r5 = števila.Distinct().Count();
            Console.WriteLine("\t" + r5);
            Console.ReadLine();
        }
        static private List<Naročilo> setupNaročila()
        {
            List<Naročilo> NaročiloList = new List<Naročilo>();
            Naročilo o1 = new Naročilo();
            o1.Datum = DateTime.Parse("12.7.2010");
            o1.NaročiloID = 9009;
            PodrobnostiNaročila oi1 = new PodrobnostiNaročila();
            oi1.ElementID = 123;
            oi1.ImeIzdelka = "Mars";
            oi1.Količina = 2;
            o1.Elementi.Add(oi1);
            PodrobnostiNaročila oi2 = new PodrobnostiNaročila();
            oi2.ElementID = 124;
            oi2.ImeIzdelka = "Kraš";
            oi2.Količina = 3;
            o1.Elementi.Add(oi2);
            Naročilo o2 = new Naročilo();
            o2.Datum = DateTime.Parse("12.1.2011");
            o2.NaročiloID = 9010;
            PodrobnostiNaročila oi3 = new PodrobnostiNaročila();
            oi3.ElementID = 125;
            oi3.ImeIzdelka = "Mars";
            oi3.Količina = 1;
            o2.Elementi.Add(oi3);
            PodrobnostiNaročila oi4 = new PodrobnostiNaročila();
            oi4.ElementID = 126;
            oi4.ImeIzdelka = "Extreme";
            oi4.Količina = 5;
            o2.Elementi.Add(oi4);
            PodrobnostiNaročila oi5 = new PodrobnostiNaročila();
            oi5.ElementID = 127;
            oi5.ImeIzdelka = "Bazooka";
            oi5.Količina = 1;
            o2.Elementi.Add(oi5);
            PodrobnostiNaročila oi6 = new PodrobnostiNaročila();
            oi6.ElementID = 128;
            oi6.ImeIzdelka = "Sadje";
            oi6.Količina = 6;
            o2.Elementi.Add(oi6);
            NaročiloList.Add(o1);
            NaročiloList.Add(o2);

            return NaročiloList;
        }
    }
}

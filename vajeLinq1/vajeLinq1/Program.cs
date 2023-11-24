using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace vajeLinq1
{
    internal class Program
    {
        //naloga: https://ucilnice.scng.si/pluginfile.php/31856/mod_resource/content/0/LINQObjectsVaje.pdf
        static void Main(string[] args)
        {
            var kupci = new[]{
            new {KupecID=1,Ime="Janez",Priimek="Kranjski",Podjetje="Kolo"},
            new {KupecID=2,Ime="Miha",Priimek="Polanc",Podjetje="Djak"},
            new {KupecID=3,Ime="Gašper",Priimek="Rupnik",Podjetje="Fitnes"},
            new {KupecID=4,Ime="Martin",Priimek="Bolčina",Podjetje="Kolo"},
            new {KupecID=5,Ime="Alenka",Priimek="Puncer",Podjetje="Kolo"},
            new {KupecID=6,Ime="Mojca",Priimek="Širok",Podjetje="Djak"},
            new {KupecID=7,Ime="Peter",Priimek="Gulin",Podjetje="Djak"},
            new {KupecID=8,Ime="Pavel",Priimek="Gantar",Podjetje="Inn"},
            new {KupecID=9,Ime="David",Priimek="Niven",Podjetje="Inn"},
            new {KupecID=10,Ime="Erik",Priimek="Kompara",Podjetje="Fitnes"}
            };
            var podjetja = new[] {
            new {ImePodjetja="Kolo",Mesto="Nova Gorica",Država="Slovenija"},
            new {ImePodjetja="Djak",Mesto="Nova Gorica",Država="Slovenija"},
            new {ImePodjetja="Fitnes",Mesto="Ljubljana",Država="Slovenija"},
            new {ImePodjetja="Inn",Mesto="Trst",Država="Italija"},
            };
            //1. napiši LINQ stavek s katerim izbereš in izpišeš vsa imena kupcev
            var a = from ab in kupci
                    select ab.Ime;
            foreach (var ac in a)
                Console.WriteLine(ac.ToString());
            Console.WriteLine("****************************");
            //2. napiši LINQ stavek katerim izbereš in izpišeš imena in priimke kupcev
            var b = from bb in kupci
                    select new { bb.Ime, bb.Priimek};
            foreach (var bc in b)
                Console.WriteLine(bc.Ime.ToString() + " " + bc.Priimek.ToString());
            Console.WriteLine("****************************");
            //3. izberi in izpiši vsa imena podjetji iz Slovenije
            var c = from cb in podjetja
                    select cb.ImePodjetja;
            foreach (var cc in c)
                Console.WriteLine(cc.ToString());
            Console.WriteLine("****************************");
            //4. Izpiši imena podjetji urejena po abecedi
            var d = from db in podjetja
                    orderby db.ImePodjetja
                    select db;
            foreach (var dc in d)
                Console.WriteLine(dc.ImePodjetja);
            Console.WriteLine("****************************");
            //5. izpiši koliko je različnih podjetji
            var e = (from eb in podjetja
                      select eb).Count();
            Console.WriteLine("Število podjetji je " + e.ToString() + ".");
            Console.WriteLine("****************************");
            //6. izpiši koliko podjetij je iz Italije
            var f = (from fb in podjetja
                      where fb.Država == "Italija"
                      select fb).Count();
            Console.WriteLine("Število podjetji je " + f.ToString() + ".");
            Console.WriteLine("****************************");
            //7. izpiši iz koliko različnih držav imamo podjetja
            var g = (from gb in podjetja
                     select gb.Država).Distinct().Count();
            Console.WriteLine("Podjetja imamo iz " + g.ToString() + " različnih držav.");
            Console.WriteLine("****************************");
            Console.ReadLine();
        }
    }
}

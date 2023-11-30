using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UvodVDelegate
{
    internal class Program
    {
        //1. definiraj delegata - ni potreben
        //public delegate bool FunkcijaZaNize(string s);
        //2. uporabi delegata kot parameter metide
        public static List<string> DelajOperacijeNadNizi(string[] nizi,Func<string,bool> funkcija)
        {
            List<string> rezultat = new List<string>();
            foreach (string s in nizi)
            {
                if (funkcija(s))
                    rezultat.Add(s);
            }
            return rezultat;
        }
        //3. napiši metode, ki so tipa FunkcijeZaNize
        //public static bool ZačneZA(string s)
        //{
        //    return s.StartsWith("A");
        //}
        public static bool KončaZN(string s)
        {
            return s.EndsWith("n");
        }
        static void Main(string[] args)
        {
            //string[] mojiNizi = { "Adam", "Aida", "Bob", "Steve", "Jim", "Alan", "Rob", "Bill", "Jackob", "James" };
            ////FunkcijaZaNize anonimna = delegate (string s) { return s.StartsWith("A"); };
            ////List<string> x = DelajOperacijeNadNizi(mojiNizi, anonimna);
            //List<string> x=DelajOperacijeNadNizi(mojiNizi, s=>s.StartsWith("A"));
            //foreach(string s in x)
            //{
            //    Console.WriteLine(s);
            //}
            //List<string> y = DelajOperacijeNadNizi(mojiNizi, KončaZN);
            //foreach (string s in y)
            //{
            //    Console.WriteLine(s);
            //}


            int[] števila = { 5, 10, 8, 3, 6, 12 };
            var r1 = from a in števila
                     where a % 2 == 0
                     orderby a
                     select a;
            foreach(var x in r1)
            {
                Console.WriteLine(x);
            }
            var r2 = števila.Where(a => a % 2 == 0).OrderBy(a => a);
            foreach (var x in r2)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;
namespace LinqVDrevesu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Delaj();
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void Delaj()
        {
            Zaposleni d = new Zaposleni() { Id = 1, Ime = "Miha", Priimek = "Polanc", Oddelek = "IT" };
            Tree<Zaposleni> z = new Tree<Zaposleni>(d);
            z.Insert(new Zaposleni() { Id = 2, Ime = "Andrej", Priimek = "Bratina", Oddelek = "Marketing" });
            z.Insert(new Zaposleni() { Id = 4, Ime = "Lucija", Priimek = "Kovač", Oddelek = "Prodaja" });
            z.Insert(new Zaposleni() { Id = 6, Ime = "Peter", Priimek = "Gulin", Oddelek = "IT" });
            z.Insert(new Zaposleni() { Id = 3, Ime = "Miha", Priimek = "Polanc", Oddelek = "IT" });
            z.Insert(new Zaposleni() { Id = 5, Ime = "Pavel", Priimek = "Matko", Oddelek = "Prodaja" });
            //izpiši vse zapolene
            var vsi = (from a in z
                      select a).ToList();
            foreach (var x in vsi)
            {
                Console.WriteLine(x.ToString());
            }
            z.Insert(new Zaposleni() { Id = 555, Ime = "Ava", Priimek = "Prašek", Oddelek = "Prodaja" });
            Console.WriteLine("*********************************");
            foreach (var x in vsi)
            {
                Console.WriteLine(x.ToString());
            }
            //izpiši vse oddelke
            var x1 = from a in z
                     select a.Oddelek;
            foreach (var x in x1)
            {
                Console.WriteLine(x);
            }
            //izpiši različne 
            var x2 = from a in z
                     select a.Oddelek;
            foreach (var x in x2)
            {
                Console.WriteLine(x);
            }
            //izpiši zaposlene v IT oddelku
            var x3 = from a in z
                     where a.Oddelek == "IT"
                     select a;
            Console.WriteLine("*************************");
            foreach(var x in x3)
            {
                Console.WriteLine(x.ToString());
            }
            //izpiši zaposlene po oddelkih
            var x4 = from a in z
                     group a by a.Oddelek;
            foreach (var x in x4)
            {
                Console.WriteLine("Oddelek "+x.Key);
                foreach(var y in x)
                {
                    Console.WriteLine(y.ToString());
                }
            }
        }
    }
}

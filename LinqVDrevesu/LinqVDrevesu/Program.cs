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
        }
    }
}

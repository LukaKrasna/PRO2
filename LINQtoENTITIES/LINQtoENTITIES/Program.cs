using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoENTITIES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //naloga 7.ma : https://ucilnice.scng.si/pluginfile.php/32040/mod_resource/content/0/LINQ_to_Entitites.pdf
            nwEntities1 nw = new nwEntities1();
            nw.Database.Log = Console.WriteLine;
            var pijače = from p in nw.Products
                         where p.Categories.CategoryName == "Beverages"
                         orderby p.ProductName
                         select p;
            Console.WriteLine("Imamo "+pijače.Count()+ " pijač.");
            var pi=nw.Products.Where(a=>a.Categories.CategoryName == "Beverages").OrderBy(e=>e.ProductName).Count();
            Console.WriteLine("Imamo "+pi+"pijač.");
            Products produkt=pijače.FirstOrDefault();
            Console.WriteLine("stara cena " +produkt.UnitPrice);
            if (produkt != null)
            {
                decimal novaCena = (decimal)produkt.UnitPrice + 10;
                produkt.UnitPrice = novaCena;
                nw.SaveChanges();
            }
            Console.WriteLine("Nova cena "+produkt.UnitPrice);
            Console.ReadLine();
        }
    }
}

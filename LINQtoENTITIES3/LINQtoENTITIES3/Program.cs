using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoENTITIES3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //naloga:https://ucilnice.scng.si/pluginfile.php/41749/mod_resource/content/0/VajaLinqToEntities.pdf
            ElektrikaEntities1 en = new ElektrikaEntities1();
            //1. izberi čas meritve in skupno moč
            //ista poizvedba z lambda izrazom
            var x1 = en.Meritve.Select(e => new { Čas = e.ZapisČas, Moč = e.kW1 + e.kW2 + e.kW3 });
            var x = from a in en.Meritve
                    select new {Čas = a.ZapisČas, Moč = a.kW1 + a.kW2 + a.kW3 };
            //2. izberi čas meritve in skupno moč za datum 18.8.2013
            var x2 = from a in en.Meritve
                     where a.ZapisČas.Value.Day == 20 && a.ZapisČas.Value.Month == 8
                     select new { Čas = a.ZapisČas, Moč = a.kW2 + a.kW2 + a.kW3 };
            //foreach (var y in x)
            //{
            //    Console.WriteLine(y.Čas + " " + y.Moč);
            //}
            //3. izračunaj povprečno moč za datum 18.8.2013
            var x3 = from a in en.Meritve
                     where a.ZapisČas.Value.Day == 20 && a.ZapisČas.Value.Month == 8
                     select new { Moč = (a.kW2 + a.kW2 + a.kW3)/3 };// ni prav

            //4. izračunaj maximalno moč za ta datum
            //5. izračunaj minimalno moč za ta datum
            //6. izračunaj povprečno moč po urah za dan 18.8.2013
            //7. izračunaj 15 minutna povprečja za 18.8.2013
            en.Database.Log = Console.WriteLine;
            var x7 = from b in en.Meritve
                     where b.ZapisČas.Value.Month == 8
                     let ural = b.ZapisČas.Value.Hour
                     let minuta = b.ZapisČas.Value.Minute
                     let quater = minuta / 15
                     group b by new { ural, quater } into z
                     orderby z.Key
                     select new
                     {
                         Ura = z.Key.ural,
                         Minuta = z.Key.quater,
                         Moč = z.Average(e => e.A1 * e.V1 + e.A2 * e.V2 + e.A3 + e.V3),
                     };
            foreach (var y in x7)
            {
                Console.WriteLine(y.Ura + " " + y.Minuta * 15 + " " + y.Moč/1000);
            }
        }
    }
}

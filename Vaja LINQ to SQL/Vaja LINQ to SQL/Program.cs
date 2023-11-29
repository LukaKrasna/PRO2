using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_LINQ_to_SQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //naloga:https://ucilnice.scng.si/pluginfile.php/189231/mod_resource/content/0/Vaja%20LINQ%20to%20SQL%20Brez.pdf
            //1. izpiši vsa imena in kode modelov letal iz tabele model
            ArdiaDataContext ar = new ArdiaDataContext();
            var a1 = from b in ar.MODELs
                     select b;
            Console.WriteLine("**************************");
            foreach (var x in a1)
            {
                Console.WriteLine(x.MOD_IME + " " + x.MOD_KODA);
            }
            Console.ReadLine();
            //2. izpiši imena vseh zaposlenih, ki so piloti

            //3. izpiši imena in priimke vseh strank
            //4. izpiši podatke o čarterskih poletih - datum in cilj zbrane po strankah
            //5. izpiši podatke o čarterskih poletih - datum in cilj, zbrane po pilotih
            //6. izpiši podatke o čarterskih poletih urejene po ciljih
            //7. razvrsti čarterske polete po urah čakanja- izpiši cilj in ure čakanja
            //8. vstavi stranko s priimkom Saksida, imenom Miran v tabelo Strank
            //upoštevaj, da je koda stranke samoštevilo
            //9. stranki s priimkom Ramas spremeni telefon v 123-456
            //10. izbriši stranke s priimkom Smith
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ho_izmišljeno_podjetje_za_mobilno_telefonijo_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kupec janez = new Kupec();
            janez.Ime = "Janez Novak";
            janez.BeležiKlic(100, 2);
            Console.WriteLine(janez.Ime + " dolguje " + janez.Stanje + " evrov.");
            Kupec60 alenka=new Kupec60();
            alenka.Ime = "Alenka Prinčič";
            alenka.BeležiKlic(100, 1);
            Console.WriteLine(alenka.Ime+" dolguje "+alenka.Stanje + " evrov.");
            Console.ReadLine();
        }
    }
}

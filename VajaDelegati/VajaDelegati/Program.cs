using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaDelegati
{
    internal class Program
    {
        delegate string Spremeni(string s);
        static void Main(string[] args)
        {
            Func<string,string> mojaMetoda = s=>s.ToLower();
            string ime = "Dakota";
            Console.WriteLine(mojaMetoda(ime));
            Console.ReadLine();
        }
        //static string WeLike(string s)
        //{
        //    return s.ToUpper();
        //}
        //static string VMale(string s)
        //{
        //    return s.ToLower();
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Generiki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sklad s = new Sklad(10);
            //s.Push(1);
            //s.Push("a");
            //s.Push("b");
            //string x=(string)s.Pop();
            //SkladGen<string> sg = new SkladGen<string>(10);
            //sg.Push("A");
            //sg.Push("1");
            //SkladGen<int> sg1=new SkladGen<int> (10);
            //sg1.Push(1);
            //sg1.Push(2);
            //Console.WriteLine(x);
            PovezanaLista<int, string> lista = new PovezanaLista<int, string>();
            lista.Dodaj(1, "A");
            PovezanaLista<DateTime, string> pl = new PovezanaLista<DateTime, string>();
            pl.Dodaj(DateTime.Now, "B");
        }
    }
}

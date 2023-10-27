using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabela a = new Tabela(10);
            a.Dodaj("a");
            a.Dodaj("b");
            a.Dodaj("m");
            a.Dodaj("d");
            a.Dodaj("f");
            a.Dodaj("v");
            a.Dodaj("h");
            a.Dodaj("i");
            a.Dodaj("l");
            a.Dodaj("k");
            Console.WriteLine("Neurejena tabela");
            a.Izpis();
            a.QuickSort(0, 9);
           
            Console.WriteLine("urejena tabela");
            a.Izpis();
            Console.ReadLine();
        }
    }
}

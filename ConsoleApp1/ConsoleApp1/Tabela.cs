using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Tabela
    {
        string[] tab;
        int štEelementov;
        public Tabela(int velikost)
        {
            tab = new string[velikost];
            štEelementov = 0;
        }
        public void Dodaj(string x)
        {
            tab[štEelementov] = x;
            štEelementov++;
        }
        public void Izpis()
        {
            for (int k = 0; k < tab.Length; k++)
            {
                Console.Write(tab[k]+"\t");
            }
            Console.WriteLine();
        }
        public int Pivot(int zač, int konec)
        {
            //razvrsti elemente v tabeli glede na pivotni element
            // vrne pozicijo elementa glede na katerega smo razvrščali
            string p = tab[zač];
            int m = zač;
            int n = konec + 1;
            //poišči z m prvega večjega od p
            do
            {
                m = m + 1;
            } while (m < konec && tab[m].CompareTo(p) <= 0);

            do
            {
                n = n - 1;
            } while (tab[n].CompareTo(p) > 0);

            while (m < n)
            {
                string temp = tab[m];
                tab[m] = tab[n];
                tab[n] = temp;

                do
                {
                    m = m + 1;
                } while (tab[m].CompareTo(p) <= 0);

                do
                {
                    n = n - 1;
                } while (tab[n].CompareTo(p) > 0);
            }

            string temp2 = tab[n];
            tab[n] = tab[zač];
            tab[zač] = temp2;

            return n;
        }
        public void QuickSort(int zač, int konec)
        {
            if (zač < konec)
            {
                int n = Pivot(zač, konec);
                Izpis();
                QuickSort(zač, n - 1);
                QuickSort(n + 1, konec);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiPrimer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "POTOP";
            Console.WriteLine("Je " + a + " palindrom?" + JePalindrom(a));
            //Console.ReadLine();

            //Del 2. naloge
            Console.WriteLine("Je ABBA palindrom? " + JePalindrom("ABBA"));
            Hanoi(4, "a", "c", "b");
            Console.ReadLine();
        }
        //napiši rekurzivno metodo, ki ugotovi ali je beseda palindrom (to so besede, ki se preberejo isto tudi vbratno npr. kisik, radar, ana, potop...).
        //Če je dolžina besede 0 ali 1 ptoem je pelindrom
        static bool JePalindrom(string beseda)
        {
            int d = beseda.Length; //to drži število dolžine besede
            if (d== 0 || d==1)
            {
                return true;
            }
            char črka = beseda[0];
            char zadnjaČrka = beseda[beseda.Length - 1];
            string nov = beseda.Substring(1);
            return črka == zadnjaČrka && JePalindrom(beseda.Substring(1, d - 2));
        }
        //2. naloga
        static void Hanoi(int n, string zač, string kon, string pomoč)
        {
            if(n==1)
            {
                Console.WriteLine("Predstavi obroč iz " + zač + " na " +  kon);
                return;
            }
            Hanoi(n - 1, zač, pomoč, kon);
            Console.WriteLine("Predstavi obroč iz " + zač + " na " + kon);
            Hanoi(n - 1, pomoč, kon, zač);

        }
    }
}

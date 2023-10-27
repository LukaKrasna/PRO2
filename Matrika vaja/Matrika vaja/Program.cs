using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrika_vaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Naloga: https://ucilnice.scng.si/pluginfile.php/26202/mod_resource/content/0/Matrike.pdf
            Matrika m1 = new Matrika();
            Matrika m2 = new Matrika();
            /*Random r = new Random();
            for (int x = 0; x < 3; x++)
                for (int y = 0; y < 3; y++)
                {
                    m1.m[x, y] = r.NextDouble();
                    m2.m[x, y] = r.NextDouble();
                }
            */
            m1.m[0, 0] = 1;
            m1.m[0, 1] = 0;
            m1.m[0, 2] = 1;
            m1.m[1, 0] = -1;
            m1.m[1, 1] = 1;
            m1.m[1, 2] = 1;
            m1.m[2, 0] = 1;
            m1.m[2, 1] = 1;
            m1.m[2, 2] = 1;
            m2.m[0, 0] = 2;
            m2.m[0, 1] = 1;
            m2.m[0, 2] = 0;
            m2.m[1, 0] = 0;
            m2.m[1, 1] = 0;
            m2.m[1, 2] = 0;
            m2.m[2, 0] = 0;
            m2.m[2, 1] = 0;
            m2.m[2, 2] = 0;
            Console.WriteLine("Matrika 1");
            m1.Tiskaj();
            Console.WriteLine("Matrika 2");
            m2.Tiskaj();
            Console.WriteLine("Matrika 3");
            Matrika m3 = m1 + m2;
            m3.Tiskaj();
            Console.ReadLine();
        }
    }
}

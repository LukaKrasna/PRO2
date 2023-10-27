using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._10._2023__Strukture_
{
    internal class Program
    {
        struct Vektor
        {
            public double x, y, z;
            public double this[int i]//indekser
            {
                get
                {
                    switch(i)
                    {
                        case 0:
                            return x;
                        case 1:
                            return y;
                        case 2:
                            return z;
                        default:
                            throw new IndexOutOfRangeException("napačen indeks");
                    }
                }
                set
                {
                    switch(i)
                    {
                        case 0:
                            x = value;
                            break;
                        case 1:
                            y = value;
                            break;
                        case 2:
                            z = value;
                            break;
                        default:
                            throw new IndexOutOfRangeException("napačen indeks");
                    }
                }
            }
            public override string ToString()
            {
                return "("+x+", "+y+", "+z+")";
            }
            public Vektor(double x1,double y1, double z1)
            {
                x = x1; y = y1; z = z1;
            }
            public Vektor(Vektor w)
            {
                x = w.x;y = w.y; z = w.z;
            }
            public static Vektor operator+ (Vektor levi, Vektor desni)
            {
                Vektor r = new Vektor();
                r.x = levi.x +desni.x;
                r.y = levi.y + desni.y;
                r.z=levi.z + desni.z;
                return r;
            }

            public static Vektor operator * (double levi,Vektor desni)
            {
                return new Vektor(levi * desni.x, levi * desni.y, levi * desni.z);
            }
            public static Vektor operator * (Vektor levi, double desni)// * ta koda popravi, da (v*2) tudi deluje
            {
                return desni * levi;
            }
            public static double operator * (Vektor levi, Vektor desni)
            {
                return levi.x*desni.x+levi.y*desni.y+levi.z*desni.z;
            }
            public static bool operator == (Vektor levi, Vektor desni)
            {
                return levi.x == desni.x && levi.y == desni.y && levi.z == desni.z;
            }
            public static bool operator !=(Vektor levi, Vektor desni)
            {
                return !(levi == desni);
            }
        }
        static void Main(string[] args)
        {
            Vektor v;
            v.x =  1;
            v.y = -1;
            v.z =  1;
            Console.WriteLine(v.ToString());
            Vektor z=new Vektor(1,-2,3);
            Console.WriteLine(z.ToString());
            Vektor u = new Vektor(v);
            Console.WriteLine(u.ToString());
            Vektor w = v + z;
            Console.WriteLine(w.ToString());
            Console.WriteLine((2*v).ToString());//(v*2) =/= (2*v) glej kodo z oznako "*"
            Console.WriteLine("Skalarni produkt je "+(v*z));
            Console.WriteLine("v=w? " + (v==w));
            for(int k = 0;k<3;k++)
            {
                Console.WriteLine(v[k]);
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izjeme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vnos;
            while (true)
            {
                try
                {
                    Console.WriteLine("Vnesi število med 1 in 5 ali return za konec.");
                    vnos = Console.ReadLine();
                    if (vnos == "")
                    {
                        break;
                    }
                    int index = int.Parse(vnos);
                    if(index<1 || index>5)
                    {
                        throw new IndexOutOfRangeException("Število mora biti med 1 in 5.");
                    }
                    Console.WriteLine("Tvoje število je " + index + ".");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Napačen vnost.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Prišlo je do napake.");
                    Console.WriteLine(e.Message);//To bo v programu izpisalo sporočilo napake
                }
            }
            Console.ReadLine();
        }
    }
}

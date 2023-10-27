using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Klici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "Vnesi ime datoteke");
            string imeDat = Console.ReadLine();
            Bralec osebe = new Bralec();
            try
            {
                osebe.Odpri(imeDat);
                for(int k=0;k<osebe.NOseb;k++)
                {
                    osebe.ObravnavajNaslednjega();
                }
            }
            catch(FileNotFoundException) 
            {
                Console.WriteLine("Datoteka " + imeDat + " ne obstaja");
            }
            catch(KliciException x) 
            {
                Console.WriteLine(  "Datoteka je v napačnem formatu.");
                Console.WriteLine("Podrobnosti " + x.Message);
                if(x.InnerException != null)
                {
                    Console.WriteLine("Notranja napaka " + x.InnerException.Message);
                }
            }
            catch (Exception x) { Console.WriteLine(x.Message); }
            Console.ReadLine();
        }
    }
}

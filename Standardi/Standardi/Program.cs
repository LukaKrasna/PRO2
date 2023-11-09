using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Standardi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("liga.xml", FileMode.Create);
            XmlSerializer s = new XmlSerializer(typeof(NogometnaLiga));
            NogometnaLiga n=new NogometnaLiga();
            s.Serialize(fs, n);
            fs.Close();
            Console.WriteLine("Konec");
            Console.ReadLine();
        }
    }
}

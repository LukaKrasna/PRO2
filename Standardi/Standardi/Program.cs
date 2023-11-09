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
            //FileStream fs = new FileStream("liga.xml", FileMode.Create);
            //XmlSerializer s = new XmlSerializer(typeof(NogometnaLiga));
            //NogometnaLiga n=new NogometnaLiga();
            //s.Serialize(fs, n);
            //fs.Close();
            FileStream fs = new FileStream("d:\\pro2\\liga.xml", FileMode.Open);
            XmlSerializer s = new XmlSerializer(typeof(NogometnaLiga));
            NogometnaLiga x = null;
            x=(NogometnaLiga)s.Deserialize(fs);
            foreach(Ekipa a in x.liga)
            {
                Console.WriteLine(  a.Ime);
            }
            Console.WriteLine("Konec");
            Console.ReadLine();
        }
    }
}

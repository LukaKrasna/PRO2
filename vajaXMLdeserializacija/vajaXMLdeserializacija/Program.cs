using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace vajaXMLdeserializacija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new
            FileStream(@"D:\Pro2\vajaXMLdeserializacija\vajaXMLdeserializacija\Vaja.xml", FileMode.Open);
            XmlSerializer s = new XmlSerializer(typeof(IzdaniRacunEnostavni));
            IzdaniRacunEnostavni a = (IzdaniRacunEnostavni)s.Deserialize(fs);
            foreach (var x in a.Racun.PostavkeRacuna)
            {
                Console.WriteLine(x.OpisiArtiklov.OpisArtikla.OpisArtikla1 + " " + x.KolicinaArtikla.Kolicina + " " + x.ZneskiPostavke.ZnesekPostavke);
            }
                Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MeteoXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("D:\\Pro2\\MeteoXML\\MeteoXML\\Meteo.xml", FileMode.Open);
            XmlSerializer s=new XmlSerializer(typeof(data));
            data podatki=(data)s.Deserialize(fs);
            foreach(dataMetData x in podatki.metData) 
            {
                Console.WriteLine(x.validStart+" "+ x.tavg+" "+x.valid_UTC);
            }
            Console.ReadLine();
        }
    }
}

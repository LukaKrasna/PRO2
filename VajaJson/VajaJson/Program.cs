using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VajaJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("Podatki.json", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string prebrano = sr.ReadToEnd();
            List<Poglavje> n = JsonConvert.DeserializeObject<List<Poglavje>>(prebrano);
            foreach ( x in n.)
            {
                Console.WriteLine(x.Ime);
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karitas__pisanje_in_branje_iz_datotek_
{
    [Serializable] //zaradi pisanja v binarno datoteko
    public class Darovi
    {
        public int ZapŠt { get; set; }
        public DateTime Datum { get; set; }
        public string Namen { get; set; }
        public double Znesek { get; set; }
        public string Opombe { get; set; }
        public Darovi() { }//{} jih rabimo samo za pisanje podatkov
    }
}

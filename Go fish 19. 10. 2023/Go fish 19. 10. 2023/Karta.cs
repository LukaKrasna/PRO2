using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go_fish_19._10._2023
{
    internal class Karta
    {
        //Naloga: https://ucilnice.scng.si/pluginfile.php/80438/mod_resource/content/0/Na%C5%A1tevni%20tipi%20in%20zbirke.pdf
        public Barve b;
        public Vrednosti v;
        public string Ime;
        public Karta(Barve b1, Vrednosti v1)
        {
            b = b1;
            v = v1;
            Ime = v + " " + b;
        }
        public override string ToString()
        {
            return Ime;
        }
    }
}

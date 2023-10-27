using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ho_izmišljeno_podjetje_za_mobilno_telefonijo_
{
    internal class Kupec
    {
        protected string ime;
        protected decimal stanje;

        public string Ime { get => ime; set => ime = value; }
        public decimal Stanje { get => stanje; }

        public void BeležiPlačilo(decimal plačano)
        {
            stanje -= plačano;
        }
        public void BeležiKlic(int minute, int tip)
        {
            switch (tip)
            {
                case 1: //klic v mobilno
                    stanje += minute * 0.02m;//0.01 je double. 0.01m pa je decimal
                    break;
                case 2://klic v stacionarno
                    stanje += minute * 0.2m;
                    break;
            }
        }
    }
}

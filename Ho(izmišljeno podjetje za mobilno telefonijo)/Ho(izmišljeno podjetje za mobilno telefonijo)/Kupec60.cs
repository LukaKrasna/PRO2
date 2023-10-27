using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ho_izmišljeno_podjetje_za_mobilno_telefonijo_
{
    internal class Kupec60:Kupec
    {
        private int višjaTarifaPorabljeno;
        public new void BeležiKlic(int minute, int tip)
        {
            switch (tip)
            {
                case 1: //klic v mobilno
                    int vMin, nMin;
                    int šeVMinute = (višjaTarifaPorabljeno < 60) ? 60 - višjaTarifaPorabljeno : 0;//isto kot if stavek
                    if (minute>šeVMinute)
                    {
                        vMin = šeVMinute;
                        nMin = minute - vMin;
                    }
                    else
                    {
                        vMin = minute;
                        nMin = 0;
                    }
                    stanje += vMin*0.03m+nMin*0.01m;//0.03 je double. 0.03m pa je decimal
                    višjaTarifaPorabljeno += vMin;
                    break;
                case 2://klic v stacionarno
                    stanje += minute * 0.2m;
                    break;
            }
        }
    }
}

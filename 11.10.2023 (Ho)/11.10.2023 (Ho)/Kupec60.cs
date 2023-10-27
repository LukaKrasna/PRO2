using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._10._2023__Ho_
{
    internal class Kupec60:Kupec
    {
        private int VišjaTarifaPorabljeno;
        public override void BeležiKlic(int minute , int tip) //12.10 override
        {
            switch (tip)
            {
                case 1: //klic v mobilno
                    int vMin, nMin;
                    int šeVMinute = (VišjaTarifaPorabljeno < 60) ? 60 - VišjaTarifaPorabljeno : 0;
                    if (minute > šeVMinute)
                    {
                        vMin = šeVMinute;
                        nMin = minute - vMin;
                    }
                    else
                    {
                        vMin = minute;
                        nMin = 0;
                    }
                    stanje += vMin * 0.03m + nMin * 0.01m; //m za deci
                    VišjaTarifaPorabljeno += vMin;
                    break;

                case 2: //klic v stacionarno
                    stanje += minute * 0.2m; //m za deci
                    break;
            }
        }
    }
}

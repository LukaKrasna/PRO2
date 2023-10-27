using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._10._2023__Ho_
{
    internal class Kupec
    {
        private string ime;
        public decimal stanje;

        public string Ime { get => ime; set => ime = value; }
        public decimal Stanje { get => stanje;}

        public void BeležiPlačilo(decimal plačano)
        {
            stanje -= plačano;
        }
        public virtual void BeležiKlic(int minute, int tip)  //12.10 virtual
        {
            switch(tip)
            {
                case 1: //klic v mobilno
                    stanje += minute * 0.02m; //m za deci
                    break;

                case 2: //klic v stacionarno
                    stanje += minute * 0.2m; //m za deci
                    break;
            }
        }
        //12.10.2023
        public override string ToString()
        {
            return ime + " dolguje " + stanje;
        }
    }
}

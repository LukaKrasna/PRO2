using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._10._2023__Mutanti_
{
    internal class Fizikalec : Mutant
    {
        public override int KvocientNevarnosti() {
            return Stopnja * IQ * Moč;
        }
        public int IQ { get; set; }
        public int Moč { get; set; }

    }
}

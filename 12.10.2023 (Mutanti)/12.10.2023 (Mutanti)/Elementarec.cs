using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._10._2023__Mutanti_
{
    internal class Elementarec : Mutant
    {
        public int Področje { get; private set; }

        public override int KvocientNevarnosti()
        {
            return Stopnja + Področje;
        }


    }
}
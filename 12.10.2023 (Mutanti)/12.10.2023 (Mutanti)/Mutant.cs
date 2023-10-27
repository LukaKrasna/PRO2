using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._10._2023__Mutanti_
{
    internal abstract class Mutant : IPrikazovalnik
    {
        private string ime;
        private int stopnja;

        public string Ime { get => ime; set => ime = value; }
        public int Stopnja { get => stopnja; set => stopnja = value; }

        public abstract int KvocientNevarnosti();

        public void PrikažiInformacije()
        {
            Console.WriteLine( ime + " ima kvocient nevarnosti " + KvocientNevarnosti() );
        }
    }
}

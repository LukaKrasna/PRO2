using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klici
{
    internal class KliciException : ApplicationException
    {
        public KliciException(string sporočilo):base("Kici " + sporočilo)
        {
            //tu ni kode
        }
        public KliciException(string sporočilo, Exception notranje):
            base("Klici " + sporočilo,notranje)
        {
            
        }
    }
}

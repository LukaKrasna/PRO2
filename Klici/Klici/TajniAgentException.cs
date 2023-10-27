using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klici
{
    internal class TajniAgentException:ApplicationException
    {
        public TajniAgentException(string imeAgenta):
            base("Najden tajni agent " + imeAgenta)
        {

        }
        public TajniAgentException(string imeAgenta, Exception notrnaja):
            base("Najden tajni agent " + imeAgenta, notrnaja)
        {
            
        }
    }
}

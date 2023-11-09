using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raziskovalec_WPF
{
    internal class Imena_datotek
    {
        public string Ime { get; set; }
        public ObservableCollection<Imena_datotek> Elementi { get; set; }
        public Imena_datotek()
        {
            Elementi = new ObservableCollection<Imena_datotek>();
        }
    }
}

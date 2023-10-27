using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    class Igralec
    {
        private string ime;

        public string Ime
        {
            get { return ime; }
        }
        private Kup roka;
        private TextBox textNaFormi;
        private Random random;
        public Igralec(string i, Random r, TextBox t)
        {
            ime = i;
            random = r;
            textNaFormi = t;
            roka = new Kup(new Karta[] { });
            textNaFormi.Text += ime + " se pridruži igri " + Environment.NewLine;
        }
        public IEnumerable<Vrednosti> IzločiKomplete()
        {
            List<Vrednosti> kompleti = new List<Vrednosti>();
            for (int i = 1; i <= 13; i++)
            {
                Vrednosti v = (Vrednosti)i;
                int k = 0;
                for (int j = 0; j < roka.Count; j++)
                {
                    if (roka.Peek(j).Vrednost == v)
                        k++;
                }
                if (k == 4)
                {
                    kompleti.Add(v);
                    roka.PullOutValues(v);
                }
            }
            return kompleti;
        }
        //uporabno samo, če je igralec računalnik
        public Vrednosti DobiNaključnoVrednosti()
        {
            Karta n = roka.Peek(random.Next(roka.Count));
            return n.Vrednost;
        }
        public Kup imaškakšno(Vrednosti v)
        {
            Kup imam = roka.PullOutValues(v);
            textNaFormi.Text += ime + " ima " + imam.Count + " " + v + Environment.NewLine;
            return imam;
        }
        public void VprašajZaKarto(List<Igralec> i, int mojIndeks, Kup talon, Vrednosti v)
        {
            textNaFormi.Text += ime + " spršauje, če ma kdo " + v + Environment.NewLine;
            int daneKarteSKupaj = 0;
            for (int k = 0; k < i.Count; k++)
            {
                if (k != mojIndeks)
                {
                    Igralec ig = i[k];
                    Kup daneKarte = ig.imaškakšno(v);
                    daneKarteSKupaj += daneKarte.Count;
                    while (daneKarte.Count > 0)
                        roka.Add(daneKarte.Deli());
                }
            }
            if (daneKarteSKupaj == 0 && talon.Count > 0)
            {
                textNaFormi.Text += ime + " mora potegniti karto iz talona " + Environment.NewLine;
                roka.Add(talon.Deli());
            }
        }
        //vprašaj za karto, kjer je vrednost naključna
        public void VprašajZaKarto(List<Igralec> i, int mojIndeks, Kup talon)

        {
            if (talon.Count > 0)
            {
                if (roka.Count == 0)
                    roka.Add(talon.Deli());
                Vrednosti nak = DobiNaključnoVrednosti();
                VprašajZaKarto(i, mojIndeks, talon, nak);
            }
        }
        public int ŠtevecKart { get { return roka.Count; } }
        public void VzemiKarto(Karta k)
        {
            roka.Add(k);
        }
        public IEnumerable<string> Imena()
        {
            return roka.ImenaKart();
        }
        public Karta Peek(int št)
        {
            return roka.Peek(št);
        }
        public void SortRoka()
        {
            roka.Sort();
        }
    }
}

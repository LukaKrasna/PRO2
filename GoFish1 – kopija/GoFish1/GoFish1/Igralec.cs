using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish1
{
    internal class Igralec //človek ali računalnik
    {
        public string Ime;
        public Kup roka; //karte, ki jih ima igralec v roki
        Random r=new Random();
        TextBox textNaFormi;
        public Igralec(string i, Random r, TextBox t)
        {
            //Konstruktor inicializira atribute Igralca
            //v vnosno polje doda tekst "Joe se je pridružil igri"
            ////in prehod 
            //v novo vrstico
            Ime = i;
            this.r = r;
            textNaFormi = t;
            roka = new Kup(new Karta[] { });
            textNaFormi.Text += Ime + " se je pridružil igri. \n";
        }
        //igralec izloči komplete
        public IEnumerable<Vrednosti> IzločiKomplete()
        {
            List<Vrednosti> kompleti=new List<Vrednosti>();
            for (int i=1; i <= 13; i++)
            {
                Vrednosti v = (Vrednosti)i;
                int št = 0;
                for (int k = 0; k< roka.Count;k++)
                {
                    if (roka.Peek(k).Vrednost==v)
                    {
                        št++;//poveča št za 1
                    }
                    if (št == 4)
                    {
                        kompleti.Add(v);
                        roka.PullOutValues(v);
                    }
                }
            }
            return kompleti;
        }
        //računalnik mora izbrati naključno vrednost (od karte), a jo mora imeti v rokah
        public Vrednosti DobiNaključnoVrednost()
        {
            Karta n = roka.Peek(r.Next(roka.Count));
            return n.Vrednost;
        }
        //Imaš kakšno karto?
        public Kup ImašKakšno(Vrednosti v)
        {
            Kup imam = roka.PullOutValues(v);
            textNaFormi.Text += Ime + " ima " + imam.Count + " " + v +Environment.NewLine;
            return imam;
        }
        public void VprašajZaKarto(List<Igralec> i,int mojIndeks, Kup talon, Vrednosti v)
        {
            //i=seznam vseh igralcev, mojIndeks= sem jaz
            textNaFormi.Text += Ime + " sprašujem, če ima kdo " + v + Environment.NewLine;
            int daneKarteSkupaj = 0;
            //vprašaj vse igralce
            for(int k=0; k<i.Count;k++)
            {
                //razen mene
                if (k != mojIndeks)
                {
                    Igralec ig = i[k];
                    Kup daneKarte = ig.ImašKakšno(v);
                    daneKarteSkupaj += daneKarte.Count;
                    while(daneKarte.Count > 0)
                    {
                        roka.Add(daneKarte.Deli());
                    }
                }
            }//konec pregleda vseh kart drugih igralcev
            if (daneKarteSkupaj==0 && talon.Count > 0)
            {
                textNaFormi.Text += Ime + " mora potegniti karto iz talona." + Environment.NewLine;
                roka.Add(talon.Deli());
            }
        }
        public void VprašajZaKarto(List<Igralec>i,int mojIndeks, Kup talon)
        {
            if (talon.Count > 0)
            {
                if (roka.Count > 0)
                {
                    roka.Add(talon.Deli());
                }
                Vrednosti n = DobiNaključnoVrednost();
                VprašajZaKarto(i, mojIndeks, talon, n);
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

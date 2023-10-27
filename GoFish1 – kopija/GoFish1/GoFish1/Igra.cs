using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish1
{
    internal class Igra
    {
        private List<Igralec> igralci;
        private Dictionary<Vrednosti, Igralec> kompleti;
        private Kup talon;
        private TextBox textNaFormi;
        public Igra(string i, IEnumerable<string> nasprotniki, TextBox txtIgra)
        {
            Random r = new Random();
            textNaFormi = txtIgra;
            igralci = new List<Igralec>();
            igralci.Add(new Igralec(i, r, textNaFormi));
            foreach (string k in nasprotniki)
                igralci.Add(new Igralec(k, r, textNaFormi));
            kompleti = new Dictionary<Vrednosti, Igralec>();
            talon = new Kup(); //ne pozabi, če kličem brez parametrov
                               // imam tu vse možne karte
            Deli();
            igralci[0].SortRoka();
        }
        private void Deli()
        {
            //Tukaj se igra začne. Premešaj kup daj vsakemu igralcu 5 kart
            // nato kliči metodo IzločiKomplete

            talon.Mešaj();
            for(int i = 0; i < 5; i++)
            // 5 krat
            {
                //po eno vsakemu igralcu
                foreach (Igralec ig in igralci)
                {
                    ig.VzemiKarto(talon.Deli());
                }
            }
            foreach (Igralec ig in igralci)
            {
                IzločiKomplete(ig); //najprej napisana metoda
            }

        }
        public bool IgrajEnKrog(int izbranaKarta)
        {
            //metoda vrača true, če je konec igre, false sicer
            //iščemo izbrano karto, najprej igra igralec 0, nato vsi ostali
            //takoj, ko dobimo morebitne karte od igralcev, igra preveri, če je kaj
            // kompletov, komplete odstrani, po potrebi dodeli igralcu nove karte
            //če zmanjka kart je igre konec
            Vrednosti v = igralci[0].Peek(izbranaKarta).Vrednost;
            for (int i = 1; i < igralci.Count; i++)
            {
                igralci[i].VprašajZaKarto(igralci, i, talon, v);
                if (IzločiKomplete(igralci[i]))
                    return false;
            }
            igralci[0].VprašajZaKarto(igralci, 0, talon, v);
            if (IzločiKomplete(igralci[0]))
                return false;
            else
                return true;
        }
        public bool IzločiKomplete(Igralec i)
        {
            //izloči komplete za posameznega igralca in vrne vrednost true
            // če je igralec ostal brez kart
            IEnumerable<Vrednosti> kompleti = i.IzločiKomplete();
            foreach (Vrednosti v in kompleti)
                kompleti.Add(v, i);
            return i.ŠtevecKart == 0;
        }
        public string OpišiKomplete()
        {
            //vrni niz, v katerem so imena igralcev in kompleti kart
            string rezultat = "";
            foreach (Vrednosti v in kompleti.Keys)
                rezultat += kompleti[v].Ime + " ima komplet " + v + Environment.NewLine;
            return rezultat;
        }
        public string ImeZmagovalca()
        {
            //Metoda se kliče na koncu igre. Uporablja svojo strukturo - slovar, v
            // kateri je število vseh kompletov posameznega igralca
            //Najprej pregleda z zanko foreach število kompletov in jih doda v zbirko
            // zmagovalcev

            Dictionary<string, int> winners = new Dictionary<string, int>();
            foreach (Vrednosti v in kompleti.Keys)
            {
                string ime = kompleti[v].Ime;
                if (winners.ContainsKey(ime))
                    winners[ime]++;
                else
                    winners.Add(ime, 1);
            }
            //Nato poišče največjo vrednost kompletov
            int mostBooks = 0;
            foreach (string name in winners.Keys)
                if (winners[name] > mostBooks)
                    mostBooks = winners[name];
            bool tie = false;
            string winnerList = "";
            //določi kateri od igralcev ima to vrednost, lahko jih je več
            foreach (string name in winners.Keys)
                if (winners[name] == mostBooks)
                {
                    if (!String.IsNullOrEmpty(winnerList))
                    {
                        winnerList += " in ";
                        tie = true;
                    }
                    winnerList += name;
                }
            winnerList += " z " + mostBooks + " kompleti";
            if (tie)
                return "Neodločeno " + winnerList;
            else
                return winnerList;
        }
        public IEnumerable<string> KarteIgralca()
        {
            //vrni seznam imen igralcev
            return igralci[0].Imena();
        }
        public string OpišiVRokah()
        {
            //izpiši imena igralcev in število kart v rokah
            // izpiši tudi koliko kart je v talonu, opis vrni kot spremenljivko tipa string
            string opis = "Talon vsebuje " + talon.Count + " kart" + Environment.NewLine;
            for (int i = 0; i < igralci.Count; i++)
                opis += igralci[i].Ime + " ima " + igralci[i].ŠtevecKart + " kart" + Environment.NewLine;
            return opis;
        }

    }
}

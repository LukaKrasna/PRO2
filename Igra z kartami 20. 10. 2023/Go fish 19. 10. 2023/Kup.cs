using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Go_fish_19._10._2023
{
    internal class Kup
    {
        List<Karta> karte;
        Random r=new Random();
        public Kup()
        {
            karte = new List<Karta>();
            for(int barva=0; barva<=3; barva++)
            {
                for (int vr=0;vr<13; vr++) 
                {
                    karte.Add(new Karta((Barve)barva, (Vrednosti)vr));
                }
            }
        }
        public Kup(IEnumerable<Karta> začetek)
        {
            karte = new List<Karta>(začetek);
        }
        public void Add(Karta novaKarta)//Add je lahko napisan tudi v slovenščini (Dodaj)
        {
            karte.Add(novaKarta);
        }
        public int Count
        {
            get { return karte.Count; }
        }
        public void Sort()
        { 
            karte.Sort(new Primerjava()); 
        }
        public Karta Deli(int indeks)
        {
            Karta zaDelitev = karte[indeks];
            karte.Remove(zaDelitev);
            return zaDelitev;
        }
        public void Mešaj()
        {
            List<Karta> noveKarte=new List<Karta>();
            while(karte.Count > 0)
            {
                int zaPremik = r.Next(karte.Count);
                noveKarte.Add(karte[zaPremik]);
                karte.RemoveAt(zaPremik);
            }
            karte=noveKarte;
        }
        public string[] ImenaKart()
        {
            string[] imena=new string[karte.Count];
            for(int k=0;k<imena.Count(); k++)
            {
                imena[k] = karte[k].ToString();
            }
            return imena;
        }
    }
}

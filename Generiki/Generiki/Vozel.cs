using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generiki
{
    internal class Vozel<K,T>
    {
        public K Key;
        public T Item;
        public Vozel<K, T> Naslednji;
        public Vozel()
        {
            Key = default(K);
            Item = default(T);
            Naslednji = null;
        }
        public Vozel(K ključ, T vsebina, Vozel<K,T> n)
        {
            Key = ključ; 
            Item = vsebina; 
            Naslednji = n;
        }
    }
    class PovezanaLista<K,T> where K:IComparable //where K:IComparable = K je lahko kar koli
    {
        Vozel<K, T> glava;
        public PovezanaLista()
        {
            glava = new Vozel<K, T>();
        }
        public void Dodaj(K ključ, T vsebina)
        {
            Vozel<K,T> nov=new Vozel<K,T>(ključ,vsebina,glava.Naslednji);
            glava.Naslednji = nov;
        }
        public T Najdi(K ključ)
        {
            Vozel<K, T> trenutni = glava;
            while(trenutni.Naslednji != null)
            {
                if (trenutni.Key.CompareTo(ključ) == 0)
                    break;
                else
                    trenutni = trenutni.Naslednji;
            }
            return trenutni.Item;
        }
    }
}

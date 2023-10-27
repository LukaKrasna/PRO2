using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//Tega smo dodali
using System.CodeDom;//Ta se je sam dodal

namespace Klici
{
    internal class Bralec
    {
        FileStream fs;
        StreamReader sr;
        uint število;
        public void Odpri(String imeDat)
        {
            fs=new FileStream(imeDat, FileMode.Open);
            sr=new StreamReader(fs);
            try
            {
                string prvaVrstica = sr.ReadLine();//tu notri mora biti število oseb
                število = uint.Parse(prvaVrstica);
            }
            catch (FormatException e)
            {
                throw new KliciException("Prvo število ni celo ", e);
            }
        }
        public uint NOseb
        {
            get { return število; }
        }
        public void ObravnavajNaslednjega()
        {
            try
            {
                string ime;
                ime = sr.ReadLine();
                if (ime == null)
                {
                    throw new KliciException("Ni dovolj imen");
                }
                if (ime[0] == 'Z')
                {
                    throw new TajniAgentException(ime);
                    Console.WriteLine("Naslednji za klicati je " + ime);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

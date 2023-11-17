using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Drawing.Printing;
namespace Društvo
{
    public partial class Form3 : Form
    {
        private string pot = "D:\\pro2\\bilanca.dat";
        private Font printFont;
        List<Darovi> vsi = new List<Darovi>();
        List<Darovi> filter = new List<Darovi>();
        private double znesekVDobro;
        private double znesekVBreme;
        private double saldo;
        public Form3()
        {
            InitializeComponent();
        }
        private void NaložiPodatke()
        {
            //iz datoteke prebere podatke in jih shrani v listo vsi
            try
            {
                FileStream fs = new FileStream(pot, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                Darovi d;
                try
                {
                    while (true)
                    {
                        d = (Darovi)bf.Deserialize(fs);
                        vsi.Add(d);
                    }
                }
                catch (SerializationException) { }
                finally { fs.Close(); }
            }
            catch { }
            
        }
        private void PreveriDatume()
        { 
        //iz liste vsi vzame samo tiste, ki so med danimi datumi
        // in jih shrani v filter
            filter = new List<Darovi>();
            DateTime datumOd = dtp1.Value;
            DateTime datumDo = dtp2.Value;
            foreach (Darovi d in vsi)
            {
                if (d.Datum >= datumOd & d.Datum <= datumDo)
                    filter.Add(d);
            }
        }
        private void RačunajVsote()
        {
            znesekVBreme = 0;
            znesekVDobro = 0;
            saldo = 0;
            foreach (Darovi d in filter)
            {
                if (d.Znesek >= 0)
                    znesekVDobro += d.Znesek;
                else
                    znesekVBreme += d.Znesek;
            }
            saldo = znesekVDobro - znesekVBreme;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            PreveriDatume();
            printFont = new Font("Arial", 14);
            pd.PrintPage+=new System.Drawing.Printing.PrintPageEventHandler(pd_PrintPage);
            printPreviewDialog1.ShowDialog();
        }
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0; // število vrstic na stran
            float yPos = 0; // y pozicija
            int count = 0; // število vseh izpisanih vrstic
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null; // vrstica za izpis
            int štVrstice = 0;
            RačunajVsote(); // metoda za izračun vsot
            // število vrstic na eno stran, zapisov je lahko veliko
            linesPerPage = ev.MarginBounds.Height /
            printFont.GetHeight(ev.Graphics);
            //prva vrstica – naslov dokumenta
            line = "Izpis vseh darov in izdatkov za Karitas";
            yPos = topMargin + (count *
            printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, printFont, Brushes.Black,
            leftMargin, yPos, new StringFormat());
            count++;
            //izris slike
            Bitmap bi = new Bitmap(@"D:\Pro2\Društvo\Društvo\Resources\a.gif");
            ev.Graphics.DrawImage(bi, ev.MarginBounds.Right - 70, yPos - 10);
            //zaradi velikosti slike zgornjemu robu prištejem 32 (velikost=32x32)
            topMargin += 32;
            line = "";
            //izris prazne vrstice
            yPos = topMargin + (count *
            printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, printFont, Brushes.Black,
            leftMargin, yPos, new StringFormat());
            count++;
            //izris črte
            yPos = topMargin + (count *
            printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawLine(new Pen(Color.Black), ev.MarginBounds.Left, yPos, ev.MarginBounds.Right, yPos);
            count++;
            //izpis glave tabele
            line = "Poz. Datum Namen V dobro V breme Opombe";
            yPos = topMargin + (count *
            printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, printFont, Brushes.Black,
            leftMargin, yPos, new StringFormat());
            count++;
            //izris črte
            yPos = topMargin + (count *
            printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawLine(new Pen(Color.Black), ev.MarginBounds.Left, yPos, ev.MarginBounds.Right, yPos);
            count++;
            // Izpis podatkov iz datoteke.
            while (count < linesPerPage && štVrstice < filter.Count)
            {
                string a; //namen skrajšan na 10 znakov
                string b; //opombe skrajšane na 10 znakov
                if (filter[štVrstice].Namen.Length > 10)
                    a = filter[štVrstice].Namen.Substring(0, 10);
                else a = filter[štVrstice].Namen;
                if (filter[štVrstice].Opombe.Length > 10)
                    b = filter[štVrstice].Opombe.Substring(0, 10);
                else b = filter[štVrstice].Opombe;
                double c = filter[štVrstice].Znesek; //v dobro ali breme?
                if (c > 0)
                    line = String.Format("{0,3}", (štVrstice + 1)) + " " + filter[štVrstice].Datum.ToShortDateString() + " " +
                    String.Format("{0,10}", a) + " " +
                    String.Format("{0,10:c}", filter[štVrstice].Znesek) + " " +
                    String.Format("{0,10}", b);
                else
                    line = String.Format("{0,3}", (štVrstice + 1)) + " " + filter[štVrstice].Datum.ToShortDateString() + " " +
                    String.Format("{0,10}", a) + " " +
                    String.Format("{0,10:c}", filter[štVrstice].Znesek) + " " +
                    String.Format("{0,10}", b);
                štVrstice++;
                yPos = topMargin + (count *
                printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                leftMargin, yPos, new StringFormat());
                count++;
                line = "";
            }
            yPos = topMargin + (count *
            printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawLine(new Pen(Color.Black), ev.MarginBounds.Left, yPos, ev.MarginBounds.Right, yPos);
            count++;
            //izpis vrstice skupaj
            line = String.Format("{0,24}", "Skupaj") + " " +
            String.Format("{0,10:c}", znesekVDobro) + " " +
            String.Format("{0,10:c}", znesekVBreme) + " " +
            String.Format("{0,10:c}", saldo);
            yPos = topMargin + (count *
            printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, printFont, Brushes.Black,
            leftMargin, yPos, new StringFormat());
            count++;
            // če še nismo na koncu datoteke, pojdi na novo stran
            if (štVrstice != filter.Count)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            NaložiPodatke();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDialog a = new PrintDialog();
            a.Document = pd;
            DialogResult b = a.ShowDialog();
            if (b == DialogResult.OK)
                pd.Print();
        }
    

    }
}

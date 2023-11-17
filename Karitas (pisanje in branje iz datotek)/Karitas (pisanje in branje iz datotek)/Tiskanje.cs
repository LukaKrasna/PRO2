using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karitas__pisanje_in_branje_iz_datotek_
{
    public partial class Tiskanje : Form
    {
        private Font printFont = new Font("Arial", 14);
        List<Darovi> vsi = new List<Darovi>();
        List<Darovi> filter = new List<Darovi>();
        double znesekVDobro = 0;
        double znesekVBreme = 0;
        double saldo = 0;
        public Tiskanje()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FiltrirajPodatke();
            printDialog1.Document = printDocument1;
            DialogResult a=printDialog1.ShowDialog();
            if (a == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void FiltrirajPodatke()
        {
            filter = new List<Darovi>();
            foreach(Darovi d in vsi)
            {
                if (d.Datum.Date >= dateTimePicker1.Value.Date && d.Datum.Date <= dateTimePicker2.Value.Date)
                {
                    filter.Add(d);
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linesPerPage = 0; // število vrstic na stran
            float yPos = 0; // y pozicija
            int count = 0; // število vseh izpisanih vrstic
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null; // vrstica za izpis
            int štVrstice = 0;
            RačunajVsote(); // metoda za izračun vsot
            // število vrstic na eno stran, zapisov je lahko veliko
            linesPerPage = e.MarginBounds.Height /
            printFont.GetHeight(e.Graphics);
            //prva vrstica – naslov dokumenta
            line = "Izpis vseh darov in izdatkov za Karitas";
            yPos = topMargin + (count *
            printFont.GetHeight(e.Graphics));
            e.Graphics.DrawString(line, printFont, Brushes.Black,
            leftMargin, yPos, new StringFormat());
            count++;
            //izris slike
            //Bitmap bi = new Bitmap(@"D:\Pro2\Društvo\Društvo\Resources\a.gif");
            //e.Graphics.DrawImage(bi, e.MarginBounds.Right - 70, yPos - 10);
            //zaradi velikosti slike zgornjemu robu prištejem 32 (velikost=32x32)
            topMargin += 32;
            line = "";
            //izris prazne vrstice
            yPos = topMargin + (count *
            printFont.GetHeight(e.Graphics));
            e.Graphics.DrawString(line, printFont, Brushes.Black,
            leftMargin, yPos, new StringFormat());
            count++;
            //izris črte
            yPos = topMargin + (count *
            printFont.GetHeight(e.Graphics));
            e.Graphics.DrawLine(new Pen(Color.Black), e.MarginBounds.Left, yPos, e.MarginBounds.Right, yPos);
            count++;
            //izpis glave tabele
            line = "Poz. Datum Namen V dobro V breme Opombe";
            yPos = topMargin + (count *
            printFont.GetHeight(e.Graphics));
            e.Graphics.DrawString(line, printFont, Brushes.Black,
            leftMargin, yPos, new StringFormat());
            count++;
            //izris črte
            yPos = topMargin + (count *
            printFont.GetHeight(e.Graphics));
            e.Graphics.DrawLine(new Pen(Color.Black), e.MarginBounds.Left, yPos, e.MarginBounds.Right, yPos);
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
                printFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(line, printFont, Brushes.Black,
                leftMargin, yPos, new StringFormat());
                count++;
                line = "";
            }
            yPos = topMargin + (count *
            printFont.GetHeight(e.Graphics));
            e.Graphics.DrawLine(new Pen(Color.Black), e.MarginBounds.Left, yPos, e.MarginBounds.Right, yPos);
            count++;
            //izpis vrstice skupaj
            line = String.Format("{0,24}", "Skupaj") + " " +
            String.Format("{0,10:c}", znesekVDobro) + " " +
            String.Format("{0,10:c}", znesekVBreme) + " " +
            String.Format("{0,10:c}", saldo);
            yPos = topMargin + (count *
            printFont.GetHeight(e.Graphics));
            e.Graphics.DrawString(line, printFont, Brushes.Black,
            leftMargin, yPos, new StringFormat());
            count++;
            // če še nismo na koncu datoteke, pojdi na novo stran
            if (štVrstice != filter.Count)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }

        private void RačunajVsote()
        {
            znesekVDobro = 0;
            znesekVBreme = 0;
            saldo = 0;
            foreach(Darovi d in filter)
            {
                if (d.Znesek <= 0)
                    znesekVBreme += d.Znesek;
                else
                    znesekVDobro += d.Znesek;
            }
            saldo=znesekVDobro + znesekVBreme;
        }

        private void Tiskanje_Load(object sender, EventArgs e)
        {
            string pot = Resource1.pot;
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
            } //bere, v neskončni zanki
            catch (SerializationException) { }
            fs.Close();
        }
    }
}

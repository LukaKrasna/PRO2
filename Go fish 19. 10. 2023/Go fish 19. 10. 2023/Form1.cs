using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Go_fish_19._10._2023
{
    public partial class Form1 : Form
    {
        Kup kup1;
        Kup kup2;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            ResetKupa(1); ResetKupa(2);
            RedrawKupa(1); RedrawKupa(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Karta> karte = new List<Karta>();
            string izpis = "Neurejen kup\n";
            for (int k = 0; k < 5; k++)
            {
                int b = r.Next(4);
                int v = r.Next(13);
                Karta k1 = new Karta((Barve)b, (Vrednosti)v);
                karte.Add(k1);
                izpis += k1.ToString() + "\n";
            }
            karte.Sort(new Primerjava());
            izpis += "\nUrejen kup\n";
            for (int k = 0; k < 5; k++)
            {
                izpis += karte[k].ToString() + "\n";
            }
            MessageBox.Show(izpis);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ResetKupa(int št)
        {
            if (št == 1)
            {
                int štKart = r.Next(1, 11);
                kup1 = new Kup(new Karta[] { });
                for (int i = 0; i < štKart; i++)
                    kup1.Add(new Karta((Barve)r.Next(4), (Vrednosti)r.Next(1, 14)));
                kup1.Sort();
            }
            else
                kup2 = new Kup();
        }
        private void RedrawKupa(int št)
        {
            if (št == 1)
            {
                listBox1.Items.Clear();
                foreach (string im in kup1.ImenaKart())
                {
                    listBox1.Items.Add(im);
                }
                label1.Text = "Kup #1 (" + kup1.Count + " kart)";
            }
            else
            {
                listBox2.Items.Clear();
                foreach (string im in kup2.ImenaKart())
                {
                    listBox2.Items.Add(im);
                }
                label2.Text = "Kup #2 (" + kup2.Count + " kart)";
            }
        }

        private void OdLeveKDesni_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
                if (kup1.Count > 0)
                    kup2.Add(kup1.Deli(listBox1.SelectedIndex));
            RedrawKupa(1);
            RedrawKupa(2);
        }

        private void btnMešajKupEna_Click(object sender, EventArgs e)
        {
            kup1.Mešaj();
            RedrawKupa(1);
        }

        private void btnPonastaviKupEna_Click(object sender, EventArgs e)
        {
            ResetKupa(1);
            RedrawKupa(1);
        }

        private void btnMešajKupDva_Click(object sender, EventArgs e)
        {
            kup2.Mešaj();
            RedrawKupa(2);
        }

        private void btnPonastaviKupDva_Click(object sender, EventArgs e)
        {
            ResetKupa(2);
            RedrawKupa(2);
            kup2 = new Kup();
            listBox2.Items.Clear();
            foreach (string x in kup2.ImenaKart())
            {
                listBox2.Items.Add(x);
            }
            kup1 = new Kup(new Karta[] { });
        }

        private void OdDesneKLevi_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
                if (kup2.Count > 0)
                    kup1.Add(kup2.Deli(listBox2.SelectedIndex));
            RedrawKupa(1);
            RedrawKupa(2);
        }
    }
}

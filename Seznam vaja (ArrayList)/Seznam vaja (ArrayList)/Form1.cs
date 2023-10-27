using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seznam_vaja__ArrayList_
{
    public partial class Form1 : Form
    {
        //Naloga: https://ucilnice.scng.si/pluginfile.php/4433/mod_resource/content/1/vaje1/vaja1pdf.pdf
        private ArrayList seznam = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vnos = txtVnos.Text;
            seznam.Add(vnos);
            txtVnos.Text += "Dodan element " + vnos + " na konec seznama\n";
            //txtVnos.Clear();
        }

        private void txtKonzola_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string vnos = txtVnos.Text;
            if (seznam.Contains(vnos))
            {
                seznam.Remove(vnos);
                txtKonzola.AppendText($"Odstranjen element '{vnos}'; ");
            }
            else
            {
                txtKonzola.AppendText($"Element '{vnos}' ni bil najden v seznamu; ");
            }
            txtKonzola.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (seznam.Count > 0)
            {
                string prviElement = seznam[0].ToString();
                txtKonzola.AppendText($"Prvi element v seznamu: {prviElement}; ");
            }
            else
            {
                txtKonzola.AppendText("Seznam je prazen; ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (seznam.Count > 0)
            {
                string zadnjiElement = seznam[seznam.Count - 1].ToString();
                txtKonzola.AppendText($"Zadnji element v seznamu: {zadnjiElement}; ");
            }
            else
            {
                txtKonzola.AppendText("Seznam je prazen; ");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (seznam.Count == 0)
            {
                txtKonzola.AppendText("Seznam je prazen");
            }
            else
            {
                txtKonzola.AppendText("Seznam ni prazen");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string vnos = txtVnos.Text;
            if (seznam.Contains(vnos))
            {
                txtKonzola.Text = ("Seznam vsebuje element " + vnos);
            }
            else
            {
                txtKonzola.Text = ("Seznam ne vsebuje elementa " + vnos);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string vnos = txtVnos.Text;
            int lokacija = seznam.IndexOf(vnos);
            if (lokacija != -1)
            {
                txtKonzola.AppendText("Lokacija elementa " + vnos + " v seznamu: " + lokacija);
            }
            else
            {
                txtKonzola.AppendText("Element " + vnos + " ni bil najden v seznamu");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            seznam.TrimToSize();
            txtKonzola.AppendText("Seznam je skrajšan; ");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int velikost = seznam.Count;
            txtKonzola.AppendText("Velikost seznama: " + velikost);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtKonzola.AppendText("Seznam:\n");
            foreach (object element in seznam)
            {
                txtKonzola.AppendText(element.ToString() + "; ");
            }
        }

        /*
    {
        private ArrayList seznam = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string vnos = txtKonzola.Text;
            seznam.Add(vnos);
            txtKonzola.AppendText($"Dodan element '{vnos}' na konec seznama\n");
            txtKonzola.Clear();
        }

        private void btnOdstrani_Click(object sender, EventArgs e)
        {
            string vnos = txtKonzola.Text;
            if (seznam.Contains(vnos))
            {
                seznam.Remove(vnos);
                txtKonzola1.AppendText($"Odstranjen element '{vnos}'\n");
            }
            else
            {
                txtKonzola1.AppendText($"Element '{vnos}' ni bil najden v seznamu\n");
            }
            txtKonzola1.Clear();
        }

        private void btnPrvi_Click(object sender, EventArgs e)
        {
            if (seznam.Count > 0)
            {
                string prviElement = seznam[0].ToString();
                txtKonzola1.AppendText($"Prvi element v seznamu: {prviElement}\n");
            }
            else
            {
                txtKonzola1.AppendText("Seznam je prazen\n");
            }
        }

        private void btnZadnji_Click(object sender, EventArgs e)
        {
            if (seznam.Count > 0)
            {
                string zadnjiElement = seznam[seznam.Count - 1].ToString();
                txtKonzola1.AppendText($"Zadnji element v seznamu: {zadnjiElement}\n");
            }
            else
            {
                txtKonzola1.AppendText("Seznam je prazen\n");
            }
        }

        private void btnJePrazna_Click(object sender, EventArgs e)
        {
            if (seznam.Count == 0)
            {
                txtKonzola1.AppendText("Seznam je prazen");
            }
            else
            {
                txtKonzola1.AppendText("Seznam ni prazen");
            }
        }

        private void btnVsebuje_Click(object sender, EventArgs e)
        {
            string vnos = txtKonzola.Text;
            if (seznam.Contains(vnos))
            {
                txtKonzola1.Text=("Seznam vsebuje element "+vnos);
            }
            else
            {
                txtKonzola1.Text=("Seznam ne vsebuje elementa "+vnos);
            }
           // txtKonzola1.Clear();
        }

        private void btnLokacija_Click(object sender, EventArgs e)
        {
            string vnos = txtKonzola.Text;
            int lokacija = seznam.IndexOf(vnos);
            if (lokacija != -1)
            {
                txtKonzola1.AppendText("Lokacija elementa " + vnos + " v seznamu: " + lokacija);
            }
            else
            {
                txtKonzola1.AppendText("Element "+vnos+" ni bil najden v seznamu");
            }
           // txtKonzola1.Clear();
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            seznam.TrimToSize();
            txtKonzola1.AppendText("Seznam je skrajšan\n");
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            int velikost = seznam.Count;
            txtKonzola1.AppendText("Velikost seznama: "+velikost);

        }

        private void btnIzpisi_Click(object sender, EventArgs e)
        {
            txtKonzola1.AppendText("Seznam:\n");
            foreach (object element in seznam)
            {
                txtKonzola1.AppendText(element.ToString() + "\n");
            }
        } 
        */
    }
}

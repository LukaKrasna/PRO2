using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Naloga: https://ucilnice.scng.si/pluginfile.php/31461/mod_resource/content/1/Vaja_serializacija.pdf
namespace Karitas__pisanje_in_branje_iz_datotek_
{
    public partial class Form1 : Form
    {
        string pot = Resource1.pot;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVnesi_Click(object sender, EventArgs e)
        {
            Darovi d=new Darovi();
            try //slabo rešeno ampak v glavnem dela
            {
                d.ZapŠt = int.Parse(txtZapŠt.Text);
            }
            catch
            {
                d.ZapŠt=0;
                txtZapŠt.Focus();
            }
            d.Datum = dtpDatum.Value;
            d.Namen=txtNamen.Text;
            try
            {
                d.Znesek = double.Parse(txtZnesek.Text);
            }
            catch
            {
                d.Znesek = 0;
                txtZnesek.Focus();
            }
            d.Opombe=txtOpombe.Text;
            FileStream fs = new FileStream(pot, FileMode.Append);
            BinaryFormatter bf=new BinaryFormatter();
            bf.Serialize(fs, d);
            fs.Close();
            labStanje.Text = "Vneseno";
            txtZapŠt.Clear();
            txtNamen.Clear();
            txtZnesek.Clear();
            txtOpombe.Clear();
            txtZapŠt.Focus();
        }

        private void txtZapŠt_Leave(object sender, EventArgs e)
        {
            labStanje.Text = "Pripravljen";
        }
    }
}

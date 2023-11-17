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
using System.Xml.Serialization;

namespace Karitas__pisanje_in_branje_iz_datotek_
{
    public partial class Obnova : Form
    {
        List<Darovi> spremembe = new List<Darovi>();
        public Obnova()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pot = Resource1.pot;
            
            //preberi xml v List<obnovi>
            string ime = @"D:\Karitas" + dateTimePicker1.Value.ToShortDateString() + ".xml";
            List<Darovi> vsi = new List<Darovi>();
            try
            {
                FileStream fs = new FileStream(ime, FileMode.Open);
                XmlSerializer xml = new XmlSerializer(typeof(List<Darovi>));
                vsi= (List<Darovi>)xml.Deserialize(fs);
                fs.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Na ta dan ni zaščite\nIzberi drug datum");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            //izbriši darovi.dat
            FileInfo fi = new FileInfo(pot);
            fi.Delete();
            //piši iz List<darovi> v binarno datoteko
            FileStream fs1 = new FileStream(pot, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            foreach (Darovi d in spremembe) 
            {
                bf.Serialize(fs1, d);
            }
            fs1.Close();
            MessageBox.Show("Zaščita končana", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

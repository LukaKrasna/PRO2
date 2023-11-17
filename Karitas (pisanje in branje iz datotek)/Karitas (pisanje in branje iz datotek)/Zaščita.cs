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
using System.Xml.Serialization;

namespace Karitas__pisanje_in_branje_iz_datotek_
{
    public partial class Zaščita : Form
    {
        public Zaščita()
        {
            InitializeComponent();
        }

        private void Zaščita_Load(object sender, EventArgs e)
        {

        }
        string pot = Resource1.pot;
        List<Darovi> spremembe = new List<Darovi>();
        private void btnZaščita_Click(object sender, EventArgs e)
        {
            //preberi podatke iz datoteke na disku
            FileStream fs = new FileStream(pot, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            Darovi d;
            try
            {
                while (true)
                {
                    d = (Darovi)bf.Deserialize(fs);
                    spremembe.Add(d);
                }
            } //bere, v neskončni zanki
            catch (SerializationException) { }
            fs.Close();
            //podatke piši v XML datoteko
            string imeD=@"D:\Karitas"+DateTime.Now.ToShortDateString()+".xml";
            FileStream fs1=new FileStream(imeD, FileMode.Create);
            XmlSerializer xml = new XmlSerializer(typeof(List<Darovi>));
            xml.Serialize(fs1, spremembe);
            fs1.Close();
            MessageBox.Show("Zaščita končana", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }
    }
}

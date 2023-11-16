using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karitas__pisanje_in_branje_iz_datotek_
{
    public partial class Pregledi : Form
    {
        string pot = Resource1.pot;
        List<Darovi> spremembe=new List<Darovi>();
        int štSprememb = 0;
        public Pregledi()
        {
            InitializeComponent();
        }
        private void PolepšajMe()
        {
            DataGridViewCellStyle dcs=new DataGridViewCellStyle();
            dcs.Format = "###.00 €";//format števila
            dgvPregledi.Columns[3].DefaultCellStyle = dcs;
            dgvPregledi.Columns[4].Width = 175;
            foreach(DataGridViewRow row in dgvPregledi.Rows)
            {
                double vr = double.Parse(row.Cells[3].Value.ToString());
                if (vr < 0)
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                else
                    row.DefaultCellStyle.BackColor = Color.LightGray;
            }
        }
        private void Pregledi_Load(object sender, EventArgs e)
        {
            //preberi podatke iz datoteke na disku
            FileStream fs = new FileStream(pot, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            Darovi d;
            try 
            {
                while (true)
                {
                    d=(Darovi)bf.Deserialize(fs);
                    spremembe.Add(d);
                }
            } //bere, v neskončni zanki
            catch (SerializationException) { }
            fs.Close();
            //podatke imam v seznamu spremembe
            dgvPregledi.DataSource = spremembe;
        }

        private void dgvPregledi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //spremebo iz dgvPodatki shrani v List<Darovi>
            int vrstica = e.RowIndex;
            Darovi d = new Darovi();
            d.ZapŠt = int.Parse(dgvPregledi.Rows[vrstica].Cells[0].Value.ToString());
            d.Datum = DateTime.Parse(dgvPregledi.Rows[vrstica].Cells["Datum"].Value.ToString());
            d.Namen = dgvPregledi.Rows[vrstica].Cells[2].Value.ToString();
            d.Znesek = double.Parse(dgvPregledi.Rows[vrstica].Cells[3].Value.ToString());
            d.Opombe = dgvPregledi.Rows[vrstica].Cells[4].Value.ToString();
            spremembe[vrstica] = d;
            štSprememb++;
        }

        private void Pregledi_Shown(object sender, EventArgs e)
        {
            PolepšajMe();
            dgvPregledi.Refresh();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ShraniSpremembe();
        }

        private void Pregledi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult a = MessageBox.Show("Ostajajo neshranjene spremembe\nShrani sedaj?", "Opozorilo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if(a == DialogResult.Yes)
            {
                ShraniSpremembe();
            }
        }
        void ShraniSpremembe()
        {
            FileInfo fi = new FileInfo(pot);
            fi.Delete();
            //shrani
            toolStripProgressBar1.Maximum = spremembe.Count();
            toolStripProgressBar1.Value = 0;
            FileStream fs = new FileStream(pot, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            foreach (Darovi d in spremembe)
            {
                bf.Serialize(fs, d);
                toolStripProgressBar1.Increment(1);
            }
            fs.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Resnično želup brisati vrstico?", "Opozorilo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (a == DialogResult.Yes)
            {
                DataGridViewRow vrstica = dgvPregledi.CurrentRow;
                int b = vrstica.Index;
                BrišiVrstico(b);
            }
        }

        private void BrišiVrstico(int b)
        {
            spremembe.RemoveAt(b);
            štSprememb++;
            dgvPregledi.DataSource = null;
            dgvPregledi.Rows.Clear();
            dgvPregledi.DataSource = spremembe;
            PolepšajMe();
            dgvPregledi.Refresh();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karitas__pisanje_in_branje_iz_datotek_
{
    public partial class Glavno_okno : Form
    {
        public Glavno_okno()
        {
            InitializeComponent();
        }

        private void vnosiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.MdiParent = this;
            a.Show();
        }

        private void preglediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pregledi a=new Pregledi();
            a.MdiParent = this;
            a.Show();
        }

        private void Glavno_okno_Load(object sender, EventArgs e)
        {

        }

        private void zaščitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zaščita a = new Zaščita();
            a.MdiParent = this;
            a.Show();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Obnova a =new Obnova();
            a.MdiParent = this;
            a.Show();
        }

        private void tiskanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tiskanje a = new Tiskanje();
            a.MdiParent = this;
            a.Show();
        }
    }
}

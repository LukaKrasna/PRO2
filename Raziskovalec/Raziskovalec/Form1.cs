using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raziskovalec
{
    enum Tip { Mapa=1, Datoteka = 2}
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NaložiDrevo();
        }

        private void NaložiDrevo()
        {
            //foreach (string ime in Directory.GetLogicalDrives())
            //{
            //    TreeNode vozel = trvDrevo.Nodes.Add(ime);
            //    vozel.Nodes.Add("Brezveze");
            //}
            TreeNode vozel = trvDrevo.Nodes.Add("d:\\Pro2");//
            PopulateDrevo("d:\\Pro2", trvDrevo.Nodes[0]);//
        }

        private void PopulateDrevo(string ime, TreeNode roditelj)//
        {//
            //rekurzivna rešitev//
            string[] tabelaMap = Directory.GetDirectories(ime);//
            if (tabelaMap.Length != 0) //robni pogoj//
            {//
                foreach(string mapa in tabelaMap)//
                {//
                    TreeNode mojV = new TreeNode(mapa);//
                    roditelj.Nodes.Add(mojV);//
                    PopulateDrevo(mapa, mojV);//rekurzivni klic//
                }//
            }//
        }//

        private void trvDrevo_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            //try
            //{
            //    e.Node.Nodes.Clear();
            //    DodajMape(e.Node);
            //    DodajDatoteke(e.Node);
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void DodajDatoteke(TreeNode node)
        {
            string pot = node.FullPath;
            foreach (string imeD in Directory.GetFiles(pot))
            {
                TreeNode noviV = node.Nodes.Add(Path.GetFileName(imeD));
                noviV.Tag = Tip.Datoteka;
            }
        }

        private void DodajMape(TreeNode node)
        {
            string pot = node.FullPath;
            foreach(string imeM in Directory.GetDirectories(pot))
            {
                TreeNode noviV = node.Nodes.Add(Path.GetFileName(imeM));//Čeprav je ime directoria je še vedno GetFileName
                noviV.Tag = Tip.Mapa;
                noviV.Nodes.Add("Brez veze"); //dodam "+" pred ime mape
            }
        }

        private void trvDrevo_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is Tip)
            {
                switch ((Tip)e.Node.Tag)
                {
                    case Tip.Mapa:
                        DirectoryInfo d = new DirectoryInfo(e.Node.FullPath);
                        txtAtribut.Text = "Mapa";
                        txtUstvarjena.Text = d.CreationTime.ToShortDateString();
                        txtDostop.Text=d.LastAccessTime.ToShortDateString();
                        txtSprememba.Text=d.LastWriteTime.ToShortDateString();
                        txtCeloIme.Text = d.FullName;
                        txtIme.Text= d.Name;
                        txtStars.Text = d.Parent.ToString();
                        txtRoot.Text = d.Root.ToString();
                        txtDolžina.Text = "";
                        break;
                    case Tip.Datoteka:
                        FileInfo f = new FileInfo(e.Node.FullPath);
                        txtAtribut.Text = "File";
                        txtUstvarjena.Text = f.CreationTime.ToShortDateString();
                        txtDostop.Text = f.LastAccessTime.ToShortDateString();
                        txtSprememba.Text = f.LastWriteTime.ToShortDateString();
                        txtExtension.Text = f.Extension;
                        txtCeloIme.Text = f.FullName;
                        txtIme.Text = f.Name;
                        txtDolžina.Text = f.Length.ToString();
                        break;
                }
            }
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 x = new AboutBox1();
            x.Show();
        }
    }
}

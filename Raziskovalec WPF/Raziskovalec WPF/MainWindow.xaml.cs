using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Raziskovalec_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string imeD = "d:\\Pro2";
            Imena_datotek koren = new Imena_datotek() { Ime = imeD };
            NapolniVeje(imeD, koren);
            IzpišiDatoteke(imeD, koren);
            //Imena_datotek otrok = new Imena_datotek() { Ime = "Redni" };
            //otrok.Elementi.Add(new Imena_datotek() { Ime = "1.letnik" });
            //otrok.Elementi.Add(new Imena_datotek() { Ime = "2.letnik" });
            //koren.Elementi.Add(otrok);
            //dodaj koren v drevo TreeView
            trvDrevo.Items.Add(koren);
        }
        private void NapolniVeje(string imeD, Imena_datotek koren)
        {
            try
            {
                string[] mape = Directory.GetDirectories(imeD);
                if (mape.Length != 0)
                {
                    foreach (string imeMape in mape)
                    {
                        DirectoryInfo d=new DirectoryInfo(imeMape);
                        string brezPoti = d.Name;
                        Imena_datotek nov = new Imena_datotek() { Ime = brezPoti };
                        IzpišiDatoteke(imeMape, nov);
                        NapolniVeje(imeMape, nov);
                        koren.Elementi.Add(nov);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void IzpišiDatoteke(string imeMape, Imena_datotek nov)
        {
            DirectoryInfo d = new DirectoryInfo(imeMape);
            foreach(FileInfo f in d.GetFiles())
            {
                nov.Elementi.Add(new Imena_datotek() { Ime = f.Name, });
            }
        }
    }
}

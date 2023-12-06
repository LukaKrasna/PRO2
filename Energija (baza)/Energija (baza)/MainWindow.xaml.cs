using System;
using System.Collections.Generic;
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

namespace Energija__baza_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ElektrikaEntities en = new ElektrikaEntities();
            var x = (from a in en.Meritve
                    where a.ZapisČas.Value.Day == 18 && a.ZapisČas.Value.Month == 8 && a.ZapisČas.Value.Year == 2013
                    group a by a.ZapisČas.Value.Hour into z
                    select new 
                    {
                       Ura=z.Key,
                       Moč=z.Average(b=>b.kW1+b.kW2+b.kW3)
                    }).ToList();
                    ;
            //string rezultat = "";
            //foreach (var y in x)
            //{
            //    rezultat += y.Ura +"  "+ y.Moč+ "\n";
            //}
            //MessageBox.Show(rezultat);
            CollectionViewSource cvs = (CollectionViewSource)this.FindResource("cvs");
            cvs.Source = x;
        }
    }
}

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

namespace Nepovezan__Baze_podatkov_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// navodila: https://ucilnice.scng.si/pluginfile.php/26238/mod_resource/content/0/Vaje_-_nepovezan.pdf
    public partial class MainWindow : Window
    {
        adbDataset adbDataset;
        adbDatasetTableAdapters.ProductTableAdapter adbDatasetProductTableAdapter;
        CollectionViewSource productViewSource;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            adbDataset = ((adbDataset)(this.FindResource("adbDataset")));
            // Load data into the table Product. You can modify this code as needed.
            adbDatasetProductTableAdapter = new adbDatasetTableAdapters.ProductTableAdapter();
            adbDatasetProductTableAdapter.Fill(adbDataset.Product);
            productViewSource = ((CollectionViewSource)(this.FindResource("productViewSource")));
            productViewSource.View.MoveCurrentToFirst();
        }

        private void btnNaprej_Click(object sender, RoutedEventArgs e)
        {
            int dolžina = ((CollectionView)(productViewSource.View)).Count;
            if (productViewSource.View.CurrentPosition<dolžina-1)
                productViewSource.View.MoveCurrentToNext();
        }

        private void btnNazaj_Click(object sender, RoutedEventArgs e)
        {
            if (productViewSource.View.CurrentPosition > 0)
                productViewSource.View.MoveCurrentToPrevious();
        }

        private void btnShrani_Click(object sender, RoutedEventArgs e)
        {
            adbDatasetProductTableAdapter.Update(adbDataset.Product);
        }
    }
}

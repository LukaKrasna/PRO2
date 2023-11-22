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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Nepovezan__Baze_podatkov_.adbDataset adbDataset = ((Nepovezan__Baze_podatkov_.adbDataset)(this.FindResource("adbDataset")));
            // Load data into the table Product. You can modify this code as needed.
            Nepovezan__Baze_podatkov_.adbDatasetTableAdapters.ProductTableAdapter adbDatasetProductTableAdapter = new Nepovezan__Baze_podatkov_.adbDatasetTableAdapters.ProductTableAdapter();
            adbDatasetProductTableAdapter.Fill(adbDataset.Product);
            System.Windows.Data.CollectionViewSource productViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("productViewSource")));
            productViewSource.View.MoveCurrentToFirst();
        }
    }
}

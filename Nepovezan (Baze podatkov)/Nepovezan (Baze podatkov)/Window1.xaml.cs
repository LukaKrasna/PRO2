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
using System.Windows.Shapes;

namespace Nepovezan__Baze_podatkov_
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            Nepovezan__Baze_podatkov_.adbDataset adbDataset = ((Nepovezan__Baze_podatkov_.adbDataset)(this.FindResource("adbDataset")));
            // Load data into the table SalesOrderHeader. You can modify this code as needed.
            Nepovezan__Baze_podatkov_.adbDatasetTableAdapters.SalesOrderHeaderTableAdapter adbDatasetSalesOrderHeaderTableAdapter = new Nepovezan__Baze_podatkov_.adbDatasetTableAdapters.SalesOrderHeaderTableAdapter();
            adbDatasetSalesOrderHeaderTableAdapter.Fill(adbDataset.SalesOrderHeader);
            System.Windows.Data.CollectionViewSource salesOrderHeaderViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("salesOrderHeaderViewSource")));
            salesOrderHeaderViewSource.View.MoveCurrentToFirst();
            // Load data into the table SalesOrderDetail. You can modify this code as needed.
            Nepovezan__Baze_podatkov_.adbDatasetTableAdapters.SalesOrderDetailTableAdapter adbDatasetSalesOrderDetailTableAdapter = new Nepovezan__Baze_podatkov_.adbDatasetTableAdapters.SalesOrderDetailTableAdapter();
            adbDatasetSalesOrderDetailTableAdapter.Fill(adbDataset.SalesOrderDetail);
            System.Windows.Data.CollectionViewSource salesOrderHeaderSalesOrderDetailViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("salesOrderHeaderSalesOrderDetailViewSource")));
            salesOrderHeaderSalesOrderDetailViewSource.View.MoveCurrentToFirst();
        }
    }
}

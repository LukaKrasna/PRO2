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

namespace WPFinEF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //naloga:https://ucilnice.scng.si/pluginfile.php/189535/mod_resource/content/0/WPF%20in%20EF.pdf
        northwndEntities nw=new northwndEntities();
        CollectionViewSource custViewSource;
        CollectionViewSource ordViewSource;
        public MainWindow()
        {
            InitializeComponent();
            custViewSource = (CollectionViewSource)FindResource("customersViewSource");
            ordViewSource = (CollectionViewSource)FindResource("customersOrdersViewSource");
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var x = nw.Customers.Select(a => a).ToList();
            custViewSource.Source = x;
        }
    }
}

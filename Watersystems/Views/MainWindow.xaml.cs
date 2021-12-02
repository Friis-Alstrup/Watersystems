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

namespace Watersystems
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameWindow.Source = new Uri("ProductList.xaml", UriKind.Relative);
        }

        private void WarehouseBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameWindow.Source = new Uri("ProductList.xaml", UriKind.Relative);
        }

        private void OrderBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameWindow.Source = new Uri("OrderList.xaml", UriKind.Relative);
        }

        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameWindow.Source = new Uri("SettingsPage.xaml", UriKind.Relative);
        }
    }
}

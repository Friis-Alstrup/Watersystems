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
using Watersystems.ViewModels;

namespace Watersystems.Views
{
    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        WarehouseViewModel WVM = new WarehouseViewModel();

        public SettingsPage()
        {
            InitializeComponent();
            DataContext = WVM;
        }

        private void AddWarehousebtn_Click(object sender, RoutedEventArgs e)
        {
            WVM.CreateWarehouse(int.Parse(WarehouseNameBox.Text), LocationBox.Text);
        }
    }
}

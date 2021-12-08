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
using Watersystems.ViewModels;

namespace Watersystems.Views
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {

        WarehouseViewModel wvm = new WarehouseViewModel();
        ProductViewModel pvm = new ProductViewModel();

        public AddProduct()
        {
            InitializeComponent();
            DataContext = wvm;
        }

        private void AddProductToList_Click(object sender, RoutedEventArgs e)
        {
            pvm.CreateProduct(productNameBox.Text, int.Parse(productNumberBox.Text), 0, unitTypeBox.Text, selectedWarehouse.SelectedIndex + 1, supplierBox.Text);    
            Close();
        }
    }
}

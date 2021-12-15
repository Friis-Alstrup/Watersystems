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

        public string SelectedProductName { get; set; }
        public int SelectedProductNumber { get; set; }
        public int SelectedQuantity { get; set; }
        public string SelectedUnitType { get; set; }
        public int SelectedWarehouse { get; set; }
        public string SelectedSupplier { get; set; }


        public AddProduct()
        {
            InitializeComponent();
            DataContext = wvm;
        }

        private void AddProductToList_Click(object sender, RoutedEventArgs e)
        {
            SelectedProductName = productNameBox.Text;
            SelectedProductNumber = int.Parse(productNumberBox.Text);
            SelectedQuantity = 0;
            SelectedWarehouse = selectedWarehouse.SelectedIndex + 1;
            SelectedSupplier = supplierBox.Text;
            DialogResult = true;
        }

        private void CancelAddProductToList_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

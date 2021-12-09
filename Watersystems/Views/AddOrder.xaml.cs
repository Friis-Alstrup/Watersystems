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
    /// Interaction logic for AddOrder.xaml
    /// </summary>
    public partial class AddOrder : Window
    {
        ProductViewModel pvm = new ProductViewModel();

        public string SelectedOrderNumber { get; set; }
        public string SelectedOrderedBy { get; set; }
        public int SelectedProduct { get; set; }
        public string SelectedQuantity { get; set; }

        public AddOrder()
        {
            InitializeComponent();
            DataContext = pvm;
        }

        private void AddOrderToList_Click(object sender, RoutedEventArgs e)
        {
            SelectedOrderNumber = orderNumberBox.Text;
            SelectedOrderedBy = orderedByBox.Text;
            SelectedProduct = selectedProduct.SelectedIndex + 1;
            SelectedQuantity = quantityBox.Text;
            DialogResult = true;
        }

        private void CancelAddOrderToList_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}

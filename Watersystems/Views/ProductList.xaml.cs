﻿using System;
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
    /// Interaction logic for WarehouseList.xaml
    /// </summary>
    public partial class ProductList : Page
    {

        ProductViewModel pvm = new ProductViewModel();

        public ProductList()
        {
            InitializeComponent();
            DataContext = pvm;
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            AddProduct ap = new AddProduct();
            
            if (ap.ShowDialog() == true)
            {
                pvm.CreateProduct(ap.SelectedProductName, ap.SelectedProductNumber, ap.SelectedQuantity, ap.SelectedUnitType, ap.SelectedWarehouse, ap.SelectedSupplier);
            }
        }
    }
}

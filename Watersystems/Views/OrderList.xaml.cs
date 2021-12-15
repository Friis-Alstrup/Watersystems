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
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class OrderList : Page
    {

        OrderViewModel ovm = new OrderViewModel();
        ProductViewModel pvm = new ProductViewModel();

        public OrderList()
        {
            InitializeComponent();
            DataContext = ovm;
        }

        private void AddOrder_Click(object sender, RoutedEventArgs e)
        {
            AddOrder ao = new AddOrder();

            if (ao.ShowDialog() == true)
            {
                ovm.CreateOrder(int.Parse(ao.SelectedOrderNumber), ao.SelectedOrderedBy, double.Parse(ao.SelectedQuantity), pvm.GetProduct(ao.SelectedProduct));
            }
        }
    }
}

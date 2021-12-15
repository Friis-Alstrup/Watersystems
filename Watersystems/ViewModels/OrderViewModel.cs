using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watersystems.Models;

namespace Watersystems.ViewModels
{
   public class OrderViewModel
    {
        OrderRepo orderRepo = new OrderRepo();

        public ObservableCollection<Order> OrderVM { get; set; }

        public OrderViewModel()
        {
            OrderVM = new ObservableCollection<Order>();

            foreach (Order order in GetAllOrders())
            {
                OrderVM.Add(order);
            }
        }

        public void CreateOrder(int orderNumber, string orderedBy, double quantity, Product product)
        {
            Order order = orderRepo.Create(orderNumber, orderedBy, quantity, product);
            OrderVM.Add(order);
        }
        public List<Order> GetAllOrders()
        {
            return orderRepo.GetAll();
        }
        public void GetOrder(int orderNumber)
        {
            orderRepo.Get(orderNumber);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watersystems.Models;

namespace Watersystems.ViewModels
{
   public class OrderViewModel
    {
        OrderRepo orderRepo = new OrderRepo();
        
        public void CreateOrder(int orderNumber, string orderedBy, string recievedBy, List<Product> products)
        {
            orderRepo.Create(orderNumber, orderedBy, recievedBy, products);
        }
        public void CreateOrder(int orderNumber, string orderedBy, List<Product> products)
        {
            orderRepo.Create(orderNumber, orderedBy, products);
        }
        public void GetAllOrders()
        {
            orderRepo.GetAll();
        }
        public void GetOrder(int orderNumber)
        {
            orderRepo.Get(orderNumber);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watersystems.Models;

namespace Watersystems.ViewModels
{
    public class OrderRepo
    {
        private List<Order> orders = new List<Order>();

        private string dataFileName = "Order.csv";

        public void Create(int orderNumber, string orderedBy, List<Product> products)
        {
            orders.Add(new Order(orderNumber, orderedBy, products));
        }
        public void Create(int orderNumber, string orderedBy, string recivedBy, List<Product> products)
        {
            orders.Add(new Order(orderNumber, orderedBy, recivedBy, products));
        }
        public Order Get(int orderNumber)
        {
            Order result = null;
            foreach (Order order in orders)
            {
                if (orderNumber == order.OrderNumber)
                {
                    result = order;
                    break;
                }
            }
            return result;
        }
        public List<Order> GetAll()
        {
            return orders;
        }
        public void Update()
        {

        }
        public void Delete(int orderNumber)
        {
            Order order = this.Get(orderNumber);
            if (order != null)
            {
                orders.Remove(order);
            }
        }
    }
}

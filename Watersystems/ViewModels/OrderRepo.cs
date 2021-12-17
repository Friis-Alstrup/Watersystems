using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watersystems.Models;
using System.IO;

namespace Watersystems.ViewModels
{
    public class OrderRepo
    {
        // Defination af fields.
        private List<Order> orders = new List<Order>();
        private string dataFileName = "Orders.csv";

        public OrderRepo()
        {
            InitializeRepo();
        }

        public Order Create(int orderNumber, string orderedBy, double quantity, Product product)
        {
            Order order = new Order(orderNumber, orderedBy, quantity, product);
            orders.Add(order);

            using (StreamWriter sw = new StreamWriter(dataFileName, append: true))
            {
                sw.WriteLine($"{order.OrderNumber},{order.DateOrdered},{order.OrderedBy},{order.RecivedBy},{order.Quantity},{order.Product.ProductName}");
            }

            return order;
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

/*      Ment to be implemented later.
        public void Update()
        {

        }*/

        public void Delete(int orderNumber)
        {
            Order order = this.Get(orderNumber);
            if (order != null)
            {
                orders.Remove(order);
            }
        }

        private void InitializeRepo()
        {
            ProductRepo pr = new ProductRepo();

            using (StreamReader sr = new StreamReader(dataFileName))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] parts = line.Split(",");

                    orders.Add(new Order(int.Parse(parts[0]), parts[2], parts[1], double.Parse(parts[4]), parts[3], pr.Get(parts[5])));

                    line = sr.ReadLine();
                }
            }
        }
    }
}

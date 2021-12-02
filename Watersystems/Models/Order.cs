using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watersystems.Models
{
    public class Order
    {
        public int OrderNumber { get; set; }
        public string OrderedBy { get; set; }
        public DateTime DateOrdered { get; set; }
        public DateTime DateRecived { get; set; }
        public string RecivedBy { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();


        public Order(int orderNumber, string orderedBy, List<Product> products) : this(orderNumber, orderedBy, DateTime.Today, default, string.Empty, products)
        {

        }
        public Order(int orderNumber, string orderedBy, string recivedBy, List<Product> products ) : this(orderNumber, orderedBy, DateTime.Today, default, recivedBy, products)
        {

        }
        public Order(int orderNumber, string orderedBy, DateTime dateOrdered, DateTime dateRecived, string recivedBy, List<Product> products)
        {
            this.OrderNumber = orderNumber;
            this.OrderedBy = orderedBy;
            this.DateOrdered = dateOrdered;
            this.DateRecived = dateRecived;
            this.RecivedBy = recivedBy;
            this.Products = products;
        }

    }


}

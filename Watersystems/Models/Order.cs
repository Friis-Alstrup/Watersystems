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
        public double Quantity { get; set; }
        public Product Product { get; set; }

        public Order(int orderNumber, string orderedBy, double quantity, Product product) : this(orderNumber, orderedBy, DateTime.Today, default, "Ikke modtaget", quantity, product)
        {

        }

        public Order(int orderNumber, string orderedBy, double quantity, string RecivedBy, Product product) : this(orderNumber, orderedBy, DateTime.Today, default, RecivedBy, quantity, product)
        {

        }

        public Order(int orderNumber, string orderedBy, DateTime dateOrdered, DateTime dateRecived, string recivedBy, double quantity, Product product)
        {
            this.OrderNumber = orderNumber;
            this.OrderedBy = orderedBy;
            this.DateOrdered = dateOrdered;
            this.DateRecived = dateRecived;
            this.RecivedBy = recivedBy;
            this.Quantity = quantity;
            this.Product = product;
        }

    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watersystems.Models
{
    public class Order
    {
        // Defination af properties
        public int OrderNumber { get; set; }
        public string OrderedBy { get; set; }
        public string DateOrdered { get; set; }
        public DateTime DateRecived { get; set; }
        public string RecivedBy { get; set; }
        public double Quantity { get; set; }
        public Product Product { get; set; }

        // Constructor overloading
        
        // Modtager kun Ordernummer, Bestilt af, antal og produktet. (Brugt i UI)
        public Order(int orderNumber, string orderedBy, double quantity, Product product) : this(orderNumber, orderedBy, DateTime.Now.ToString("dd/MM/yyyy"), default, "Ikke modtaget", quantity, product)
        {

        }

        // Bliver brugt til at initialize repositoriet ud fra csv-filen.
        public Order(int orderNumber, string orderedBy, string dateOrdered, double quantity, string RecivedBy, Product product) : this(orderNumber, orderedBy, dateOrdered, default, RecivedBy, quantity, product)
        {

        }

        // Modtager alle properties.
        public Order(int orderNumber, string orderedBy, string dateOrdered, DateTime dateRecived, string recivedBy, double quantity, Product product)
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

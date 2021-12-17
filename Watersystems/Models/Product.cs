using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watersystems.Models
{
    public class Product
    {
        // Defination af properties.
        public string ProductName { get; set; }
        public int ProductNumber { get; set; }
        public double Quantity { get; set; }
        public string UnitType { get; set; }
        public Warehouse Warehouse { get; set; }
        public Supplier Supplier { get; set; }


        // Constructor
        public Product(string productName, int productNumber, double quantity, string unitType, Warehouse warehouse, Supplier supplier)
        {
            this.ProductName = productName;
            this.ProductNumber = productNumber;
            this.Quantity = quantity;
            this.UnitType = unitType;
            this.Warehouse = warehouse;
            this.Supplier = supplier;
        }
    }
}

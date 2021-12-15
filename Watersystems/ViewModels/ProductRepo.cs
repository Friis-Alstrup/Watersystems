using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watersystems.Models;
using System.IO;

namespace Watersystems.ViewModels
{
    public class ProductRepo
    {
        private List<Product> products = new List<Product>();

        private WarehouseRepo warehouseRepo = new WarehouseRepo();

        private string dataFileName = "Products.csv";

        public ProductRepo()
        {
            InitializeRepo();
        }

        public Product Create(string productName, int productNumber, double quantity, string unitType, int warehouse, string supplier)
        {
            Product product = new Product(productName, productNumber, quantity, unitType, warehouseRepo.Get(warehouse), new Supplier(supplier));

            products.Add(product);

            using (StreamWriter sw = new StreamWriter(dataFileName, append: true))
            {
                sw.WriteLine($"{product.ProductName},{product.ProductNumber},{product.Quantity},{product.UnitType},{product.Warehouse.WarehouseName},{product.Supplier.SupplierName}");
            }

            return product;
        }

        public Product Get(int productNumber)
        {
            Product result = null;
            foreach (Product product in products)
            {
                if (productNumber == product.ProductNumber)
                {
                    result = product;
                    break;
                }
            }
            return result;
        }

        public Product Get(string productName)
        {
            Product result = null;
            foreach(Product product in products)
            {
                if (productName == product.ProductName)
                {
                    result = product;
                    break;
                }
            }
            return result;
        }

        public List<Product> GetAll()
        {
            return products;
        }

/*      Ment to be implemented later.
        public void Update()
        {

        }*/

        public void Delete(int productNumber)
        {
            Product product = this.Get(productNumber);
            if (product != null)
            {
                products.Remove(product);
            }
        }

        private void InitializeRepo()
        {
            using (StreamReader sr = new StreamReader(dataFileName, Encoding.UTF8))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] parts = line.Split(",");

                    products.Add(new Product(parts[0], int.Parse(parts[1]), double.Parse(parts[2]), parts[3], warehouseRepo.Get(int.Parse(parts[4])), new Supplier(parts[5])));

                    line = sr.ReadLine();
                }
            }
        }
    }
}

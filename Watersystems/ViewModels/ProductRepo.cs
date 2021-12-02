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

        private string dataFileName = "Products.csv";

        public ProductRepo()
        {
            InitializeRepo();
        }

        private void InitializeRepo()
        {
            using (StreamReader sr = new StreamReader(dataFileName))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] parts = line.Split(",");

                    this.Create(parts[0], int.Parse( parts[1]), double.Parse(parts[2]), parts[3], int.Parse( parts[4]), parts[5]);

                    line = sr.ReadLine();
                }
            }
        }

        public void Create(string productName, int productNumber, double quantity, string unitType, int warehouse, string supplier)
        {
            Product product = new Product(productName, productNumber, quantity, unitType, warehouse, new Supplier(supplier));

            products.Add(product);
            SaveToFile(product);
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

        public List<Product> GetAll()
        {
            return products;
        }
        public void Update()
        {

        }
        public void Delete(int productNumber)
        {
            Product product = this.Get(productNumber);
            if (product != null)
            {
                products.Remove(product);
            }

        }

        private void SaveToFile(Product product)
        {
            using (StreamWriter sw = new StreamWriter(dataFileName, append: true))
            {
                sw.WriteLine(product);
            }
        }
    }
}

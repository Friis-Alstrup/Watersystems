using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watersystems.Models;

namespace Watersystems.ViewModels
{
    public class ProductRepo
    {
        private List<Product> products = new List<Product>();

        private string dataFileName = "Product.csv";

        public void Create(string productName, int productNumber, double quantity, string unitType)
        {
            products.Add(new Product(productName, productNumber, quantity, unitType));
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
    }
}

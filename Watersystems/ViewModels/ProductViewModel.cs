using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watersystems.Models;

namespace Watersystems.ViewModels
{
    public class ProductViewModel
    {

        ProductRepo productRepo = new ProductRepo(); 


        public void CreateProduct(string productName, int productNumber, double quantity, string unitType, int warehouse, string supplier )
        {
            productRepo.Create(productName, productNumber, quantity, unitType, warehouse, supplier);
        }

        public List<Product> GetAllProducts()
        {
            return productRepo.GetAll();
        }
        public Product GetProduct(int productnumber)
        {
            return productRepo.Get(productnumber);
        }

  
    }
}

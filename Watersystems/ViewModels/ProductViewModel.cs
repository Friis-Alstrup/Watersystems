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


        public void CreateProduct(string productName, int productNumber, double quantity, string unitType, Warehouse warehouse, Supplier supplier )
        {
            productRepo.Create(productName, productNumber, quantity, unitType, warehouse, supplier);
        }

        public void GetAllProducts()
        {
            productRepo.GetAll();
        }
        public void GetProduct(int productnumber)
        {
            productRepo.Get(productnumber);
        }

        public void GetProduct(string productName)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watersystems.Models;

namespace Watersystems.ViewModels
{
    public class ProductViewModel
    {
        ProductRepo productRepo = new ProductRepo();
        
        public ObservableCollection<Product> ProductVM { get; set; }

        public ProductViewModel()
        {
            ProductVM = new ObservableCollection<Product>();

            foreach (Product product in GetAllProducts())
            {
                ProductVM.Add(product);
            }
        }

        public void CreateProduct(string productName, int productNumber, double quantity, string unitType, int warehouse, string supplier)
        {
            Product product = productRepo.Create(productName, productNumber, quantity, unitType, warehouse, supplier);
            ProductVM.Add(product);
        }

        public List<Product> GetAllProducts()
        {
            return productRepo.GetAll();
        }

        public Product GetProduct(int productnumber)
        {
            return productRepo.Get(productnumber);
        }

        public void DeleteProduct(int productNumber)
        {
            Product product = productRepo.Get(productNumber);
            ProductVM.Remove(product);
            productRepo.Delete(productNumber);
        }

/*        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }*/
    }
}

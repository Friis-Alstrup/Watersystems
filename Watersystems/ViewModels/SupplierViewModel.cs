using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watersystems.Models;

namespace Watersystems.ViewModels
{
   public class SupplierViewModel
    {

        // Implementeres sernere.
        public Supplier CreateSupplier(string supplierName)
        {
            return new Supplier(supplierName);
        }
      
    }
}

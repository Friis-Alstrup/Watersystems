using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watersystems.Models
{
    public class Supplier
    {
        public string SupplierName { get; set; }

        public Supplier(string supplier)
        {
            this.SupplierName = supplier;
        }
    }
}

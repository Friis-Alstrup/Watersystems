using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watersystems.Models
{
    public class Warehouse
    {
        public int WarehouseName { get; set; }
        public string Location { get; set; }

        public Warehouse(int warehouseName, string location)
        {
            this.WarehouseName = warehouseName;
            this.Location = location;
        }
    }
}

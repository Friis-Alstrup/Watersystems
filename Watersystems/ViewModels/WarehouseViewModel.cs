using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watersystems.Models;

namespace Watersystems.ViewModels
{
    public class WarehouseViewModel
    {
        WarehouseRepo warehouserepo = new WarehouseRepo();
        
        public void CreateWarehouse(int warehouseName, string location)
        {
            warehouserepo.Create(warehouseName, location);
        }

        public Warehouse GetWarehouse(int warehouseName)
        {
            return warehouserepo.Get(warehouseName);
        }

    }
}

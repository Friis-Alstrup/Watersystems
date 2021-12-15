using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watersystems.Models;

namespace Watersystems.ViewModels
{
    public class WarehouseViewModel
    {

        public ObservableCollection<Warehouse> WarehouseVM { get; set; }
        WarehouseRepo warehouseRepo = new WarehouseRepo();

        public WarehouseViewModel()
        {
            WarehouseVM = new ObservableCollection<Warehouse>();

            foreach (Warehouse warehouse in warehouseRepo.GetAll())
            {
                WarehouseVM.Add(warehouse);
            }
        }
        
        public void CreateWarehouse(int warehouseName, string location)
        {
            Warehouse warehouse = warehouseRepo.Create(warehouseName, location);
            WarehouseVM.Add(warehouse);
        }

        public Warehouse GetWarehouse(int warehouseName)
        {
            return warehouseRepo.Get(warehouseName);
        }
    }
}

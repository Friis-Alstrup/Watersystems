using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watersystems.Models;
using System.IO;

namespace Watersystems.ViewModels
{
   public class WarehouseRepo
    {
        private List<Warehouse> warehouses = new List<Warehouse>();
        private string dataFileName = "warehouses.csv";

        public WarehouseRepo()
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

                    this.Create(int.Parse(parts[0]), parts[1]);

                    line = sr.ReadLine();
                }
            }
        }

        public void Create(int warehousename, string location)
        {
            warehouses.Add(new Warehouse(warehousename, location));
        }
        public Warehouse Get(int warehouseName)
        {
            Warehouse result = null;
            foreach (Warehouse warehouse in warehouses)
            {
                if (warehouseName == warehouse.WarehouseName)
                {
                    result = warehouse;
                    break;
                }
            }
            return result;
        }
        public void Update()
        {

        }
        public void Delete(int warehouseName)
        {
            Warehouse warehouse = this.Get(warehouseName);
            if (warehouse != null)
            {
                warehouses.Remove(warehouse);
            }
        }

    }
}

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
        private string dataFileName = "Warehouses.csv";

        public WarehouseRepo()
        {
            InitializeRepo();
        }

        private void InitializeRepo()
        {
           /* using (StreamReader sr = new StreamReader(dataFileName))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] parts = line.Split(",");
                    warehouses.Add(new Warehouse(int.Parse(parts[0]), parts[1]));
                    line = sr.ReadLine();
                }
            }*/
        }

        public void Create(int warehousename, string location)
        {
            Warehouse warehouse = new Warehouse(warehousename, location);

            warehouses.Add(warehouse);
            SaveToFile(warehouse);

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

        public List<Warehouse> GetAll()
        {
            return warehouses;
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

        private void SaveToFile(Warehouse warehouse)
        {
            using (StreamWriter sw = new StreamWriter(dataFileName, append: true))
            {
                sw.WriteLine($"{warehouse.WarehouseName},{warehouse.Location}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watersystems.Models;

namespace Watersystems.ViewModels
{
    public class WarehouseViewModel : INotifyPropertyChanged
    {

        private Warehouse _selectedWarehouseVM;
        public Warehouse SelectedWarehouseVM { get { return _selectedWarehouseVM; } set { _selectedWarehouseVM = value; OnPropertyChanged("SelectedWarehouseVM"); } }

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
            Warehouse adw = warehouse;
            WarehouseVM.Add(adw);
        }

        public Warehouse GetWarehouse(int warehouseName)
        {
            return warehouseRepo.Get(warehouseName);
        }

        public void DeleteSelectedPerson()
        {
            // Need to be implemented -> warehouseRepo.Delete(warehouseName);
            WarehouseVM.Remove(SelectedWarehouseVM);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Models;

namespace VehicleManagementSystem.Data
{
    public class VehicleManager : IVehicleManager
    {
        private readonly List<IVehicle> _vehicles = new List<IVehicle>();
        public void Add(IVehicle vehicle) => _vehicles.Add(vehicle);

        public IEnumerable<IVehicle> ViewAllVehicles() => _vehicles;
        
        public bool Remove(int id)
        {
            var v = _vehicles.FirstOrDefault(x => x.Id == id);
            if(v == null) return false;
            _vehicles.Remove(v);
            return true;
        }

        public IEnumerable<IVehicle> SearchByBrand(string brand)
        {
            return _vehicles.Where(v => v.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<IVehicle> SearchByType(string type)
        {
            return _vehicles.Where(v => v.VehicleType.Equals(type, StringComparison.OrdinalIgnoreCase));
        }
        public void Display(IEnumerable<IVehicle> vehicles)
        {
            if (!vehicles.Any())
            {
                Console.WriteLine("No vehicles found.");
                return;
            }
            foreach (var vehicle in vehicles)
                Console.WriteLine(vehicle);
        }

    }
}

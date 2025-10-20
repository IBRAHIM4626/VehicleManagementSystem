using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Models;

namespace VehicleManagementSystem.Data
{
    public interface IVehicleManager
    {
        void Add(IVehicle vehicle);
        bool Remove(int id);
        IEnumerable<IVehicle> ViewAllVehicles();
        IEnumerable<IVehicle> SearchByBrand(string brand);
        IEnumerable<IVehicle> SearchByType(string type);
        void Display(IEnumerable<IVehicle> vehicles);
    }
}

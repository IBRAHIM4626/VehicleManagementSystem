using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Models
{
    public interface IVehicle
    {
        int Id { get; }
        string Brand { get; }
        string Model { get; }
        int Year { get; }
        double MaxSpeed {  get; }
        string VehicleType {  get; }

        double CalculateRentalPrice();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Models
{
    public sealed class Truck : Vehicle
    {
        public double LoadCapacity { get; set; }


        public Truck(int id, string brand, string model, int year, double maxSpeed, double loadCapacity)
            : base(id, brand, model, year, maxSpeed)
        {
            LoadCapacity = loadCapacity;
        }
        public override string VehicleType => nameof(Truck);

        public override double CalculateRentalPrice()
        {
            return 80 + LoadCapacity * 15;
        }
        public override string ToString()
        {
            return base.ToString() + $", LoadCapacity={LoadCapacity} tons";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Models
{
    public sealed class Motorcycle : Vehicle
    {
        public bool HasSideCar {  get; set; }


        public Motorcycle(int id, string brand, string model, int year, double maxSpeed, bool hasSideCar) 
            : base(id, brand, model, year, maxSpeed)
        {
            HasSideCar = hasSideCar;
        }
        public override string VehicleType => nameof(Motorcycle);

        public override double CalculateRentalPrice()
        {
            return HasSideCar ? 35 : 25;
        }
        public override string ToString()
        {
            return base.ToString() + $", SideCar={(HasSideCar ? "Yes" : "No")}";
        }
    }
}

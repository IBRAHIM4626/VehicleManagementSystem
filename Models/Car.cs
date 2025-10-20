using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Models
{
    public sealed class Car : Vehicle
    {
        public int Doors { get; set; }
        public Car(int id, string brand, string model, int year, double maxSpeed, int doors)
            : base(id, brand, model, year, maxSpeed) 
        {
            Doors = doors;
        }
        public override string VehicleType => nameof(Car);
        public override double CalculateRentalPrice()
        {
            return 40 + Doors * 8;
        }
        public override string ToString()
        {
            return base.ToString() + $", Doors= {Doors}";
        }
    }
}

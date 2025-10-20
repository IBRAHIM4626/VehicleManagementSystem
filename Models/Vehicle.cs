using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Models
{
    public abstract class Vehicle : IVehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double MaxSpeed { get; set; }

        protected Vehicle(int id, string brand, string model, int year, double maxSpeed) 
        {
            Id = id;
            Brand = brand;
            Model = model;
            Year = year;
            MaxSpeed = maxSpeed;
        }
        public abstract string VehicleType { get; }
        public abstract double CalculateRentalPrice();
        public override string ToString() => 
            $"{VehicleType} [Id={Id}, Brand={Brand}, Model={Model}, Year={Year}, MaxSpeed={MaxSpeed} km/h, Rent=${CalculateRentalPrice():0.00}]";
    }
}

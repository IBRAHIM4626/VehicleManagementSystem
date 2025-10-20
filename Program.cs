using VehicleManagementSystem.Data;
using VehicleManagementSystem.Models;

namespace VehicleManagementSystem
{
    internal class Program
    {
        private static readonly VehicleManager manager = new();
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("\n=== Vehicle Management System ===");
                Console.WriteLine("1. Add Vehicle");
                Console.WriteLine("2. View All Vehicle");
                Console.WriteLine("3. Search by Brand");
                Console.WriteLine("4. Search by Type");
                Console.WriteLine("5. Remove Vehicle by Id");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Select an option");

                switch (Console.ReadLine()) 
                {
                    case "1": AddVehicle(); break;
                    case "2": manager.Display(manager.ViewAllVehicles()); break;
                    case "3":
                        Console.Write("Enter Brand: ");
                        manager.Display(manager.SearchByBrand(Console.ReadLine()));
                        break;
                    case "4":
                        Console.Write("Enter Type: ");
                        manager.Display(manager.SearchByType(Console.ReadLine()));
                        break;
                    case "5":
                        Console.Write("Enter Vehicle Id: ");
                        if(int.TryParse(Console.ReadLine(), out int id) && manager.Remove(id))
                            Console.WriteLine("Vehicle removed successfully.");
                        else
                            Console.WriteLine("Vehicle not found.");
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

            }

        }
        private static void AddVehicle()
        {
            Console.WriteLine("\nSelect Vehicle Type:");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Motorcycle");
            Console.WriteLine("3. Truck");
            Console.WriteLine("Choice: ");
            string choice = Console.ReadLine();

            int id = ReadInt("Enter Id: ");
            string brand = ReadString("Enter Brand: ");
            string model = ReadString("Enter Model: ");
            int year = ReadInt("Enter Year: ");
            double speed = ReadDouble("Enter Max Speed (km/h): ");

            switch (choice) 
            {
                case "1":
                    int doors = ReadInt("Enter Number of Doors: ");
                    manager.Add(new Car(id, brand, model, year, speed, doors));
                    break;
                case "2":
                    bool sideCar = ReadBool("Has SideCar (true/false): ");
                    manager.Add(new Motorcycle(id, brand, model, year, speed, sideCar));
                    break;
                case "3":
                    double loadCapacity = ReadDouble("Enter Load Capacity (tons): ");
                    manager.Add(new Truck(id, brand, model, year, speed, loadCapacity));
                    break;
                default:
                    Console.WriteLine("Invalid vehicle type.");
                    return;
            }
            Console.WriteLine("Vehicle added successfully!");

        }

        private static int ReadInt(string message)
        {
            Console.Write(message);
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
                Console.Write("Invalid input, try again: ");
            return result;
        }
        private static string ReadString(string message) 
        {
            Console.Write(message);
            string? result;
            while (string.IsNullOrWhiteSpace(result = Console.ReadLine()))
                Console.Write("Can not be empty, try again: ");
            return result;
        }
        private static double ReadDouble(string message) 
        {
            Console.Write(message);
            double result;
            while(!double.TryParse(Console.ReadLine(),out result))
                Console.Write("Invalid input, try again: ");
            return result;
        }
        private static bool ReadBool(string message)
        {
            Console.Write(message);
            bool result;
            while (!bool.TryParse(Console.ReadLine(), out result))
                Console.Write("Invalid input (true/false): ");
            return result;
        }
    }
}

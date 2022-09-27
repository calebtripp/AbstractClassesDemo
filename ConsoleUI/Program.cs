using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicleList = new List<Vehicle>();

            var mini = new Car() { HasTrunk = true, Make = "Austin", Model = "Cooper S", Year = 1963 };
            var triumph = new Motorcycle() { HasSideCar = false, Make = "Triumph", Model = "Bonneville", Year = 1962 };
            Vehicle healey = new Car() { HasTrunk = true, Make = "Austin", Model = "100-6", Year = 1957 };
            Vehicle indian = new Motorcycle() { HasSideCar = true, Make = "Indian", Model = "Scout", Year = 1923 };

            vehicleList.Add(mini);
            vehicleList.Add(triumph);
            vehicleList.Add(healey);
            vehicleList.Add(indian);

            foreach (var vehicle in vehicleList)
            {
                Console.WriteLine($"Year: {vehicle.Year}, Make: {vehicle.Make}, Model: {vehicle.Model}");

                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool HasSideCar { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("key on, ignition, in gear, release clutch & increase throttle");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Cycle is driving\n");
        }
    }
}

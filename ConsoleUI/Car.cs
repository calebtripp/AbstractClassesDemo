using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool HasTrunk { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("key on, ignition, in gear, increase throttle");
        }
    }
}

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public int Year { get; set; } = 1900;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Focus";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("vehicle is driving\n");
        }
    }
}

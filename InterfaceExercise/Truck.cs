﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        //Unique classes to Truck
        public void PrintInfo()
        {
            Console.WriteLine($"Bed Size: {BedSize}.");
            Console.WriteLine();
            Console.WriteLine($"This vehicle has four-wheel drive: {HasFourWheelDrive}.");
        }
        public string BedSize { get; set; }
        public bool HasFourWheelDrive { get; set; }

        //IVehicle interface
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string NumberOfWheels { get; set; }

        //ICompany interface
        public string CountryOrigin { get; set; }
        public string Logo { get; set; }
    }
}

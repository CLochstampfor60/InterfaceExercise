using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        //Unique classes to Car
        public string TrunkSize {  get; set; }
        public bool BestForSingles { get; set;}

        //IVehicle interface
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string NumberOfWheels { get; set; }

        //ICompany Interface
        public string CountryOrigin { get; set; }
        public string Logo { get; set; }
    }
}

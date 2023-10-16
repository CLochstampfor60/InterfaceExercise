using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise 
{
    internal class SUV : IVehicle, ICompany
    {
        //Unique classes to SUV
        public string CargoHoldSize { get; set; }
        public bool BestForFamilies { get; set; }

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

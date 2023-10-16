using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        //Unique classes to Truck
        public string BedSize { get; set; }
        public bool HasFourWheelDrive { get; set; }

        //IVehicle interface
        public string Year { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Make { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumberOfWheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //ICompany interface
        string ICompany.CountryOrigin { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ICompany.Logo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

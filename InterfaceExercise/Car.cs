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
        public string Year { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Make { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumberOfWheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //ICompany Interface
        string ICompany.CountryOrigin { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ICompany.Logo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

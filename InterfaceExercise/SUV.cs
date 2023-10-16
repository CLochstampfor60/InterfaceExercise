using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise 
{
    internal class SUV : IVehicle
    {
        public string CargoHoldSize { get; set; }
        public string BestForFamilies { get; set; }
        public string Year { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Make { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumberOfWheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

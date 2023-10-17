﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle: ICompany
    {
        public string Year { get; set; }
        public string Make {  get; set; }
        public string Model { get; set; }
        public string NumberOfWheels { get; set; }
        void PrintInfo();

    }

}

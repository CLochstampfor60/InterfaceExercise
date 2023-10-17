using InterfaceExercise;
using System;
using System.Collections.Generic;
//TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

//DONE Create 2 Interfaces called IVehicle & ICompany

//DONE Create 3 classes called Car , Truck , & SUV

//In your IVehicle

/* DONE Create 4 members that Car, Truck, & SUV all have in common.
 * Example: All vehicles have a number of wheels... for now..
 */


//In ICompany

/*DONE Create 2 members that are specific to each every company
 * regardless of vehicle type.
 *
 *
 * Example: public string Logo { get; set; }
 */

//In each of your car, truck, and suv classes

/*DONE Create 2 members that are specific to each class
 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
 *
 * DONE Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
 * 
 */

//Now, create objects of your 3 classes and give their members values;
Car car = new Car()
{
    Year = "2023",
    Make = "Ford",
    Model = "Mustang",
    NumberOfWheels = "four",
    CountryOrigin = "United States of America",
    Logo = "The Ford Mustang logo is a galloping stallion. Ford designers met to decide how to communicate the car's Americanness and namesake with an icon and settled on a proposal by Phil Clark. He'd been working on a horse-based design for a while, and it nailed the brief.",
    TrunkSize = "10 to 13 feet",
    BestForSingles = true,
};

SUV suv = new SUV()
{
    Year = "2023",
    Make = "Honda",
    Model = "CR-V (SUV)",
    NumberOfWheels = "four",
    CountryOrigin = "Japan",
    Logo = "The Honda logo emblem has always been a version of the stylized letter “H” on all products for the brand. The sign is symbolic of the “Honda” name, but it has meaning beyond this too. According to some experts, the symbol is also intended to look like a classic armchair, to symbolize safety.",
    CargoHoldSize = "If you want to seat five and use the space behind the second row, you have 39.3 cubic feet of space. Fold down that back row, and you have 75.5 cubic feet of cargo room at your disposal",
    BestForFamilies = true,

};

Truck truck = new Truck()
{
    Year = "2018",
    Make = "Toyota",
    Model = "Tacoma",
    NumberOfWheels = "four",
    CountryOrigin = "Japan",
    Logo = "Toyota logo: The overlapping of the two perpendicular ovals inside the outer oval symbolize 'T' for Toyota, as well as a steering wheel representing the vehicle itself. The outer oval symbolizes the world that embraces Toyota. Each oval is contoured with different stroke thicknesses, similar to the brush art in Japanese culture.",
    BedSize = "5 feet",
    HasFourWheelDrive = true,

};

/*https://stackoverflow.com/questions/5716799/multiple-interfaces-contained-in-one-listt*/
var vehicles = new List<IVehicle>();
vehicles.Add(car);
vehicles.Add(suv);
vehicles.Add(truck);
/*public class Automobiles : IVehicle, ICompany
{

    string IVehicle.Year { get; set; }
    string IVehicle.Make { get; set; }
    string IVehicle.Model { get; set; }
    string IVehicle.NumberOfWheels { get; set; }
    string ICompany.CountryOrigin { get; set; }
    string ICompany.Logo { get; set; }

    void IVehicle.PrintInfo()
    {
        throw new NotImplementedException();
    }
}*/



//Creatively display and organize their values
foreach (var vehicle in vehicles)
{
    Console.WriteLine($"Year: {vehicle.Year}");
    Console.WriteLine($"Make: {vehicle.Make}");
    Console.WriteLine($"Model: {vehicle.Model}");
    Console.WriteLine($"Number of Wheels: {vehicle.NumberOfWheels}");
    Console.WriteLine($"Country Origin: {vehicle.CountryOrigin}");
    Console.WriteLine();
    Console.WriteLine($"Logo: {vehicle.Logo}");
    Console.WriteLine();
    vehicle.PrintInfo();
    Console.WriteLine("----------");
    Console.WriteLine();
}

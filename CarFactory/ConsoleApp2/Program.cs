using CarFabric.Classes.CarFactories;
using CarFabric.Classes.Cars;
using CarFactory.Classes.CarFactories;
using CarFabric.Interfaces;


SedanFactory _SedanFactory = new SedanFactory();
SUVFactory _SUVFactory = new SUVFactory();
TruckFactory _TruckFactory = new TruckFactory();

ICar Car = new Sedan();
_SedanFactory.CreateCar(Car);
Console.WriteLine(Car.GetInfo());

Car = new SUV();
_SUVFactory.CreateCar(Car);
Console.WriteLine($"\n{Car.GetInfo()}\n");


Car = new Truck();
_TruckFactory.CreateCar(Car);
Console.WriteLine(Car.GetInfo());
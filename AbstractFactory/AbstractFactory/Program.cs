using AbstractFactory.Classes;
using AbstractFactory.Interfaces;

ITransport transport;

CarFactory carFactory = new CarFactory();
AirplaneFactory airplaneFactory = new AirplaneFactory();
BoatFactory boardFactory = new BoatFactory();


Factory factory = new Factory(carFactory);
transport = factory.CreateTransport();
Console.WriteLine(transport);

factory = new Factory(airplaneFactory);
transport = factory.CreateTransport();
Console.WriteLine($"\n{transport}\n");

factory = new Factory(boardFactory);
transport = factory.CreateTransport();
Console.WriteLine(transport);
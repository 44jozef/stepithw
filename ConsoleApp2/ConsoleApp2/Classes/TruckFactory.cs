using CarFabric.Classes.Cars;
using CarFabric.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Classes.CarFactories;

internal class TruckFactory : IFactory
{
    public TruckFactory()
    {

    }

    public ICar CreateCar(ICar car)
    {
        var truck = car as Truck;

        truck.Wheels = 4;
        truck.Model = "Ford F-150 Raptor";
        truck.MaxSpeed = 215;
        truck.HP = 430;

        return truck;
    }
}

using CarFabric.Classes.Cars;
using CarFabric.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFabric.Classes.CarFactories;

internal class SUVFactory : IFactory
{


    public SUVFactory()
    {

    }
    public ICar CreateCar(ICar car)
    {
        var Suv = car as SUV;

        Suv.Wheels = 4;
        Suv.IsOffRoad = false;
        Suv.Model = "Toyota RAV4";
        Suv.MaxSpeed = 180;
        Suv.HP = 222;

        return Suv;

    }
}
using CarFabric.Classes.Cars;
using CarFabric.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Classes.CarFactories;

internal class SedanFactory : IFactory
{
    public SedanFactory()
    {

    }

    public ICar CreateCar(ICar car)
    {
        var sedan = car as Sedan;

        sedan.Wheels = 4;
        sedan.Model = "Audi RS7 PowerDivision";
        sedan.MaxSpeed = 330;
        sedan.HP = 1050;

        return sedan;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFabric.Interfaces;

internal interface IFactory
{

    public ICar CreateCar(ICar car);

}
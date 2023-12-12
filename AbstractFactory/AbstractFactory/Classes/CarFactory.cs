using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes;

internal class CarFactory : IFactory
{

    public ITransport CreateTransport()
    {
        return new Car("Porsche 911", 4, 293);
    }
}

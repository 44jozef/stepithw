using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes;

internal class AirplaneFactory : IFactory
{
  
    public ITransport CreateTransport()
    {
        return new Airplane("PHOENIX RIYADH 787-9",10,954);
    }
}

using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes;

internal class Factory
{
    private readonly IFactory factory;
    private ITransport transport;

    public Factory(IFactory _factory)
    {
        factory = _factory;
    }

    public ITransport CreateTransport()
    {
        if (factory != null) 
        {
            transport = factory.CreateTransport();            
        }
        else
        {
            throw new Exception("Factory is now found");
        }
        return transport;
    }
}

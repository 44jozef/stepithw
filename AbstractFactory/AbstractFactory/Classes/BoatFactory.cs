using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes;

internal class BoatFactory : IFactory
{
    public ITransport CreateTransport()
    {
        return new Boat("AMT 190 RF",0, 70);
    }
}

using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes;

internal class Boat : ITransport
{
    public Boat()
    {
        
    }

    public Boat(string _Model,int _Wheels,int _MaxSpeed)
    {
        Model = _Model;
        Wheels = _Wheels;
        MaxSpeed = _MaxSpeed;
    }

    public string Model { get; set; }
    public int Wheels { get; set; }
    public int MaxSpeed { get; set; }

    public override string ToString()
    {
        return $"Boat :\nModel : {Model}\nWheels : {Wheels}\nMax Speed : {MaxSpeed}";
    }

}

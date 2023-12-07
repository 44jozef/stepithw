using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFabric.Interfaces;

internal interface ICar
{

    public string Model { get; set; }
    public int Wheels { get; set; }
    public int HP { get; set; }
    public int MaxSpeed { get; set; }

    public string GetInfo();
}
using CarFabric.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFabric.Classes.Cars;

internal class SUV : ICar
{
    public string Model { get; set; }
    public int Wheels { get; set; }
    public int HP { get; set; }
    public int MaxSpeed { get; set; }
    public bool IsOffRoad { get; set; }

    public SUV()
    {

    }


    public string GetInfo()
    {

        return $"SUV\nModel : {Model}\nWheels : {Wheels} \nHP : {HP}\nMaxSpeed : {MaxSpeed}\nIsOffRoad : {IsOffRoad}";
    }
}
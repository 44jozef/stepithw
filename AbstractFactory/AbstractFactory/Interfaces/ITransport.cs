using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces;

internal interface ITransport
{
    string Model { get; set; }
    int Wheels {  get; set; }
    int MaxSpeed {  get; set; }


}

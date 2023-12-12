using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Classes;

internal class Tour
{
    public string Place { get; set; }
    public int Price { get; set; }

    public Tour(string _Place,int _Price)
    {
        Place = _Place;
        Price = _Price;
    }

    public override string ToString()
    {
        return $"Place : {Place} Price : {Price}";
    }
}

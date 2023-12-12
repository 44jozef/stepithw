using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Classes;
internal class PlaneTicket
{
    public string Country { get; set; }
    public int Price { get; set; }
    public PlaneTicket(string _Country,int _Price)
    {
        Country = _Country;
        Price = _Price;        
    }

    public override string ToString()
    {
        return $"Country : {Country}\nPrice : {Price}";
    }
}

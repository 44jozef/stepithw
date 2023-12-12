using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Classes;

internal class MobType
{
    public string Name { get; set; }
    public string Color { get; set; }
    public int HP { get; set; }

    public MobType(string name, string color, int hP)
    {
        Name = name;
        Color = color;
        HP = hP;
    }
}

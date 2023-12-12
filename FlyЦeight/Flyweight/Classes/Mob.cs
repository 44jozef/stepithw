using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Classes;

internal class Mob
{
    public MobType Type { get; set; }

    public Mob(MobType mobType)
    {
        Type = mobType;
    }

    
}

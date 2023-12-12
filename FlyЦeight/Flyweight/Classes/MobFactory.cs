using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Classes;

internal static class MobFactory
{

    public static List<MobType> MobTypes = new List<MobType>();

    public static MobType GetMobType(string Name, string Color, int HP)
    {
        Predicate<MobType> FindMobType = Mob => Mob.Name == Name && Mob.Color == Color && Mob.HP == HP;
        MobType mobType = MobTypes.Find(FindMobType);

        if (mobType == null)
        {
            MobTypes.Add(new MobType(Name, Color, HP));
            return new MobType(Name, Color, HP);
        }

            return mobType;
       
    }


}

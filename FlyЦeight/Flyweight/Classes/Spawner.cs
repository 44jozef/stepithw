using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Classes;

internal class Spawner
{
    public List<Mob> Mobs { get; set; } = new List<Mob>();

	public Spawner()
	{

	}

	public void SpawnMob(string Name,string Color,int Hp)
	{
		MobType tmp = MobFactory.GetMobType(Name,Color,Hp);
		Mob mob = new Mob(tmp);
		Mobs.Add(mob);
	}

    public override string ToString()
    {
		for (int i = 0; i < Mobs.Count; i++)
		{
            Console.WriteLine($"\nName : {Mobs[i].Type.Name} \nColor : {Mobs[i].Type.Color}\nHP : {Mobs[i].Type.HP}");
        }
        return "";
    }
}

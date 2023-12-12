using Flyweight.Classes;

MobFactory.GetMobType("Elph", "Green", 40);
MobFactory.GetMobType("Archer", "Black", 75);

Spawner spawner = new();

spawner.SpawnMob("Elph", "Green", 40);
spawner.SpawnMob("Archer", "Black", 75);
spawner.SpawnMob("Tank", "Red", 120); // Если типа который мы хотим заспавнить нету,он его в начале создат а потом заспавнит

Console.WriteLine(spawner);
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Classes;
internal class Hotel
{
    public string Name { get; set; }
    public Hotel(string name)
    {

        Name = name;

    }
    Dictionary<int, string> Rooms { get; set; } = new Dictionary<int, string>();

    public void AddPerson(string Name,int Room)
    {
        Rooms.Add(Room,Name);
    }

    public void RemovePerson(int Room)
    {
        Rooms.Remove(Room);
       
    }

    public override string ToString()
    {
        if (Rooms.Count != 0)
        {

            foreach (var Guest in Rooms)
                Console.WriteLine($"Room:{Guest.Key} , Guest Name: {Guest.Value} ");
        }
        else
        {
            Console.WriteLine("All rooms are free");
        }
        return "";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Classes;

internal class Manager
{
    public Hotel Hotel { get; set; }
    public List<Tour> Tours { get; set; } = new List<Tour>();
    public List<PlaneTicket> Tickets { get; set; } = new List<PlaneTicket>();
    public Manager(Hotel hotel)
    {
        Hotel = hotel;
    }

    #region ManagerOwnMethods

    public void AddTour(Tour tour){ Tours.Add(tour); }
    public void AddTicket(PlaneTicket planeTicket) {  Tickets.Add(planeTicket); }

    #endregion

    #region WorkWithClient

    #region Hotel 
    public void RegisterPerson(string Name, int Room)
    {
        Hotel.AddPerson(Name, Room);
    }

    public void UnregisterPerson(int Room)
    {
        Hotel.RemovePerson(Room);
    }

    public void ShowReservedRooms()
    {
        Console.WriteLine(Hotel);
    }
    #endregion

    #region Tour
    public void ShowAllTours()
    {
        if (Tours.Count == 0) { Console.WriteLine("Tours are not foud"); return; };
        foreach (var t in Tours)
        {
            Console.WriteLine(t);
        }
    }

    public void BuyTour(string Place, int Price)
    {
        int index = 0;

        for (int i = 0; i < Tours.Count; i++)
        {
            if (Tours[i].Price == Price && Tours[i].Place == Place )
            {
                index = i;
                break;
            }
        }

        Tours.RemoveAt(index);
    }
    #endregion

    #region PlaneTickets

    public void ShowAllTickets()
    {
        foreach (var t in Tickets)
        {
            Console.WriteLine(t);
        }
    }

    public void BuyTicket(string Country, int Price)
    {
        int index = 0;

        for (int i = 0; i < Tours.Count; i++)
        {
            if (Tickets[i].Price == Price && Tickets[i].Country == Country)
            {
                index = i;
                break;
            }
        }

        Tickets.RemoveAt(index);
    }

    #endregion

    #endregion
}
using Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proxy.Classes;

internal class MoviesManager
{

    public IMoviesLib Service;
    public Movies Movies { get; set; }
    public MoviesManager(IMoviesLib service)
    {

        Service = service;

    }



    public void ShowAllInfo() 
    {
        Movies = Service.GetAllInfo();
        if (Movies == null) { Console.WriteLine("Movies are empty"); return; }

        Console.WriteLine("\nAll info about 3 first movies: ");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\n({i}) Title :{Movies.Search[i].Title}\n Year :{Movies.Search[i].Year}\n Type :{Movies.Search[i].Type}\n IMD ID :{Movies.Search[i].imdbID}");
        }

    }

    public void ShowTitltes()
    {
        Movies = Service.GetAllInfo();
        if (Movies == null) { Console.WriteLine("Movies are empty"); return; }

        Console.WriteLine("\nTitle of 3 first movies:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\n({i}) Title :{Movies.Search[i].Title}");
        }
    }


}

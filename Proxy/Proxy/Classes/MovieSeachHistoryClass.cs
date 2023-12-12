using Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Proxy.Classes;

internal class MovieSeachHistoryClass
{
    IMoviesLib _MoviesLib;
    public MovieSeachHistoryClass(IMoviesLib moviesLib)
    {

        _MoviesLib = moviesLib;

    }

    public void SaveToJson()
    {
        using FileStream fs = new FileStream("data.json", FileMode.OpenOrCreate);
        using StreamWriter sw = new StreamWriter(fs);

        var json = JsonSerializer.Serialize(_MoviesLib.GetAllInfo());
        sw.WriteLine(json);

    }
   
}

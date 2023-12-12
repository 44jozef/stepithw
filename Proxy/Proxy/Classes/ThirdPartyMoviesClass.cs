using Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Proxy.Classes;

internal class ThirdPartyMoviesClass : IMoviesLib
{
    public string URL { get ; set; }
    public Movies Movies { get; set; }

    public ThirdPartyMoviesClass(string _Title)
    {
        URL = $"http://www.omdbapi.com/?s={_Title}&apikey=ddf8754c";

        var Client = new WebClient();
        var Res = Client.DownloadString(URL);

        string Json = Res.ToString();
        Movies = JsonSerializer.Deserialize<Movies>(Json);
    }

    public Movies GetAllInfo()
    {
        return Movies ?? throw new Exception("Movies are empty");
    }

public Movies GetTitles()
    {
        return Movies ?? throw new Exception("Movies are empty") ;
    }
}

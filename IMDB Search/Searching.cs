using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Searching;


public class Movies
{
    public Search[] Search { get; set; }
    public string totalResults { get; set; }
    public string Response { get; set; }
}

public class Search
{
    public string Title { get; set; }
    public string Year { get; set; }
    public string imdbID { get; set; }
    public string Type { get; set; }
    public string Poster { get; set; }
}

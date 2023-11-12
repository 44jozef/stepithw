using System;
using Searching;

namespace IMDB_Search;

static class FindMovie
{  

    public static Movies GetMovie(String movieTitle)
    {
        string URL = $"http://www.omdbapi.com/?s={movieTitle}&apikey=ddf8754c";


        try
        {
            string json = DownloadService.DownloadJson(URL);
            Movies movie = DeserializeService.DeserializeJson<Movies>(json);

            return movie;
        }
        catch (Exception)
        {

            throw;
        }
    }
}
   

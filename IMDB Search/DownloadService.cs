using System;
using System.Net;

namespace IMDB_Search
{
    static class DownloadService
    {
        public static string DownloadJson(string url)
        {
            try
            {
                var client = new WebClient();
                var res = client.DownloadString(url);

                return res ?? throw new ArgumentNullException("Json is null");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
       

}

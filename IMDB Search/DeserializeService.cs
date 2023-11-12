using System;
using System.Text.Json;

namespace IMDB_Search
{
    static class DeserializeService
    {
        public static T DeserializeJson<T>(string data)
        {
            try
            {
                return JsonSerializer.Deserialize<T>(data) ?? throw new NullReferenceException("Object is null");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
       

}

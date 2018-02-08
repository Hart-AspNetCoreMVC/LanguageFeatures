using System.Collections.Generic;

using System.Net.Http;

using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LanguageFeatures.Models
{
    public class MyAsyncMethods
    {
        public async static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();
            var httpMsg = await client.GetAsync("http://apress.com");
            var response = httpMsg.Content.Headers.ContentLength;
            return response;
        }

        //HTML model requires @model Newtonsoft.Json.Linq.JObject to query dictionary
        public static async Task<Dictionary<string,object>> GetPageAsString()
        {
            HttpClient client = new HttpClient();
            var httpMsg = await client.GetStringAsync("https://pokeapi.co/api/v2/pokedex/");
            var result = JsonConvert.DeserializeObject<Dictionary<string, object>>(httpMsg);
            return result;
        }
    }
}

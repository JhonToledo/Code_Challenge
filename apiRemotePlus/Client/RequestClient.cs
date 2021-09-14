using apiRemotePlus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace apiRemotePlus.Client
{
    public class RequestClient
    {
        private readonly HttpClient client;
        public RequestClient()
        {
            client = new HttpClient
            {
                BaseAddress = new Uri("https://gnews.io")
            };

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
        }

        public async Task<GNews> GetNews()
        {
            GNews news = new GNews();
            try
            {
                news = await client.GetFromJsonAsync<GNews>("/api/v4/search?q=watches&token=d1b06d89c72db28ecea0a05d55fe5125");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return news;
        }

    }
}

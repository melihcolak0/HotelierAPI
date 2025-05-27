using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using RapidAPIConsume.Models;
using Newtonsoft.Json;

namespace RapidAPIConsume.Controllers
{
    public class IMDbController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<APIMovieViewModel> aPIMovieViewModels = new List<APIMovieViewModel>();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
    {
        { "x-rapidapi-key", "my_rapid_api_key" },
        { "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                aPIMovieViewModels = JsonConvert.DeserializeObject<List<APIMovieViewModel>>(body);
                return View(aPIMovieViewModels);
            }
        }
    }
}

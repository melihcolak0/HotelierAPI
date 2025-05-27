using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using RapidAPIConsume.Models;
using Newtonsoft.Json;
using System.Linq;

namespace RapidAPIConsume.Controllers
{
    public class SearchLocationController : Controller
    {
        public async Task<IActionResult> Index(string cityName)
        {
            if (!string.IsNullOrEmpty(cityName))
            {
                List<SearchLocationViewModel> searchLocationViewModels = new List<SearchLocationViewModel>();

                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?locale=en-gb&name={cityName.ToLower()}"),
                    Headers =
    {
        { "x-rapidapi-key", "my_rapidapi_key" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    searchLocationViewModels = JsonConvert.DeserializeObject<List<SearchLocationViewModel>>(body);
                    return View(searchLocationViewModels.Take(1).ToList());
                }
            }
            else
            {
                List<SearchLocationViewModel> searchLocationViewModels = new List<SearchLocationViewModel>();

                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?locale=en-gb&name=paris"),
                    Headers =
    {
        { "x-rapidapi-key", "my_rapidapi_key" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    searchLocationViewModels = JsonConvert.DeserializeObject<List<SearchLocationViewModel>>(body);
                    return View(searchLocationViewModels.Take(1).ToList());
                }
            }
        }
    }
}

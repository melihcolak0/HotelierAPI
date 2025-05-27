using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using RapidAPIConsume.Models;
using Newtonsoft.Json;
using System.Linq;

namespace RapidAPIConsume.Controllers
{
    public class HotelController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<HotelAPIViewModel> hotelAPIViewModels = new List<HotelAPIViewModel>();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?children_number=2&adults_number=2&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&children_ages=5%2C0&checkout_date=2026-03-27&dest_type=city&page_number=0&units=metric&order_by=popularity&room_number=1&checkin_date=2026-03-24&filter_by_currency=EUR&dest_id=-1456928&locale=en-gb&include_adjacency=true"),
                Headers =
    {
        { "x-rapidapi-key", "my_rapid_api_key" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<HotelAPIViewModel>(body);
                return View(values.results.ToList());
            }
        }
    }
}

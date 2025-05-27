using APIHotelMan.WebUI.Dtos.BookingDtos;
using APIHotelMan.WebUI.Dtos.ServiceDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APIHotelMan.WebUI.Controllers
{
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:9552/api/Booking");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> ConfirmBooking(int id)
        {
            //var client = _httpClientFactory.CreateClient();
            //StringContent stringContent = new StringContent("", Encoding.UTF8, "application/json");
            //await client.PutAsync($"http://localhost:9552/api/Booking/ConfirmBooking/{id}", stringContent);
            //return RedirectToAction("Index");

            var client = _httpClientFactory.CreateClient();
            var requestUri = $"http://localhost:9552/api/Booking/ConfirmBooking/{id}";
            var response = await client.PutAsync(requestUri, null);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            var errorContent = await response.Content.ReadAsStringAsync();
            return Content($"İstek başarısız oldu: {response.StatusCode} - {errorContent}");
        }

        public async Task<IActionResult> CancelBooking(int id)
        {           
            var client = _httpClientFactory.CreateClient();
            var requestUri = $"http://localhost:9552/api/Booking/CancelBooking/{id}";
            var response = await client.PutAsync(requestUri, null);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            var errorContent = await response.Content.ReadAsStringAsync();
            return Content($"İstek başarısız oldu: {response.StatusCode} - {errorContent}");
        }

        public async Task<IActionResult> WaitBooking(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var requestUri = $"http://localhost:9552/api/Booking/WaitBooking/{id}";
            var response = await client.PutAsync(requestUri, null);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            var errorContent = await response.Content.ReadAsStringAsync();
            return Content($"İstek başarısız oldu: {response.StatusCode} - {errorContent}");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateBooking(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:9552/api/Booking/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateBookingDto>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateBookingDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:9552/api/Booking/UpdateBooking", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}

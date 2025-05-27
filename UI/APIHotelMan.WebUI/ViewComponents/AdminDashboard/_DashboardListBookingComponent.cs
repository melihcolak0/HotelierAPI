using APIHotelMan.WebUI.Dtos.DashboardListBookingDtos;
using APIHotelMan.WebUI.Dtos.DashboardListStaffDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace APIHotelMan.WebUI.ViewComponents.AdminDashboard
{
    public class _DashboardListBookingComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardListBookingComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:9552/api/Booking/GetListLast6Booking");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultDashboardListBookingDto>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}

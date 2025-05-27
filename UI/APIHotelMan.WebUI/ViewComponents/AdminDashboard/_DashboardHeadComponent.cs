using APIHotelMan.WebUI.Dtos.DashboardHeadDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace APIHotelMan.WebUI.ViewComponents.AdminDashboard
{
    public class _DashboardHeadComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardHeadComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            int staffCount = 0;
            int bookingCount = 0;
            int guestCount = 0;
            int roomCount = 0;

            var client = _httpClientFactory.CreateClient();            

            var staffCountResponse = await client.GetAsync("http://localhost:9552/api/Staff/GetStaffCount");
            if (staffCountResponse.IsSuccessStatusCode)
            {
                var json = await staffCountResponse.Content.ReadAsStringAsync();
                staffCount = JsonConvert.DeserializeObject<int>(json);
            }

            var bookingCountResponse = await client.GetAsync("http://localhost:9552/api/Booking/GetBookingCount");
            if (bookingCountResponse.IsSuccessStatusCode)
            {
                var json = await bookingCountResponse.Content.ReadAsStringAsync();
                bookingCount = JsonConvert.DeserializeObject<int>(json);
            }

            var guestCountResponse = await client.GetAsync("http://localhost:9552/api/Guest/GetGuestCount");
            if (guestCountResponse.IsSuccessStatusCode)
            {
                var json = await guestCountResponse.Content.ReadAsStringAsync();
                guestCount = JsonConvert.DeserializeObject<int>(json);
            }

            var roomCountResponse = await client.GetAsync("http://localhost:9552/api/Room/GetRoomCount");
            if (roomCountResponse.IsSuccessStatusCode)
            {
                var json = await roomCountResponse.Content.ReadAsStringAsync();
                roomCount = JsonConvert.DeserializeObject<int>(json);
            }

            var dto = new ResultDashboardHeadDto
            {
                StaffCount = staffCount,
                BookingCount = bookingCount,
                GuestCount = guestCount,
                RoomCount = roomCount
            };

            return View(dto);
        }
    }
}

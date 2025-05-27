using APIHotelMan.WebUI.Models.Message;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace APIHotelMan.WebUI.ViewComponents.AdminMessage
{
    public class _ContactSideBarComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ContactSideBarComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();

            int contactMessageCount = 0;
            int sendMessageCount = 0;

            var contactMessageResponse = await client.GetAsync("http://localhost:9552/api/Contact/GetContactMessagesCount");
            if (contactMessageResponse.IsSuccessStatusCode)
            {
                var json = await contactMessageResponse.Content.ReadAsStringAsync();
                contactMessageCount = JsonConvert.DeserializeObject<int>(json);
            }

            var sendMessageResponse = await client.GetAsync("http://localhost:9552/api/SendMessage/GetSendMessagesCount");
            if (sendMessageResponse.IsSuccessStatusCode)
            {
                var json = await sendMessageResponse.Content.ReadAsStringAsync();
                sendMessageCount = JsonConvert.DeserializeObject<int>(json);
            }

            var model = new MessageCountViewModel
            {
                ContactMessageCount = contactMessageCount,
                SendMessageCount = sendMessageCount
            };

            return View(model);
        }
    }
}

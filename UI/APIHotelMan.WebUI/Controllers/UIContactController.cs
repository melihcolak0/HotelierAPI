using APIHotelMan.WebUI.Dtos.ContactDtos;
using APIHotelMan.WebUI.Dtos.ContactMessageCategoryDtos;
using APIHotelMan.WebUI.Models.Staff;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APIHotelMan.WebUI.Controllers
{
    [AllowAnonymous]
    public class UIContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public UIContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:9552/api/ContactMessageCategory");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultContactMessageCategoryDto>>(jsonData);
                List<SelectListItem> categories = (from x in values
                                                   select new SelectListItem
                                                   {
                                                       Text = x.ContactMessageCategoryName,
                                                       Value = x.ContactMessageCategoryId.ToString()
                                                   }).ToList();
                ViewBag.v = categories;
            }
            return View();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(CreateContactDto createContactDto)
        {
            createContactDto.SendDate = DateTime.Now;
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createContactDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:9552/api/Contact", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}

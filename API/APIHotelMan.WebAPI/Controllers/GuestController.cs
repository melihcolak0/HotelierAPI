using APIHotelMan.BusinessLayer.Abstract;
using APIHotelMan.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIHotelMan.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;

        public GuestController(IGuestService guestService)
        {
            _guestService = guestService;
        }

        [HttpGet]
        public IActionResult ListGuest()
        {
            var values = _guestService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddGuest(Guest Guest)
        {
            _guestService.TInsert(Guest);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var value = _guestService.TGetById(id);
            _guestService.TDelete(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateGuest(Guest Guest)
        {
            _guestService.TUpdate(Guest);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetGuest(int id)
        {
            var value = _guestService.TGetById(id);
            return Ok(value);
        }

        [HttpGet("GetGuestCount")]
        public IActionResult GetGuestCount()
        {
            var value = _guestService.TGetGuestCount();
            return Ok(value);
        }
    }
}

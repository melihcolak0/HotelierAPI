using APIHotelMan.BusinessLayer.Abstract;
using APIHotelMan.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIHotelMan.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult ListBooking()
        {
            var values = _bookingService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.TInsert(booking);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            _bookingService.TDelete(value);
            return Ok();
        }

        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            return Ok(value);
        }

        [HttpPut("ConfirmBooking/{id}")]
        public IActionResult ConfirmBooking(int id)
        {
            _bookingService.TConfirmBooking(id);
            return Ok();
        }

        [HttpPut("CancelBooking/{id}")]
        public IActionResult CancelBooking(int id)
        {
            _bookingService.TCancelBooking(id);
            return Ok();
        }

        [HttpPut("WaitBooking/{id}")]
        public IActionResult WaitBooking(int id)
        {
            _bookingService.TWaitBooking(id);
            return Ok();
        }

        [HttpGet("GetBookingCount")]
        public IActionResult GetBookingCount()
        {
            var value = _bookingService.TGetBookingCount();
            return Ok(value);
        }

        [HttpGet("GetListLast6Booking")]
        public IActionResult GetListLast6Booking()
        {
            var values = _bookingService.TGetListLast6Booking();
            return Ok(values);
        }
    }
}

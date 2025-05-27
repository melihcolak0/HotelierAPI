using APIHotelMan.BusinessLayer.Abstract;
using APIHotelMan.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIHotelMan.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactMessageCategoryController : ControllerBase
    {
        private readonly IContactMessageCategoryService _contactMessageCategoryService;

        public ContactMessageCategoryController(IContactMessageCategoryService contactMessageCategoryService)
        {
            _contactMessageCategoryService = contactMessageCategoryService;
        }

        [HttpGet]
        public IActionResult ListContactMessageCategory()
        {
            var values = _contactMessageCategoryService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddContactMessageCategory(ContactMessageCategory contactMessageCategory)
        {
            _contactMessageCategoryService.TInsert(contactMessageCategory);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContactMessageCategory(int id)
        {
            var value = _contactMessageCategoryService.TGetById(id);
            _contactMessageCategoryService.TDelete(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateContactMessageCategory(ContactMessageCategory contactMessageCategory)
        {
            _contactMessageCategoryService.TUpdate(contactMessageCategory);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetContactMessageCategory(int id)
        {
            var value = _contactMessageCategoryService.TGetById(id);
            return Ok(value);
        }
    }
}

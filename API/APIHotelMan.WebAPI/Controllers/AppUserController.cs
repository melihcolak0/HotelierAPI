using APIHotelMan.BusinessLayer.Abstract;
using APIHotelMan.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIHotelMan.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpGet]
        public IActionResult ListAppUser()
        {
            var values = _appUserService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddAppUser(AppUser appUser)
        {
            _appUserService.TInsert(appUser);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAppUser(int id)
        {
            var value = _appUserService.TGetById(id);
            _appUserService.TDelete(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAppUser(AppUser appUser)
        {
            _appUserService.TUpdate(appUser);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetAppUser(int id)
        {
            var value = _appUserService.TGetById(id);
            return Ok(value);
        }

        [HttpGet("ListAppUserWithWorkLocations")]
        public IActionResult ListAppUserWithWorkLocations()
        {
            var values = _appUserService.TGetUserListWithWorkLocations();
            return Ok(values);
        }
    }
}

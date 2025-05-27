using APIHotelMan.EntityLayer.Concrete;
using APIHotelMan.WebUI.Dtos.IdentityDtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace APIHotelMan.WebUI.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            EditUserDto editUserDto = new EditUserDto();
            editUserDto.Name = user.Name;
            editUserDto.Surname = user.Surname;
            editUserDto.UserName = user.UserName;
            editUserDto.Email = user.Email;
            
            return View(editUserDto);
        }

        [HttpPost]
        public async Task<IActionResult> Index(EditUserDto editUserDto)
        {
            if(editUserDto.Password == editUserDto.ConfirmPassword)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.Name = editUserDto.Name;
                user.Surname = editUserDto.Surname;
                user.Email = editUserDto.Email;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, editUserDto.Password);
                await _userManager.UpdateAsync(user);                
                return RedirectToAction("Index", "LogIn");
            }
            else
            {
                return View();
            }           
        }
    }
}

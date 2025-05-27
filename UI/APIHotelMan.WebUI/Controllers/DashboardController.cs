using Microsoft.AspNetCore.Mvc;

namespace APIHotelMan.WebUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

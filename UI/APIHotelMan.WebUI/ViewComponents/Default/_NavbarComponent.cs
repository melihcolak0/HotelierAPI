using Microsoft.AspNetCore.Mvc;

namespace APIHotelMan.WebUI.ViewComponents.Default
{
    public class _NavbarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

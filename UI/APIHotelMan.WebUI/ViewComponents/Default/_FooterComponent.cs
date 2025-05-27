using Microsoft.AspNetCore.Mvc;

namespace APIHotelMan.WebUI.ViewComponents.Default
{
    public class _FooterComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace APIHotelMan.WebUI.ViewComponents.Default
{
    public class _BookComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

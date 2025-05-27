using Microsoft.AspNetCore.Mvc;

namespace APIHotelMan.WebUI.ViewComponents.Default
{
    public class _TrailerComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

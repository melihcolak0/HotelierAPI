using Microsoft.AspNetCore.Mvc;

namespace APIHotelMan.WebUI.ViewComponents.Default
{
    public class _ScriptComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

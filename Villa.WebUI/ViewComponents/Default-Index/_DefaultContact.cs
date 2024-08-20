using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.Default_Index
{
    public class _DefaultContact : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace ExxerIoT.UI.Web.ViewComponents
{
    public class SummaryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Default");
        }
    }
}
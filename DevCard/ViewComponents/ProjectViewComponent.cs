using Microsoft.AspNetCore.Mvc;

namespace DevCard.ViewComponents
{
    public class ProjectViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("_Projects");
        }
    }
}

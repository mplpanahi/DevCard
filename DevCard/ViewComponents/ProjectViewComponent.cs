using Microsoft.AspNetCore.Mvc;
using DevCard.Models;

namespace DevCard.ViewComponents
{
    public class ProjectViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects=new List<Project>
            {
                new Project(1,"تاکسی","project-1.jpg","درخواست آنلاین تاکسی برای سفرهای درون شهری","MPLPanahi"),
                new Project(2,"زودفود","project-2.jpg","درخواست آنلاین غذا برای سراسر کشور","ZoodFood"),
                new Project(3,"مدارس","project-3.jpg","سیستم یکپارچه مدارس","MONOP"),
                new Project(4,"فضا پیما","project-4.jpg","برنامه مدیریت فضاپیماهای ناسا","NASA")
            };
            return View("_Projects", projects);
        }
    }
}

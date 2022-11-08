using Microsoft.AspNetCore.Mvc;

namespace RyanPolterSite.Controllers
{
    public class DiscographyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace RyanPolterSite.Controllers
{
    public class SourcesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OnlineSources()
        {
            return View();
        }

        public IActionResult PrintSources()
        {
            return View();
        }
    }
}

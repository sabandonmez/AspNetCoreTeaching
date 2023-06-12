using Microsoft.AspNetCore.Mvc;

namespace OrnekProje.Areas.faturaPaneli.Controllers
{
    [Area("faturaPaneli")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var data = TempData["data"];
            return View();
        }
    }
}

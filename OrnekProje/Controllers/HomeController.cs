using Microsoft.AspNetCore.Mvc;
using OrnekProje.Services;

namespace OrnekProje.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            TextLog log = new TextLog();
            log.Log();

            return View();
        }
        public IActionResult Sayfa1()
        {
            return View();
        }
        public IActionResult Sayfa2()
        {
            return View();
        }
    }
}

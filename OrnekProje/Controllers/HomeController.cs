using Microsoft.AspNetCore.Mvc;
using OrnekProje.Services;
using OrnekProje.Services.Interfaces;

namespace OrnekProje.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index([FromServices]ILog log)
        {
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

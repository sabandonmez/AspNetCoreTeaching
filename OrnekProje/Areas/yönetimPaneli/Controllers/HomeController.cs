using Microsoft.AspNetCore.Mvc;

namespace OrnekProje.Areas.yönetimPaneli.Controllers
{
    [Area("yönetimPaneli")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            TempData["data"] = "Ürettiğimiz data ...";
            return RedirectToAction("Index","Home",new {area="faturaPaneli"});
        }
    }
}

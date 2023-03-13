using Microsoft.AspNetCore.Mvc;

namespace PorfolioWeb.Areas.Cliente.Controllers
{
    public class AboutController : Controller
    {
        [Area("Cliente")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

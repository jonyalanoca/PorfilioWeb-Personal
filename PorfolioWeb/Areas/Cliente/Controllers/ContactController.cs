using Microsoft.AspNetCore.Mvc;

namespace PorfolioWeb.Areas.Cliente.Controllers
{
    [Area("Cliente")]
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

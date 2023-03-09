using Microsoft.AspNetCore.Mvc;
using PorfolioWeb_AccesoDatos.Data.Repository.IRepository;

namespace PorfolioWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SkillController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;

        public SkillController(IContenedorTrabajo contenedorTrabajo)
        {
            _contenedorTrabajo = contenedorTrabajo;
        }

        [Area("Admin")]
        public IActionResult Index()
        {
            var listaSkills = _contenedorTrabajo.Skills.GetAll();
            return View(listaSkills);
        }


    }
}

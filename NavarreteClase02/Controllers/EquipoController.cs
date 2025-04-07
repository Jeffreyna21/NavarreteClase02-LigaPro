using Microsoft.AspNetCore.Mvc;
using NavarreteClase02.Models;
using NavarreteClase02.Repositories;

namespace NavarreteClase02.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult View()
        {
            return View();
        }
        public ActionResult List()
        {

            EquipoRepository repository = new EquipoRepository();
            var equipos = repository.DevuelveListadoEquipos();

            equipos = equipos.OrderBy(item => item.PartidosGanados);
            //equipos = equipos.Where(item => item.Nombre == "Liga de Quito");
            return View(equipos);
        }
    }
}

using CajeroAutomatico.Models;
using Microsoft.AspNetCore.Mvc;

namespace CajeroAutomatico.Controllers
{
    public class CajeroController : Controller
    {
        private static CajeroModel cajero = new CajeroModel();

        public IActionResult Index()
        {
            ViewBag.ModoActual = cajero.ModoActual.ToString();
            return View();
        }

        public IActionResult Configuration()
        {
            var model = new Configuration
            {
                ModoSeleccionado = cajero.ModoActual
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Configuration(Configuration model)
        {
            if (ModelState.IsValid)
            {

                cajero.ModoActual = model.ModoSeleccionado;
                TempData["Mensaje"] = "Modo de dispensación actualizado correctamente.";
                return RedirectToAction("Index", "Home");
            }

            return View("Configuration", model);
        }

        [HttpPost]
        public JsonResult RetirarDinero([FromBody] RetiroRequest request)
        {
            if (request == null)
            {
                return Json(new { Error = "Debe Ingresar un Monto" });
            }

            var monto = request.Monto;
            var resultado = cajero.RetirarDinero(monto);

            return Json(resultado);
        }
    }
}

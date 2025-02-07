using CajeroAutomatico.Models;
using Microsoft.AspNetCore.Mvc;

namespace CajeroAutomatico.Controllers;

public class CajeroController : Controller
{
    private static CajeroModel cajero = new CajeroModel();

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Configuration()
    {
        ViewBag.ModoActual = cajero.ModoActual;
        return View();
    }


    [HttpPost]
    public IActionResult Configuracion(CajeroModel.ModoDispensacion modo)
    {
        cajero.ModoActual = modo;
        return RedirectToAction("Configuracion");
    }

    [HttpPost]
    public IActionResult Retirar(int monto)
    {
        if (monto % 100 != 0)
        {
            ViewBag.Mensaje = "El monto debe ser múltiplo de 100.";
            return View("Index");
        }

        var resultado = cajero.RetirarDinero(monto);
        ViewBag.Resultado = resultado;
        return View("Index");
    }

    [HttpPost]
    public JsonResult RetirarDinero([FromBody] RetiroRequest request)
    {
        int monto = request.Monto;

        CajeroModel cajero = new CajeroModel();
        var resultado = cajero.RetirarDinero(monto);

        return Json(resultado);
    }
}
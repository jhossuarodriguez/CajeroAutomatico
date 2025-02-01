using Microsoft.AspNetCore.Mvc;

namespace CajeroAutomatico.Controllers
{
    public class CajeroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

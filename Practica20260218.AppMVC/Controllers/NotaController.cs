using Microsoft.AspNetCore.Mvc;

namespace Practica20260218.AppMVC.Controllers
{
    public class NotaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }     
        [HttpPost]
        public IActionResult CalcularNota(decimal n1, decimal n2, decimal n3)
        {
            decimal promedio = (n1 + n2 + n3) / 3;
            ViewBag.Promedio =decimal.Round(promedio,2);
            return View("Index");
        } 
    }
}

using Microsoft.AspNetCore.Mvc;

namespace mvc_core.Controllers
{
    public class ProdutoController : Controller
    {
        public string Index()
        {
            return "Este é o método Action do produto felipe";
        }

        public IActionResult Detalhe()
        {
            return View();
        }
    }
}

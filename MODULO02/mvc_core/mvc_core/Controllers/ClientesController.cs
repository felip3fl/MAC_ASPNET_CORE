using Microsoft.AspNetCore.Mvc;
using mvc_core.Models;

namespace mvc_core.Controllers
{
    [Route("[controller]/[action]")]
    public class ClientesController : Controller
    {
        public IActionResult Detalhe()
        {
            Cliente cliente = new Cliente
            {
                ClienteId = 100,
                Nome = "Felipe",
                Email = "felipe@gmail.com"
            };

            return View(cliente);
        }
    }
}
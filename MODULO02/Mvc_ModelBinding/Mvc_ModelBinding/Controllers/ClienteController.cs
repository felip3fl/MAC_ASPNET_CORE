using Microsoft.AspNetCore.Mvc;
using Mvc_ModelBinding.Models;

namespace Mvc_ModelBinding.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Cliente cliente)
        {
            if(cliente?.Id==0 || cliente?.Nome==null || cliente?.Email == null)
            {
                ViewBag.Erro = "Dados do cliente invalido";
                return View();
            }
            else
            {
                return View("ExibirDados", cliente);
            }
            
        }
    }
}
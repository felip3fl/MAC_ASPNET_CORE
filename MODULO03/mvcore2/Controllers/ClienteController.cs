using System.Linq;
using Microsoft.AspNetCore.Mvc;
using mvcore2.Models;

namespace mvcore2.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteContext _context;

        public ClienteController(ClienteContext context) 
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var clientes = _context.Clientes.ToList();
            return View(clientes);
        }
    }
}
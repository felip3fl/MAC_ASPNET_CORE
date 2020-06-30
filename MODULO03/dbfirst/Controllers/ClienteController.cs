using System.Linq;
using dbfirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace dbfirst.Controllers
{
    public class ClienteController : Controller
    {
        private TesteContext _context;
        public ClienteController(TesteContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var Estudantes = _context.Student.ToList();
            return View(Estudantes);
        }
    }
}
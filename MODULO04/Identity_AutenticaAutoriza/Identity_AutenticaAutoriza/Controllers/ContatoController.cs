using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Identity_AutenticaAutoriza.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Identity_AutenticaAutoriza.Controllers
{
    [Authorize]
    public class ContatoController : Controller
    {
        private ApplicationDbContext _context;

        public ContatoController(ApplicationDbContext contexto)
        {
            _context = contexto;
        }

        public IActionResult Index()
        {
            //if (User.Identity.IsAuthenticated)
            //{
                var contatos = _context.Contatos.ToList();
                return View(contatos);
            //}
            //return RedirectToAction("Login","Account", new { area = "Identity" });
        }

        public IActionResult AcessoAutorizado()
        {
            return Content("ACESSO AUTORIZADO");
        }

        [AllowAnonymous]
        public IActionResult AcessoAnonimo()
        {
            return Content("ACESSO ANÔNIMO");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc_EFCore2.Models;

namespace Mvc_EFCore2.Controllers
{
    public class TesteController : Controller
    {
        public AlunoContext _context;
        public TesteController(AlunoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var alunos = _context.Alunos.ToList();

            return View(alunos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Nome,Sexo,Email,Nascimento")]Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aluno);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(aluno);
        }

    }
}

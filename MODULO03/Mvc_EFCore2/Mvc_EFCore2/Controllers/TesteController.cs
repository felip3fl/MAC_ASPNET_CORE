using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno = _context.Alunos.SingleOrDefault(a => a.Id == id);
            if(aluno == null)
            {
                return NotFound();
            }

            return View(aluno);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id,[Bind("Id,Nome,Sexo,Email,Nascimento")]Aluno aluno)
        {
            if(id != aluno.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aluno);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {

                    if (!AlunoExists(aluno.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(aluno);
        }

        private bool AlunoExists(int id) 
        {
            return _context.Alunos.Any(e => e.Id == id);
        }


    }
}

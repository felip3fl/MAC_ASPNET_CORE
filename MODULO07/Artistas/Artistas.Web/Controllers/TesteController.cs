using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Artistas.DAL.Entities;
using Artistas.DAL.Entities.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace Artistas.Web.Controllers
{
    public class TesteController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public TesteController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var artistas = _unitOfWork.Artistas.GetAll();
            return View(artistas);
        }

        // GET: Artistas/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalhes = _unitOfWork.Artistas.getArtistaComDetalhes(id);

            if (detalhes == null)
            {
                return NotFound();
            }

            return View(detalhes);
        }

        // GET: Artistas/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ArtistaId,Nome,Pais,Cidade,Site,Nascimento")] Artista artista)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Artistas.Add(artista);
                _unitOfWork.Commit();
                return RedirectToAction(nameof(Index));
            }
            return View(artista);
        }

        // GET: Artistas/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artista = _unitOfWork.Artistas.Get(id);
            if (artista == null)
            {
                return NotFound();
            }
            return View(artista);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("ArtistaId,Nome,Pais,Cidade,Site,Nascimento")] Artista artista)
        {
            if (id != artista.ArtistaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _unitOfWork.Artistas.Update(artista);
                    _unitOfWork.Commit();
                }
                catch
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(artista);
        }

        // GET: Artistas/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artista = _unitOfWork.Artistas.Get(id);
            if (artista == null)
            {
                return NotFound();
            }

            return View(artista);
        }

        // POST: Artistas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            var artista = _unitOfWork.Artistas.Get(id);

            _unitOfWork.Artistas.Remove(artista);
            _unitOfWork.Commit();

            return RedirectToAction(nameof(Index));
        }
    }
}

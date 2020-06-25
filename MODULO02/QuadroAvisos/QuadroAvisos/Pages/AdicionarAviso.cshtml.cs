using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuadroAvisos.Data;

namespace QuadroAvisos.Pages
{
    public class AdicionarAvisoModel : PageModel
    {
        private AvisoContext _context;

        public AdicionarAvisoModel(AvisoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Aviso Item { get; set; }

        public void OnGet()
        {
            if (Item == null) { }
            {
                Item = new Aviso();
            }

            Item.Hora = DateTime.Now;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Item.Id = 0;
            _context.Avisos.Add(Item);
            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
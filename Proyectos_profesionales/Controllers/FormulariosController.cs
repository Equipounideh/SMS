using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proyectos_profesionales.Data;
using Proyectos_profesionales.Models;

namespace Proyectos_profesionales.Controllers
{
    public class FormulariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FormulariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Formularios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Formulario.ToListAsync());
        }

        // GET: Formularios/ShowSearchForm/Busqueda
        public async Task<IActionResult> ShowSearchForm()
        {
            return View();
        }

        // GET: Formularios/ShowSearchResultado
        public async Task<IActionResult> ShowSearchResults(String SearchPhrase)
        {
            return View("Index", await _context.Formulario.Where(j => j.FormularioEntrada.Contains(SearchPhrase)).ToListAsync());
        }


        // GET: Formularios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formulario = await _context.Formulario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formulario == null)
            {
                return NotFound();
            }

            return View(formulario);
        }

        // GET: Formularios/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Formularios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FormularioEntrada,FormularioSalida")] Formulario formulario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formulario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formulario);
        }

        // GET: Formularios/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formulario = await _context.Formulario.FindAsync(id);
            if (formulario == null)
            {
                return NotFound();
            }
            return View(formulario);
        }

        // POST: Formularios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FormularioEntrada,FormularioSalida")] Formulario formulario)
        {
            if (id != formulario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formulario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormularioExists(formulario.Id))
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
            return View(formulario);
        }

        // GET: Formularios/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formulario = await _context.Formulario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formulario == null)
            {
                return NotFound();
            }

            return View(formulario);
        }

        // POST: Formularios/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formulario = await _context.Formulario.FindAsync(id);
            _context.Formulario.Remove(formulario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormularioExists(int id)
        {
            return _context.Formulario.Any(e => e.Id == id);
        }
    }
}

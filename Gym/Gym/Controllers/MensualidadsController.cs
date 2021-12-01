using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gym.Data;
using Gym.Models;

namespace Gym
{
    public class MensualidadsController : Controller
    {
        private readonly GymContext _context;

        public MensualidadsController(GymContext context)
        {
            _context = context;
        }

        // GET: Mensualidads
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mensualidad.ToListAsync());
        }

        // GET: Mensualidads/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mensualidad = await _context.Mensualidad
                .FirstOrDefaultAsync(m => m.IdMensualidad == id);
            if (mensualidad == null)
            {
                return NotFound();
            }

            return View(mensualidad);
        }

        // GET: Mensualidads/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mensualidads/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMensualidad,IdCliente,FechaInicio,Precio")] Mensualidad mensualidad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mensualidad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mensualidad);
        }

        // GET: Mensualidads/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mensualidad = await _context.Mensualidad.FindAsync(id);
            if (mensualidad == null)
            {
                return NotFound();
            }
            return View(mensualidad);
        }

        // POST: Mensualidads/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMensualidad,IdCliente,FechaInicio,Precio")] Mensualidad mensualidad)
        {
            if (id != mensualidad.IdMensualidad)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mensualidad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MensualidadExists(mensualidad.IdMensualidad))
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
            return View(mensualidad);
        }

        // GET: Mensualidads/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mensualidad = await _context.Mensualidad
                .FirstOrDefaultAsync(m => m.IdMensualidad == id);
            if (mensualidad == null)
            {
                return NotFound();
            }

            return View(mensualidad);
        }

        // POST: Mensualidads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mensualidad = await _context.Mensualidad.FindAsync(id);
            _context.Mensualidad.Remove(mensualidad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MensualidadExists(int id)
        {
            return _context.Mensualidad.Any(e => e.IdMensualidad == id);
        }
    }
}

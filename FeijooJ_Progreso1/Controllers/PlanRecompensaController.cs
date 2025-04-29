using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FeijooJ_Progreso1.Data;
using FeijooJ_Progreso1.Models;

namespace FeijooJ_Progreso1.Controllers
{
    public class PlanRecompensaController : Controller
    {
        private readonly FeijooJ_Progreso1Context _context;

        public PlanRecompensaController(FeijooJ_Progreso1Context context)
        {
            _context = context;
        }

        // GET: PlanRecompensa
        public async Task<IActionResult> Index()
        {
            return View(await _context.PlanRecompensa.ToListAsync());
        }

        // GET: PlanRecompensa/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planRecompensa = await _context.PlanRecompensa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planRecompensa == null)
            {
                return NotFound();
            }

            return View(planRecompensa);
        }

        // GET: PlanRecompensa/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PlanRecompensa/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,FechaInicioP,NoReservas")] PlanRecompensa planRecompensa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planRecompensa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(planRecompensa);
        }

        // GET: PlanRecompensa/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planRecompensa = await _context.PlanRecompensa.FindAsync(id);
            if (planRecompensa == null)
            {
                return NotFound();
            }
            return View(planRecompensa);
        }

        // POST: PlanRecompensa/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,FechaInicioP,NoReservas")] PlanRecompensa planRecompensa)
        {
            if (id != planRecompensa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planRecompensa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanRecompensaExists(planRecompensa.Id))
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
            return View(planRecompensa);
        }

        // GET: PlanRecompensa/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planRecompensa = await _context.PlanRecompensa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planRecompensa == null)
            {
                return NotFound();
            }

            return View(planRecompensa);
        }

        // POST: PlanRecompensa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var planRecompensa = await _context.PlanRecompensa.FindAsync(id);
            if (planRecompensa != null)
            {
                _context.PlanRecompensa.Remove(planRecompensa);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanRecompensaExists(int id)
        {
            return _context.PlanRecompensa.Any(e => e.Id == id);
        }
    }
}

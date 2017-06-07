using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NutritionSite.Models;
using NutritionSite.Models.ViewModels;

namespace NutritionSite.Controllers
{
    public class DailyNutritionsController : Controller
    {
        private readonly NutritionSiteContext _context;

        public DailyNutritionsController(NutritionSiteContext context)
        {
            _context = context;    
        }

        // GET: DailyNutritions
        public async Task<IActionResult> Index()
        {
            var plans = _context.DailyNutrition
                .Include(c => c.Ingredients)
                .ThenInclude(c => c.Food)
                .AsNoTracking();
            return View(await plans.ToListAsync());
        }

        // GET: DailyNutritions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dailyNutrition = await _context.DailyNutrition
                .SingleOrDefaultAsync(m => m.ID == id);
            if (dailyNutrition == null)
            {
                return NotFound();
            }

            return View(dailyNutrition);
        }

        // GET: DailyNutritions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DailyNutritions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name")] DailyNutrition dailyNutrition)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dailyNutrition);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(dailyNutrition);
        }

        // GET: DailyNutritions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dailyNutrition = await _context.DailyNutrition.SingleOrDefaultAsync(m => m.ID == id);
            if (dailyNutrition == null)
            {
                return NotFound();
            }
            return View(dailyNutrition);
        }

        // POST: DailyNutritions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name")] DailyNutrition dailyNutrition)
        {
            if (id != dailyNutrition.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dailyNutrition);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DailyNutritionExists(dailyNutrition.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(dailyNutrition);
        }

        // GET: DailyNutritions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dailyNutrition = await _context.DailyNutrition
                .SingleOrDefaultAsync(m => m.ID == id);
            if (dailyNutrition == null)
            {
                return NotFound();
            }

            return View(dailyNutrition);
        }

        // POST: DailyNutritions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dailyNutrition = await _context.DailyNutrition.SingleOrDefaultAsync(m => m.ID == id);
            _context.DailyNutrition.Remove(dailyNutrition);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool DailyNutritionExists(int id)
        {
            return _context.DailyNutrition.Any(e => e.ID == id);
        }
    }
}

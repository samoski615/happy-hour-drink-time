using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HappyHourTracker.Data;
using HappyHourTracker.Models;

namespace HappyHourTracker.Controllers
{
    public class DrinkSpecialsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DrinkSpecialsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DrinkSpecials
        public async Task<IActionResult> Index()
        {
            return View(await _context.DrinkSpecials.ToListAsync());
        }

        // GET: DrinkSpecials/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drinkSpecial = await _context.DrinkSpecials
                .FirstOrDefaultAsync(m => m.Id == id);
            if (drinkSpecial == null)
            {
                return NotFound();
            }

            return View(drinkSpecial);
        }

        // GET: DrinkSpecials/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DrinkSpecials/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id ,DayOfTheWeek, TypeOfDrink, DrinkPrice, HappyHourStartTime, HappyHourEndTime, ApplicationId")] DrinkSpecial drinkSpecial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(drinkSpecial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(drinkSpecial);
        }

        // GET: DrinkSpecials/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drinkSpecial = await _context.DrinkSpecials.FindAsync(id);
            if (drinkSpecial == null)
            {
                return NotFound();
            }
            return View(drinkSpecial);
        }

        // POST: DrinkSpecials/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id, DayOfTheWeek, TypeOfDrink, DrinkPrice, HappyHourStartTime, HappyHourEndTime, ApplicationId")] DrinkSpecial drinkSpecial)
        {
            if (id != drinkSpecial.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(drinkSpecial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DrinkSpecialExists(drinkSpecial.Id))
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
            return View(drinkSpecial);
        }

        // GET: DrinkSpecials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drinkSpecial = await _context.DrinkSpecials
                .FirstOrDefaultAsync(m => m.Id == id);
            if (drinkSpecial == null)
            {
                return NotFound();
            }

            return View(drinkSpecial);
        }

        // POST: DrinkSpecials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var drinkSpecial = await _context.DrinkSpecials.FindAsync(id);
            _context.DrinkSpecials.Remove(drinkSpecial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DrinkSpecialExists(int id)
        {
            return _context.DrinkSpecials.Any(e => e.Id == id);
        }
    }
}

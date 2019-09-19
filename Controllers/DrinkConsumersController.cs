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
    public class DrinkConsumersController : Controller
    {
        private readonly ApplicationDbContext _context;
        DrinkConsumers drinkConsumers;

        public DrinkConsumersController(ApplicationDbContext context)
        {
            drinkConsumers = new DrinkConsumers();
            _context = context;
        }

        // GET: DrinkConsumers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Drinkers.ToListAsync());
        }

        // GET: DrinkConsumers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drinkConsumers = await _context.Drinkers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (drinkConsumers == null)
            {
                return NotFound();
            }

            return View(drinkConsumers);
        }

        // GET: DrinkConsumers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DrinkConsumers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, FirstName, LastName, Address, City, State, Zipcode")] DrinkConsumers drinkConsumers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(drinkConsumers);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create");
            }
            return View(drinkConsumers);
        }

        // GET: DrinkConsumers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drinkConsumers = await _context.Drinkers.FindAsync(id);
            if (drinkConsumers == null)
            {
                return NotFound();
            }
            return View(drinkConsumers);
        }

        // POST: DrinkConsumers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id, FirstName, LastName, Address, City, State, Zipcode")] DrinkConsumers drinkConsumers)
        {
            if (id != drinkConsumers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(drinkConsumers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DrinkConsumersExists(drinkConsumers.Id))
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
            return View(drinkConsumers);
        }

        // GET: DrinkConsumers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drinkConsumers = await _context.Drinkers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (drinkConsumers == null)
            {
                return NotFound();
            }

            return View(drinkConsumers);
        }

        public async void CheckingIn() //needs to use the await keyword
        {
            List<DrinkConsumers> drinker = new List<DrinkConsumers>();
            if (drinkConsumers.CheckInStatus == true)
            {
                drinker.Add(drinkConsumers);           
            }
        }






        public ActionResult GoogleMapAPI()
        {
            return View();
        }



        // POST: DrinkConsumers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var drinkConsumers = await _context.Drinkers.FindAsync(id);
            _context.Drinkers.Remove(drinkConsumers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DrinkConsumersExists(int id)
        {
            return _context.Drinkers.Any(e => e.Id == id);
        }
    }
}

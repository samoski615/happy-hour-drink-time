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
    public class BarsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BarsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Bars
        public async Task<IActionResult> Index()
        {
            return View(await _context.BarOwners.ToListAsync());
        }

        // GET: Bars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bar = await _context.BarOwners
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bar == null)
            {
                return NotFound();
            }

            return View(bar);
        }

        // GET: Bars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, BarName, Address, City, State, Zipcode, TypeOfBar, BarOpen, BarClose")] BarOwner barOwner)
        {
            if (ModelState.IsValid)
            {
                _context.Add(barOwner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(barOwner);
        }

        // GET: Bars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bar = await _context.BarOwners.FindAsync(id);
            if (bar == null)
            {
                return NotFound();
            }
            return View(bar);
        }

        // POST: Bars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id, BarName, Address, City, State, Zipcode, TypeOfBar, BarOpen, BarClose")] BarOwner barOwner)
        {
            if (id != barOwner.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(barOwner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BarExists(barOwner.Id))
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
            return View(barOwner);
        }


        //public async void PotentialCustomers() //when people click the the check in box, the potential customers property in bar model will increment
        //{//the method will be a bool, if checked = true else = false, if true add, else leave it alone
        //    foreach(DrinkConsumers consumer in consumerList)
        //    {
        //        if(consumer.CheckInStatus == true)
        //        PotentialCustomers++;
        //    }
        //}







        // GET: Bars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bar = await _context.BarOwners
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bar == null)
            {
                return NotFound();
            }

            return View(bar);
        }

        // POST: Bars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bar = await _context.BarOwners.FindAsync(id);
            _context.BarOwners.Remove(bar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BarExists(int id)
        {
            return _context.BarOwners.Any(e => e.Id == id);
        }
    }
}

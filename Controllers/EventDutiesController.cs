using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EventDutiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventDutiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EventDuties
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.EventDuty.Include(e => e.Event);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: EventDuties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventDuty = await _context.EventDuty
                .Include(e => e.Event)
                .FirstOrDefaultAsync(m => m.EventDutyId == id);
            if (eventDuty == null)
            {
                return NotFound();
            }

            return View(eventDuty);
        }

        // GET: EventDuties/Create
        public IActionResult Create()
        {
            ViewData["EventId"] = new SelectList(_context.Event, "EventId", "EventId");
            return View();
        }

        // POST: EventDuties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EventDutyId,EventId,DutyDescription")] EventDuty eventDuty)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eventDuty);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Event, "EventId", "EventId", eventDuty.EventId);
            return View(eventDuty);
        }

        // GET: EventDuties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventDuty = await _context.EventDuty.FindAsync(id);
            if (eventDuty == null)
            {
                return NotFound();
            }
            ViewData["EventId"] = new SelectList(_context.Event, "EventId", "EventId", eventDuty.EventId);
            return View(eventDuty);
        }

        // POST: EventDuties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EventDutyId,EventId,DutyDescription")] EventDuty eventDuty)
        {
            if (id != eventDuty.EventDutyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eventDuty);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventDutyExists(eventDuty.EventDutyId))
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
            ViewData["EventId"] = new SelectList(_context.Event, "EventId", "EventId", eventDuty.EventId);
            return View(eventDuty);
        }

        // GET: EventDuties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventDuty = await _context.EventDuty
                .Include(e => e.Event)
                .FirstOrDefaultAsync(m => m.EventDutyId == id);
            if (eventDuty == null)
            {
                return NotFound();
            }

            return View(eventDuty);
        }

        // POST: EventDuties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eventDuty = await _context.EventDuty.FindAsync(id);
            _context.EventDuty.Remove(eventDuty);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventDutyExists(int id)
        {
            return _context.EventDuty.Any(e => e.EventDutyId == id);
        }
    }
}

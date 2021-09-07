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
    public class ProjectFrameworksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProjectFrameworksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProjectFrameworks
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ProjectFramework.Include(p => p.Framework).Include(p => p.Project);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ProjectFrameworks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectFramework = await _context.ProjectFramework
                .Include(p => p.Framework)
                .Include(p => p.Project)
                .FirstOrDefaultAsync(m => m.ProjFrameId == id);
            if (projectFramework == null)
            {
                return NotFound();
            }

            return View(projectFramework);
        }

        // GET: ProjectFrameworks/Create
        public IActionResult Create()
        {
            ViewData["FrameworkId"] = new SelectList(_context.Framework, "FrameworkId", "FrameworkName");
            ViewData["ProjectId"] = new SelectList(_context.Project, "ProjectId", "ProjectName");
            return View();
        }

        // POST: ProjectFrameworks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjFrameId,ProjectId,FrameworkId")] ProjectFramework projectFramework)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectFramework);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FrameworkId"] = new SelectList(_context.Framework, "FrameworkId", "FrameworkName", projectFramework.FrameworkId);
            ViewData["ProjectId"] = new SelectList(_context.Project, "ProjectId", "ProjectName", projectFramework.ProjectId);
            return View(projectFramework);
        }

        // GET: ProjectFrameworks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectFramework = await _context.ProjectFramework.FindAsync(id);
            if (projectFramework == null)
            {
                return NotFound();
            }
            ViewData["FrameworkId"] = new SelectList(_context.Framework, "FrameworkId", "FrameworkName", projectFramework.FrameworkId);
            ViewData["ProjectId"] = new SelectList(_context.Project, "ProjectId", "ProjectName", projectFramework.ProjectId);
            return View(projectFramework);
        }

        // POST: ProjectFrameworks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjFrameId,ProjectId,FrameworkId")] ProjectFramework projectFramework)
        {
            if (id != projectFramework.ProjFrameId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectFramework);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectFrameworkExists(projectFramework.ProjFrameId))
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
            ViewData["FrameworkId"] = new SelectList(_context.Framework, "FrameworkId", "FrameworkName", projectFramework.FrameworkId);
            ViewData["ProjectId"] = new SelectList(_context.Project, "ProjectId", "ProjectName", projectFramework.ProjectId);
            return View(projectFramework);
        }

        // GET: ProjectFrameworks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectFramework = await _context.ProjectFramework
                .Include(p => p.Framework)
                .Include(p => p.Project)
                .FirstOrDefaultAsync(m => m.ProjFrameId == id);
            if (projectFramework == null)
            {
                return NotFound();
            }

            return View(projectFramework);
        }

        // POST: ProjectFrameworks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectFramework = await _context.ProjectFramework.FindAsync(id);
            _context.ProjectFramework.Remove(projectFramework);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectFrameworkExists(int id)
        {
            return _context.ProjectFramework.Any(e => e.ProjFrameId == id);
        }
    }
}

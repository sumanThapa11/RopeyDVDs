#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ropey_DVDs.Data;
using Ropey_DVDs.Models;

namespace Ropey_DVDs.Controllers
{
    public class DVDCategoriesController : Controller
    {
        private readonly RopeyDBContext _context;

        public DVDCategoriesController(RopeyDBContext context)
        {
            _context = context;
        }

        // GET: DVDCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.DVDCategories.ToListAsync());
        }

        // GET: DVDCategories/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dVDCategory = await _context.DVDCategories
                .FirstOrDefaultAsync(m => m.CategoryNumber == id);
            if (dVDCategory == null)
            {
                return NotFound();
            }

            return View(dVDCategory);
        }

        // GET: DVDCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DVDCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryNumber,CategoryDescription,AgeRestricted")] DVDCategory dVDCategory)
        {
            if (ModelState.IsValid)
            {
                dVDCategory.CategoryNumber = Guid.NewGuid();
                _context.Add(dVDCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dVDCategory);
        }

        // GET: DVDCategories/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dVDCategory = await _context.DVDCategories.FindAsync(id);
            if (dVDCategory == null)
            {
                return NotFound();
            }
            return View(dVDCategory);
        }

        // POST: DVDCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CategoryNumber,CategoryDescription,AgeRestricted")] DVDCategory dVDCategory)
        {
            if (id != dVDCategory.CategoryNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dVDCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DVDCategoryExists(dVDCategory.CategoryNumber))
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
            return View(dVDCategory);
        }

        // GET: DVDCategories/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dVDCategory = await _context.DVDCategories
                .FirstOrDefaultAsync(m => m.CategoryNumber == id);
            if (dVDCategory == null)
            {
                return NotFound();
            }

            return View(dVDCategory);
        }

        // POST: DVDCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var dVDCategory = await _context.DVDCategories.FindAsync(id);
            _context.DVDCategories.Remove(dVDCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DVDCategoryExists(Guid id)
        {
            return _context.DVDCategories.Any(e => e.CategoryNumber == id);
        }
    }
}

﻿#nullable disable
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
    public class DVDTitlesController : Controller
    {
        private readonly RopeyDBContext _context;

        public DVDTitlesController(RopeyDBContext context)
        {
            _context = context;
        }

        // GET: DVDTitles
        public async Task<IActionResult> Index()
        {
            var ropeyDBContext = _context.DVDTitles.Include(d => d.DVDCategory).Include(d => d.Producer).Include(d => d.Studio);
            return View(await ropeyDBContext.ToListAsync());
        }

        // GET: DVDTitles/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dVDTitle = await _context.DVDTitles
                .Include(d => d.DVDCategory)
                .Include(d => d.Producer)
                .Include(d => d.Studio)
                .FirstOrDefaultAsync(m => m.DVDNumber == id);
            if (dVDTitle == null)
            {
                return NotFound();
            }

            return View(dVDTitle);
        }

        // GET: DVDTitles/Create
        public IActionResult Create()
        {
            ViewData["CategoryNumber"] = new SelectList(_context.DVDCategories, "CategoryNumber", "CategoryDescription");
            ViewData["ProducerNumber"] = new SelectList(_context.Producers, "ProducerNumber", "ProducerName");
            ViewData["StudioNumber"] = new SelectList(_context.Studios, "StudioNumber", "StudioName");
            return View();
        }

        // POST: DVDTitles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DVDNumber,CategoryNumber,StudioNumber,ProducerNumber,Title,DateReleased,StandardCharge,PenaltyCharge")] DVDTitle dVDTitle)
        {
            if (ModelState.IsValid)
            {
                dVDTitle.DVDNumber = Guid.NewGuid();
                _context.Add(dVDTitle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryNumber"] = new SelectList(_context.DVDCategories, "CategoryNumber", "CategoryDescription", dVDTitle.CategoryNumber);
            ViewData["ProducerNumber"] = new SelectList(_context.Producers, "ProducerNumber", "ProducerName", dVDTitle.ProducerNumber);
            ViewData["StudioNumber"] = new SelectList(_context.Studios, "StudioNumber", "StudioName", dVDTitle.StudioNumber);
            return View(dVDTitle);
        }

        // GET: DVDTitles/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dVDTitle = await _context.DVDTitles.FindAsync(id);
            if (dVDTitle == null)
            {
                return NotFound();
            }
            ViewData["CategoryNumber"] = new SelectList(_context.DVDCategories, "CategoryNumber", "CategoryDescription", dVDTitle.CategoryNumber);
            ViewData["ProducerNumber"] = new SelectList(_context.Producers, "ProducerNumber", "ProducerName", dVDTitle.ProducerNumber);
            ViewData["StudioNumber"] = new SelectList(_context.Studios, "StudioNumber", "StudioName", dVDTitle.StudioNumber);
            return View(dVDTitle);
        }

        // POST: DVDTitles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("DVDNumber,CategoryNumber,StudioNumber,ProducerNumber,Title,DateReleased,StandardCharge,PenaltyCharge")] DVDTitle dVDTitle)
        {
            if (id != dVDTitle.DVDNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dVDTitle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DVDTitleExists(dVDTitle.DVDNumber))
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
            ViewData["CategoryNumber"] = new SelectList(_context.DVDCategories, "CategoryNumber", "CategoryDescription", dVDTitle.CategoryNumber);
            ViewData["ProducerNumber"] = new SelectList(_context.Producers, "ProducerNumber", "ProducerName", dVDTitle.ProducerNumber);
            ViewData["StudioNumber"] = new SelectList(_context.Studios, "StudioNumber", "StudioName", dVDTitle.StudioNumber);
            return View(dVDTitle);
        }

        // GET: DVDTitles/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dVDTitle = await _context.DVDTitles
                .Include(d => d.DVDCategory)
                .Include(d => d.Producer)
                .Include(d => d.Studio)
                .FirstOrDefaultAsync(m => m.DVDNumber == id);
            if (dVDTitle == null)
            {
                return NotFound();
            }

            return View(dVDTitle);
        }

        // POST: DVDTitles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var dVDTitle = await _context.DVDTitles.FindAsync(id);
            _context.DVDTitles.Remove(dVDTitle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DVDTitleExists(Guid id)
        {
            return _context.DVDTitles.Any(e => e.DVDNumber == id);
        }
    }
}

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
using Ropey_DVDs.Models.ViewModels;

namespace Ropey_DVDs.Controllers
{
    public class CastMembersController : Controller
    {
        private readonly RopeyDBContext _context;

        public CastMembersController(RopeyDBContext context)
        {
            _context = context;
        }

        // GET: CastMembers
        public async Task<IActionResult> Index(string search)
        {

            if (search == null)
            {
                IList<DVDCastViewModel> viewModel = (from dt in _context.DVDTitles
                                                     join cm in _context.CastMembers
                                                     on dt.DVDNumber equals cm.DVDNumber
                                                     join a in _context.Actors
                                                     on cm.ActorNumber equals a.ActorNumber

                                                     select new DVDCastViewModel()
                                                     {
                                                         DVDTitle = dt.DVDNumber,
                                                         ActorSurname = a.ActorSurname

                                                     }).ToList();
                return View(viewModel);
            }

            else {
                IList<DVDCastViewModel> viewModel = (from dt in _context.DVDTitles
                                                     join cm in _context.CastMembers
                                                     on dt.DVDNumber equals cm.DVDNumber
                                                     join a in _context.Actors
                                                     on cm.ActorNumber equals a.ActorNumber
                                                     where a.ActorSurname == search
                                                     select new DVDCastViewModel()
                                                     {
                                                         DVDTitle = dt.DVDNumber,
                                                         ActorSurname = a.ActorSurname

                                                     }).ToList();
                return View(viewModel);

            }

            //DVDCastViewModel ropeyDBContext = new DVDCastViewModel();



            //foreach (var t in ropeyDBContext)
            //{
            //    Console.WriteLine("{0} {1}", t.DVDTitle, t.Actor);
            //}
           
        }


       

        // GET: CastMembers/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var castMember = await _context.CastMembers
                .Include(c => c.Actor)
                .Include(c => c.DVDTitle)
                .FirstOrDefaultAsync(m => m.DVDNumber == id);
            if (castMember == null)
            {
                return NotFound();
            }

            return View(castMember);
        }

        // GET: CastMembers/Create
        public IActionResult Create()
        {
            ViewData["ActorNumber"] = new SelectList(_context.Actors, "ActorNumber", "ActorSurname");
            ViewData["DVDNumber"] = new SelectList(_context.DVDTitles, "DVDNumber", "DVDNumber");
            return View();
        }

        // POST: CastMembers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DVDNumber,ActorNumber")] CastMember castMember)
        {
            if (ModelState.IsValid)
            {
                //castMember.DVDNumber = Guid.NewGuid();
                _context.Add(castMember);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ActorNumber"] = new SelectList(_context.Actors, "ActorNumber", "ActorSurname", castMember.ActorNumber);
            ViewData["DVDNumber"] = new SelectList(_context.DVDTitles, "DVDNumber", "DVDNumber", castMember.DVDNumber);
            return View(castMember);
        }

        // GET: CastMembers/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var castMember = await _context.CastMembers.FindAsync(id);
            if (castMember == null)
            {
                return NotFound();
            }
            ViewData["ActorNumber"] = new SelectList(_context.Actors, "ActorNumber", "ActorSurname", castMember.ActorNumber);
            ViewData["DVDNumber"] = new SelectList(_context.DVDTitles, "DVDNumber", "DVDNumber", castMember.DVDNumber);
            return View(castMember);
        }

        // POST: CastMembers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("DVDNumber,ActorNumber")] CastMember castMember)
        {
            if (id != castMember.DVDNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(castMember);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CastMemberExists(castMember.DVDNumber))
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
            ViewData["ActorNumber"] = new SelectList(_context.Actors, "ActorNumber", "ActorSurname", castMember.ActorNumber);
            ViewData["DVDNumber"] = new SelectList(_context.DVDTitles, "DVDNumber", "DVDNumber", castMember.DVDNumber);
            return View(castMember);
        }

        // GET: CastMembers/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var castMember = await _context.CastMembers
                .Include(c => c.Actor)
                .Include(c => c.DVDTitle)
                .FirstOrDefaultAsync(m => m.DVDNumber == id);
            if (castMember == null)
            {
                return NotFound();
            }

            return View(castMember);
        }

        // POST: CastMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var castMember = await _context.CastMembers.FindAsync(id);
            _context.CastMembers.Remove(castMember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CastMemberExists(Guid id)
        {
            return _context.CastMembers.Any(e => e.DVDNumber == id);
        }
    }
}

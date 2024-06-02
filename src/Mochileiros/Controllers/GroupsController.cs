using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mochileiros.Data;
using Mochileiros.Models;
using System.Text.Json;
using System.Collections.Generic;

namespace Mochileiros.Controllers
{
    public class GroupsController : Controller
    {
        private readonly MochileirosContext _context;

        public GroupsController(MochileirosContext context)
        {
            _context = context;
        }

        // GET: Groups
        public async Task<IActionResult> Index()
        {
            var mochileirosContext = _context.Group.Include(g => g.Travel);
            return View(await mochileirosContext.ToListAsync());
        }

        // GET: Groups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @group = await _context.Group
                .Include(g => g.Travel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@group == null)
            {
                return NotFound();
            }

            return View(@group);
        }

        // GET: Groups/Create
        public IActionResult Create()
        {
            ViewData["TravelId"] = new SelectList(_context.Travel, "Id", "Id");
            return PartialView();
        }

        // POST: Groups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NumberOfUsers,TravelId")] Group @group)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@group);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TravelId"] = new SelectList(_context.Travel, "Id", "Id", @group.TravelId);
            return View(@group);
        }

        // GET: Groups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @group = await _context.Group.FindAsync(id);
            if (@group == null)
            {
                return NotFound();
            }
            ViewData["TravelId"] = new SelectList(_context.Travel, "Id", "Id", @group.TravelId);
            return PartialView(@group);
        }

        // POST: Groups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Edit(int id, [Bind("Id,NumberOfUsers,TravelId,Participants")] Group @group, string participantsJson)
{
    if (id != @group.Id)
    {
        return NotFound();
    }

    var travel = await _context.Travel.FindAsync(@group.TravelId);
    if (travel == null)
    {
        ModelState.AddModelError("TravelId", "Invalid travel ID.");
    }
    else
    {
        @group.Travel = travel;
    }

    JsonDocument existingParticipantsDoc = null;
    JsonDocument newParticipantsDoc = null;

    try
    {
        if (!string.IsNullOrEmpty(@group.Participants))
        {
            existingParticipantsDoc = JsonDocument.Parse(@group.Participants);
        }

        if (!string.IsNullOrEmpty(participantsJson))
        {
            newParticipantsDoc = JsonDocument.Parse(participantsJson);
        }
    }
    catch (JsonException ex)
    {
        ModelState.AddModelError("Participants", "Invalid JSON format for participants.");
    }

    if (ModelState.IsValid)
    {
        var mergedParticipants = new List<JsonElement>();

        if (existingParticipantsDoc != null)
        {
            foreach (var element in existingParticipantsDoc.RootElement.EnumerateArray())
            {
                mergedParticipants.Add(element);
            }
        }

        if (newParticipantsDoc != null)
        {
            foreach (var element in newParticipantsDoc.RootElement.EnumerateArray())
            {
                mergedParticipants.Add(element);
            }
        }

        @group.Participants = JsonSerializer.Serialize(mergedParticipants);

        try
        {
            _context.Update(@group);
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!GroupExists(@group.Id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return RedirectToAction("Details", "Travels", new { id = @group.TravelId });
    }

    return View(@group);
}

        // GET: Groups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @group = await _context.Group
                .Include(g => g.Travel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@group == null)
            {
                return NotFound();
            }

            return View(@group);
        }

        // POST: Groups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @group = await _context.Group.FindAsync(id);
            if (@group != null)
            {
                _context.Group.Remove(@group);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroupExists(int id)
        {
            return _context.Group.Any(e => e.Id == id);
        }
    }

    private bool GroupExists(int id)
{
    return _context.Groups.Any(e => e.Id == id);
}   
}

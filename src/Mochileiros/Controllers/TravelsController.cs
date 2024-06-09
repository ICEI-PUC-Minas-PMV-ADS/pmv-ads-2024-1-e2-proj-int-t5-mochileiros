using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mochileiros.Data;
using Mochileiros.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;


namespace Mochileiros.Controllers
{
[Authorize]    
public class TravelsController : Controller
    {
        private readonly MochileirosContext _context;

        public TravelsController(MochileirosContext context)
        {
            _context = context;
        }

        // GET: Travels
        public async Task<IActionResult> Index()
        {
            var userId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            if (userId == null)
                return NotFound();
            var usuario = await _context.User.FindAsync(userId);

            if (usuario == null)
                return NotFound();
            var viagens = await _context.Travel
                .Where(t => t.UserId == userId)
                .OrderByDescending(t => t.StartDate)
                .ToListAsync();


            return View(viagens);
        }

        // GET: Travels/Details/5
public async Task<IActionResult> Details(int? id)
{
    if (id == null)
    {
        return NotFound();
    }

    var travel = await GetTravelById(id);
    if (travel == null)
    {
        return NotFound();
    }

    var totalExpenses = await CalculateTotalExpenses(travel);
    var daysArray = await GenerateDaysArray(travel);

    ViewData["daysArray"] = daysArray;
    ViewData["totalExpenses"] = totalExpenses;

    return View(travel);
}

public async Task<IActionResult> Document(int? id)
{
    if (id == null)
    {
        return NotFound();
    }

    var travel = await GetTravelById(id);
    if (travel == null)
    {
        return NotFound();
    }

    var totalExpenses = await CalculateTotalExpenses(travel);
    var daysArray = await GenerateDaysArray(travel);

    ViewData["daysArray"] = daysArray;
    ViewData["totalExpenses"] = totalExpenses;

    return View(travel);
}





    private async Task<Travel> GetTravelById(int? id)
{
    return await _context.Travel.FirstOrDefaultAsync(m => m.Id == id);
}

private async Task<decimal> CalculateTotalExpenses(Travel travel)
{
    var daysApart = (int)(travel.EndDate - travel.StartDate).TotalDays;
    decimal totalExpenses = 0.0m;

    for (int i = 0; i <= daysApart; i++)
    {
        var currentDay = travel.StartDate.AddDays(i);

        var expensesForDay = await _context.Expense
            .Where(e => e.TravelID == travel.Id && e.Date.Date == currentDay.Date)
            .ToListAsync();

        totalExpenses += expensesForDay.Sum(e => e.Value);
    }

    return totalExpenses;
}

private async Task<List<object>> GenerateDaysArray(Travel travel)
{
    var daysApart = (int)(travel.EndDate - travel.StartDate).TotalDays;
    var daysArray = new List<object>();

    var expenses = await _context.Expense
        .Where(e => e.TravelID == travel.Id && e.Date >= travel.StartDate && e.Date <= travel.EndDate)
        .ToListAsync();

for (int i = 0; i <= daysApart; i++)
{
    var currentDay = travel.StartDate.AddDays(i);



  var expensesForDay = await _context.Expense
    .Where(e => e.TravelID == travel.Id &&
                e.Date.Year == currentDay.Year &&
                e.Date.Day == currentDay.Day &&
                e.Date.Month == currentDay.Month)
    .ToListAsync();


    var dayObject = new
    {
        id = i + 1,
        travelId = travel.Id,
        date = currentDay,
        expenses = expensesForDay.Select(e => new
        {
            e.Id,
            e.Description,
            e.Value,
            e.Type,
            e.Name,
            e.Date
        })
    };

    daysArray.Add(dayObject);
}


    return daysArray;
}
        // GET: Travels/Create
        public IActionResult Create()
        {
            var userId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

            // Passa o ID do usuário para a ViewBag
            ViewBag.UserId = userId;
            return View();
        }

        // POST: Travels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TravelNumber,Destination,UserId,StartDate,EndDate,GroupId,Image")] Travel travel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(travel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(travel);
        }

        // GET: Travels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travel = await _context.Travel.FindAsync(id);
            if (travel == null)
            {
                return NotFound();
            }
            return View(travel);
        }


    

        // POST: Travels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TravelNumber,Destination,UserId,StartDate,EndDate,GroupId,Image")] Travel travel)
        {
            if (id != travel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(travel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TravelExists(travel.Id))
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
            return View(travel);
        }

        // GET: Travels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travel = await _context.Travel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (travel == null)
            {
                return NotFound();
            }

            return View(travel);
        }

        // POST: Travels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var travel = await _context.Travel.FindAsync(id);
            if (travel != null)
            {
                _context.Travel.Remove(travel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TravelExists(int id)
        {
            return _context.Travel.Any(e => e.Id == id);
        }
    }
}

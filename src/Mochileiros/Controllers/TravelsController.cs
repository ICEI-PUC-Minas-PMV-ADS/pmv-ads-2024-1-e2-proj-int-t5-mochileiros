using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mochileiros.Data;
using Newtonsoft.Json.Linq;
using Mochileiros.Models;
using Newtonsoft.Json; 

namespace Mochileiros.Controllers
{
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
            return View(await _context.Travel.ToListAsync());
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

    travel.Group = await _context.Group.FindAsync(travel.GroupId); 
    var totalExpenses = await CalculateTotalExpenses(travel);
    var daysArray = await GenerateDaysArray(travel);
    var expensesByParticipant = await CalculateExpensesByParticipant(totalExpenses,travel.Group.Participants );

    ViewData["daysArray"] = daysArray;
    ViewData["totalExpenses"] = totalExpenses;
    ViewData["participants"] = travel.Group.Participants;
    ViewData["expensesByParticipant"] = expensesByParticipant;

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

private async Task<decimal> CalculateExpensesByParticipant(decimal totalExpense, string participants){
    var participantsArray = JArray.Parse(participants);

    int numParticipants = participantsArray.Count;

    decimal expensePerParticipant = numParticipants > 0 ? totalExpense / numParticipants : 0;

    return expensePerParticipant;
}

private async Task<List<object>> GenerateDaysArray(Travel travel)
{
    var daysApart = (int)(travel.EndDate - travel.StartDate).TotalDays;
    var daysArray = new List<object>();

    for (int i = 0; i <= daysApart; i++)
    {
        var currentDay = travel.StartDate.AddDays(i);

        var expensesForDay = await _context.Expense
            .Where(e => e.TravelID == travel.Id && e.Date.Date == currentDay.Date)
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
                int travelId = travel.Id;
                var group = new Group();
                var participant = new JObject();
                participant["name"] = "Participant1Name";
                participant["email"] = "participant1@example.com";
                participant["imageUrl"] = "https://example.com/participant1image.jpg";

        

                var participantsArray = new JArray();
                participantsArray.Add(participant);

                 group.Participants = participantsArray.ToString();
                 group.Travel = travel;
                 group.TravelId = travelId;
                

                _context.Add(group);
                await _context.SaveChangesAsync();

                travel.Group = group;
                travel.GroupId = group.Id;
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

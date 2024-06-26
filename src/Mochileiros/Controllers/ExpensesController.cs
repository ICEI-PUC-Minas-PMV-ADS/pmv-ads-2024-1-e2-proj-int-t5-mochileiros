using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mochileiros.Data;
using Mochileiros.Models;

namespace Mochileiros.Controllers
{
    [Authorize]
    public class ExpensesController : Controller
    {
        private readonly MochileirosContext _context;

        public ExpensesController(MochileirosContext context)
        {
            _context = context;
        }

        // GET: Expenses
        public async Task<IActionResult> Index()
        {
            var mochileirosContext = _context.Expense.Include(e => e.Travel);
            return View(await mochileirosContext.ToListAsync());
        }

        // GET: Expenses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expense = await _context.Expense
                .Include(e => e.Travel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (expense == null)
            {
                return NotFound();
            }

            return View(expense);
        }

        // GET: Expenses/Create
        public IActionResult Create()
    {  
            ViewData["TravelID"] = new SelectList(_context.Travel, "Id", "Id");
            return PartialView();
        }

        // POST: Expenses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,Value,Type,Name,Date,TravelID")] Expense expense)
        {
            System.Diagnostics.Debug.WriteLine(ModelState.IsValid);
            System.Diagnostics.Debug.WriteLine(expense);
            if (!ModelState.IsValid)
            {
                // If the ModelState is not valid, there are errors
                IEnumerable<string> errorMessages = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage);

                // Output error messages
                foreach (var errorMessage in errorMessages)
                {
                    System.Diagnostics.Debug.WriteLine(errorMessage);
                }

                // Return a response indicating failure, possibly with error messages
                return BadRequest(errorMessages);
            }


            _context.Add(expense);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Travels", new { id = expense.TravelID });
        }

        // GET: Expenses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expense = await _context.Expense.FindAsync(id);
            if (expense == null)
            {
                return NotFound();
            }
            ViewData["TravelID"] = new SelectList(_context.Travel, "Id", "Id", expense.TravelID);
            return PartialView(expense);
        }

        // POST: Expenses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,Value,Type,Name,Date,TravelID")] Expense expense)
        {
            if (id != expense.Id)
            {
                return NotFound();
            }
             if (!ModelState.IsValid)
            {
                // If the ModelState is not valid, there are errors
                IEnumerable<string> errorMessages = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage);

                // Output error messages
                foreach (var errorMessage in errorMessages)
                {
                    System.Diagnostics.Debug.WriteLine(errorMessage);
                }

                // Return a response indicating failure, possibly with error messages
                return BadRequest(errorMessages);
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(expense);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExpenseExists(expense.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction("Details", "Travels", new { id = expense.TravelID });
            }
            ViewData["TravelID"] = new SelectList(_context.Travel, "Id", "Id", expense.TravelID);
            return View(expense);
        }

        // GET: Expenses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expense = await _context.Expense
                .Include(e => e.Travel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (expense == null)
            {
                return NotFound();
            }

            return PartialView(expense);
        }

        // POST: Expenses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var expense = await _context.Expense.FindAsync(id);
            if (expense != null)
            {
                _context.Expense.Remove(expense);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Travels", new { id = expense.TravelID });
        }

        private bool ExpenseExists(int id)
        {
            return _context.Expense.Any(e => e.Id == id);
        }
    }
}

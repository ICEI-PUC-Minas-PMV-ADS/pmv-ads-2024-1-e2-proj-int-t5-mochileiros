using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mochileiros.Models;
using SQLitePCL;
using Microsoft.EntityFrameworkCore;
using Mochileiros.Data;



namespace Mochileiros.Controllers
{
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;
        private readonly MochileirosContext _context;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }
      
        public async Task<IActionResult> Viagem(int? id)
        {
            if(id == null)
                return NotFound();
            var usuario = await _context.User.FindAsync(id);

            if (usuario == null)
                return NotFound();
            var viagens = await _context.Travel
                .Where(t => t.UserId == id)
                .OrderByDescending(t => t.StartDate)
                .ToListAsync();
            
            ViewBag.Travel = viagens;
      
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
 public async Task<IActionResult> Newuser()
        {
            
      
            return View();
        }
    }
}

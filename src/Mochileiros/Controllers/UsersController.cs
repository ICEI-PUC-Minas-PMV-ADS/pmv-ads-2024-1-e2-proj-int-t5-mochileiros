using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mochileiros.Models;


namespace Mochileiros.Controllers
{
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }
      
        public IActionResult Login()
        {
            return View();
        }
    }
}

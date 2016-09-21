using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NationBuilder.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace NationBuilder.Controllers
{
    public class GameController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly NationBuilderDbContext _db;

        public GameController(UserManager<ApplicationUser> userManager, NationBuilderDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        public IActionResult GetEvent()
        {
            var m = _db.Events.Count();
            Random random = new Random();
            int randomNumber = random.Next(0, m-1);
            var randomEvent = _db.Events.ToList();
            var nextup = randomEvent[randomNumber];
            return Json(nextup);
        }
    }
}

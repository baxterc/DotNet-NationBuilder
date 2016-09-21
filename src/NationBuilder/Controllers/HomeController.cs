using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NationBuilder.Models;
using NationBuilder.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NationBuilder.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly NationBuilderDbContext _db;

        public HomeController(UserManager<ApplicationUser> userManager, NationBuilderDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Play()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ApplicationUser user = await _userManager.FindByIdAsync(userId);
            ViewBag.user = user;
            var userNation = _db.Nations.FirstOrDefault(n => n.Id == user.NationId);

            return View(userNation);
        }
        [HttpPost]
        public async Task<IActionResult> CreateNation(string Name)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ApplicationUser user = await _userManager.FindByIdAsync(userId);

            Nation newNation = new Nation();
            newNation.Name = Name;
            newNation.UserId = userId;
            _db.Nations.Add(newNation);
            _db.SaveChanges();
            user.NationId = newNation.Id;
            _db.Entry(user).State = EntityState.Modified;
            _db.SaveChanges();
            ViewBag.nation = newNation;
            return RedirectToAction("Play");
        }
    }
}

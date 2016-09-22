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
            if (m != 0)
            {
                Random random = new Random();
                int randomNumber = random.Next(0, m - 1);
                var randomEvent = _db.Events.ToList();
                var nextup = randomEvent[randomNumber];
                return Json(nextup);
            }
            else
            {
                var error = "There are no events in the database";
                return Json(error);
            }
        }

        [HttpPost]
        public IActionResult EventResult(int nationId, int eventId, string choiceValue)
        {
            Console.WriteLine("You chose option : " + choiceValue);
            var choiceValueInt = int.Parse(choiceValue);
            Console.WriteLine("Nation ID is " + nationId + " and event ID is " + eventId);
            var currentNation = _db.Nations.FirstOrDefault(n => n.Id == nationId);
            var currentEvent = _db.Events.FirstOrDefault(e => e.Id == eventId);
            if (choiceValueInt == 1)
            {
                ViewBag.resultText = currentEvent.TextResponse1;
                var splitResult = currentEvent.ValueResponse1.Split(',').ToList<String>();
                currentNation.Capital += int.Parse(splitResult[0]);
                currentNation.Stability += int.Parse(splitResult[1]);
                _db.Entry(currentNation).State = EntityState.Modified;
                _db.SaveChanges();
                return Json(currentNation);
            }
            else if (choiceValueInt == 2)
            {
                ViewBag.resultText = currentEvent.TextResponse2;
                var splitResult = currentEvent.ValueResponse2.Split(',').ToList<String>();
                currentNation.Capital += int.Parse(splitResult[0]);
                currentNation.Stability += int.Parse(splitResult[1]);
                _db.Entry(currentNation).State = EntityState.Modified;
                _db.SaveChanges();
                return Json(currentNation);
            }
            else if (choiceValueInt == 3)
            {
                ViewBag.resultText = currentEvent.TextResponse3;
                var splitResult = currentEvent.ValueResponse3.Split(',').ToList<String>();
                currentNation.Capital += int.Parse(splitResult[0]);
                currentNation.Stability += int.Parse(splitResult[1]);
                _db.Entry(currentNation).State = EntityState.Modified;
                _db.SaveChanges();
                return Json(currentNation);
            }
            else
            {
                var errorText = "An error has occurred";
                return Json(errorText);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RPG.Models;

namespace RPG.Controllers
{
    public class CharacterController : Controller
    {
        private RPGContext db = new RPGContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
           return View(db.Characters.ToList());
        }
    }
}

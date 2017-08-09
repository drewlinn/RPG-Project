using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RPG.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RPG.Controllers
{
    public class PlayerController : Controller
    {
        private RPGContext db = new RPGContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
           return View(db.Players.ToList());
        }
    }
}

using Blink.DAL;
using Blink.Models;
using Blink.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Blink.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;
        public HomeController(AppDbContext _db)
        {
            db = _db;
        }
        public async  Task<IActionResult> Index()
        {
            HomeViewModels hvm = new HomeViewModels
            {
                news =await db.News.Include(x=>x.Category).OrderByDescending(x=>x.Id).Take(3).ToListAsync()
            };

            return View(hvm);
        }
    }
}

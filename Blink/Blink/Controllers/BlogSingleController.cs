using Blink.DAL;
using Blink.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blink.Controllers
{
    public class BlogSingleController : Controller
    {
        private readonly AppDbContext db;
        public BlogSingleController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index(int? Id)
        {
            if (Id != null)
            {
                News news = db.News.FirstOrDefault(x => x.Id == Id);
                return View(news);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Messages msg)
        {
            if (ModelState.IsValid)
            {
                msg.Date = DateTime.Now;
                await db.Messages.AddAsync(msg);
                await db.SaveChangesAsync();

                News news = db.News.FirstOrDefault(x => x.Id == msg.NewsId);
                return View(news);
                //return RedirectToAction("Index", "BlogSingle");
        }
            return Content("not found");
     }
    }
}

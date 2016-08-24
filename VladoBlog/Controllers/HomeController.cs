using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VladoBlog.Models;
using System.Data.Entity;

namespace VladoBlog.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var post = db.Posts.Include(p => p.Author).OrderByDescending(p => p.Date).Take(3);
            return View(post.ToList());
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
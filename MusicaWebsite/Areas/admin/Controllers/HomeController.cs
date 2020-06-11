using MusicaWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicaWebsite.Areas.admin.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private ApplicationDbContext dbContext;

        public HomeController()
        {
            dbContext = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            dbContext.Dispose();
        }

        // GET: admin/Home
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Account()
        {
            var account = dbContext.Users.ToList();
            return View(account);
        }
    }
}
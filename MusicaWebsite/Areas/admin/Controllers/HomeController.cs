using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicaWebsite.Areas.admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: admin/Home
        //[Route("admin/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
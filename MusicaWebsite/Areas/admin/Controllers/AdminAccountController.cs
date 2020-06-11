using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicaWebsite.Areas.admin.Controllers
{
    public class AdminAccountController : Controller
    {
        // GET: admin/AdminAccount
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        //    [HttpPost]
        //    [AllowAnonymous]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Login()
        //    {
        //        return View();
        //    }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using velaMaryWebApp.Models;

namespace velaMaryWebApp.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            velaMaryEntities db = new velaMaryEntities();
            return View();
        }
    }
}
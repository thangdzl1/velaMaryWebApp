using DATA;
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
        //GET ADMIN/HOME/Index
        public ActionResult Index()
        { 
            MapCart map = new MapCart();
            ViewBag.totalEarned = map.getTotalEarned();
            ViewBag.pendingOrder = map.getPendingOrder();
            return View();
        }

    }
}
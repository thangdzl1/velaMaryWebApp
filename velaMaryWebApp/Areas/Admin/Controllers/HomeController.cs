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
            velaMaryEntities db = new velaMaryEntities();
            //Tính tổng tiền earned
            ViewBag.totalEarned = (from item in db.tb_cart
                               where item.status_id == 1 
                               select item.price).Sum();
            //Tính pending order
            ViewBag.pendingOrder = (from item in db.tb_cart
                        where item.status_id == 2
                        select item).Count();
            return View();
        }


    }
}
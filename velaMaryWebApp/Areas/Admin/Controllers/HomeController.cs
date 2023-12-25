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
        //private velaMaryEntities db;
        

        //HomeController()
        //{
        //    //Lệnh kết nối db
        //    db = new velaMaryEntities();
        //}
        // GET: Admin/Home
        public ActionResult Index()
        { 
            //List<tb_catalog> catalog = db.tb_catalog.ToList();
            return View();
        }
    }
}
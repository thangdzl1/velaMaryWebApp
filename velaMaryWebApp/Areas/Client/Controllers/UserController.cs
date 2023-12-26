using DATA;
using DATA.Entity;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace velaMaryWebApp.Areas.Client.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]// GET: Client/User
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost] // POST: Client/User/login
        public ActionResult Login(string email, string pass)
        {
            MapUser mapUser = new MapUser();

            //Authen User
            tb_user user = mapUser.AuthenticateUser(email, pass);
            if (user!= null)
            {
                //Authorize User
                if (user.tb_role.name.Equals("admin"))
                {
                    // Mang Role Admin thì nhảy vào đây
                    return RedirectToAction("Index","Home", new {area = "Admin"}); // GET: Admin/Home/Index
                }
                else
                {
                    // Mang Role User thì nhảy vào đây
                    return RedirectToAction("Index", "Dashboard", new { area = "Client" }); // GET: Client/Dashboard/Index
                }
            }
            //Không có thì quay lại login View, Báo lỗi
            ViewBag.loginError = "Incorrect Email or Password";
            return View();
        }


        [HttpPost] // POST: Client/User/register
        public ActionResult Register(tb_user user) 
        {
            MapUser mapUser = new MapUser();
            if (mapUser.addUser(user))
            {
                //Thành công thì chuyển sang login
                return RedirectToAction("Login", "User");
            }
            //Fail thì chuyển về Dashboard
            ViewBag.registerError = "Register Failed";
            return View("Login", user);
        }
    }
}
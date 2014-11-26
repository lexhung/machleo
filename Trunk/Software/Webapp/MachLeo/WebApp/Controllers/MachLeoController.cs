using DBAdapter.BusinessLogic;
using DBAdapter.DataContext;
using DBAdapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace WebApp.Controllers
{
    public class MachLeoController : Controller
    {
        private ApplicationDBContext adb = new ApplicationDBContext();

        public ActionResult Index()
        {

            return View("Index");

        }
        public ActionResult ListUsers()
        {
            ViewData["listusers"] = adb.Users.ToList();
            return View("ListUsers");

        }
        public ActionResult Register()
        {
            return View("Register");

        }

        public ActionResult HandleRegister(FormCollection fc)
        {

            UserHelper uh = new UserHelper();
            uh.AddUser(fc["username"],fc["password"],fc["fullname"],fc["email"],);
            return View("Login");

        }
        public ActionResult Login()
        {
            return View("Login");

        }
        public ActionResult HandleLogin(FormCollection fc)
        {
            ViewData["listusers"] = adb.Users.ToList();
            foreach (User user in (List<User>)ViewData["listusers"]) {
                if (user.Username == fc["username"] && user.Password == fc["password"])
                    return View("ListUsers");
   
            }

            return View("Login");
        }


    }
}
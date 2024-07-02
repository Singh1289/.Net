using Login.Dal;
using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class UserController : Controller
    {
        private UserDal _userDal;

        public UserController()
        {
                _userDal = new UserDal();   
        }

        public ActionResult Index(User u)
        {
            ViewData["status"] = TempData["status"];
            return View(u);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                User loggedUser = _userDal.checkCredential(user);
                if (loggedUser != null)
                {

                    Session["Role"] = loggedUser.Role;
                    return RedirectToAction("Index",user);
                }
            }
            return View();

        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}

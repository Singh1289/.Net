using eCommerce.Dal;
using eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Controllers
{
    public class SecurityController : Controller
    {
        private readonly UserDal _userDal;

        public SecurityController(UserDal userDal)
        {
            _userDal = userDal;
        }

        // GET: Security
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                User loggedInUser = _userDal.CheckCredentials(user);
                if (loggedInUser != null)
                {
                    Session["Role"] = loggedInUser.Role;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login", "Security");
        }
    }
}
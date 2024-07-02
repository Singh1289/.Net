using FirstREST_api.Dal;
using FirstREST_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace FirstREST_api.Controllers
{
    public class UserController : Controller
    {
        private UserDal _userDal;

        public UserController()
        {
                _userDal = new UserDal();   
        }

        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                User loggedInUser = _userDal.checkCredential(user);
                if (loggedInUser != null)
                {
                    Session["Role"] = loggedInUser.Role;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();

        }
    }
}

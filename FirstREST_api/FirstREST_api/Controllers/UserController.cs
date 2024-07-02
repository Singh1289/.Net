using FirstREST_api.Dal;
using FirstREST_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace FirstREST_api.Controllers
{
    public class UserController : ApiController
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
                User loggedInUser = _userDal.CheckCredentials(user);
                if (loggedInUser != null)
                {
                    Session["Role"] = loggedInUser.Role;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();

            // GET: api/User
            public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/User/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}

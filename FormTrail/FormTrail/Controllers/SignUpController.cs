using FormTrail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormTrail.Controllers
{
    public class SignUpController : Controller
    {
        // GET: SignUp
        [HttpGet]
        public ActionResult signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult signup(SignUpUser user)
        {
            if (ModelState.IsValid)
            {
                RedirectToAction("signup");
            }
            return View(user);
        }
    }
}